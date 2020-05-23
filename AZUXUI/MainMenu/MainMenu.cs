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

        




    }
}
