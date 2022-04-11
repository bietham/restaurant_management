
namespace DeliveryApp
{
    partial class KitchenForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ordered_Table = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assign_Cook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deliveryDBDataSet = new DeliveryApp.DeliveryDBDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new DeliveryApp.DeliveryDBDataSetTableAdapters.OrdersTableAdapter();
            this.orderItemsTableAdapter = new DeliveryApp.DeliveryDBDataSetTableAdapters.OrderItemsTableAdapter();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Dish_Box = new System.Windows.Forms.GroupBox();
            this.Dishes_Table = new System.Windows.Forms.DataGridView();
            this.Dish_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dish_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dish_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredients_Box = new System.Windows.Forms.GroupBox();
            this.Ingredients_Table = new System.Windows.Forms.DataGridView();
            this.Ingredient_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredient_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preparation_Box = new System.Windows.Forms.GroupBox();
            this.Preparation_Table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complete_Order = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fKOrderItemsOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ordered_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.Dish_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dishes_Table)).BeginInit();
            this.Ingredients_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ingredients_Table)).BeginInit();
            this.Preparation_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Preparation_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderItemsOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.Ordered_Table);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(885, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unprepared";
            // 
            // Ordered_Table
            // 
            this.Ordered_Table.AllowUserToAddRows = false;
            this.Ordered_Table.AllowUserToDeleteRows = false;
            this.Ordered_Table.AllowUserToResizeColumns = false;
            this.Ordered_Table.AllowUserToResizeRows = false;
            this.Ordered_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ordered_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Ordered_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ordered_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Order_Time,
            this.Status,
            this.Comments,
            this.Assign_Cook});
            this.Ordered_Table.Location = new System.Drawing.Point(2, 26);
            this.Ordered_Table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ordered_Table.Name = "Ordered_Table";
            this.Ordered_Table.RowHeadersWidth = 62;
            this.Ordered_Table.RowTemplate.Height = 28;
            this.Ordered_Table.Size = new System.Drawing.Size(881, 147);
            this.Ordered_Table.TabIndex = 0;
            this.Ordered_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ordered_Table_CellClick);
            this.Ordered_Table.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ordered_Table_RowEnter);
            // 
            // Id
            // 
            this.Id.FillWeight = 32.1575F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Order_Time
            // 
            this.Order_Time.FillWeight = 139.2517F;
            this.Order_Time.HeaderText = "Order Time";
            this.Order_Time.MinimumWidth = 8;
            this.Order_Time.Name = "Order_Time";
            this.Order_Time.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 107.5289F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Comments
            // 
            this.Comments.FillWeight = 151.8401F;
            this.Comments.HeaderText = "Comments";
            this.Comments.MinimumWidth = 8;
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            // 
            // Assign_Cook
            // 
            this.Assign_Cook.FillWeight = 55.22798F;
            this.Assign_Cook.HeaderText = "Assign";
            this.Assign_Cook.MinimumWidth = 8;
            this.Assign_Cook.Name = "Assign_Cook";
            // 
            // deliveryDBDataSet
            // 
            this.deliveryDBDataSet.DataSetName = "DeliveryDBDataSet";
            this.deliveryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.deliveryDBDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // orderItemsTableAdapter
            // 
            this.orderItemsTableAdapter.ClearBeforeFill = true;
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Refresh_Button.Location = new System.Drawing.Point(427, 8);
            this.Refresh_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(105, 26);
            this.Refresh_Button.TabIndex = 1;
            this.Refresh_Button.Text = "Refresh Page";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Dish_Box
            // 
            this.Dish_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Dish_Box.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Dish_Box.Controls.Add(this.Dishes_Table);
            this.Dish_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dish_Box.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Dish_Box.Location = new System.Drawing.Point(29, 204);
            this.Dish_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dish_Box.Name = "Dish_Box";
            this.Dish_Box.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dish_Box.Size = new System.Drawing.Size(432, 148);
            this.Dish_Box.TabIndex = 2;
            this.Dish_Box.TabStop = false;
            this.Dish_Box.Text = "Dishes";
            // 
            // Dishes_Table
            // 
            this.Dishes_Table.AllowUserToAddRows = false;
            this.Dishes_Table.AllowUserToDeleteRows = false;
            this.Dishes_Table.AllowUserToResizeColumns = false;
            this.Dishes_Table.AllowUserToResizeRows = false;
            this.Dishes_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Dishes_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dishes_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dishes_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dish_Id,
            this.Dish_Name,
            this.Dish_Quantity});
            this.Dishes_Table.Location = new System.Drawing.Point(2, 23);
            this.Dishes_Table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dishes_Table.Name = "Dishes_Table";
            this.Dishes_Table.RowHeadersWidth = 62;
            this.Dishes_Table.RowTemplate.Height = 28;
            this.Dishes_Table.Size = new System.Drawing.Size(428, 123);
            this.Dishes_Table.TabIndex = 0;
            this.Dishes_Table.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dishes_Table_RowEnter);
            // 
            // Dish_Id
            // 
            this.Dish_Id.FillWeight = 37.73169F;
            this.Dish_Id.HeaderText = "Id";
            this.Dish_Id.MinimumWidth = 8;
            this.Dish_Id.Name = "Dish_Id";
            // 
            // Dish_Name
            // 
            this.Dish_Name.FillWeight = 170.4545F;
            this.Dish_Name.HeaderText = "Name";
            this.Dish_Name.MinimumWidth = 8;
            this.Dish_Name.Name = "Dish_Name";
            // 
            // Dish_Quantity
            // 
            this.Dish_Quantity.FillWeight = 91.81377F;
            this.Dish_Quantity.HeaderText = "Quantity";
            this.Dish_Quantity.MinimumWidth = 8;
            this.Dish_Quantity.Name = "Dish_Quantity";
            // 
            // Ingredients_Box
            // 
            this.Ingredients_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ingredients_Box.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Ingredients_Box.Controls.Add(this.Ingredients_Table);
            this.Ingredients_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ingredients_Box.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Ingredients_Box.Location = new System.Drawing.Point(489, 204);
            this.Ingredients_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ingredients_Box.Name = "Ingredients_Box";
            this.Ingredients_Box.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ingredients_Box.Size = new System.Drawing.Size(423, 148);
            this.Ingredients_Box.TabIndex = 3;
            this.Ingredients_Box.TabStop = false;
            this.Ingredients_Box.Text = "Ingredients";
            // 
            // Ingredients_Table
            // 
            this.Ingredients_Table.AllowUserToAddRows = false;
            this.Ingredients_Table.AllowUserToDeleteRows = false;
            this.Ingredients_Table.AllowUserToResizeColumns = false;
            this.Ingredients_Table.AllowUserToResizeRows = false;
            this.Ingredients_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ingredients_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Ingredients_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ingredients_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingredient_id,
            this.Ingredient_Name});
            this.Ingredients_Table.Location = new System.Drawing.Point(2, 23);
            this.Ingredients_Table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ingredients_Table.Name = "Ingredients_Table";
            this.Ingredients_Table.RowHeadersWidth = 62;
            this.Ingredients_Table.RowTemplate.Height = 28;
            this.Ingredients_Table.Size = new System.Drawing.Size(419, 123);
            this.Ingredients_Table.TabIndex = 0;
            // 
            // Ingredient_id
            // 
            this.Ingredient_id.FillWeight = 22.72727F;
            this.Ingredient_id.HeaderText = "Id";
            this.Ingredient_id.MinimumWidth = 8;
            this.Ingredient_id.Name = "Ingredient_id";
            // 
            // Ingredient_Name
            // 
            this.Ingredient_Name.FillWeight = 177.2727F;
            this.Ingredient_Name.HeaderText = "Name";
            this.Ingredient_Name.MinimumWidth = 8;
            this.Ingredient_Name.Name = "Ingredient_Name";
            // 
            // Preparation_Box
            // 
            this.Preparation_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preparation_Box.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Preparation_Box.Controls.Add(this.Preparation_Table);
            this.Preparation_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Preparation_Box.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Preparation_Box.Location = new System.Drawing.Point(29, 365);
            this.Preparation_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Preparation_Box.Name = "Preparation_Box";
            this.Preparation_Box.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Preparation_Box.Size = new System.Drawing.Size(883, 182);
            this.Preparation_Box.TabIndex = 4;
            this.Preparation_Box.TabStop = false;
            this.Preparation_Box.Text = "Preparation";
            // 
            // Preparation_Table
            // 
            this.Preparation_Table.AllowUserToAddRows = false;
            this.Preparation_Table.AllowUserToDeleteRows = false;
            this.Preparation_Table.AllowUserToResizeColumns = false;
            this.Preparation_Table.AllowUserToResizeRows = false;
            this.Preparation_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preparation_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Preparation_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Preparation_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Complete_Order});
            this.Preparation_Table.Location = new System.Drawing.Point(2, 26);
            this.Preparation_Table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Preparation_Table.Name = "Preparation_Table";
            this.Preparation_Table.RowHeadersWidth = 62;
            this.Preparation_Table.RowTemplate.Height = 28;
            this.Preparation_Table.Size = new System.Drawing.Size(879, 154);
            this.Preparation_Table.TabIndex = 1;
            this.Preparation_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Preparation_Table_CellClick);
            this.Preparation_Table.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Preparation_Table_RowEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 43.5023F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 139.5133F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Order Time";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 60.31571F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 210.42F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Complete_Order
            // 
            this.Complete_Order.FillWeight = 77.02686F;
            this.Complete_Order.HeaderText = "Completed";
            this.Complete_Order.MinimumWidth = 8;
            this.Complete_Order.Name = "Complete_Order";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DeliveryApp.Properties.Resources.eYha0LGLUkA;
            this.pictureBox1.Location = new System.Drawing.Point(-17, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1011, 567);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // fKOrderItemsOrdersBindingSource
            // 
            this.fKOrderItemsOrdersBindingSource.DataMember = "FK_OrderItems_Orders";
            this.fKOrderItemsOrdersBindingSource.DataSource = this.ordersBindingSource;
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 554);
            this.Controls.Add(this.Preparation_Box);
            this.Controls.Add(this.Ingredients_Box);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Dish_Box);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(955, 593);
            this.Name = "KitchenForm";
            this.Text = "KitchenForm";
            this.Load += new System.EventHandler(this.KitchenForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ordered_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.Dish_Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dishes_Table)).EndInit();
            this.Ingredients_Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ingredients_Table)).EndInit();
            this.Preparation_Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Preparation_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderItemsOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Ordered_Table;
        private DeliveryDBDataSet deliveryDBDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DeliveryDBDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource fKOrderItemsOrdersBindingSource;
        private DeliveryDBDataSetTableAdapters.OrderItemsTableAdapter orderItemsTableAdapter;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.GroupBox Dish_Box;
        private System.Windows.Forms.DataGridView Dishes_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dish_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dish_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dish_Quantity;
        private System.Windows.Forms.GroupBox Ingredients_Box;
        private System.Windows.Forms.DataGridView Ingredients_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredient_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredient_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewButtonColumn Assign_Cook;
        private System.Windows.Forms.GroupBox Preparation_Box;
        private System.Windows.Forms.DataGridView Preparation_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn Complete_Order;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}