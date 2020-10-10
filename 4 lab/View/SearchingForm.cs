using _3_lab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace View
{
    /// <summary>
    /// Форма поиска
    /// </summary>
    public partial class SearchingForm : Form
    {
        /// <summary>
        /// Коллекция изданий
        /// </summary>
        private BindingList<EditionBase> _editions;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="editions"></param>
        public SearchingForm(BindingList<EditionBase> editions)
        {
            InitializeComponent();

            _editions = editions;
        }

        /// <summary>
        /// Коллекция искомых изданий
        /// </summary>
        private BindingList<EditionBase> _searchedEditions =
            new BindingList<EditionBase>();

        /// <summary>
        /// События при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchingForm_Load(object sender, EventArgs e)
        {
            EditionDataView.CreateTable(_searchedEditions, EditionDescriptionGridView);

            SelectEdition.SelectedIndex = 0;
        }

        /// <summary>
        /// Поиск издания
        /// </summary>
        private void SearchEdition()
        {
            _searchedEditions.Clear();

            try
            {
                if (SelectEdition.SelectedIndex == 0 ||
                    SelectEdition.SelectedIndex == 1 ||
                    SelectEdition.SelectedIndex == 3 ||
                    SearchingWordTextBox.Text == null)
                {
                    SearchingWordLabel.Text = "Строка пуста";
                    SearchingWordLabel.ForeColor = Color.Red;
                }
                else
                {
                    SearchingWordLabel.Text = "Слово для поиска";
                    SearchingWordLabel.ForeColor = Color.Black;

                    foreach (var row in _editions)
                    {
                        if (SelectEdition.SelectedIndex == 0)
                        {
                            if (row.Title.ToLower().Contains(SearchingWordTextBox.Text.ToLower()))
                            {
                                _searchedEditions.Add(row);
                            }
                        }
                        else if (SelectEdition.SelectedIndex == 1)
                        {
                            if (row.City.ToLower().Contains(SearchingWordTextBox.Text.ToLower()))
                            {
                                _searchedEditions.Add(row);
                            }
                        }
                        else if (SelectEdition.SelectedIndex == 2)
                        {
                            if (row.Date == DatePicker.Value.Date)
                            {
                                _searchedEditions.Add(row);
                            }
                        }
                        else if (SelectEdition.SelectedIndex == 3)
                        {
                            Regex regex = new Regex("[0-9]");
                            if (!regex.IsMatch(SearchingWordTextBox.Text))
                            {
                                SearchingWordLabel.Text = "Вы должны ввести число";
                                SearchingWordLabel.ForeColor = Color.Red;
                            }
                            else
                            {
                                SearchingWordLabel.Text = "Слово для поиска";
                                SearchingWordLabel.ForeColor = Color.Black;

                                if (row.Pages == int.Parse(SearchingWordTextBox.Text))
                                {
                                    _searchedEditions.Add(row);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}");
            }
        }

        /// <summary>
        /// Событие при выборе поиска издания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchEdition();
        }

        /// <summary>
        /// События при изменении желаемого типа издания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectEdition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectEdition.SelectedIndex == 0 ||
                SelectEdition.SelectedIndex == 1 ||
                SelectEdition.SelectedIndex == 3)
            {
                SearchingWordLabel.Text = "Слово для поиска";
                SearchingWordLabel.ForeColor = Color.Black;
                SearchingWordTextBox.Enabled = true;
                DatePicker.Enabled = false;
            }
            else if (SelectEdition.SelectedIndex == 2)
            {
                SearchingWordLabel.Text = "Слово для поиска";
                SearchingWordLabel.ForeColor = Color.Black;
                SearchingWordTextBox.Enabled = false;
                DatePicker.Enabled = true;
            }
        }
    }
}
