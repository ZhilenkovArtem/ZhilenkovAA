using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using _3_lab;
using System.Text.RegularExpressions;

namespace View
{
    /// <summary>
    /// Форма добавления авторов
    /// </summary>
    public partial class AddingAuthors : UserControl
    {
        /// <summary>
        /// Лист фамилий
        /// </summary>
        List<TextBox> _surnameList = new List<TextBox>();

        /// <summary>
        /// Лист инициалов
        /// </summary>
        List<TextBox> _initialsList = new List<TextBox>();

        /// <summary>
        /// Добавление авторов
        /// </summary>
        public AddingAuthors()
        {
            InitializeComponent();

            _surnameList.AddRange(new TextBox[] 
            {
                SurnameTextBox1,
                SurnameTextBox2,
                SurnameTextBox3,
                SurnameTextBox4
            });

            _initialsList.AddRange(new TextBox[]
            {
                InitialsTextBox1,
                InitialsTextBox2,
                InitialsTextBox3,
                InitialsTextBox4
            });

            for (int i = 1; i < 4; i++)
            {
                _surnameList[i].Visible = false;
                _initialsList[i].Visible = false;
            }
        }

        /// <summary>
        /// События при нажатии кнопки добавления автора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAuthor_Click(object sender, EventArgs e)
        {
            var listVisibleCount = _surnameList.Where(surnameTextBox => surnameTextBox.Visible == true).Count();
            if (listVisibleCount < 4)
            {
                _surnameList[listVisibleCount].Visible = true;
                _initialsList[listVisibleCount].Visible = true;
            }
        }

        /// <summary>
        /// События при нажатии кнопки удаления автора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveAuthor_Click(object sender, EventArgs e)
        {
            var listVisibleCount = _surnameList.Where(surnameTextBox => surnameTextBox.Visible == true).Count();
            if (listVisibleCount > 1)
            {
                _surnameList[listVisibleCount-1].Visible = false;
                _initialsList[listVisibleCount-1].Visible = false;
            }
        }

        /// <summary>
        /// Вернуть список авторов
        /// </summary>
        /// <returns>список авторов</returns>
        public List<Author> SelectAuthors()
        {
            var authors = new List<Author>();
            var listVisibleCount = _surnameList.Where(surnameTextBox => 
            surnameTextBox.Visible == true && surnameTextBox.Enabled == true).Count();

            for (int i = 0; i < listVisibleCount; i++)
            {
                authors.Add(new Author(_surnameList[i].Text, _initialsList[i].Text));
            }
            return authors;
        }

        /// <summary>
        /// Вернуть список textBox-фамилий
        /// </summary>
        public List<TextBox> SelectSurnameList
        {
            get
            {
                return _surnameList;
            }
        }

        /// <summary>
        /// Вернуть список textBox-инициалов
        /// </summary>
        public List<TextBox> SelectInitialsList
        {
            get
            {
                return _initialsList;
            }
        }

        /// <summary>
        /// Вернуть кнопку добавления автора
        /// </summary>
        public Button SelectAddAuthorButton
        {
            get
            {
                return AddAuthor;
            }
        }

        /// <summary>
        /// Вернуть кнопку удаления автора
        /// </summary>
        public Button SelectRemoveAuthorButton
        {
            get
            {
                return RemoveAuthor;
            }
        }

        /// <summary>
        /// Валидация фамилии
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="e"></param>
        public void SurnameTextBoxValidating(object textBox, CancelEventArgs e)
        {
            Regex regex = new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])");

            TextBoxValidating(regex, (TextBox)textBox, $"Значение 'Фамилия' пусто", 
                "Фамилия содержит только буквы", e);
        }

        /// <summary>
        /// Валидация инициалов
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="e"></param>
        public void InitialsTextBoxValidating(object textBox, CancelEventArgs e)
        {
            Regex regex = new Regex("(([А-Я]|[а-я]|[A-Z]|[a-z])[.]){2}");

            TextBoxValidating(regex, (TextBox)textBox, $"Значение 'Инициалы' пусто", 
                "Инициалы имеют формат А.А.", e);
        }

        /// <summary>
        /// Валидация текста в textBox
        /// </summary>
        /// <param name="regex">регулярное выражение</param>
        /// <param name="textBox"></param>
        /// <param name="stringForEmpty">строка для пустого значения</param>
        /// <param name="stringForUncorrect">
        /// строка для неверного значения</param>
        /// <param name="e"></param>
        private void TextBoxValidating(Regex regex, TextBox textBox, 
            string stringForEmpty, string stringForUncorrect, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                SurnameLabel.Text = stringForEmpty;
                SurnameLabel.ForeColor = Color.Red;
                InitialsLabel.Visible = false;
            }
            else if (!regex.IsMatch(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                SurnameLabel.Text = stringForUncorrect;
                SurnameLabel.ForeColor = Color.Red;
                InitialsLabel.Visible = false;
            }
            else
            {
                e.Cancel = false;
                SurnameLabel.Text = "Фамилия";
                SurnameLabel.ForeColor = Color.Black;
                InitialsLabel.Visible = true;
            }
        }
    }
}
