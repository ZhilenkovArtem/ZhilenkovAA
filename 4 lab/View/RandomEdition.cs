using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using _3_lab;
using Library;

namespace View
{
    public static class RandomEdition
    {
        /// <summary>
        /// Случайное число
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Получить рандомное издание
        /// </summary>
        /// <returns>рандомное издание</returns>
        public static EditionBase GetRandomEdition()
        {
            //int typeEdition = _random.Next(0, 3);
            //
            //switch (typeEdition)
            //{
            //    case 0:
            //        {
            return GetRandomBook();
            //        }
            //}
        }

        /// <summary>
        /// Получить случайную книгу
        /// </summary>
        /// <returns>случайная книга</returns>
        private static EditionBase GetRandomBook()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author("Иванов", "А.А."));

            var book = new Book()
            {
                Title = GetTitle(),
                City = GetCity(),
                Date = GetDate(
                    DateTime.Parse("01.01.1800"), DateTime.Parse("01.01.2020")),
                Pages = _random.Next(1, 1000),
                Publishing = "Издание",
                Authors = authors
            };
            return book;
        }

        /// <summary>
        /// Получить название
        /// </summary>
        /// <returns></returns>
        private static string GetTitle()
        {
            List<string> titleList = new List<string>();
            titleList.Add("Структура лесного фонда Няганьского городского " +
                "лесничества");
            titleList.Add("Изучение приживаемости штамма Agrobacterium " +
                "radiobacter 204 в ризосфере виноградного растения");
            titleList.Add("Водосберегающая технология орошения риса и " +
                "регулирование минерализации воды в рисовых чеках");

            int index = _random.Next(0, 2);

            return titleList[index];
        }

        /// <summary>
        /// Получить город
        /// </summary>
        /// <returns></returns>
        private static string GetCity()
        {
            List<string> cityList = new List<string>();
            cityList.Add("Москва");
            cityList.Add("Казань");
            cityList.Add("Санкт-Петерсбург");
            cityList.Add("Томск");
            cityList.Add("Кемерово");
            cityList.Add("Новосибирск");
            cityList.Add("Иркутск");

            int index = _random.Next(0, 6);

            return cityList[index];
        }

        /// <summary>
        /// Получить дату
        /// </summary>
        /// <param name="minimalData">минимальное занчение</param>
        /// <param name="maximalDate">максимальное значение</param>
        /// <returns></returns>
        private static DateTime GetDate(
            DateTime minimalData, DateTime maximalDate)
        {
            TimeSpan range = maximalDate - minimalData;
            var randts = new TimeSpan(
                (long)(_random.NextDouble() * range.Ticks));
            return (minimalData + randts).Date;
        }
    }
}
