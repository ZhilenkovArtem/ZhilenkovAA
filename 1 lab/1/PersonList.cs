using System;
using System.Text.RegularExpressions;

namespace Library
{
    /// <summary>
    /// Класс, описывающий список людей
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Список людей
        /// </summary>
        private Person[] _persons;

        /// <summary>
        /// Задает начальное значение списка людей
        /// </summary>
        public PersonList()
        {
            _persons = new Person[0];
        }

        /// <summary>
        /// Возвращает размер списка людей
        /// </summary>
        public int Length
        {
            get
            {
                return _persons.Length;
            }
        }

        /// <summary>
        /// Возвращает человека из списка по его номеру в этом списке
        /// </summary>
        /// <param name="index">Номер человека в списке людей</param>
        /// <returns>Параметры человека с заданным номером</returns>
        public Person GetPerson(int index)
        {
            CheckIndex(index);
            return _persons[index];
        }

        /// <summary>
        /// Очищение списка
        /// </summary>
        public void Clear()
        {
            _persons = new Person[0];
        }

        /// <summary>
        /// Определение наличия в списке людей
        /// </summary>
        public void CheckLength()
        {
            if (_persons.Length == 0)
            {
                throw new ArgumentException("В списке нет элементов");
            }
        }
        /// <summary>
        /// Определение наличия в списке заданного индекса
        /// </summary>
        /// <param name="indexPerson">Заданный индекс человека</param>
        public void CheckIndex(int indexPerson)
        {
            if (indexPerson < 0 || _persons.Length < indexPerson)
            {
                throw new IndexOutOfRangeException();
            }
        }
        /// <summary>
        /// Добавление человека в список людей
        /// </summary>
        /// <param name="addingPerson">Добавляемый человек</param>
        public void AddPerson(Person addingPerson)
        {
            Person[] copyPersons = _persons;

            _persons = new Person[copyPersons.Length + 1];
            for (int i = 0; i < copyPersons.Length; i++)
            {
                _persons[i] = copyPersons[i];
            }

            _persons[copyPersons.Length] = addingPerson;
        }
        /// <summary>
        /// Нахождение номера удаляемого человека по заданным параметрам
        /// </summary>
        /// <param name="deletedPerson">Удаляемый человек</param>
        public void GetIndexDelete (Person deletedPerson)
        {
            bool indicator = false;

            for (int i = 0; i < _persons.Length; i++)
            {
                if (deletedPerson.Equals(_persons[i]))
                {
                    DeletePersonIndex(i);
                    indicator = true;
                }
            }

            if (indicator != true)
            {
                throw new ArgumentException("Элемент с выбранными " +
                    "параметрами не найден");
            }
        }
        /// <summary>
        /// Возвращает номер из списка человека с заданными параметрами
        /// </summary>
        /// <param name="presentPerson">Заданный человек</param>
        /// <returns>Список номеров</returns>
        public int[] GetIndex(Person presentPerson)
        {
            bool indicator = false;
            
            int[] numbers = new int[0];
            for (int i = 0; i < _persons.Length; i++)
            {
                if (presentPerson.Equals(_persons[i]))
                {
                    int[] copyNumbers = numbers;
                    numbers = new int[copyNumbers.Length+1];
                    for (int j = 0; j < copyNumbers.Length; j++)
                    {
                        numbers[j] = copyNumbers[j];
                    }
                    numbers[copyNumbers.Length] = i + 1;
                    indicator = true;
                }
            }

            if (indicator != true)
            {
                throw new ArgumentException("Элемент с выбранными " +
                    "параметрами не найден");
            }
            return numbers;
        }
        /// <summary>
        /// Проверка правильности введенного числа, чтобы затем
        /// произвести удаление человека по заданному номеру
        /// </summary>
        /// <param name="allegedIndex">Символы, предполагаемые номером</param>
        public void SendDeletePersonIndex(string allegedIndex)
        {
            Regex regexName = new Regex("[0-9]");
            if (!regexName.IsMatch(allegedIndex))
            {
                throw new FormatException("Индекс должен иметь" +
                    " численный формат");
            }
            DeletePersonIndex(int.Parse(allegedIndex) - 1);
        }

        /// <summary>
        /// Удаление человека по его номеру в списке
        /// </summary>
        /// <param name="indexDelete">Номер удаляемого человека</param>
        public void DeletePersonIndex(int indexDelete)
        {
            CheckIndex(indexDelete);
            Person[] copyPersons = _persons;

            _persons = new Person[copyPersons.Length - 1];
            int count = 0;
            for (int i = 0; i < copyPersons.Length; i++)
            {
                if (i != indexDelete)
                {
                    _persons[count] = copyPersons[i];
                    count++;
                }
            }
        }
    }
}
