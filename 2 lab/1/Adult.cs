using System;
using System.Threading;

namespace Library
{
    public class Adult : Person
    {
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
        /// Создание взрослого человека
        /// </summary>
        /// <param name="marriage">женатость</param>
        /// <param name="partner">партнер</param>
        /// <param name="gender">пол</param>
        /// <returns>взрослый человек</returns>
        public static Adult CreateRandomAdult(bool marriage=false, Adult partner=null, GenderType gender = GenderType.No)
        {
            var newAdult = new Adult();
            Random random = new Random();
            Thread.Sleep(15);

            Person.GetRandomPerson(newAdult, gender);

            int countStateOfMarriage = Enum.GetNames(typeof(StateOfMarriage)).Length;

            if (marriage == false)
            {
                newAdult.StateOfMarriage = (StateOfMarriage)random.Next(countStateOfMarriage);

                if (newAdult.StateOfMarriage == StateOfMarriage.Married)
                {
                    newAdult.Partner = CreateRandomAdult(true, newAdult, newAdult.Gender);
                }
            }
            else if (marriage == true && partner == null)
            {
                newAdult.Partner = CreateRandomAdult(true, newAdult, newAdult.Gender);
            }
            else
            {
                newAdult.Partner = partner;
            }

            newAdult.Age = random.Next(17, 100);

            newAdult.PassportSeries = random.Next(0, 9999).ToString("D4");
            newAdult.PassportNumber = random.Next(0, 999999).ToString("D6");

            var Path = AppDomain.CurrentDomain.BaseDirectory
                + "\\ParametrsPerson\\";
            var pathWorkPlace = System.IO.Path.Combine(Path, "WorkPlace.txt");
            newAdult.WorkPlace = Person.GetLine(pathWorkPlace);

            return newAdult;
        }

        /// <summary>
        /// Проверка правильности (5.С задание)
        /// </summary>
        /// <returns>строка с каким-то текстом</returns>
        public override string IAm()
        {
            var iAm = base.IAm();

            iAm += $"и я взрослый человек";

            return iAm;
        }
    }
}
