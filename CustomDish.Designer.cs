
namespace DeliveryApp
{
    partial class CustomDish
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
            this.Dish_Box = new System.Windows.Forms.GroupBox();
            this.Products_Table = new System.Windows.Forms.DataGridView();
            this.Product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dishes_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Base_Table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove_Button = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Removed_Table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return_Button = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.New_Table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Button = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dish_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Base_Table)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Removed_Table)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.New_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Dish_Box
            // 
            this.Dish_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Dish_Box.Controls.Add(this.Products_Table);
            this.Dish_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dish_Box.Location = new System.Drawing.Point(15, 21);
            this.Dish_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Dish_Box.Name = "Dish_Box";
            this.Dish_Box.Padding = new System.Windows.Forms.Padding(2);
            this.Dish_Box.Size = new System.Drawing.Size(291, 266);
            this.Dish_Box.TabIndex = 0;
            this.Dish_Box.TabStop = false;
            this.Dish_Box.Text = "Dishes";
            // 
            // Products_Table
            // 
            this.Products_Table.AllowUserToAddRows = false;
            this.Products_Table.AllowUserToDeleteRows = false;
            this.Products_Table.AllowUserToResizeColumns = false;
            this.Products_Table.AllowUserToResizeRows = false;
            this.Products_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Products_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Id,
            this.Products_Name});
            this.Products_Table.Location = new System.Drawing.Point(2, 26);
            this.Products_Table.Margin = new System.Windows.Forms.Padding(2);
            this.Products_Table.Name = "Products_Table";
            this.Products_Table.ReadOnly = true;
            this.Products_Table.RowHeadersWidth = 62;
            this.Products_Table.RowTemplate.Height = 28;
            this.Products_Table.Size = new System.Drawing.Size(287, 238);
            this.Products_Table.TabIndex = 0;
            this.Products_Table.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Products_Table_RowEnter);
            // 
            // Product_Id
            // 
            this.Product_Id.FillWeight = 34.09091F;
            this.Product_Id.HeaderText = "Id";
            this.Product_Id.MinimumWidth = 8;
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.ReadOnly = true;
            // 
            // Products_Name
            // 
            this.Products_Name.FillWeight = 165.9091F;
            this.Products_Name.HeaderText = "Name";
            this.Products_Name.MinimumWidth = 8;
            this.Products_Name.Name = "Products_Name";
            this.Products_Name.ReadOnly = true;
            // 
            // Dishes_Button
            // 
            this.Dishes_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dishes_Button.Location = new System.Drawing.Point(225, 14);
            this.Dishes_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Dishes_Button.Name = "Dishes_Button";
            this.Dishes_Button.Size = new System.Drawing.Size(79, 25);
            this.Dishes_Button.TabIndex = 1;
            this.Dishes_Button.Text = "Load";
            this.Dishes_Button.UseVisualStyleBackColor = true;
            this.Dishes_Button.Click += new System.EventHandler(this.Dishes_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Base_Table);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(326, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(368, 264);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base Ingredients";
            // 
            // Base_Table
            // 
            this.Base_Table.AllowUserToAddRows = false;
            this.Base_Table.AllowUserToDeleteRows = false;
            this.Base_Table.AllowUserToResizeColumns = false;
            this.Base_Table.AllowUserToResizeRows = false;
            this.Base_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Base_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Base_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Remove_Button});
            this.Base_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Base_Table.Location = new System.Drawing.Point(2, 24);
            this.Base_Table.Margin = new System.Windows.Forms.Padding(2);
            this.Base_Table.Name = "Base_Table";
            this.Base_Table.ReadOnly = true;
            this.Base_Table.RowHeadersWidth = 62;
            this.Base_Table.RowTemplate.Height = 28;
            this.Base_Table.Size = new System.Drawing.Size(364, 238);
            this.Base_Table.TabIndex = 0;
            this.Base_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Base_Table_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 39.20454F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 162.7185F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Remove_Button
            // 
            this.Remove_Button.FillWeight = 98.07692F;
            this.Remove_Button.HeaderText = "Remove";
            this.Remove_Button.MinimumWidth = 8;
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Removed_Table);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(324, 303);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(368, 244);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Removed Ingredients";
            // 
            // Removed_Table
            // 
            this.Removed_Table.AllowUserToAddRows = false;
            this.Removed_Table.AllowUserToDeleteRows = false;
            this.Removed_Table.AllowUserToResizeColumns = false;
            this.Removed_Table.AllowUserToResizeRows = false;
            this.Removed_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Removed_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Removed_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Return_Button});
            this.Removed_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Removed_Table.Location = new System.Drawing.Point(2, 24);
            this.Removed_Table.Margin = new System.Windows.Forms.Padding(2);
            this.Removed_Table.Name = "Removed_Table";
            this.Removed_Table.ReadOnly = true;
            this.Removed_Table.RowHeadersWidth = 62;
            this.Removed_Table.RowTemplate.Height = 28;
            this.Removed_Table.Size = new System.Drawing.Size(364, 218);
            this.Removed_Table.TabIndex = 0;
            this.Removed_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Removed_Table_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 39.20454F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 162.7185F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Return_Button
            // 
            this.Return_Button.HeaderText = "Return";
            this.Return_Button.MinimumWidth = 8;
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.New_Table);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(15, 303);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(289, 244);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New Ingredients";
            // 
            // New_Table
            // 
            this.New_Table.AllowUserToAddRows = false;
            this.New_Table.AllowUserToDeleteRows = false;
            this.New_Table.AllowUserToResizeColumns = false;
            this.New_Table.AllowUserToResizeRows = false;
            this.New_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.New_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.New_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Add_Button});
            this.New_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.New_Table.Location = new System.Drawing.Point(2, 24);
            this.New_Table.Margin = new System.Windows.Forms.Padding(2);
            this.New_Table.Name = "New_Table";
            this.New_Table.ReadOnly = true;
            this.New_Table.RowHeadersWidth = 62;
            this.New_Table.RowTemplate.Height = 28;
            this.New_Table.Size = new System.Drawing.Size(285, 218);
            this.New_Table.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 64.36665F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 167.5127F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Add_Button
            // 
            this.Add_Button.FillWeight = 68.12065F;
            this.Add_Button.HeaderText = "Add";
            this.Add_Button.MinimumWidth = 8;
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.ReadOnly = true;
            // 
            // CustomDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dishes_Button);
            this.Controls.Add(this.Dish_Box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(732, 597);
            this.MinimumSize = new System.Drawing.Size(732, 597);
            this.Name = "CustomDish";
            this.Text = "CustomDish";
            this.Dish_Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Base_Table)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Removed_Table)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.New_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Dish_Box;
        private System.Windows.Forms.DataGridView Products_Table;
        private System.Windows.Forms.Button Dishes_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Base_Table;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Removed_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remove_Button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView New_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add_Button;
    }
}