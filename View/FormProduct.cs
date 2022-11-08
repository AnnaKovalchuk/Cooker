using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Поваренок.Classes;
using System.Data.SqlClient;

namespace Поваренок.View
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void ShowProducts(int category)
        {
            string sql = "SELECT * FROM[Product], [Manufacturer] " + "WHERE [Product].ProductManufacturerID = [Manufacturer].ManufacturerID";
            if(category != 0)
            {
                sql += " AND [Product].ProductCategoryID = (category)";
            }
            switch (comboBoxCategory.SelectedIndex)
            {
                case 1: sql += " AND [Product].ProductCategoryID = 1"; break;
                case 2: sql += " AND [Product].ProductCategoryID = 2"; break;
                case 3: sql += " AND [Product].ProductCategoryID = 3"; break;
                case 4: sql += " AND [Product].ProductCategoryID = 4"; break;
            }
            switch (comboBoxSale.SelectedIndex)
            {
                case 1: sql += " AND [Product].ProductDiscountAmount BETWEEN 0 AND 9.99"; break;
                case 2: sql += " AND [Product].ProductDiscountAmount BETWEEN 10 AND 14.99"; break;
                case 3: sql += " AND [Product].ProductDiscountAmount > 14.99"; break;
            }
            if (textBoxSearch.Text != "")
            {
                sql += " AND [Product].ProductName LIKE '%" + textBoxSearch.Text + "%'";
            }
            switch (comboBoxSort.SelectedIndex)
            {
                case 0: sql += " ORDER BY [Product].ProductCost DESC"; break;
                case 1: sql += " ORDER BY [Product].ProductCost ASC"; break;
            }
            SqlCommand command = ClassSqlConnection.connection.CreateCommand();
            command.CommandText = sql;
            SqlDataReader dataReader = command.ExecuteReader();
            dataGridViewProduct.Rows.Clear();
            int index = 0;
            Bitmap bitmap;
            double cost, sale, costSale;
            if(dataReader.HasRows)
            {
                while(dataReader.Read())
                {
                    //Колонка с описанием товара
                    string description = "Наименование товара: " + dataReader["ProductName"] + "\n";
                    description += "Описание товара: " + dataReader["ProductDescription"] + Environment.NewLine;
                    description += "Производитель: " + dataReader["ManufacturerName"] + Environment.NewLine;
                    cost = Convert.ToDouble(dataReader["ProductCost"]);
                    sale = Convert.ToDouble(dataReader["ProductDiscountAmount"]);
                    costSale = cost - sale / 100.00 * cost;
                    description += "Цена: " + cost + Environment.NewLine;
                    description += "Скидка: " + sale + Environment.NewLine;
                    description += "Цена со скидкой: " + costSale + Environment.NewLine;

                    //Работа с фото
                    if (dataReader["ProductPhoto"].ToString() == "")
                    {
                        bitmap = Properties.Resources.no_product;
                        dataGridViewProduct.Rows.Add(null, bitmap, description);
                    }
                    else
                    {
                        dataGridViewProduct.Rows.Add(null, dataReader["ProductPhoto"], description);
                    }

                    dataGridViewProduct.Rows[index].Height = 140;
                    index++;
                }
            }
            dataReader.Close();
            labelCountProduct.Text = "Количество: " + index;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormAuth formAuth = new FormAuth();
            this.Hide();
            formAuth.ShowDialog();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            tableLayoutPanelTop.BackColor = Color.FromArgb(255, 204, 153);
            tableLayoutPanelTop.BackColor = Color.FromArgb(255, 204, 153);
            tableLayoutPanelInfo.BackColor = Color.FromArgb(255, 255, 255);
            tableLayoutPanelParametrs.BackColor = Color.FromArgb(255, 255, 255);
            buttonExit.BackColor = Color.FromArgb(204, 102, 0);

            comboBoxSort.Text = comboBoxSort.Items[0].ToString();
            comboBoxSale.Text = comboBoxSale.Items[0].ToString();

            //Заполнение списка категорий
            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.Add("Все категории");
            SqlCommand command = ClassSqlConnection.connection.CreateCommand();
            command.CommandText = "SELECT * FROM[Category]";
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboBoxCategory.Items.Add(dataReader[1]);
            }
            dataReader.Close();
            comboBoxCategory.Text = comboBoxCategory.Items[0].ToString();
            ShowProducts(0);
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowProducts(0);
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowProducts(0);
        }

        private void comboBoxSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowProducts(0);
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowProducts(0);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowProducts(0);
        }
    }
}
