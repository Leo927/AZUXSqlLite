using AZUXlib.DataAccess;
using AZUXlib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            CategoryDataGridView.AutoGenerateColumns = false;
            CategoryDataGridView.DataSource = GenericDataAccess.FindAll<Category>();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CategoryAccess.Insert(CategoryNameTextBox.Text );
            CategoryDataGridView.DataSource = GenericDataAccess.FindAll<Category>();
        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            var categoryToBeDeleted = (Category)CategoryDataGridView.SelectedRows[0].DataBoundItem;
            GenericDataAccess.Delete<Category>(categoryToBeDeleted.Id);
            CategoryDataGridView.DataSource = GenericDataAccess.FindAll<Category>();
        }
    }
}
