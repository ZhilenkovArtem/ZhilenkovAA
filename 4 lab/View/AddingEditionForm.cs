using _3_lab;
using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
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
        /// Словарь
        /// </summary>
        /// <returns>словарь</returns>
        private Dictionary<TextBox, Tuple<string, string, Regex, Label>> GetDictionary()
        {
            return new Dictionary<TextBox, Tuple<string, string, Regex, Label>>()
            {
                {
                    TitleTextBox,
                    new Tuple<string, string, Regex, Label>(
                        "Название содержит только буквы",
                        "Название",
                        new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])"),
                        TitleLabel)
                },
                {
                    CityTextBox,
                    new Tuple<string, string, Regex, Label>(
                        "Город содержит только буквы",
                        "Город",
                        new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])"),
                        CityLabel)
                },
                {
                    SpecialityCodeTextBox,
                    new Tuple<string, string, Regex, Label>(
                        "Код имеет формат 11.11.11",
                        "Код специальности",
                        new Regex("(([0-9]{2})[.]){2}[0-9]{2}"),
                        SpecialityCodeLabel)
                },
                {
                    SpecialityTextBox,
                    new Tuple<string, string, Regex, Label>(
                        "Спец-ть содержит только буквы",
                        "Специальность",
                        new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])"),
                        SpecialityLabel)
                },
                {
                    UniversityTextBox,
                    new Tuple<string, string, Regex, Label>(
                        "Универ-т содержит только буквы",
                        "Университет",
                        new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])"),
                        UniversityLabel)
                },
                {
                    PagesTextBox,
                    new Tuple<string, string, Regex, Label>(
                        "Страницы должны быть числами",
                        "Количество страниц",
                        new Regex("[0-9]"),
                        PagesLabel)
                },
                {
                    PublishingTextBox,
                    new Tuple<string, string, Regex, Label>(
                        "Издат-во содержит только буквы",
                        "Издательство",
                        new Regex("([А-Я]|[а-я]|[A-Z]|[a-z])"),
                        Publishing)
                }
            };
        }

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public AddingEditionForm()
        {
            InitializeComponent();

            SelectEdition.DropDownStyle = ComboBoxStyle.DropDownList;
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
                    book.Authors = addingAuthors1.SelectAuthors();
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
                    var authors = new List<Author>(addingAuthors1.SelectAuthors());
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
            switch (SelectEdition.SelectedIndex)
            {
                case 0:
                    DoVisibleField(true, false, false, false, true, true,
                    true, true, true, true);
                    _edition = new Book();
                break;
                case 1:
                    DoVisibleField(true, true, false, false, false, false,
                    false, false, false, false);
                    _edition = new CollectedPaper();
                break;
                case 2:
                    DoVisibleField(false, true, true, true, false, false,
                    true, true, false, false);
                    _edition = new Dissertation();
                break;
                case 3:
                    DoVisibleField(true, false, false, false, false, false,
                    false, false, false, false);
                    _edition = new Journal();
                break;
            }
        }

        /// <summary>
        /// Сделать видимыми/невидимыми поля
        /// </summary>
        /// <param name="publishingFlag">флажок для издательства</param>
        /// <param name="universityFlag">флажок для университета</param>
        /// <param name="specialityCodeFlag">флажок для кода</param>
        /// <param name="specialityFlag">флажок для специальности</param>
        /// <param name="addButtonFlag">флажок для кнопки добавления</param>
        /// <param name="removeButtonFlag">флажок для кнопки удаления</param>
        /// <param name="surnameFlag">флажок для первой фамилии</param>
        /// <param name="initialsFlag">флажок для первых инициалов</param>
        /// <param name="surnameListFlag">флажок для остальных фамилий</param>
        /// <param name="initialsListFlag">флажок для остальных инициалов</param>
        private void DoVisibleField(bool publishingFlag, bool universityFlag,
            bool specialityCodeFlag, bool specialityFlag, bool addButtonFlag,
            bool removeButtonFlag, bool surnameFlag, bool initialsFlag,
            bool surnameListFlag, bool initialsListFlag)
        {
            PublishingTextBox.Enabled = publishingFlag;
            UniversityTextBox.Enabled = universityFlag;
            SpecialityCodeTextBox.Enabled = specialityCodeFlag;
            SpecialityTextBox.Enabled = specialityFlag;
            addingAuthors1.SelectAddAuthorButton.Enabled = addButtonFlag;
            addingAuthors1.SelectRemoveAuthorButton.Enabled = 
                removeButtonFlag;
            var listVisibleCount = addingAuthors1.SelectSurnameList.Where(
                surnameTextBox => surnameTextBox.Visible == true).Count();
            addingAuthors1.SelectSurnameList[0].Enabled = surnameFlag;
            addingAuthors1.SelectInitialsList[0].Enabled = initialsFlag;
            if (listVisibleCount > 1)
            {
                for (int i = 1; i < listVisibleCount; i++)
                {
                    addingAuthors1.SelectSurnameList[i].Enabled = 
                        surnameListFlag;
                    addingAuthors1.SelectInitialsList[i].Enabled = 
                        initialsListFlag;
                }
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
        /// Валидация textBox'ов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Validation(object sender, CancelEventArgs e)
        {
            var textBox = (TextBox)sender;
            var tuple = GetDictionary()[textBox];

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                tuple.Item4.Text = $"Значение '{tuple.Item2}' пусто";
                tuple.Item4.ForeColor = Color.Red;
            }
            else if (!tuple.Item3.IsMatch(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                tuple.Item4.Text = tuple.Item1;
                tuple.Item4.ForeColor = Color.Red;
            }
            else
            {
                e.Cancel = false;
                tuple.Item4.Text = tuple.Item1;
                tuple.Item4.ForeColor = Color.Black;
            }
        }
    }
}
