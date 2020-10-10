using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Library
{
    /// <summary>
    /// Класс, описывающий параметры человека
    /// </summary>
    public abstract class PersonBase
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
        protected int _age;

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
        public abstract int Age { get;  set; }

        /// <summary>
        /// Пол
        /// </summary>
        public GenderType Gender { set; get; }

        

        /// <summary>
        /// Определяет равны ли два человека
        /// </summary>
        /// <param name="person">Человек из списка</param>
        /// <returns></returns>
        public override bool Equals(object person)
        {
            var tmpPerson = person as PersonBase;
            
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

        /// <summary>
        /// Формирование строки с базовыми данными о человеке
        /// </summary>
        /// <returns>Данные о человеке</returns>
        public virtual string DescriptionPerson()
        {
            return $"Имя: {Name}\nФамилия: {Surname}\nВозраст: {Age}\n" +
                $"Пол: {Gender}";
        }

        /// <summary>
        /// Сформировать короткую информацию о человеке
        /// </summary>
        /// <returns>Строка с информацией</returns>
        public string ShortDescriptionPerson()
        {
            return $"{Name} {Surname}";
        }

        /// <summary>
        /// Проверка правильности
        /// </summary>
        /// <returns>строка с каким-то текстом</returns>
        public virtual string DefinitionPerson()
        {
            return $"Меня зовут {ShortDescriptionPerson()} ";
        }
    }
}