using System;
using System.Collections.Generic;
using System.Threading;
using Library;

namespace Testing
{
    /// <summary>
    /// Класс для тестирования
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args">Аргументы</param>
        static void Main(string[] args)
        {
            var persons1 = new PersonList();

            while(true)
            {
                Console.WriteLine("***Меню***");
                Console.WriteLine("1 - Запуск 3го задания Лабы (2 списка, " +
                    "копирование...)");
                Console.WriteLine("2 - Добавление рандомного элемента");
                Console.WriteLine("3 - Добавление элемента");
                Console.WriteLine("4 - Вывод данных");
                Console.WriteLine("5 - Удаление элемента по индексу");
                Console.WriteLine("6 - Удаление элемента");
                Console.WriteLine("7 - Поиск элемента по индексу");
                Console.WriteLine("8 - Поиск индекса по элементу");
                Console.WriteLine("9 - Получить количество элементов в " +
                    "списке");
                Console.WriteLine("10 - Очистить список");
                Console.WriteLine("11 - Выход\n");
                Console.Write("Ваш выбор:  ");
                var key = Console.ReadLine();
                Console.WriteLine();
                switch (key)
                {
                    case "1":
                        persons1.Clear();

                        var persons2 = new PersonList();

                        Console.WriteLine("***Создание двух списков, по три " +
                            "элемента в каждом***\n");

                        for (int j = 0; j < 3; j++)
                        {
                            persons1.AddPerson(Person.GetRandomPerson());
                            Thread.Sleep(15);
                            persons2.AddPerson(Person.GetRandomPerson());
                            Thread.Sleep(15);
                        }

                        ShowTwoLists(persons1, persons2);
                        Console.ReadKey();

                        Console.WriteLine("***Добавление нового элемента в 1 " +
                            "список***\n");

                        persons1.AddPerson(Person.GetRandomPerson());

                        ShowList(persons1);
                        Console.ReadKey();

                        Console.WriteLine("***Копирование 2го элемента из " +
                            "1 списока во 2ой список***\n");

                        persons2.AddPerson(persons1.GetPerson(1));

                        ShowTwoLists(persons1, persons2);
                        Console.ReadKey();

                        Console.WriteLine("***Удаление 2го элемента из 1 " +
                            "списка***\n");

                        persons1.DeletePersonIndex(1);

                        ShowTwoLists(persons1, persons2);
                        Console.ReadKey();

                        Console.WriteLine("***Очищение 2го списка " +
                            "элементов***\n");

                        persons2.Clear();

                        ShowTwoLists(persons1, persons2);
                        break;
                    case "2":
                        {
                            string subkey;
                            do
                            {
                                persons1.AddPerson(Person.GetRandomPerson());
                                Console.Write("\nВ список добавлена ");
                                ShowPerson(persons1.Length - 1, persons1);
                                Console.WriteLine("Продолжить?" +
                                    "(Y - для продолжения / N или любая " +
                                    "другая клавиша - для завершения)");
                                subkey = Console.ReadLine();
                            }
                            while ((subkey == "y") || (subkey == "Y"));
                            break;
                        }
                    case "3":
                        {
                            string subkey;
                            do
                            {
                                persons1.AddPerson(EnterPerson());
                                Console.WriteLine("\nПродолжить?" +
                                    "(Y - для продолжения / N или любая " +
                                    "другая клавиша - для завершения)");
                                subkey = Console.ReadLine();
                            }
                            while ((subkey == "y") || (subkey == "Y"));
                        }
                        break;
                    case "4":
                        try
                        {
                            persons1.CheckLength();
                            ShowList(persons1);
                        }
                        catch (Exception exception)
                        {
                            if (exception is ArgumentException
                                || exception is IndexOutOfRangeException)
                            {
                                Console.WriteLine($"{exception.Message}\n");
                            }
                        }
                        break;
                    case "5":
                        try
                        {
                            persons1.CheckLength();
                            Console.WriteLine("Введите индекс элемента, " +
                                "который вы хотели бы удалить:");
                            persons1.SendDeletePersonIndex(Console.ReadLine());
                        }
                        catch (Exception exception)
                        {
                            if (exception is ArgumentException
                                || exception is IndexOutOfRangeException
                                || exception is FormatException)
                            {
                                Console.WriteLine($"{exception.Message}\n");
                            }
                        }
                        break;
                    case "6":
                        try
                        {
                            persons1.CheckLength();
                            persons1.GetIndexDelete(
                                EnterPerson());
                        }
                        catch (Exception exception)
                        {
                            if (exception is ArgumentException
                                || exception is IndexOutOfRangeException)
                            {
                                Console.WriteLine($"{exception.Message}\n");
                            }
                        }
                        break;
                    case "7":
                        try
                        {
                            persons1.CheckLength();
                            Console.WriteLine("Введите индекс элемента, " +
                                "который вы хотели бы найти:");
                            ShowPerson(Int32.Parse(Console.ReadLine()) - 1,
                                persons1);
                        }
                        catch (Exception exception)
                        {
                            if (exception is ArgumentException
                                || exception is IndexOutOfRangeException
                                || exception is FormatException)
                            {
                                Console.WriteLine($"{exception.Message}\n");
                            }
                        }
                    break;
                    case "8":
                        try
                        {
                            persons1.CheckLength();
                            int[] numbers = persons1.GetIndex(
                                EnterPerson());
                            Console.Write("\nНомера человека с такими " +
                                "параметрами в списке: ");
                            for (int i=0; i < numbers.Length; i++)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                            Console.WriteLine(" ");
                        }
                        catch (Exception exception)
                        {
                            if (exception is ArgumentException
                                || exception is IndexOutOfRangeException)
                            {
                                Console.WriteLine($"{exception.Message}\n");
                            }
                        }
                    break;
                    case "9":
                        Console.Write("Количество элементов в списке: ");
                        Console.WriteLine(persons1.Length+"\n");
                    break;
                    case "10":
                    {
                        persons1.Clear();
                        Console.WriteLine("Список очищен\n");
                        break;
                    }
                    case "11":
                        return;
                }
            }
        }

