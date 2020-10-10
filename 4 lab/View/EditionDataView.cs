using _3_lab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace View
{
    public class EditionDataView
    {
        public static void CreateTable(BindingList<EditionBase> editions,
            DataGridView dataGridView)
        {
            dataGridView.DataSource = editions;

            dataGridView.Columns[0].HeaderText = "Название";
            dataGridView.Columns[1].HeaderText = "Город";
            dataGridView.Columns[2].HeaderText = "Дата";
            dataGridView.Columns[3].HeaderText = "Количество страниц";

            dataGridView.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.Fill;
            
            dataGridView.Columns[0].Width = 290;
            dataGridView.Columns[1].Width = 115;
            
            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
