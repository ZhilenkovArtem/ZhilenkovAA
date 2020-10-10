using System;

namespace Library
{
    /// <summary>
    /// Издание
    /// </summary>
    interface IEdition
    {
        /// <summary>
        /// Название издания
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        string City { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Количество страниц
        /// </summary>
        int Pages { get; set; }
    }
}