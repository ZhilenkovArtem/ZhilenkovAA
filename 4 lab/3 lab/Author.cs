using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _3_lab
{
    /// <summary>
    /// Автор
    /// </summary>
    [Serializable]
    public class Author
    {
        #region Fields
        /// <summary>
        /// Фамилия
        /// </summary>
        private string _surname;

        /// <summary>
        /// Инициалы
        /// </summary>
        private string _initials;
        #endregion

        #region Properties
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = ValidationSurname(value);
            }
        }

        /// <summary>
        /// Инициалы
        /// </summary>
        public string Initials 
        {
            get
            { 
                return _initials; 
            }
            set
            { 
                _initials = ValidationInitials(value); 
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Авторы
        /// </summary>
        public Author() { }

        /// <summary>
        /// Автор
        /// </summary>
        /// <param name="surname">фамилия</param>
        /// <param name="initials">инициалы</param>
        public Author(string surname, string initials)
        {
            Surname = surname;
            Initials = initials;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Описание автора
        /// </summary>
        /// <returns>строка с описанием</returns>
        private string DescriptionAuthor()
        {
            return $"{Surname} {Initials}, ";
        }

        /// <summary>
        /// Описание авторов
        /// </summary>
        /// <param name="authors">авторы</param>
        /// <returns>строка с описанием</returns>
        public static string DescriptionAuthors(List<Author> authors)
        {
            string description = null;

            foreach (var author in authors)
            {
                description += author.DescriptionAuthor();
            }

            return description;
        }

        /// <summary>
        /// Проверка правильности введенной фамилии
        /// </summary>
        /// <param name="dubiousWord">сомнительное слово</param>
        /// <returns>правильное слово</returns>
        private static string ValidationSurname(string dubiousWord)
        {
            Checker.ValidationForSimpleText(dubiousWord);

            var trueWord = ChangeWord(dubiousWord);
            
            return trueWord;
        }

        /// <summary>
        /// Изменение слова
        /// </summary>
        /// <param name="changedWord">изменяемое слово</param>
        /// <returns>измененное слово</returns>
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
        /// Проверка правильности введенных инициалов
        /// </summary>
        /// <param name="dubiousWord">сомнительное слово</param>
        /// <returns>правильное слово</returns>
        private static string ValidationInitials(string dubiousWord)
        {
            Regex regexName = new Regex("(([А-Я]|[а-я]|[A-Z]|[a-z])[.]){2}");

            Checker.Validation(dubiousWord, regexName);

            var trueWord = ChangeInitials(dubiousWord);

            return trueWord;
        }

        /// <summary>
        /// Изменение инициалов
        /// </summary>
        /// <param name="changedWord">изменяемое слово</param>
        /// <returns>измененное слово</returns>
        private static string ChangeInitials(string changedWord)
        {
            char[] symbols = changedWord.ToArray();

            changedWord = $"{symbols[0].ToString().ToUpper()}." +
                $"{symbols[2].ToString().ToUpper()}.";

            return changedWord;
        }
        #endregion
    }
}
