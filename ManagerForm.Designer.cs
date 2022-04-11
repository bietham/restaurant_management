
namespace DeliveryApp
{
    partial class ManagerForm
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
            this.dishesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryDBDataSet1 = new DeliveryApp.DeliveryDBDataSet();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryDBDataSet = new DeliveryApp.DeliveryDBDataSet();
            this.dishesTableAdapter = new DeliveryApp.DeliveryDBDataSetTableAdapters.DishesTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Products_Table = new System.Windows.Forms.DataGridView();
            this.Dish_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dish_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fill_Button = new System.Windows.Forms.Button();
            this.Products_Box = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).BeginInit();
            this.Products_Box.SuspendLayout();
            this.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DeliveryApp.Properties.Resources.qHc6bBbGIHc;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Products_Table
            // 
            this.Products_Table.AllowUserToAddRows = false;
            this.Products_Table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.Products_Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Products_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Products_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Products_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Products_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dish_Id,
            this.Dish_Name,
            this.Order_Phone,
            this.Order_Address,
            this.Order_Status});
            this.Products_Table.Location = new System.Drawing.Point(17, 36);
            this.Products_Table.Margin = new System.Windows.Forms.Padding(2);
            this.Products_Table.Name = "Products_Table";
            this.Products_Table.ReadOnly = true;
            this.Products_Table.RowHeadersWidth = 62;
            this.Products_Table.RowTemplate.Height = 28;
            this.Products_Table.Size = new System.Drawing.Size(646, 435);
            this.Products_Table.TabIndex = 4;
            // 
            // Dish_Id
            // 
            this.Dish_Id.FillWeight = 32.99492F;
            this.Dish_Id.HeaderText = "Id";
            this.Dish_Id.MinimumWidth = 8;
            this.Dish_Id.Name = "Dish_Id";
            this.Dish_Id.ReadOnly = true;
            // 
            // Dish_Name
            // 
            this.Dish_Name.FillWeight = 116.7513F;
            this.Dish_Name.HeaderText = "Name";
            this.Dish_Name.MinimumWidth = 8;
            this.Dish_Name.Name = "Dish_Name";
            this.Dish_Name.ReadOnly = true;
            // 
            // Order_Phone
            // 
            this.Order_Phone.FillWeight = 116.7513F;
            this.Order_Phone.HeaderText = "Phone";
            this.Order_Phone.Name = "Order_Phone";
            this.Order_Phone.ReadOnly = true;
            // 
            // Order_Address
            // 
            this.Order_Address.FillWeight = 116.7513F;
            this.Order_Address.HeaderText = "Address";
            this.Order_Address.Name = "Order_Address";
            this.Order_Address.ReadOnly = true;
            // 
            // Order_Status
            // 
            this.Order_Status.FillWeight = 116.7513F;
            this.Order_Status.HeaderText = "Status";
            this.Order_Status.Name = "Order_Status";
            this.Order_Status.ReadOnly = true;
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
            this.Fill_Button.Text = "Show Orders";
            this.Fill_Button.UseVisualStyleBackColor = true;
            this.Fill_Button.Click += new System.EventHandler(this.Fill_Button_Click);
            // 
            // Products_Box
            // 
            this.Products_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Products_Box.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Products_Box.Controls.Add(this.Fill_Button);
            this.Products_Box.Controls.Add(this.Products_Table);
            this.Products_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Products_Box.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Products_Box.Location = new System.Drawing.Point(25, 20);
            this.Products_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Products_Box.Name = "Products_Box";
            this.Products_Box.Padding = new System.Windows.Forms.Padding(2);
            this.Products_Box.Size = new System.Drawing.Size(684, 486);
            this.Products_Box.TabIndex = 0;
            this.Products_Box.TabStop = false;
            this.Products_Box.Text = "Orders";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 527);
            this.Controls.Add(this.Products_Box);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(745, 566);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).EndInit();
            this.Products_Box.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DeliveryDBDataSet deliveryDBDataSet;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private DeliveryDBDataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
        private DeliveryDBDataSet deliveryDBDataSet1;
        private System.Windows.Forms.BindingSource dishesBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView Products_Table;
        private System.Windows.Forms.Button Fill_Button;
        private System.Windows.Forms.GroupBox Products_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dish_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dish_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Status;
    }
}