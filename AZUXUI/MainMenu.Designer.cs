namespace AZUXUI
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.Sales = new System.Windows.Forms.TabPage();
            this.ProductTabPage = new System.Windows.Forms.TabPage();
            this.ProductPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ProductsButtonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditProductButton = new System.Windows.Forms.Button();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.NewProductButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ProductDataGridView = new ADGV.AdvancedDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaximumRetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressTabPage = new System.Windows.Forms.TabPage();
            this.ScrapsTabPage = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl.SuspendLayout();
            this.ProductTabPage.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            this.ProductsButtonTableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.MainTabControl.Controls.Add(this.Sales);
            this.MainTabControl.Controls.Add(this.ProductTabPage);
            this.MainTabControl.Controls.Add(this.AddressTabPage);
            this.MainTabControl.Controls.Add(this.ScrapsTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 28);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(5);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1006, 693);
            this.MainTabControl.TabIndex = 0;
            // 
            // Sales
            // 
            this.Sales.BackColor = System.Drawing.Color.White;
            this.Sales.Location = new System.Drawing.Point(38, 4);
            this.Sales.Margin = new System.Windows.Forms.Padding(5);
            this.Sales.Name = "Sales";
            this.Sales.Padding = new System.Windows.Forms.Padding(5);
            this.Sales.Size = new System.Drawing.Size(964, 685);
            this.Sales.TabIndex = 0;
            this.Sales.Text = "Sale";
            // 
            // ProductTabPage
            // 
            this.ProductTabPage.BackColor = System.Drawing.Color.White;
            this.ProductTabPage.Controls.Add(this.ProductPanel);
            this.ProductTabPage.Location = new System.Drawing.Point(38, 4);
            this.ProductTabPage.Margin = new System.Windows.Forms.Padding(5);
            this.ProductTabPage.Name = "ProductTabPage";
            this.ProductTabPage.Padding = new System.Windows.Forms.Padding(5);
            this.ProductTabPage.Size = new System.Drawing.Size(964, 685);
            this.ProductTabPage.TabIndex = 1;
            this.ProductTabPage.Text = "Products";
            // 
            // ProductPanel
            // 
            this.ProductPanel.ColumnCount = 1;
            this.ProductPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProductPanel.Controls.Add(this.ProductsButtonTableLayout, 0, 0);
            this.ProductPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.ProductPanel.Controls.Add(this.ProductDataGridView, 0, 2);
            this.ProductPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.ProductPanel.Location = new System.Drawing.Point(5, 5);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.RowCount = 3;
            this.ProductPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ProductPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ProductPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProductPanel.Size = new System.Drawing.Size(954, 675);
            this.ProductPanel.TabIndex = 0;
            // 
            // ProductsButtonTableLayout
            // 
            this.ProductsButtonTableLayout.ColumnCount = 5;
            this.ProductsButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.ProductsButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.ProductsButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.ProductsButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.ProductsButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProductsButtonTableLayout.Controls.Add(this.DeleteButton, 0, 0);
            this.ProductsButtonTableLayout.Controls.Add(this.EditProductButton, 0, 0);
            this.ProductsButtonTableLayout.Controls.Add(this.DuplicateButton, 2, 0);
            this.ProductsButtonTableLayout.Controls.Add(this.NewProductButton, 0, 0);
            this.ProductsButtonTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsButtonTableLayout.Location = new System.Drawing.Point(3, 3);
            this.ProductsButtonTableLayout.Name = "ProductsButtonTableLayout";
            this.ProductsButtonTableLayout.RowCount = 1;
            this.ProductsButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProductsButtonTableLayout.Size = new System.Drawing.Size(948, 44);
            this.ProductsButtonTableLayout.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(403, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(194, 38);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditProductButton
            // 
            this.EditProductButton.BackColor = System.Drawing.Color.White;
            this.EditProductButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditProductButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditProductButton.FlatAppearance.BorderSize = 0;
            this.EditProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.EditProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.EditProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProductButton.Location = new System.Drawing.Point(203, 3);
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(194, 38);
            this.EditProductButton.TabIndex = 3;
            this.EditProductButton.Text = "Edit Product";
            this.EditProductButton.UseVisualStyleBackColor = false;
            this.EditProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.BackColor = System.Drawing.Color.White;
            this.DuplicateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DuplicateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DuplicateButton.FlatAppearance.BorderSize = 0;
            this.DuplicateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.DuplicateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.DuplicateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DuplicateButton.Location = new System.Drawing.Point(603, 3);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(194, 38);
            this.DuplicateButton.TabIndex = 2;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = false;
            this.DuplicateButton.Click += new System.EventHandler(this.DuplicateButton_Click);
            // 
            // NewProductButton
            // 
            this.NewProductButton.BackColor = System.Drawing.Color.White;
            this.NewProductButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewProductButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NewProductButton.FlatAppearance.BorderSize = 0;
            this.NewProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.NewProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.NewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewProductButton.Location = new System.Drawing.Point(3, 3);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(194, 38);
            this.NewProductButton.TabIndex = 0;
            this.NewProductButton.Text = "New Product";
            this.NewProductButton.UseVisualStyleBackColor = false;
            this.NewProductButton.Click += new System.EventHandler(this.NewProductForm);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ProductNameTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SearchLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(948, 44);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductNameTextBox.Location = new System.Drawing.Point(203, 3);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(742, 38);
            this.ProductNameTextBox.TabIndex = 4;
            this.ProductNameTextBox.TextChanged += new System.EventHandler(this.ProductNameTextBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(101, 8);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(96, 27);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Search";
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AutoGenerateContextFilters = true;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductName,
            this.CategoryName,
            this.DefaultPrice,
            this.MaximumRetailPrice});
            this.ProductDataGridView.DateWithTime = false;
            this.ProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductDataGridView.Location = new System.Drawing.Point(3, 103);
            this.ProductDataGridView.MultiSelect = false;
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.RowHeadersWidth = 51;
            this.ProductDataGridView.RowTemplate.Height = 27;
            this.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGridView.Size = new System.Drawing.Size(948, 569);
            this.ProductDataGridView.TabIndex = 3;
            this.ProductDataGridView.TimeFilter = false;
            this.ProductDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductDataGridView_CellFormatting);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 22;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Id.Width = 69;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 22;
            this.ProductName.Name = "ProductName";
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ProductName.Width = 125;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "Category.CategoryName";
            this.CategoryName.HeaderText = "Category";
            this.CategoryName.MinimumWidth = 22;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CategoryName.Width = 125;
            // 
            // DefaultPrice
            // 
            this.DefaultPrice.DataPropertyName = "DefaultPrice";
            this.DefaultPrice.HeaderText = "Default Price";
            this.DefaultPrice.MinimumWidth = 22;
            this.DefaultPrice.Name = "DefaultPrice";
            this.DefaultPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DefaultPrice.Width = 125;
            // 
            // MaximumRetailPrice
            // 
            this.MaximumRetailPrice.DataPropertyName = "MaximumRetailPrice";
            this.MaximumRetailPrice.HeaderText = "Maximum Retail Price";
            this.MaximumRetailPrice.MinimumWidth = 22;
            this.MaximumRetailPrice.Name = "MaximumRetailPrice";
            this.MaximumRetailPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MaximumRetailPrice.Width = 125;
            // 
            // AddressTabPage
            // 
            this.AddressTabPage.Location = new System.Drawing.Point(38, 4);
            this.AddressTabPage.Name = "AddressTabPage";
            this.AddressTabPage.Size = new System.Drawing.Size(964, 685);
            this.AddressTabPage.TabIndex = 2;
            this.AddressTabPage.Text = "Address";
            this.AddressTabPage.UseVisualStyleBackColor = true;
            // 
            // ScrapsTabPage
            // 
            this.ScrapsTabPage.Location = new System.Drawing.Point(38, 4);
            this.ScrapsTabPage.Name = "ScrapsTabPage";
            this.ScrapsTabPage.Size = new System.Drawing.Size(964, 685);
            this.ScrapsTabPage.TabIndex = 3;
            this.ScrapsTabPage.Text = "Scraps";
            this.ScrapsTabPage.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("SimSun", 16F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainMenu";
            this.Text = "AZUX";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainTabControl.ResumeLayout(false);
            this.ProductTabPage.ResumeLayout(false);
            this.ProductPanel.ResumeLayout(false);
            this.ProductsButtonTableLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage Sales;
        private System.Windows.Forms.TabPage ProductTabPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel ProductPanel;
        private System.Windows.Forms.TableLayoutPanel ProductsButtonTableLayout;
        private System.Windows.Forms.Button NewProductButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button DuplicateButton;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditProductButton;
        private System.Windows.Forms.TabPage AddressTabPage;
        private System.Windows.Forms.TabPage ScrapsTabPage;
        private ADGV.AdvancedDataGridView ProductDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaximumRetailPrice;
    }
}

