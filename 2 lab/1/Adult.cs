using System;

namespace Library
{
    /// <summary>
    /// Взрослый человек
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Минимальный возраст взрослого
        /// </summary>
        public const int MINAGE = 17;

        /// <summary>
        /// Максимальный возраст взрослого
        /// </summary>
        public const int MAXAGE = 100;

        /// <summary>
        /// Партнер
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// Состояние брака
        /// </summary>
        public StateOfMarriage StateOfMarriage { get; set; }

        /// <summary>
        /// Партнер
        /// </summary>
        public Adult Partner
        {
            get
            {
                return _partner;
            }
            set
            {
                if (StateOfMarriage == StateOfMarriage.Married)
                {
                    _partner = value;
                }
            }
        }

        /// <summary>
        /// Возраст взрослого
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
                    throw new ArgumentOutOfRangeException(
                        "Невозможный возраст человека");
                }

                _age = value;
            }
        }


        /// <summary>
        /// Номер паспорта
        /// </summary>
        public string PassportNumber { get; set; }

        /// <summary>
        /// Серия паспорта
        /// </summary>
        public string PassportSeries { get; set; }

        /// <summary>
        /// Место работы
        /// </summary>
        public string WorkPlace { get; set; }
    
        /// <summary>
        /// Описание взрослого человека
        /// </summary>
        public override string DescriptionPerson()
        {
            var description = base.DescriptionPerson() + 
                $"\nСерия и номер паспорта: {PassportSeries} {PassportNumber}\n" +
                $"Состояние брака: {StateOfMarriage}\n";

            if (StateOfMarriage == StateOfMarriage.Married)
            {
                description += $"Партнер: {Partner.Name} {Partner.Surname}\n";
            }

            description += $"Место работы: {WorkPlace}\n";

            return description;
        }

        /// <summary>
        /// Взрослый вынужден заниматься спортом
        /// </summary>
        /// <returns>возвращаемая строка про взрослого</returns>
        public string DoSport()
        {
            return $"{ShortDescriptionPerson()} " +
                $"занимается спортом для поддержания формы";
        }
    }
}
