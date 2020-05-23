namespace Test
{
    partial class CategoryForm
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
            this.DeleteButton = new System.Windows.Forms.TableLayoutPanel();
            this.CategoryDataGridView = new ADGV.AdvancedDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteCategoryButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DeleteButton.ColumnCount = 1;
            this.DeleteButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DeleteButton.Controls.Add(this.CategoryDataGridView, 0, 1);
            this.DeleteButton.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(0, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.RowCount = 2;
            this.DeleteButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.DeleteButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DeleteButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DeleteButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DeleteButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DeleteButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DeleteButton.Size = new System.Drawing.Size(579, 423);
            this.DeleteButton.TabIndex = 1;
            // 
            // CategoryDataGridView
            // 
            this.CategoryDataGridView.AutoGenerateContextFilters = true;
            this.CategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CategoryName});
            this.CategoryDataGridView.DateWithTime = false;
            this.CategoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryDataGridView.Location = new System.Drawing.Point(4, 55);
            this.CategoryDataGridView.MultiSelect = false;
            this.CategoryDataGridView.Name = "CategoryDataGridView";
            this.CategoryDataGridView.RowHeadersWidth = 51;
            this.CategoryDataGridView.RowTemplate.Height = 27;
            this.CategoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryDataGridView.Size = new System.Drawing.Size(571, 364);
            this.CategoryDataGridView.TabIndex = 4;
            this.CategoryDataGridView.TimeFilter = false;
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
            this.Id.Width = 52;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.MinimumWidth = 22;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CategoryName.Width = 125;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.58612F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.70694F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.70694F));
            this.tableLayoutPanel2.Controls.Add(this.CategoryNameTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DeleteCategoryButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(571, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryNameTextBox.Location = new System.Drawing.Point(3, 3);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(271, 25);
            this.CategoryNameTextBox.TabIndex = 7;
            // 
            // DeleteCategoryButton
            // 
            this.DeleteCategoryButton.BackColor = System.Drawing.Color.White;
            this.DeleteCategoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteCategoryButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteCategoryButton.FlatAppearance.BorderSize = 0;
            this.DeleteCategoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.DeleteCategoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.DeleteCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCategoryButton.Location = new System.Drawing.Point(426, 3);
            this.DeleteCategoryButton.Name = "DeleteCategoryButton";
            this.DeleteCategoryButton.Size = new System.Drawing.Size(142, 38);
            this.DeleteCategoryButton.TabIndex = 5;
            this.DeleteCategoryButton.Text = "Delete";
            this.DeleteCategoryButton.UseVisualStyleBackColor = false;
            this.DeleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(280, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(140, 38);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 423);
            this.Controls.Add(this.DeleteButton);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.DeleteButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DeleteButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.Button DeleteCategoryButton;
        private System.Windows.Forms.Button AddButton;
        private ADGV.AdvancedDataGridView CategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
    }
}