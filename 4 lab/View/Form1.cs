using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3_lab;
using Library;

namespace View
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Коллекция изданий
        /// </summary>
        BindingList<EditionBase> _editions = new BindingList<EditionBase>();

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление издания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEdition_Click(object sender, EventArgs e)
        {
            var addingEditionForm = new AddingEditionForm();

            if (addingEditionForm.ShowDialog() == DialogResult.OK)
            {
                _editions.Add(addingEditionForm.EditionDone);
                EditionDataView.CreateTable(_editions, EditionDescriptionGridView);
            }
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            EditionDataView.CreateTable(_editions, EditionDescriptionGridView);
        }

        /// <summary>
        /// Удаление издания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveEdition_Click(object sender, EventArgs e)
        {
            var linesCount = EditionDescriptionGridView.SelectedRows.Count;

            for (int i = 0; i < linesCount; i++)
            {
                _editions.RemoveAt(EditionDescriptionGridView.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// Поиск издания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Searching_Click(object sender, EventArgs e)
        {
            var searchingForm = new SearchingForm(_editions);
            searchingForm.Show();
        }
    }
}
