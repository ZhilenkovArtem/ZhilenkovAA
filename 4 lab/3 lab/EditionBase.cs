using Library;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3_lab
{
    /// <summary>
    /// Издание
    /// </summary>
    [Serializable]
    public abstract class EditionBase : IEdition
    {
        #region Fields
        /// <summary>
        /// Название издания
        /// </summary>
        private string _title;

        /// <summary>
        /// Город
        /// </summary>
        private string _city;

        /// <summary>
        /// Дата
        /// </summary>
        private DateTime _date;

        /// <summary>
        /// Количество страниц
        /// </summary>
        private int _pages;
        #endregion

        #region Properties
        /// <summary>
        /// Название издания
        /// </summary>
        public string Title
        {
            get
            { 
                return _title; 
            }
            set
            { 
                _title = ChangeSimpleText(value); 
            }
        }

        /// <summary>
        /// Город
        /// </summary>
        public string City
        {
            get
            { 
                return _city; 
            }
            set
            { 
                _city = ChangeCapitalizedText(value); 
            }
        }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date
        {
            get
            { 
                return _date; 
            }
            set
            {
                ValidationDates(value);

                if (value.Year > DateTime.Now.Year)
                {
                    throw new FormatException($"!Сейчас {DateTime.Now.Year} год");
                }

                _date = value;
            }
        }

        /// <summary>
        /// Количество страниц
        /// </summary>
        public int Pages
        {
            get
            { 
                return _pages; 
            }
            set
            {
                ValidationNumbers(value);

                if (value < 1)
                {
                    throw new FormatException();
                }

                _pages = value;
            }
        }
        #endregion

        #region Constructors
        
        /// <summary>
        /// Издание
        /// </summary>
        protected EditionBase() { }

        /// <summary>
        /// Издание
        /// </summary>
        /// <param name="title">название</param>
        /// <param name="city">город</param>
        /// <param name="date">дата</param>
        /// <param name="pages">страницы</param>
        protected EditionBase(string title, string city, DateTime date, int pages)
        {
            Title = title;
            City = city;
            Date = date;
            Pages = pages;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Описание издания
        /// </summary>
        /// <returns>строка с описанием</returns>
        public virtual string DescriptionEdition()
        {
            return $"{Title}. - {City}: {Date}. - {Pages} с.";
        }

        /// <summary>
        /// Проверка правильности введенного числового значения
        /// </summary>
        /// <param name="numbers">числовое значение</param>
        public static void ValidationDates(DateTime numbers)
        {
            Regex regexName = new Regex("[0-9]");

            Checker.Validation(numbers.ToString(), regexName);
        }

        /// <summary>
        /// Проверка правильности введенного числового значения
        /// </summary>
        /// <param name="numbers">числовое значение</param>
        public static void ValidationNumbers(int numbers)
        {
            Regex regexName = new Regex("[0-9]");

            Checker.Validation(numbers.ToString(), regexName);
        }

        /// <summary>
        /// Проверка и изменение введенного простого текстового значения
        /// </summary>
        /// <param name="simpleText">исходный текст</param>
        /// <returns>исправленный текст</returns>
        public static string ChangeSimpleText(string simpleText)
        {
            Checker.ValidationForSimpleText(simpleText);

            var trueText = ChangeWord(simpleText);

            return trueText;
        }

        /// <summary>
        /// Проверка и изменение введенного текста с прописными буквами
        /// </summary>
        /// <param name="capitalizedText">исходный текст</param>
        /// <returns>исправленный текст</returns>
        public static string ChangeCapitalizedText(string capitalizedText)
        {
            Checker.ValidationForSimpleText(capitalizedText);

            string[] partSentence = capitalizedText.Split(' ');

            string trueText = null;

            foreach (string part in partSentence)
            {
                trueText += ChangeWord(part) + " ";
            }

            return trueText.Substring(0, trueText.Length - 1);
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
                    + partWord[i].Substring(1).ToLower();

                changedWord += partWord[i] + "-";
            }
            return changedWord.Substring(0, changedWord.Length - 1);
        }

        /// <summary>
        /// Изменение названия издательства
        /// </summary>
        /// <param name="text">исходный текст</param>
        /// <returns>исправленный текст</returns>
        public static string ChangePublishingName(string text)
        {
            Checker.ValidationForSimpleText(text);

            string updatedText = text.First().ToString().ToUpper()
                    + text.Substring(1);

            return updatedText;
        }
        #endregion
    }
}
