using System;

namespace _3_lab
{
    /// <summary>
    /// Сборник
    /// </summary>
    public class CollectedPaper : EditionBase
    {
        #region Fields
        /// <summary>
        /// Название университета
        /// </summary>
        private string _university;

        /// <summary>
        /// Название издательства
        /// </summary>
        private string _publishing;
        #endregion

        #region Properties
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

        /// <summary>
        /// Название издательства
        /// </summary>
        public string Publishing
        {
            get
            { 
                return _publishing; 
            }
            set
            { 
                _publishing = ChangePublishingName(value); 
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Сборник
        /// </summary>
        public CollectedPaper() { }
        
        /// <summary>
        /// Сборник
        /// </summary>
        /// <param name="university">университет</param>
        /// <param name="publishing">издательство</param>
        /// <param name="title">название сборника</param>
        /// <param name="city">город</param>
        /// <param name="date">дата</param>
        /// <param name="pages">количество страниц</param>
        public CollectedPaper(string university, string publishing,
            string title, string city, DateTime date, int pages)
            : base(title, city, date, pages)
        {
            University = university;
            Publishing = publishing;
        }
        #endregion

        /// <summary>
        /// Описание издания
        /// </summary>
        /// <returns>строка с описанием</returns>
        public override string DescriptionEdition()
        {
            return $"{Title} ({Date.ToString("D")}) / {University}. - {City}" +
                $": {Publishing}, {Date.Year}. - {Pages} с.";
        }
    }
}