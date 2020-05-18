using System;
using System.Threading;
using Library;

namespace Testing
{
    /// <summary>
    /// Класс для тестирования
    /// </summary>
    public class Test
    {
        public static PersonList persons1 = new PersonList();
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args">Аргументы</param>
        static void Main(string[] args)
        {
            var people = new PersonList();

            for (int j = 0; j < 7; j++)
            {
                people.AddPerson(PersonBase.CreateRandomPerson());
                Thread.Sleep(15);
            }

            ShowList(people);

            Console.WriteLine("Определение типа 4-го элемента и выполнение " +
                "какого-нибудь метода:\n");

            FourthPerson(people);

            Console.ReadKey();
        }

        /// <summary>
        /// Перебор элементов списка
        /// </summary>
        /// <param name="personList">Список людей</param>
        static void ShowList(PersonList personList)
        {
            for (int i = 0; i < personList.Length; i++)
            {
                Console.WriteLine($"{i+1}-й:");
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
            var person = choicePerson.GetPerson(index);

            Console.WriteLine(person.DescriptionPerson());
        }

        /// <summary>
        /// Демонстрация корректности определения типа 4 человека
        /// </summary>
        /// <param name="personList">список людей</param>
        static void FourthPerson(PersonList personList)
        {
            var fourthPerson = personList.GetPerson(3);
            
            Console.WriteLine(fourthPerson.IAm());
        }
    }
}
