using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using _3_lab;
using Library;
using System.Text.RegularExpressions;

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
            int typeEdition = _random.Next(0, 3);
            
            switch (typeEdition)
            {
                case 0:
                    {
                        return GetRandomBook();
                    }
                case 1:
                    {
                        return GetRandomCollectedPaper();
                    }
                case 2:
                    {
                        return GetRandomDissertation();
                    }
                case 3:
                    {
                        return GetRandomJournal();
                    }
                default:
                    {
                        throw new ArgumentException();
                    }
            }
        }

        /// <summary>
        /// Получить случайную книгу
        /// </summary>
        /// <returns>случайная книга</returns>
        private static EditionBase GetRandomBook()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author(GetSurname(), GetInitials()));

            var book = new Book()
            {
                Title = GetTitle(),
                City = GetCity(),
                Date = GetDate(),
                Pages = _random.Next(1, 1000),
                Publishing = "Издание",
                Authors = authors
            };
            return book;
        }

        /// <summary>
        /// Получить сборник
        /// </summary>
        /// <returns>сборник</returns>
        private static EditionBase GetRandomCollectedPaper()
        {
            var paper = new CollectedPaper()
            {
                Title = GetTitle(),
                City = GetCity(),
                Date = GetDate(),
                Pages = _random.Next(1, 1000),
                University = GetUniversity()
            };
            return paper;
        }

        /// <summary>
        /// Получить диссертацию
        /// </summary>
        /// <returns>диссертация</returns>
        private static EditionBase GetRandomDissertation()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author(GetSurname(), GetInitials()));

            var dissertation = new Dissertation()
            {
                Title = GetTitle(),
                City = GetCity(),
                Date = GetDate(),
                Pages = _random.Next(1, 1000),
                SpecialityCode = GetCode(),
                Speciality = GetSpeciality(),
                University = GetUniversity(),
                Authors = authors
            };
            return dissertation;
        }

        /// <summary>
        /// Получить журнал
        /// </summary>
        /// <returns>журнал</returns>
        private static EditionBase GetRandomJournal()
        {
            var book = new Book()
            {
                Title = GetTitle(),
                City = GetCity(),
                Date = GetDate(),
                Pages = _random.Next(1, 1000),
                Publishing = "Издание"
            };
            return book;
        }

        /// <summary>
        /// Получить название специальности
        /// </summary>
        /// <returns>название специальности</returns>
        private static string GetSpeciality()
        {
            List<string> specialityList = new List<string>()
            {
                "Математика",
                "Информатика",
                "Физика",
                "Химия",
                "География",
                "Геология",
                "Радиотехника",
                "Электроэнергетика и электротехника",
                "Теплоэнергетика и теплотехника"
            };
            int index = _random.Next(0, specialityList.Count);

            return specialityList[index];
        }

        /// <summary>
        /// Получить код специальности
        /// </summary>
        /// <returns>код специальности</returns>
        private static string GetCode()
        {
            return $"{_random.Next(10, 99)}.{_random.Next(10, 99)}." +
                $"{_random.Next(10, 99)}.";
        }

        /// <summary>
        /// Получить название университета
        /// </summary>
        /// <returns>название университета</returns>
        private static string GetUniversity()
        {
            List<string> universityList = new List<string>()
            {
                "ТПУ",
                "МЭИ",
                "КГЭУ",
                "ТГУ",
                "МГИМО",
                "ТУСУР",
                "КФУ",
                "МГУ",
                "СПбГУ"
            };
            int index = _random.Next(0, universityList.Count);

            return universityList[index];
        }

        /// <summary>
        /// Получить инициалы
        /// </summary>
        /// <returns>инициалы</returns>
        private static string GetInitials()
        {
            int n = 0;
            char[] alphabet = new char[32];
            for (int i = 1040; i <= 1071; i++)
            {
                alphabet[n] = Convert.ToChar(i);
                n++;
            }

            return $"{alphabet[_random.Next(0, 32)]}." +
                $"{alphabet[_random.Next(0, 32)]}.";
        }

        /// <summary>
        /// Получить название издания
        /// </summary>
        /// <returns>название</returns>
        private static string GetTitle()
        {
            List<string> titleList = new List<string>()
            {
                "Структура лесного фонда Няганьского городского " +
                "лесничества",
                "Изучение приживаемости штамма Agrobacterium " +
                "radiobacter 204 в ризосфере виноградного растения",
                "Водосберегающая технология орошения риса и " +
                "регулирование минерализации воды в рисовых чеках"
            };
            int index = _random.Next(0, titleList.Count);

            return titleList[index];
        }

        /// <summary>
        /// Получить фамилию
        /// </summary>
        /// <returns>фамилия</returns>
        private static string GetSurname()
        {
            List<string> surnameList = new List<string>()
            {
                "Иванов",
                "Петров",
                "Сидоров",
                "Иванова",
                "Петрова",
                "Сидорова"
            };
            int index = _random.Next(0, surnameList.Count);

            return surnameList[index];
        }

        /// <summary>
        /// Получить город
        /// </summary>
        /// <returns>город</returns>
        private static string GetCity()
        {
            List<string> cityList = new List<string>()
            {
                "Москва",
                "Казань",
                "Санкт-Петерсбург",
                "Томск",
                "Кемерово",
                "Новосибирск",
                "Иркутск"
            };
            int index = _random.Next(0, cityList.Count);

            return cityList[index];
        }

        /// <summary>
        /// Получить дату
        /// </summary>
        /// <param name="minimalData">минимальное занчение</param>
        /// <param name="maximalDate">максимальное значение</param>
        /// <returns></returns>
        private static DateTime GetDate()
        {
            var minimalData = new DateTime(1800, 01, 01);
            var maximalDate = new DateTime(2020, 01, 01);
            TimeSpan range = maximalDate - minimalData;
            var randts = new TimeSpan(
                (long)(_random.NextDouble() * range.Ticks));
            return (minimalData + randts).Date;
        }
    }
}
