using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AZUXlib.DataAccess;
using AZUXlib.Models;


namespace AZUXUI
{
    public partial class MainMenu : Form
    {
        public static MainMenu Instance { get; set; }
        private List<Product> productsList;
        public MainMenu()
        {
            InitializeComponent();
            //get a reference to this form            
            Instance = this;
            UpdateProductDGV();
        }

        private void UpdateProductDGV()
        {
            ProductDataGridView.AutoGenerateColumns = false;
            ProductDataGridView.DataSource = ProductAccess
                .Find(ProductNameTextBox.Text);
        }

        private void NewProductForm(object sender, EventArgs e)
        {
            this.Enabled = false;
            var productform = new ProductForm(ProductForm.State.Create);
            //lock mainform
            this.Enabled = false;
            //set event to unlock mainform when this form is closed
            productform.FormClosing += delegate { this.Enabled = true; UpdateProductDGV(); };            
            productform.Show();
        }

        private void EditProductButton_Click(object sender, EventArgs e)
        {
            if (ProductDataGridView.SelectedRows.Count <= 0) return;
            //Instantiate a new ProductForm
            var productform = new ProductForm(ProductForm.State.Edit);
            //pass a product to the new form
            productform.ModifyingProduct = (Product)ProductDataGridView.SelectedRows[0].DataBoundItem;
            productform.FormClosing += delegate { this.Enabled = true; UpdateProductDGV(); };
            //display the new form
            productform.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var productToBeDeleted = (Product)ProductDataGridView.SelectedRows[0].DataBoundItem;
            ProductAccess.Delete(productToBeDeleted.Id);
            UpdateProductDGV();
        }

        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            //check if no row is selected
            if (ProductDataGridView.SelectedRows.Count <= 0) return;
            //Instantiate a new ProductForm
            var productform = new ProductForm(ProductForm.State.Duplicate);
            //pass a product to the new form
            productform.ModifyingProduct = (Product)ProductDataGridView.SelectedRows[0].DataBoundItem;
            //display the new form
            productform.Show();
        }

        private void ProductDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((ProductDataGridView.Rows[e.RowIndex].DataBoundItem != null) && (ProductDataGridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                e.Value = BindProperty(ProductDataGridView.Rows[e.RowIndex].DataBoundItem, ProductDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }

        /// <summary>
        /// recursive function to resolve nested object in datagridview
        /// </summary>
        /// <param name="property"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private string BindProperty(object property, string propertyName)
        {
            string retValue;

            retValue = "";

            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(propertyInfo.GetValue(property, null), propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                var temp = propertyInfo.GetValue(property, null);
                if (temp != null)
                    retValue = temp.ToString();
            }

            return retValue;
        }

        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProductDGV();
        }

    }
}
