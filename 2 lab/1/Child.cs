using System;

namespace Library
{
    /// <summary>
    /// Ребенок
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Минимальный возраст ребенка
        /// </summary>
        public const int MINAGE = 0;

        /// <summary>
        /// Максимальный возраст ребенка
        /// </summary>
        public const int MAXAGE = 17;

        /// <summary>
        /// Отец
        /// </summary>
        public Adult Father { get; set; }

        /// <summary>
        /// Мать
        /// </summary>
        public Adult Mother { get; set; }

        /// <summary>
        /// Воспитательное или учебное заведение (дет. сад, школа)
        /// </summary>
        public string Institution { get; set; }

        /// <summary>
        /// Возраст ребенка
        /// </summary>
        public override int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < MINAGE || value > MAXAGE)
                {
                    throw new ArgumentOutOfRangeException("Возраст ребенка" +
                        " должен лежать в диапазон от 0 до 17 лет");
                }
                if (value > Minimum(Mother.Age, Father.Age)-12)
                {
                    throw new ArgumentOutOfRangeException(
                        "Это ж сколько лет было родителям ребенка??");
                }

                _age = value;
            }
        }

        /// <summary>
        /// Описание ребенка
        /// </summary>
        public override string DescriptionPerson()
        {
            var description = base.DescriptionPerson() +
                $"\nОтец: {Father.Name} {Father.Surname} {Father.Age} лет\n" +
                $"Мать: {Mother.Name} {Mother.Surname} {Mother.Age} лет\n";

            if (Age <= 1)
            {
                description += $"Сосёт титю\n";
            }
            else
            {
                description += $"Заведение: {Institution}\n";
            }

            return description;
        }

        /// <summary>
        /// Нахождение минимального числа из двух
        /// </summary>
        /// <param name="firstNumber">первое число</param>
        /// <param name="secondNumber">второе число</param>
        /// <returns>минимальное число</returns>
        public static int Minimum(int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber ? secondNumber : firstNumber;
        }

        /// <summary>
        /// Ребенок от прирроды стройный
        /// </summary>
        /// <returns>возвращаемая строка про ребенка</returns>
        public string DontSport()
        {
            return $"{ShortDescriptionPerson()} " +
                $"стройняжка от природы";
        }
    }
}
