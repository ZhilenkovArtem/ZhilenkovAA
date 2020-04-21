using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace Library
{
    /// <summary>
    /// Класс, описывающий параметры человека
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя человека
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия человека
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст человека
        /// </summary>
        private int _age;

        /// <summary>
        /// Имя
        /// </summary>
        public string Name
        {
            set
            {
                _name = Validation(value, "Имя");
            }
            get
            {
                return _name;
            }
        }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname
        {
            set
            {
                _surname = Validation(value, "Фамилиия");
            }
            get
            {
                return _surname;
            }
        }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age
        {
            set
            {
                if (value < 0)
                {
                    throw new FormatException("Такого не может быть");
                }
                if (value > 160)
                {
                    throw new FormatException("Серьёзно? Не верю! А ну ка, наберай заново");
                }
                _age = value;
            }
            get
            {
                return _age;
            }
        }
        /// <summary>
        /// Пол
        /// </summary>
        public GenderType Gender { set; get; }

        /// <summary>
        /// Создание рандомного человека
        /// </summary>
        /// <returns>Рандомный человек</returns>
        public static Person GetRandomPerson()
        {
            Person randomPerson = new Person();
            Random random = new Random();

            var Path = AppDomain.CurrentDomain.BaseDirectory 
                + "\\ParametrsPerson\\";

            var pathNameFemale = System.IO.Path.Combine(Path, "NameFemale.txt");
            var pathNameMale = System.IO.Path.Combine(Path, "NameMale.txt");
            var pathSurnameFemale = System.IO.Path.Combine(Path, "SurnameFemale.txt");
            var pathSurnameMale = System.IO.Path.Combine(Path, "SurnameMale.txt");

            int countGender = Enum.GetNames(typeof(GenderType)).Length;

            randomPerson.Gender = (GenderType)random.Next(countGender);

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

            randomPerson.Age = random.Next(0, 100);

            return randomPerson;
        }

        /// <summary>
        /// Выбор строки из списка, к которому дан путь
        /// </summary>
        /// <param name="path">Путь к списку</param>
        /// <returns>Строка списка</returns>
        public static string GetLine(string path)
        {
            Random random = new Random();
            string[] temp = File.ReadAllText(path).Split('\n');
            var line = temp[random.Next(temp.Length)];
            return line;
        }

        /// <summary>
        /// Определяет равны ли два человека
        /// </summary>
        /// <param name="person">Человек из списка</param>
        /// <returns></returns>
        public override bool Equals(object person)
        {
            var tmpPerson = person as Person;
            
            if (tmpPerson == null || person == null)
            {
                return false;
            }

            return Name.Equals(tmpPerson.Name) &&
                   Surname.Equals(tmpPerson.Surname) &&
                   Age.Equals(tmpPerson.Age) &&
                   Gender.Equals(tmpPerson.Gender);
        }

        /// <summary>
        /// Преобразование слова в вид, при котором оно начинается с
        /// заглавной буквы. Учтено существование составных имен
        /// </summary>
        /// <param name="changedWord">Изменяемое слово</param>
        /// <returns>Измененное слово</returns>
        private static string ChangeWord(string changedWord)
        {
            string[] partWord = changedWord.Split('-');
            changedWord = null;

            for (int i = 0; i < partWord.Length; i++)
            {
                partWord[i] = partWord[i].First().ToString().ToUpper() 
                    + partWord[i].Substring(1);

                changedWord += partWord[i] + "-";
            }
            return changedWord.Substring(0, changedWord.Length - 1);
        }

        /// <summary>
        /// Проверка на правильность введенного имени/фамилии
        /// </summary>
        /// <param name="dubiousValue">Введенное слово</param>
        /// <returns>Проверенно на правильность и 
        /// отредактированное слово</returns>
        private static string Validation(string dubiousValue, 
            string nameOrSurname)
        {
            Regex regexName = new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])");

            if (string.IsNullOrEmpty(dubiousValue))
            {
                throw new ArgumentNullException();
            }

            if (!regexName.IsMatch(dubiousValue))
            {
                throw new FormatException($"{nameOrSurname} не может " +
                    $"содержать символы");
            }

            var trueWord = ChangeWord(dubiousValue);
            return trueWord;
        }
    }
}