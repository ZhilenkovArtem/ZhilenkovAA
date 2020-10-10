using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3_lab
{
    /// <summary>
    /// Диссертация
    /// </summary>
    public class Dissertation : EditionBase
    {
        #region Fields
        /// <summary>
        /// Код специальности
        /// </summary>
        private string _code;

        /// <summary>
        /// Специальность/направление
        /// </summary>
        private string _speciality;

        /// <summary>
        /// Название университета
        /// </summary>
        private string _university;
        #endregion

        #region Properties
        /// <summary>
        /// Авторы
        /// </summary>
        public List<Author> Authors { get; set; }

    
        /// <summary>
        /// Код специальности
        /// </summary>
        public string SpecialityCode
        {
            get
            { 
                return _code; 
            }
            set
            {
                ValidationCode(value);

                _code = value;
            }
        }

        /// <summary>
        /// Специальность/направление
        /// </summary>
        public string Speciality
        {
            get
            { 
                return _speciality; 
            }
            set
            { 
                _speciality = ChangeSimpleText(value); 
            }
        }

        /// <summary>
        /// Название университета
        /// </summary>
        public string University
        {
            get
            { 
                return _university; 
            }
            set
            { 
                _university = ChangeCapitalizedText(value); 
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Диссертация
        /// </summary>
        public Dissertation() {}

        /// <summary>
        /// Диссертация
        /// </summary>
        /// <param name="authors">авторы</param>
        /// <param name="code">код специальности</param>
        /// <param name="speciality">название специальности</param>
        /// <param name="university">университет</param>
        /// <param name="title">тема диссертации</param>
        /// <param name="city">город</param>
        /// <param name="date">дата</param>
        /// <param name="pages">количество страниц</param>
        public Dissertation(List<Author> authors, string code, 
            string speciality, string university,
            string title, string city, DateTime date, int pages)
            : base(title, city, date, pages)
        {
            Authors = authors;
            SpecialityCode = code;
            Speciality = speciality;
            University = university;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Описание издания
        /// </summary>
        /// <returns>строка с описанием</returns>
        public override string DescriptionEdition()
        {
            string authorList = Author.DescriptionAuthors(Authors);

            return $"{authorList} {Title}: специальность {SpecialityCode} \"{Speciality}\"" +
                $" : диссертация на соискание ученой степени / {authorList} ; " +
                $"{University}. - {City}, {Date.Year}. - {Pages} с.";
        }

        /// <summary>
        /// Проверка правильности введенного кода специальности
        /// </summary>
        /// <param name="dubiousValue">сомнительная величина</param>
        private static void ValidationCode(string dubiousValue)
        {
            Regex regexName = new Regex("(([0-9]{2})[.]){2}[0-9]{2}");

            Checker.Validation(dubiousValue, regexName);
        }
        #endregion
    }
}
