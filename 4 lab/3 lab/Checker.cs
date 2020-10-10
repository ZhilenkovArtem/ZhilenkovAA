using System;
using System.Text.RegularExpressions;

namespace _3_lab
{
    /// <summary>
    /// Проверщик
    /// </summary>
    public class Checker
    {
        /// <summary>
        /// Валидация для простого текста
        /// </summary>
        /// <param name="text">текст</param>
        public static void ValidationForSimpleText(string text)
        {
            Regex regexName = new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])");

            Validation(text, regexName);
        }

        /// <summary>
        /// Валидация для текста с уникальной проверкой
        /// </summary>
        /// <param name="text">текст</param>
        /// <param name="regexName">регулярное выражение</param>
        public static void Validation(string text, Regex regexName)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException();
            }

            if (!regexName.IsMatch(text))
            {
                throw new FormatException();
            }
        }
    }
}
