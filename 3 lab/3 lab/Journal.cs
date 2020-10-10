using System;

namespace _3_lab
{
    /// <summary>
    /// Журнал
    /// </summary>
    public class Journal : EditionBase
    {
        /// <summary>
        /// Название издательства
        /// </summary>
        private string _publishing;

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

        #region Constructors
        /// <summary>
        /// Журнал
        /// </summary>
        public Journal() { }

        /// <summary>
        /// Журнал
        /// </summary>
        /// <param name="publishing">издательство</param>
        /// <param name="title">название журнала</param>
        /// <param name="city">город</param>
        /// <param name="date">дата</param>
        /// <param name="pages">количество страниц</param>
        public Journal(string publishing,
            string title, string city, DateTime date, int pages)
            : base(title, city, date, pages)
        {
            Publishing = publishing;
        }
        #endregion

        /// <summary>
        /// Описание издания
        /// </summary>
        /// <returns>строка с описанием</returns>
        public override string DescriptionEdition()
        {
            return $"{Title} ({Date.ToString("D")}). - {City}: " +
                $"{Publishing}, {Date.Year}. - {Pages} с.";
        }
    }
}