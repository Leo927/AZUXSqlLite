using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AZUXlib.Models;

namespace AZUXUI.MainMenu
{
    public static class AddressTabPage
    {
        public static void EditProductButton_Click(this MainMenu mainMenu, object sender, EventArgs e)
        {
            if (mainMenu.ProductDataGridView.SelectedRows.Count <= 0) return;
            //Instantiate a new ProductForm
            var productform = new ProductForm(ProductForm.State.Edit);
            //pass a product to the new form
            productform.ModifyingProduct = (Product)mainMenu.ProductDataGridView.SelectedRows[0].DataBoundItem;
            productform.FormClosing += delegate { mainMenu.Enabled = true; mainMenu.UpdateProductDGV(); };
            //display the new form
            productform.Show();
        }
    }
}
