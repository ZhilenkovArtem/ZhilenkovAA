using System;
using System.IO;

namespace Library
{
    public class RandomPerson
    {
        /// <summary>
        /// Рандом
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Дополнительный рандомайзер
        /// </summary>
        /// <param name="minimum">минимальное число</param>
        /// <param name="maximum">максимальное число</param>
        /// <returns>возвращаемое число</returns>
        private static int Randomize(int minimum, int maximum)
        {
            DateTime date = DateTime.Now;
            var randomNumber = int.Parse(date.ToString("ffff").Substring(2, 1));
            double calculatedNumber = (maximum - minimum) * randomNumber / 10;
            int findedNumber = minimum + (int)Math.Round(calculatedNumber);

            return findedNumber;
        }

        /// <summary>
        /// Создание рандомного человека
        /// </summary>
        /// <returns>рандомный человек</returns>
        public static PersonBase CreateRandomPerson()
        {
            if (_random.Next(0, 2) == 0)
            {
                return CreateRandomAdult();
            }
            else
            {
                return CreateRandomChild();
            }
        }

        /// <summary>
        /// Создание рандомного человека с базовыми параметрами
        /// </summary>
        /// <returns>рандомный человек</returns>
        public static void CreateBasePerson(PersonBase randomPerson, GenderType gender = GenderType.NoGender)
        {
            var Path = AppDomain.CurrentDomain.BaseDirectory
                + "\\ParametrsPerson\\";

            var pathNameFemale = System.IO.Path.Combine(Path, "NameFemale.txt");
            var pathNameMale = System.IO.Path.Combine(Path, "NameMale.txt");
            var pathSurnameFemale = System.IO.Path.Combine(Path, "SurnameFemale.txt");
            var pathSurnameMale = System.IO.Path.Combine(Path, "SurnameMale.txt");

            switch (gender)
            {
                case GenderType.NoGender:
                    {
                        int countGender = Enum.GetNames(typeof(GenderType)).Length;
                        randomPerson.Gender = (GenderType)_random.Next(countGender - 1);
                    }
                    break;
                case GenderType.Male:
                    {
                        randomPerson.Gender = GenderType.Female;
                    }
                    break;
                case GenderType.Female:
                    {
                        randomPerson.Gender = GenderType.Male;
                    }
                    break;
            }

            switch (randomPerson.Gender)
            {
                case GenderType.Female:
                    {
                        randomPerson.Name = GetLine(pathNameFemale);
                        randomPerson.Surname = GetLine(pathSurnameFemale);
                    }
                    break;
                case GenderType.Male:
                    {
                        randomPerson.Name = GetLine(pathNameMale);
                        randomPerson.Surname = GetLine(pathSurnameMale);
                    }
                    break;
            }
        }

        /// <summary>
        /// Выбор строки из списка, к которому дан путь
        /// </summary>
        /// <param name="path">Путь к списку</param>
        /// <returns>Строка списка</returns>
        public static string GetLine(string path)
        {
            string[] separator = new string[] { "\r\n" };
            string[] temp = File.ReadAllText(path).Split(separator, StringSplitOptions.None);
            var line = temp[Randomize(0, temp.Length)];

            return line;
        }

        /// <summary>
        /// Создание взрослого человека
        /// </summary>
        /// <param name="marriage">женатость</param>
        /// <param name="partner">партнер</param>
        /// <param name="gender">пол</param>
        /// <returns>взрослый человек</returns>
        public static Adult CreateRandomAdult(bool marriage = false, Adult partner = null, 
            GenderType gender = GenderType.NoGender)
        {
            var newAdult = new Adult();

            CreateBasePerson(newAdult, gender);

            int countStateOfMarriage = Enum.GetNames(typeof(StateOfMarriage)).Length;

            if (marriage == false)
            {
                newAdult.StateOfMarriage = (StateOfMarriage)_random.Next(countStateOfMarriage);

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

            newAdult.Age = Randomize(Adult.MINAGE, Adult.MAXAGE);

            newAdult.PassportSeries = _random.Next(0, 9999).ToString("D4");
            newAdult.PassportNumber = _random.Next(0, 999999).ToString("D6");

            var Path = AppDomain.CurrentDomain.BaseDirectory
                + "\\ParametrsPerson\\";
            var pathWorkPlace = System.IO.Path.Combine(Path, "WorkPlace.txt");
            newAdult.WorkPlace = GetLine(pathWorkPlace);

            return newAdult;
        }

        /// <summary>
        /// Создание ребенка
        /// </summary>
        /// <returns>ребенок</returns>
        public static Child CreateRandomChild()
        {
            var newChild = new Child();

            CreateBasePerson(newChild, GenderType.NoGender);

            newChild.Mother = CreateRandomAdult(true, null, GenderType.Male);
            newChild.Father = newChild.Mother.Partner;

            var childMaximalAge = Child.Minimum(Child.MAXAGE, Child.Minimum(newChild.Mother.Age,
                newChild.Father.Age) - 12);

            newChild.Age = Randomize(0, childMaximalAge);

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

            newChild.Institution = GetLine(path);

            return newChild;
        }
    }
}
