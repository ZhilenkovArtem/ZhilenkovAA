using _3_lab;
using System;
using System.ComponentModel;
using System.Drawing;
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
            SelectEdition.DropDownStyle = ComboBoxStyle.DropDownList;
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
            EditionDataView.CreateTable(
                _searchedEditions, SearchedEditionGridView);

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
                foreach (var row in _editions)
                {
                    switch (SelectEdition.SelectedIndex)
                    {
                        case 0:
                            {
                                if (row.Title.ToLower()
                                    .Contains(SearchingWordTextBox.Text.ToLower()))
                                {
                                    _searchedEditions.Add(row);
                                }
                                break;
                            }
                        case 1:
                            {
                                if (row.City.ToLower().Contains(
                                SearchingWordTextBox.Text.ToLower()))
                                {
                                    _searchedEditions.Add(row);
                                }
                                break;
                            }
                        case 2:
                            {
                                if (CheckingByNumber(row.Date.Year))
                                {
                                    _searchedEditions.Add(row);
                                }
                                break;
                            }
                        case 3:
                            {
                                if (CheckingByNumber(row.Pages))
                                {
                                    _searchedEditions.Add(row);
                                }
                                break;
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
        /// Проверка строки с числом на соответствие элементу коллекции
        /// </summary>
        /// <param name="parametr">сравниваемый парметр</param>
        /// <returns>метка правильности</returns>
        private bool CheckingByNumber(int parametr)
        {
            bool isRight = false;
            Regex regex = new Regex("[0-9]");
            if (!regex.IsMatch(SearchingWordTextBox.Text))
            {
                SearchingWordLabel.Text =
                    "Вы должны ввести число";
                SearchingWordLabel.ForeColor = Color.Red;
            }
            else
            {
                SearchingWordLabel.Text = "Поле для поиска";
                SearchingWordLabel.ForeColor = Color.Black;

                if (parametr == int.Parse(
                    SearchingWordTextBox.Text))
                {
                    isRight = true;
                }
            }
            return isRight;
        }

        /// <summary>
        /// Событие при выборе поиска издания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchEdition();
            EditionDataView.CreateTable(_searchedEditions, SearchedEditionGridView);
        }

        /// <summary>
        /// События при изменении желаемого типа издания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectEdition_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            SearchingWordLabel.Text = "Слово для поиска";
            SearchingWordLabel.ForeColor = Color.Black;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
