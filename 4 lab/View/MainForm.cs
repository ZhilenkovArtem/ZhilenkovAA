using System;
using System.ComponentModel;
using System.Windows.Forms;
using _3_lab;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

            #if !DEBUG
            RandomEditionButton.Visible=false;
            #endif
        }

        /// <summary>
        /// Добавление издания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEdition_Click(object sender, EventArgs e)
        {
            var addingEditionForm = new AddingEditionForm();

            if (addingEditionForm.ShowDialog() != DialogResult.OK) return;

            _editions.Add(addingEditionForm.EditionDone);

            EditionDataView.CreateTable(
                _editions, EditionDescriptionGridView);
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
                _editions.RemoveAt(
                    EditionDescriptionGridView.SelectedRows[0].Index);
            }
            EditionDataView.CreateTable(_editions, EditionDescriptionGridView);
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

        /// <summary>
        /// Добавить рандомное издание
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomEdition_Click(object sender, EventArgs e)
        {
            _editions.Add(RandomEdition.GetRandomEdition());
            EditionDataView.CreateTable(_editions, EditionDescriptionGridView);
        }

        /// <summary>
        /// Сохранение данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveData_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "zhaa files (*.zhaa)|*.zhaa";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

                var binaryFormatter = new BinaryFormatter();
                var filePath = saveFileDialog.FileName;

                using (var fileStream = new FileStream(filePath,
                    FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fileStream, _editions);
                    MessageBox.Show("Файл сохранен!");
                }
            }
        }

        /// <summary>
        /// Загрузка данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "zhaa files (*.zhaa)|*.zhaa";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;

                var binaryFormatter = new BinaryFormatter();
                var filePath = openFileDialog.FileName;

                try
                {
                    using (var fileStream = new FileStream(filePath,
                        FileMode.OpenOrCreate))
                    {
                        var newEditions = (BindingList<EditionBase>)binaryFormatter.
                            Deserialize(fileStream);

                        foreach (var edition in newEditions)
                        {
                            _editions.Add(edition);
                        }
                    }
                    EditionDataView.CreateTable(_editions, EditionDescriptionGridView);
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить файл");
                }
            }
        }

        /// <summary>
        /// Закрыть форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
