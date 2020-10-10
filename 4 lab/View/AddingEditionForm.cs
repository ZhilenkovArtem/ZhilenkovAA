using _3_lab;
using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Форма добавления издания
    /// </summary>
    public partial class AddingEditionForm : Form
    {
        /// <summary>
        /// Издание
        /// </summary>
        private EditionBase _edition;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public AddingEditionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вернуть издание
        /// </summary>
        public EditionBase EditionDone
        {
            get
            {
                return _edition;
            }
        }

        /// <summary>
        /// События при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddingEditionForm_Load(object sender, EventArgs e)
        {
            SelectEdition.SelectedIndex = 0;
            UniversityTextBox.Enabled = false;
            SpecialityCodeTextBox.Enabled = false;
            SpecialityTextBox.Enabled = false;
            _edition = new Book();
        }

        /// <summary>
        /// Лист фамилий
        /// </summary>
        List<TextBox> _surnameList = new List<TextBox>();

        /// <summary>
        /// Лист инициалов
        /// </summary>
        List<TextBox> _initialsList = new List<TextBox>();

        /// <summary>
        /// Добавить еще одного автора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAuthor_Click(object sender, EventArgs e)
        {
            TextBox surnameText = new TextBox();
            surnameText.Location = new Point(19, 395 + _surnameList.Count * 24);
            surnameText.Name = "SurnameTextBox" + (_surnameList.Count+1).ToString();
            surnameText.Size = new Size(92, 22);
            surnameText.TabIndex = _surnameList.Count;
            _surnameList.Add(surnameText);
            Controls.Add(_surnameList[_surnameList.Count - 1]);

            TextBox initialsText = new TextBox();
            initialsText.Location = new Point(122, 395 + _initialsList.Count * 24);
            initialsText.Name = "InitialsTextBox" + (_initialsList.Count + 1).ToString();
            initialsText.Size = new Size(44, 22);
            initialsText.TabIndex = _initialsList.Count;
            _initialsList.Add(initialsText);
            Controls.Add(_initialsList[_initialsList.Count - 1]);

            AddAuthor.Location = new Point(AddAuthor.Location.X, AddAuthor.Location.Y + 24);
            RemoveAuthor.Location = new Point(RemoveAuthor.Location.X, RemoveAuthor.Location.Y + 24);
            Consent.Location = new Point(Consent.Location.X, Consent.Location.Y + 24);
            Renouncement.Location = new Point(Renouncement.Location.X, Renouncement.Location.Y + 24);
            Size = new Size(Size.Width, Size.Height + 24);
        }

        /// <summary>
        /// Удалить автора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveAuthor_Click(object sender, EventArgs e)
        {
            _surnameList.RemoveAt(_surnameList.Count - 1);
            _initialsList.RemoveAt(_initialsList.Count - 1);

            Controls.Remove(Controls[Controls.Count - 1]);
            Controls.Remove(Controls[Controls.Count - 1]);

            AddAuthor.Location = new Point(AddAuthor.Location.X, AddAuthor.Location.Y - 24);
            RemoveAuthor.Location = new Point(RemoveAuthor.Location.X, RemoveAuthor.Location.Y - 24);
            Consent.Location = new Point(Consent.Location.X, Consent.Location.Y - 24);
            Renouncement.Location = new Point(Renouncement.Location.X, Renouncement.Location.Y - 24);
            Size = new Size(Size.Width, Size.Height - 24);
        }

        /// <summary>
        /// Флажок корректности введенных данных
        /// </summary>
        private bool _isCorrect;

        /// <summary>
        /// Вставить данные
        /// </summary>
        private void InsertData()
        {
            _isCorrect = false;

            try
            {
                _edition.Title = TitleTextBox.Text;

                _edition.City = CityTextBox.Text;

                _edition.Date = DatePicker.Value.Date;

                _edition.Pages = int.Parse(PagesTextBox.Text);

                if (_edition is Book book)
                {
                    book.Publishing = PublishingTextBox.Text;

                    var authors = new List<Author>();

                    authors.Add(new Author(SurnameTextBox.Text, InitialsTextBox.Text));
                    
                    for (int i = 0; i < _surnameList.Count; i++)
                    {
                        authors.Add(new Author(_surnameList[i].Text, _initialsList[i].Text));
                    }

                    book.Authors = authors;
                }
                else if (_edition is CollectedPaper paper)
                {
                    paper.Publishing = PublishingTextBox.Text;

                    paper.University = UniversityTextBox.Text;
                }
                else if (_edition is Dissertation dissertation)
                {
                    dissertation.University = UniversityTextBox.Text;

                    dissertation.SpecialityCode = SpecialityCodeTextBox.Text;

                    dissertation.Speciality = SpecialityTextBox.Text;

                    var authors = new List<Author>();

                    authors.Add(new Author(SurnameTextBox.Text, InitialsTextBox.Text));

                    dissertation.Authors = authors;
                }
                else if (_edition is Journal journal)
                {
                    journal.Publishing = PublishingTextBox.Text;
                }

                _isCorrect = true;
            }
            catch (Exception exception)
            {
                _isCorrect = false;

                MessageBox.Show($"{exception.Message}");
            }
        }

        /// <summary>
        /// Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Renouncement_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// События при изменении желаемого для ввода издания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectEdition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectEdition.SelectedIndex == 0)
            {
                PublishingTextBox.Enabled = true;
                UniversityTextBox.Enabled = false;
                SpecialityCodeTextBox.Enabled = false;
                SpecialityTextBox.Enabled = false;
                SurnameTextBox.Enabled = true;
                InitialsTextBox.Enabled = true;
                AddAuthor.Enabled = true;
                RemoveAuthor.Enabled = true;
                for (int i = 0; i < _surnameList.Count; i++)
                {
                    (Controls[$"SurnameTextBox{(i + 1)}"] as TextBox).Enabled = true;
                    (Controls[$"InitialsTextBox{(i + 1)}"] as TextBox).Enabled = true;
                }

                _edition = new Book();
            }
            else if (SelectEdition.SelectedIndex == 1)
            {
                PublishingTextBox.Enabled = true;
                UniversityTextBox.Enabled = true;
                SpecialityCodeTextBox.Enabled = false;
                SpecialityTextBox.Enabled = false;
                SurnameTextBox.Enabled = false;
                InitialsTextBox.Enabled = false;
                AddAuthor.Enabled = false;
                RemoveAuthor.Enabled = false;
                for (int i = 0; i < _surnameList.Count; i++)
                {
                    (Controls[$"SurnameTextBox{(i + 1)}"] as TextBox).Enabled = false;
                    (Controls[$"InitialsTextBox{(i + 1)}"] as TextBox).Enabled = false;
                }

                _edition = new CollectedPaper();
            }
            else if (SelectEdition.SelectedIndex == 2)
            {
                PublishingTextBox.Enabled = false;
                UniversityTextBox.Enabled = true;
                SpecialityCodeTextBox.Enabled = true;
                SpecialityTextBox.Enabled = true;
                SurnameTextBox.Enabled = true;
                InitialsTextBox.Enabled = true;
                AddAuthor.Enabled = false;
                RemoveAuthor.Enabled = false;
                for (int i = 0; i < _surnameList.Count; i++)
                {
                    (Controls[$"SurnameTextBox{(i + 1)}"] as TextBox).Enabled = false;
                    (Controls[$"InitialsTextBox{(i + 1)}"] as TextBox).Enabled = false;
                }

                _edition = new Dissertation();
            }
            else if (SelectEdition.SelectedIndex == 3)
            {
                PublishingTextBox.Enabled = true;
                UniversityTextBox.Enabled = false;
                SpecialityCodeTextBox.Enabled = false;
                SpecialityTextBox.Enabled = false;
                SurnameTextBox.Enabled = false;
                InitialsTextBox.Enabled = false;
                AddAuthor.Enabled = false;
                RemoveAuthor.Enabled = false;
                for (int i = 0; i < _surnameList.Count; i++)
                {
                    (Controls[$"SurnameTextBox{(i + 1)}"] as TextBox).Enabled = false;
                    (Controls[$"InitialsTextBox{(i + 1)}"] as TextBox).Enabled = false;
                }

                _edition = new Journal();
            }
        }

        /// <summary>
        /// Согласие ввода данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Consent_Click(object sender, EventArgs e)
        {
            InsertData();

            if (_isCorrect)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// Валидация названия издания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])");
            var invalidText = "Название содержит только буквы";
            var validText = "Название";

            Validation(regex, TitleTextBox, TitleLabel, validText, invalidText, e);
        }

        /// <summary>
        /// Валидация
        /// </summary>
        /// <param name="regex">регулярное выражение</param>
        /// <param name="textBox">текстовый бокс</param>
        /// <param name="label">описательная строка</param>
        /// <param name="textValid">текст для правильного ввода</param>
        /// <param name="textInvalid">текст для неправильного ввода</param>
        /// <param name="e"></param>
        private void Validation(Regex regex, TextBox textBox, Label label, string textValid, string textInvalid, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                label.Text = $"Значение '{textValid}' пусто";
                label.ForeColor = Color.Red;
            }
            else if (!regex.IsMatch(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                label.Text = textInvalid;
                label.ForeColor = Color.Red;
            }
            else
            {
                e.Cancel = false;
                label.Text = textValid;
                label.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Валидация города
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CityTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])");
            var invalidText = "Город содержит только буквы";
            var validText = "Город";

            Validation(regex, CityTextBox, CityLabel, validText, invalidText, e);
        }

        /// <summary>
        /// Валидация для страниц
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PagesTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            var invalidText = "Страницы должны быть числами";
            var validText = "Количество страниц";

            Validation(regex, PagesTextBox, PagesLabel, validText, invalidText, e);
        }

        /// <summary>
        /// Валидация издательства
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PublishingTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])");
            var invalidText = "Издат-во содержит только буквы";
            var validText = "Издательство";

            Validation(regex, PublishingTextBox, Publishing, validText, invalidText, e);
        }

        /// <summary>
        /// Валидация для университета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UniversityTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])");
            var invalidText = "Универ-т содержит только буквы";
            var validText = "Университет";

            Validation(regex, UniversityTextBox, UniversityLabel, validText, invalidText, e);
        }

        /// <summary>
        /// Валидация кода специальности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpecialityCodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("(([0-9]{2})[.]){2}[0-9]{2}");
            var invalidText = "Код имеет формат 11.11.11";
            var validText = "Код специальности";

            Validation(regex, SpecialityCodeTextBox, SpecialityCodeLabel, validText, invalidText, e);
        }

        /// <summary>
        /// Валидация специальности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpecialityTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])");
            var invalidText = "Спец-ть содержит только буквы";
            var validText = "Специальность";

            Validation(regex, SpecialityTextBox, SpecialityLabel, validText, invalidText, e);
        }

        /// <summary>
        /// Валидация фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SurnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])");

            if (string.IsNullOrEmpty(SurnameTextBox.Text))
            {
                e.Cancel = true;
                SurnameTextBox.Focus();
                SurnameLabel.Text = $"Значение 'Фамилия' пусто";
                SurnameLabel.ForeColor = Color.Red;
                InitialsLabel.Visible = false;
            }
            else if (!regex.IsMatch(SurnameTextBox.Text))
            {
                e.Cancel = true;
                SurnameTextBox.Focus();
                SurnameLabel.Text = "Фамилия содержит только буквы";
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

        /// <summary>
        /// Валидация инициалов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitialsTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("(([А-Я]|[а-я]|[A-Z]|[a-z])[.]){2}");

            if (string.IsNullOrEmpty(InitialsTextBox.Text))
            {
                e.Cancel = true;
                InitialsTextBox.Focus();
                SurnameLabel.Text = $"Значение 'Инициалы' пусто";
                SurnameLabel.ForeColor = Color.Red;
                InitialsLabel.Visible = false;
            }
            else if (!regex.IsMatch(InitialsTextBox.Text))
            {
                e.Cancel = true;
                InitialsTextBox.Focus();
                SurnameLabel.Text = "Инициалы имеют формат А.А.";
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
