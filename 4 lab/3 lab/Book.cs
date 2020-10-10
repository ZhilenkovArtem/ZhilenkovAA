using _3_lab;
using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Книга
    /// </summary>
    public class Book : EditionBase
    {
        #region Fields
        /// <summary>
        /// Название издательства
        /// </summary>
        private string _publishing;
        #endregion

        #region Properties
        /// <summary>
        /// Авторы
        /// </summary>
        public List<Author> Authors { get; set; }

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
        /// Книга
        /// </summary>
        public Book() { }

        /// <summary>
        /// Книга
        /// </summary>
        /// <param name="authors">авторы</param>
        /// <param name="publishing">издательство</param>
        /// <param name="title">название книги</param>
        /// <param name="city">город</param>
        /// <param name="date">дата</param>
        /// <param name="pages">количество страниц</param>
        public Book(List<Author> authors, string publishing, 
            string title, string city, DateTime date, int pages) 
            :base(title, city, date, pages)
        {
            Authors = authors;
            Publishing = publishing;
        }
        #endregion

        /// <summary>
        /// Описание издания
        /// </summary>
        /// <returns>строка с описанием</returns>
        public override string DescriptionEdition()
        {
            string authorList = Author.DescriptionAuthors(Authors);

            return $"{authorList}{Title}. - {City}: {Publishing}, {Date.Year}. -" +
                $" {Pages} с.";
        }
    }
}