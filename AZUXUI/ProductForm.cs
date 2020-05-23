using AZUXlib.DataAccess;
using AZUXlib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace AZUXUI
{
    public partial class ProductForm : Form
    {
        /// <summary>
        /// This is the product that populate the form if the form is for edit
        /// </summary>
        public Product ModifyingProduct{ get; set; }

        /// <summary>
        /// a flag that indicate whether the form was created for a new product
        /// or it was used to edit an existing product
        /// </summary>
        public State Status { get; set; }
        public enum State { Create, Edit, Duplicate};
        public ProductForm(State _Status)
        {
            InitializeComponent();
            //
            Status = _Status;
            MaximizeBox = false;

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            //link the category combo box
            CategoryComboBox.DataSource = GenericDataAccess.FindAll<Category>();
            CategoryComboBox.DisplayMember = "CategoryName";
            CategoryComboBox.ValueMember = "Id";


            //take different action based on creating or editing
            switch (Status)
            {
                case State.Create:
                    break;
                case State.Edit:
                case State.Duplicate:
                    ProductNameTextBox.Text = ModifyingProduct.ProductName;
                    CategoryComboBox.SelectedItem = ModifyingProduct.Category;
                    DefaultPriceTextBox.Text = ModifyingProduct.DefaultPrice.ToString();
                    MaximumRetailPriceTextBox.Text = ModifyingProduct.MaximumRetailPrice.ToString();
                    break;
                default:
                    break;
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            switch (Status)
            {
                case State.Create:
                case State.Duplicate:
                    ProductAccess.Insert(ReadProductFromForm());
                    break;
                case State.Edit:
                    //fill the modifying product to a new object
                    var modifyiedProduct = ReadProductFromForm();
                    //assign the new object the collect id
                    modifyiedProduct.Id = ModifyingProduct.Id;
                    Product entry =ProductAccess.Find(ModifyingProduct.Id);
                    ProductAccess.Update(modifyiedProduct.Id, modifyiedProduct);
                    break;
                default:
                    break;
            }
            this.Close();
        }

        private Product ReadProductFromForm()
        {
            Product newProduct = new Product()
            {
                ProductName = ProductNameTextBox.Text,
                CategoryId = ((Category)CategoryComboBox.SelectedItem).Id,
                DefaultPrice = decimal.Parse(DefaultPriceTextBox.Text),
                MaximumRetailPrice = decimal.Parse(MaximumRetailPriceTextBox.Text)
            };
            return newProduct;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            //lock mainform
            this.Enabled = false;
            //set event to unlock mainform when this form is closed
            categoryForm.FormClosing += delegate { this.Enabled = true; };
            categoryForm.FormClosing += delegate { this.CategoryComboBox.DataSource = GenericDataAccess.FindAll<Category>(); };
            categoryForm.Show();
        }

    }
}
