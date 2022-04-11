
namespace DeliveryApp
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Products_Box = new System.Windows.Forms.GroupBox();
            this.Fill_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Products_Table = new System.Windows.Forms.DataGridView();
            this.Dish_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dish_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dish_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Field = new System.Windows.Forms.TextBox();
            this.Quantity_Label = new System.Windows.Forms.Label();
            this.ID_Field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dishesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryDBDataSet1 = new DeliveryApp.DeliveryDBDataSet();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryDBDataSet = new DeliveryApp.DeliveryDBDataSet();
            this.dishesTableAdapter = new DeliveryApp.DeliveryDBDataSetTableAdapters.DishesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Order_Table = new System.Windows.Forms.DataGridView();
            this.Order_Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Remove_Button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Customer = new System.Windows.Forms.GroupBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Customer_Comments = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Customer_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Customer_Number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Customer_Name = new System.Windows.Forms.TextBox();
            this.Customer_Name_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Total_Price = new System.Windows.Forms.Label();
            this.Cusom_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ManagerForm = new System.Windows.Forms.Button();
            this.Products_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Table)).BeginInit();
            this.Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Products_Box
            // 
            this.Products_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Products_Box.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Products_Box.Controls.Add(this.Fill_Button);
            this.Products_Box.Controls.Add(this.Add_Button);
            this.Products_Box.Controls.Add(this.Products_Table);
            this.Products_Box.Controls.Add(this.Quantity_Field);
            this.Products_Box.Controls.Add(this.Quantity_Label);
            this.Products_Box.Controls.Add(this.ID_Field);
            this.Products_Box.Controls.Add(this.label1);
            this.Products_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Products_Box.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Products_Box.Location = new System.Drawing.Point(25, 30);
            this.Products_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Products_Box.Name = "Products_Box";
            this.Products_Box.Padding = new System.Windows.Forms.Padding(2);
            this.Products_Box.Size = new System.Drawing.Size(684, 190);
            this.Products_Box.TabIndex = 0;
            this.Products_Box.TabStop = false;
            this.Products_Box.Text = "Products";
            // 
            // Fill_Button
            // 
            this.Fill_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fill_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fill_Button.Location = new System.Drawing.Point(530, 0);
            this.Fill_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Fill_Button.Name = "Fill_Button";
            this.Fill_Button.Size = new System.Drawing.Size(116, 32);
            this.Fill_Button.TabIndex = 6;
            this.Fill_Button.Text = "Show Dishes";
            this.Fill_Button.UseVisualStyleBackColor = true;
            this.Fill_Button.Click += new System.EventHandler(this.Fill_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.LightCyan;
            this.Add_Button.Location = new System.Drawing.Point(28, 129);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(177, 32);
            this.Add_Button.TabIndex = 5;
            this.Add_Button.Text = "Add To Order";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Products_Table
            // 
            this.Products_Table.AllowUserToAddRows = false;
            this.Products_Table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.Products_Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Products_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Products_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Products_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Products_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dish_Id,
            this.Dish_Name,
            this.Dish_Price});
            this.Products_Table.Location = new System.Drawing.Point(231, 36);
            this.Products_Table.Margin = new System.Windows.Forms.Padding(2);
            this.Products_Table.Name = "Products_Table";
            this.Products_Table.ReadOnly = true;
            this.Products_Table.RowHeadersWidth = 62;
            this.Products_Table.RowTemplate.Height = 28;
            this.Products_Table.Size = new System.Drawing.Size(417, 139);
            this.Products_Table.TabIndex = 4;
            // 
            // Dish_Id
            // 
            this.Dish_Id.HeaderText = "Id";
            this.Dish_Id.MinimumWidth = 8;
            this.Dish_Id.Name = "Dish_Id";
            this.Dish_Id.ReadOnly = true;
            // 
            // Dish_Name
            // 
            this.Dish_Name.HeaderText = "Name";
            this.Dish_Name.MinimumWidth = 8;
            this.Dish_Name.Name = "Dish_Name";
            this.Dish_Name.ReadOnly = true;
            // 
            // Dish_Price
            // 
            this.Dish_Price.HeaderText = "Price";
            this.Dish_Price.MinimumWidth = 8;
            this.Dish_Price.Name = "Dish_Price";
            this.Dish_Price.ReadOnly = true;
            // 
            // Quantity_Field
            // 
            this.Quantity_Field.Location = new System.Drawing.Point(138, 77);
            this.Quantity_Field.Margin = new System.Windows.Forms.Padding(2);
            this.Quantity_Field.Name = "Quantity_Field";
            this.Quantity_Field.Size = new System.Drawing.Size(68, 29);
            this.Quantity_Field.TabIndex = 3;
            // 
            // Quantity_Label
            // 
            this.Quantity_Label.AutoSize = true;
            this.Quantity_Label.Location = new System.Drawing.Point(24, 81);
            this.Quantity_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quantity_Label.Name = "Quantity_Label";
            this.Quantity_Label.Size = new System.Drawing.Size(78, 24);
            this.Quantity_Label.TabIndex = 2;
            this.Quantity_Label.Text = "Quantity";
            // 
            // ID_Field
            // 
            this.ID_Field.Location = new System.Drawing.Point(138, 36);
            this.ID_Field.Margin = new System.Windows.Forms.Padding(2);
            this.ID_Field.Name = "ID_Field";
            this.ID_Field.Size = new System.Drawing.Size(68, 29);
            this.ID_Field.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // dishesBindingSource1
            // 
            this.dishesBindingSource1.DataMember = "Dishes";
            this.dishesBindingSource1.DataSource = this.deliveryDBDataSet1;
            // 
            // deliveryDBDataSet1
            // 
            this.deliveryDBDataSet1.DataSetName = "DeliveryDBDataSet";
            this.deliveryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "Dishes";
            this.dishesBindingSource.DataSource = this.deliveryDBDataSet;
            // 
            // deliveryDBDataSet
            // 
            this.deliveryDBDataSet.DataSetName = "DeliveryDBDataSet";
            this.deliveryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.Order_Table);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(25, 231);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(684, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // Order_Table
            // 
            this.Order_Table.AllowUserToAddRows = false;
            this.Order_Table.AllowUserToDeleteRows = false;
            this.Order_Table.AllowUserToResizeColumns = false;
            this.Order_Table.AllowUserToResizeRows = false;
            this.Order_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Order_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Order_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_Product_ID,
            this.Product_Name_Order,
            this.Quantity_Order,
            this.Product_Price_Order,
            this.Order_Remove_Button});
            this.Order_Table.Location = new System.Drawing.Point(2, 24);
            this.Order_Table.Margin = new System.Windows.Forms.Padding(2);
            this.Order_Table.Name = "Order_Table";
            this.Order_Table.ReadOnly = true;
            this.Order_Table.RowHeadersWidth = 62;
            this.Order_Table.RowTemplate.Height = 28;
            this.Order_Table.Size = new System.Drawing.Size(680, 122);
            this.Order_Table.TabIndex = 0;
            this.Order_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Order_Table_CellClick);
            // 
            // Order_Product_ID
            // 
            this.Order_Product_ID.FillWeight = 37.60341F;
            this.Order_Product_ID.HeaderText = "ID";
            this.Order_Product_ID.MinimumWidth = 8;
            this.Order_Product_ID.Name = "Order_Product_ID";
            this.Order_Product_ID.ReadOnly = true;
            // 
            // Product_Name_Order
            // 
            this.Product_Name_Order.FillWeight = 198.8636F;
            this.Product_Name_Order.HeaderText = "Product Name";
            this.Product_Name_Order.MinimumWidth = 8;
            this.Product_Name_Order.Name = "Product_Name_Order";
            this.Product_Name_Order.ReadOnly = true;
            // 
            // Quantity_Order
            // 
            this.Quantity_Order.FillWeight = 97.76887F;
            this.Quantity_Order.HeaderText = "Quantity";
            this.Quantity_Order.MinimumWidth = 8;
            this.Quantity_Order.Name = "Quantity_Order";
            this.Quantity_Order.ReadOnly = true;
            // 
            // Product_Price_Order
            // 
            this.Product_Price_Order.FillWeight = 97.76887F;
            this.Product_Price_Order.HeaderText = "Price All";
            this.Product_Price_Order.MinimumWidth = 8;
            this.Product_Price_Order.Name = "Product_Price_Order";
            this.Product_Price_Order.ReadOnly = true;
            // 
            // Order_Remove_Button
            // 
            this.Order_Remove_Button.FillWeight = 67.9952F;
            this.Order_Remove_Button.HeaderText = "Remove";
            this.Order_Remove_Button.MinimumWidth = 8;
            this.Order_Remove_Button.Name = "Order_Remove_Button";
            this.Order_Remove_Button.ReadOnly = true;
            this.Order_Remove_Button.Text = "Remove";
            // 
            // Customer
            // 
            this.Customer.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Customer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Customer.Controls.Add(this.Submit_Button);
            this.Customer.Controls.Add(this.Customer_Comments);
            this.Customer.Controls.Add(this.label6);
            this.Customer.Controls.Add(this.Customer_Address);
            this.Customer.Controls.Add(this.label3);
            this.Customer.Controls.Add(this.Customer_Number);
            this.Customer.Controls.Add(this.label2);
            this.Customer.Controls.Add(this.Customer_Name);
            this.Customer.Controls.Add(this.Customer_Name_Label);
            this.Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Customer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Customer.Location = new System.Drawing.Point(25, 417);
            this.Customer.Margin = new System.Windows.Forms.Padding(2);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(2);
            this.Customer.Size = new System.Drawing.Size(684, 189);
            this.Customer.TabIndex = 2;
            this.Customer.TabStop = false;
            this.Customer.Text = "Customer";
            // 
            // Submit_Button
            // 
            this.Submit_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Submit_Button.BackColor = System.Drawing.Color.LightCyan;
            this.Submit_Button.Location = new System.Drawing.Point(298, 148);
            this.Submit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(83, 29);
            this.Submit_Button.TabIndex = 10;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = false;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // Customer_Comments
            // 
            this.Customer_Comments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Customer_Comments.Location = new System.Drawing.Point(127, 112);
            this.Customer_Comments.Margin = new System.Windows.Forms.Padding(2);
            this.Customer_Comments.Name = "Customer_Comments";
            this.Customer_Comments.Size = new System.Drawing.Size(521, 29);
            this.Customer_Comments.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Comments";
            // 
            // Customer_Address
            // 
            this.Customer_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Customer_Address.Location = new System.Drawing.Point(108, 72);
            this.Customer_Address.Margin = new System.Windows.Forms.Padding(2);
            this.Customer_Address.Name = "Customer_Address";
            this.Customer_Address.Size = new System.Drawing.Size(539, 29);
            this.Customer_Address.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // Customer_Number
            // 
            this.Customer_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Customer_Number.Location = new System.Drawing.Point(477, 31);
            this.Customer_Number.Margin = new System.Windows.Forms.Padding(2);
            this.Customer_Number.Name = "Customer_Number";
            this.Customer_Number.Size = new System.Drawing.Size(170, 29);
            this.Customer_Number.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone Number";
            // 
            // Customer_Name
            // 
            this.Customer_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Customer_Name.Location = new System.Drawing.Point(108, 31);
            this.Customer_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Size = new System.Drawing.Size(187, 29);
            this.Customer_Name.TabIndex = 3;
            // 
            // Customer_Name_Label
            // 
            this.Customer_Name_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Customer_Name_Label.AutoSize = true;
            this.Customer_Name_Label.Location = new System.Drawing.Point(22, 33);
            this.Customer_Name_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Customer_Name_Label.Name = "Customer_Name_Label";
            this.Customer_Name_Label.Size = new System.Drawing.Size(61, 24);
            this.Customer_Name_Label.TabIndex = 2;
            this.Customer_Name_Label.Text = "Name";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(26, 387);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Price:";
            // 
            // Total_Price
            // 
            this.Total_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Total_Price.AutoSize = true;
            this.Total_Price.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Total_Price.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Total_Price.Location = new System.Drawing.Point(140, 387);
            this.Total_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.Size = new System.Drawing.Size(20, 24);
            this.Total_Price.TabIndex = 9;
            this.Total_Price.Text = "0";
            // 
            // Cusom_Button
            // 
            this.Cusom_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cusom_Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Cusom_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cusom_Button.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Cusom_Button.Location = new System.Drawing.Point(449, 383);
            this.Cusom_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Cusom_Button.Name = "Cusom_Button";
            this.Cusom_Button.Size = new System.Drawing.Size(128, 30);
            this.Cusom_Button.TabIndex = 11;
            this.Cusom_Button.Text = "Custom Dishes";
            this.Cusom_Button.UseVisualStyleBackColor = false;
            this.Cusom_Button.Click += new System.EventHandler(this.Cusom_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DeliveryApp.Properties.Resources.qHc6bBbGIHc;
            this.pictureBox1.Location = new System.Drawing.Point(-38, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 679);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerForm
            // 
            this.ManagerForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ManagerForm.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ManagerForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManagerForm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ManagerForm.Location = new System.Drawing.Point(581, 383);
            this.ManagerForm.Margin = new System.Windows.Forms.Padding(2);
            this.ManagerForm.Name = "ManagerForm";
            this.ManagerForm.Size = new System.Drawing.Size(128, 30);
            this.ManagerForm.TabIndex = 12;
            this.ManagerForm.Text = "View Orders";
            this.ManagerForm.UseVisualStyleBackColor = false;
            this.ManagerForm.Click += new System.EventHandler(this.ManagerForm_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 614);
            this.Controls.Add(this.ManagerForm);
            this.Controls.Add(this.Cusom_Button);
            this.Controls.Add(this.Total_Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Products_Box);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(745, 653);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.Products_Box.ResumeLayout(false);
            this.Products_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Order_Table)).EndInit();
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Products_Box;
        private System.Windows.Forms.TextBox Quantity_Field;
        private System.Windows.Forms.Label Quantity_Label;
        private System.Windows.Forms.TextBox ID_Field;
        private System.Windows.Forms.Label label1;
        private DeliveryDBDataSet deliveryDBDataSet;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private DeliveryDBDataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
        private DeliveryDBDataSet deliveryDBDataSet1;
        private System.Windows.Forms.BindingSource dishesBindingSource1;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Order_Table;
        private System.Windows.Forms.GroupBox Customer;
        private System.Windows.Forms.TextBox Customer_Name;
        private System.Windows.Forms.Label Customer_Name_Label;
        private System.Windows.Forms.TextBox Customer_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Customer_Number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Total_Price;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.TextBox Customer_Comments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView Products_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price_Order;
        private System.Windows.Forms.DataGridViewButtonColumn Order_Remove_Button;
        private System.Windows.Forms.Button Cusom_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dish_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dish_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dish_Price;
        private System.Windows.Forms.Button Fill_Button;
        private System.Windows.Forms.Button ManagerForm;
    }
}