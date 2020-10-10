using System;
using _3_lab;
using Library;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Test
{
    /// <summary>
    /// Тестирование
    /// </summary>
    public class Testing
    {
        /// <summary>
        /// Издания
        /// </summary>
        private static List<EditionBase> _editions = new List<EditionBase>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***Меню***\n" +
                    "b - Книга\n" +
                    "s - Сборник\n" +
                    "d - Диссертация\n" +
                    "j - Журнал\n" +
                    "getb - Вывод списка книг\n" +
                    "gets - Вывод списка сборников\n" +
                    "getd - Вывод списка диссертаций\n" +
                    "getj - Вывод списка журналов\n" +
                    "ex - Выход\n");
                try
                {
                    Console.Write("Ваш выбор:  ");
                    var key = Console.ReadLine();
                    CheckNumber(key);
                    Console.WriteLine();
                    switch (key)
                    {
                        case "b":
                            AddEdition(() => EnterBook(), _editions);
                            GetEdition(_editions.Where(edition => edition is Book));
                            break;
                        case "s":
                            AddEdition(() => EnterCollectedPaper(), _editions);
                            GetEdition(_editions.Where(edition => edition is CollectedPaper));
                            break;
                        case "d":
                            AddEdition(() => EnterDissertation(), _editions);
                            GetEdition(_editions.Where(edition => edition is Dissertation));
                            break;
                        case "j":
                            AddEdition(() => EnterJournal(), _editions);
                            GetEdition(_editions.Where(edition => edition is Journal));
                            break;
                        case "getb":
                            GetEdition(_editions.Where(edition => edition is Book));
                            break;
                        case "gets":
                            GetEdition(_editions.Where(edition => edition is CollectedPaper));
                            break;
                        case "getd":
                            GetEdition(_editions.Where(edition => edition is Dissertation));
                            break;
                        case "getj":
                            GetEdition(_editions.Where(edition => edition is Journal));
                            break;
                        case "ex":
                            return;
                    }
                }
                catch (Exception exception)
                {
                    if (exception is ArgumentNullException
                    || exception is ArgumentException
                    || exception is IndexOutOfRangeException
                    || exception is FormatException)
                    {
                        Console.WriteLine($"{exception.Message}\n");
                    }
                }
            }
        }

        #region Methods of adding editions
        /// <summary>
        /// Добавление книг
        /// </summary>
        static void AddEdition(Func<EditionBase> editionAdditior, List<EditionBase> edition)
        {
            string subkey;
            do
            {
                edition.Add(editionAdditior.Invoke());
                Console.WriteLine("\nПродолжить добавление?" +
                    "(Y - для продолжения / Любая " +
                    "другая клавиша - для завершения)");
                subkey = Console.ReadLine();
            }
            while ((subkey == "y") || (subkey == "Y"));
        }
        #endregion

        #region Methods of entering parameters
        /// <summary>
        /// Ввод параметров, общих для всех изданий
        /// </summary>
        /// <param name="edition">пустое описание издания</param>
        /// <returns>заполненное описание издания</returns>
        private static EditionBase EnterEdition(EditionBase edition)
        {
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Введите название");
                    edition.Title = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите название города");
                    edition.City = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите дату в формате 01.01.2020");
                    edition.Date = DateTime.Parse(Console.ReadLine());
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите количество страниц");
                    edition.Pages = int.Parse(Console.ReadLine());
                }),
            };
            actions.ForEach(SetParameters);
            return edition;
        }

        /// <summary>
        /// Ввод параметров книги
        /// </summary>
        /// <returns>заполненное описание книги</returns>
        private static Book EnterBook()
        {
            var book = new Book();

            var edition = EnterEdition(book);
            book.Title = edition.Title;
            book.City = edition.City;
            book.Date = edition.Date;
            book.Pages = edition.Pages;

            var authors = new List<Author>();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Введите название издательства");
                    book.Publishing = Console.ReadLine();
                }),
                new Action(() =>
                {
                    string subkey;
                    do
                    {
                        authors.Add(EnterAuthor());
                        Console.WriteLine("\nДобавить еще автора?" +
                            "(Y - для продолжения / Любая " +
                            "другая клавиша - для завершения)");
                        subkey = Console.ReadLine();
                    }
                    while ((subkey == "y") || (subkey == "Y"));

                    book.Authors = authors;
                }),
            };
            actions.ForEach(SetParameters);
            return book;
        }

        /// <summary>
        /// Ввод параметров сборника
        /// </summary>
        /// <returns>Заполненное описание сборника</returns>
        private static CollectedPaper EnterCollectedPaper()
        {
            var collectedPaper = new CollectedPaper();

            var edition = EnterEdition(collectedPaper);
            collectedPaper.Title = edition.Title;
            collectedPaper.City = edition.City;
            collectedPaper.Date = edition.Date;
            collectedPaper.Pages = edition.Pages;

            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Введите название университета");
                    collectedPaper.University = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите название издательства");
                    collectedPaper.Publishing = Console.ReadLine();
                }),
            };
            actions.ForEach(SetParameters);
            return collectedPaper;
        }

        /// <summary>
        /// Ввод параметров диссертации
        /// </summary>
        /// <returns>заполненное описание диссертации</returns>
        private static Dissertation EnterDissertation()
        {
            var dissertation = new Dissertation();

            var edition = EnterEdition(dissertation);
            dissertation.Title = edition.Title;
            dissertation.City = edition.City;
            dissertation.Date = edition.Date;
            dissertation.Pages = edition.Pages;

            var authors = new List<Author>();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    authors.Add(EnterAuthor());
                    dissertation.Authors = authors;
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите код специальности " +
                        "(например 13.03.02)");
                    dissertation.SpecialityCode = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите название специальности");
                    dissertation.Speciality = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите название университета");
                    dissertation.University = Console.ReadLine();
                }),
            };
            actions.ForEach(SetParameters);
            return dissertation;
        }

        /// <summary>
        /// Ввод параметров журнала
        /// </summary>
        /// <returns>Заполненное описание журнала</returns>
        private static Journal EnterJournal()
        {
            var journal = new Journal();

            var edition = EnterEdition(journal);
            journal.Title = edition.Title;
            journal.City = edition.City;
            journal.Date = edition.Date;
            journal.Pages = edition.Pages;

            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Введите название издательства");
                    journal.Publishing = Console.ReadLine();
                }),
            };
            actions.ForEach(SetParameters);

            return journal;
        }

        /// <summary>
        /// Ввод параметров автора
        /// </summary>
        /// <returns>Заполненное описание автора</returns>
        public static Author EnterAuthor()
        {
            var createdAuthors = new Author();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Введите фамилию");
                    createdAuthors.Surname = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите инициалы (напрмер X.X.)");
                    createdAuthors.Initials = Console.ReadLine();
                }),
            };
            actions.ForEach(SetParameters);
            return createdAuthors;
        }

        /// <summary>
        /// Получение набора данных
        /// </summary>
        /// <param name="action">Делегат с введенными параметрами</param>
        private static void SetParameters(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (ArgumentException argumentException)
                {
                    Console.WriteLine($"\n{argumentException.Message}\n");
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine($"\n{formatException.Message}\n");
                }
            }
        }
        #endregion

        #region Methods of getting editions
        private static void GetEdition(IEnumerable<EditionBase> editions)
        {
            try
            {
                foreach (var edition in editions)
                {
                    Console.WriteLine(edition.DescriptionEdition());
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine($"{exception.Message}\n");
            }
        }
        #endregion

        #region Methods of checking
        /// <summary>
        /// Проверка формата индекса
        /// </summary>
        /// <param name="index">индекс</param>
        static void CheckNumber(string index)
        {
            Regex regexName = new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])");
            if (!regexName.IsMatch(index))
            {
                throw new FormatException("Индекс должен иметь" +
                    " буквенный формат");
            }
        }
        #endregion
    }
}