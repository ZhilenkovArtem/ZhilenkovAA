using System;

namespace Library
{
    public class Child : Person
    {
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
        /// Создание ребенка
        /// </summary>
        /// <returns>ребенок</returns>
        public static Child CreateRandomChild()
        {
            var newChild = new Child();
            Random random = new Random();

            Person.GetRandomPerson(newChild, GenderType.No);

            newChild.Mother = Adult.CreateRandomAdult(true, null, GenderType.F);
            newChild.Father = newChild.Mother.Partner;

            var childMaximalAge = Minimum(18, Minimum(newChild.Mother.Age, 
                newChild.Father.Age)-12);

            newChild.Age = random.Next(0, childMaximalAge);

            var Path = AppDomain.CurrentDomain.BaseDirectory
                + "\\ParametrsPerson\\";

            string textFile;

            if (newChild.Age < 7)
            {
                textFile = "KinderGarden.txt";
            }
            else
            {
                textFile = "School.txt";
            }

            var path = System.IO.Path.Combine(Path, textFile);

            newChild.Institution = Person.GetLine(path);

            return newChild;
        }

        /// <summary>
        /// Нахождение минимального числа из двух
        /// </summary>
        /// <param name="firstNumber">первое число</param>
        /// <param name="secondNumber">второе число</param>
        /// <returns>минимальное число</returns>
        static int Minimum(int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber ? secondNumber : firstNumber;
        }

        /// <summary>
        /// Проверка правильности (5.С задание)
        /// </summary>
        /// <returns>строка с каким-то текстом</returns>
        public override string IAm()
        {
            var iAm = base.IAm();

            iAm += $"и я ребенок";

            return iAm;
        }
    }
}
