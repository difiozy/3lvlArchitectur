﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BL_Interface;
using ProjectEntities;

namespace PL
{
    public partial class FormDateShelfLifeSearch : Form
    {
        private IProductBl _productBl = new Product_BL();
        private List<Product> _allItems;
        public FormDateShelfLifeSearch()
        {
            _allItems = new List<Product>(_productBl.GetAllProduct());
            InitializeComponent();
            RenderDataGridView(DataTable, _allItems);
        }
        private void RenderDataGridView(DataGridView dataTable, List<Product> items)
        {
            dataTable.Rows.Clear();
            foreach (var item in items)
            {
                DataGridViewRow row = (DataGridViewRow)dataTable.Rows[0].Clone();
                row.Cells[0].Value = item.Id;
                row.Cells[1].Value = item.ProductName;
                if (item.DateCome != null)
                    row.Cells[2].Value = ((DateTime)item.DateCome).ToShortDateString();
                if (item.DateOut != null)
                    row.Cells[3].Value = ((DateTime)item.DateOut).ToShortDateString();
                if (item.ShelfLife != null)
                    row.Cells[4].Value = ((DateTime)item.ShelfLife).ToShortDateString();
                if (item.DateUtilization != null)
                    row.Cells[5].Value = ((DateTime)item.DateUtilization).ToShortDateString();
                dataTable.Rows.Add(row);
            }
        }


        private void dateTextBox_Click(object sender, EventArgs e)
        {
            datePicker.Show();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datePicker.Value.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (datePicker.Value.ToShortDateString().Length == 0)
            {
                RenderDataGridView(DataTable, _allItems);
            }
            else
            {
                List<Product> _searchResult = new List<Product>(_productBl.SearchByShelfLife(Convert.ToDateTime(datePicker.Value.ToShortDateString())));
                RenderDataGridView(DataTable, _searchResult);
            }
        }
    }
}