        /// <summary>
        /// Перебор элементов списка
        /// </summary>
        /// <param name="personList">Список людей</param>
        static void ShowList(PersonList personList)
        {
            for (int i = 0; i < personList.Length; i++)
            {
                ShowPerson(i, personList);
            }
        }

        /// <summary>
        /// Вывод человека на экран
        /// </summary>
        /// <param name="index">Номер человека в списке</param>
        /// <param name="choicePerson">Выбранный человек</param>
        static void ShowPerson(int index, PersonList choicePerson)
        {
            Person person = choicePerson.GetPerson(index);

            Console.WriteLine((index + 1) + "-ая персона:");
            Console.WriteLine("Имя: " + person.Name);
            Console.WriteLine("Фамилия: " + person.Surname);
            Console.WriteLine("Возраст: " + person.Age);
            Console.WriteLine($"Пол: {person.Gender}\n");
        }

        /// <summary>
        /// Вывод первого и второго списка людей
        /// </summary>
        /// <param name="personsFirst">Первый список людей</param>
        /// <param name="personsSecond">Второй список людей</param>
        static void ShowTwoLists(PersonList personsFirst, PersonList 
            personsSecond)
        {
            Console.WriteLine("Первый список:\n");
            ShowList(personsFirst);
            Console.WriteLine("Второй список:\n");
            try
            {
                personsSecond.CheckLength();
                ShowList(personsSecond);
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine($"{argumentException.Message}\n");
            }
        }

        /// <summary>
        /// Создание нового человека
        /// </summary>
        /// <returns>Созданный человек</returns>
        public static Person EnterPerson()
        {
            var createdPerson = new Person();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Введите имя");
                    Console.Write(nameof(createdPerson.Name) + ":");
                    createdPerson.Name = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите фамилию");
                    Console.Write(nameof(createdPerson.Surname) + ":");
                    createdPerson.Surname = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите возраст");
                    Console.Write(nameof(createdPerson.Age) + ":");
                    createdPerson.Age = int.Parse(Console.ReadLine());
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите пол");
                    Console.Write(nameof(createdPerson.Gender) +
                        "(M - мужской /F - женский): ");
                    createdPerson.Gender =
                    (GenderType)Enum.Parse(typeof(GenderType),
                    Console.ReadLine().ToUpper());
                }),
            };
            actions.ForEach(SetParametrs);
            return createdPerson;
        }

        /// <summary>
        /// Получение набора данных
        /// </summary>
        /// <param name="action">Делегат с введенными параметрами</param>
        public static void SetParametrs(Action action)
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
    }
}
