using _3_lab;
using System.Windows.Forms;
using System.ComponentModel;
using Library;

namespace View
{
    /// <summary>
    /// Описание вывода данных
    /// </summary>
    public class EditionDataView
    {
        /// <summary>
        /// Создать таблицу
        /// </summary>
        /// <param name="editions">издания</param>
        /// <param name="dataGridView">таблица</param>
        public static void CreateTable(BindingList<IEdition> editions,
            DataGridView dataGridView)
        {
            BindingList<DescriptionItem> editionDescription = new BindingList<DescriptionItem>();
            foreach (var edition in editions)
            {
                var description = new DescriptionItem(edition.DescriptionEdition());
                editionDescription.Add(description);
            }
            dataGridView.DataSource = editionDescription;

            dataGridView.Columns[0].HeaderText = "Описание издания";
            dataGridView.AutoResizeColumns();
            if (dataGridView.Columns[0].Width < 547)
            {
                dataGridView.Columns[0].Width = 547;
            }
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
