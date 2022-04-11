
namespace DeliveryApp
{
    partial class DeliveryForm
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
            this.Delivery_Box = new System.Windows.Forms.GroupBox();
            this.Delivery_Table = new System.Windows.Forms.DataGridView();
            this.Order_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cusomer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cusomer_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accept_Button = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Being_Delivered_Box = new System.Windows.Forms.GroupBox();
            this.In_Delivery_Table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkout_Box = new System.Windows.Forms.GroupBox();
            this.Checkout_Button = new System.Windows.Forms.Button();
            this.Payment_Field = new System.Windows.Forms.Label();
            this.Payment_Label = new System.Windows.Forms.Label();
            this.ID_Field = new System.Windows.Forms.Label();
            this.Id_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Delivery_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delivery_Table)).BeginInit();
            this.Being_Delivered_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.In_Delivery_Table)).BeginInit();
            this.Checkout_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delivery_Box
            // 
            this.Delivery_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Delivery_Box.BackColor = System.Drawing.Color.PowderBlue;
            this.Delivery_Box.Controls.Add(this.Delivery_Table);
            this.Delivery_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delivery_Box.Location = new System.Drawing.Point(8, 40);
            this.Delivery_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Delivery_Box.Name = "Delivery_Box";
            this.Delivery_Box.Padding = new System.Windows.Forms.Padding(2);
            this.Delivery_Box.Size = new System.Drawing.Size(607, 184);
            this.Delivery_Box.TabIndex = 1;
            this.Delivery_Box.TabStop = false;
            this.Delivery_Box.Text = "Waiting For Delivery";
            // 
            // Delivery_Table
            // 
            this.Delivery_Table.AllowUserToAddRows = false;
            this.Delivery_Table.AllowUserToDeleteRows = false;
            this.Delivery_Table.AllowUserToResizeColumns = false;
            this.Delivery_Table.AllowUserToResizeRows = false;
            this.Delivery_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Delivery_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Delivery_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Delivery_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_Id,
            this.Order_Time,
            this.Cusomer_Name,
            this.Cusomer_Address,
            this.Accept_Button});
            this.Delivery_Table.Location = new System.Drawing.Point(2, 24);
            this.Delivery_Table.Margin = new System.Windows.Forms.Padding(2);
            this.Delivery_Table.Name = "Delivery_Table";
            this.Delivery_Table.RowHeadersWidth = 62;
            this.Delivery_Table.RowTemplate.Height = 28;
            this.Delivery_Table.Size = new System.Drawing.Size(603, 158);
            this.Delivery_Table.TabIndex = 0;
            this.Delivery_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Delivery_Table_CellClick);
            // 
            // Order_Id
            // 
            this.Order_Id.FillWeight = 28.40909F;
            this.Order_Id.HeaderText = "Id";
            this.Order_Id.MinimumWidth = 8;
            this.Order_Id.Name = "Order_Id";
            // 
            // Order_Time
            // 
            this.Order_Time.FillWeight = 133.7236F;
            this.Order_Time.HeaderText = "Ordered At";
            this.Order_Time.MinimumWidth = 8;
            this.Order_Time.Name = "Order_Time";
            // 
            // Cusomer_Name
            // 
            this.Cusomer_Name.FillWeight = 133.7236F;
            this.Cusomer_Name.HeaderText = "Customer Name";
            this.Cusomer_Name.MinimumWidth = 8;
            this.Cusomer_Name.Name = "Cusomer_Name";
            // 
            // Cusomer_Address
            // 
            this.Cusomer_Address.FillWeight = 133.7236F;
            this.Cusomer_Address.HeaderText = "Address";
            this.Cusomer_Address.MinimumWidth = 8;
            this.Cusomer_Address.Name = "Cusomer_Address";
            // 
            // Accept_Button
            // 
            this.Accept_Button.FillWeight = 70.42014F;
            this.Accept_Button.HeaderText = "Accept";
            this.Accept_Button.MinimumWidth = 8;
            this.Accept_Button.Name = "Accept_Button";
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Refresh_Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Refresh_Button.Location = new System.Drawing.Point(269, 6);
            this.Refresh_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(106, 21);
            this.Refresh_Button.TabIndex = 2;
            this.Refresh_Button.Text = "Refresh Page";
            this.Refresh_Button.UseVisualStyleBackColor = false;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Being_Delivered_Box
            // 
            this.Being_Delivered_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Being_Delivered_Box.BackColor = System.Drawing.Color.PowderBlue;
            this.Being_Delivered_Box.Controls.Add(this.In_Delivery_Table);
            this.Being_Delivered_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Being_Delivered_Box.Location = new System.Drawing.Point(10, 235);
            this.Being_Delivered_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Being_Delivered_Box.Name = "Being_Delivered_Box";
            this.Being_Delivered_Box.Padding = new System.Windows.Forms.Padding(2);
            this.Being_Delivered_Box.Size = new System.Drawing.Size(607, 163);
            this.Being_Delivered_Box.TabIndex = 3;
            this.Being_Delivered_Box.TabStop = false;
            this.Being_Delivered_Box.Text = "You are delivering";
            // 
            // In_Delivery_Table
            // 
            this.In_Delivery_Table.AllowUserToAddRows = false;
            this.In_Delivery_Table.AllowUserToDeleteRows = false;
            this.In_Delivery_Table.AllowUserToResizeColumns = false;
            this.In_Delivery_Table.AllowUserToResizeRows = false;
            this.In_Delivery_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.In_Delivery_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.In_Delivery_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.In_Delivery_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.In_Delivery_Table.Location = new System.Drawing.Point(2, 26);
            this.In_Delivery_Table.Margin = new System.Windows.Forms.Padding(2);
            this.In_Delivery_Table.Name = "In_Delivery_Table";
            this.In_Delivery_Table.RowHeadersWidth = 62;
            this.In_Delivery_Table.RowTemplate.Height = 28;
            this.In_Delivery_Table.Size = new System.Drawing.Size(603, 135);
            this.In_Delivery_Table.TabIndex = 0;
            this.In_Delivery_Table.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.In_Delivery_Table_RowEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 28.40909F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 133.7236F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ordered At";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 133.7236F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 133.7236F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Checkout_Box
            // 
            this.Checkout_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Checkout_Box.BackColor = System.Drawing.Color.PowderBlue;
            this.Checkout_Box.Controls.Add(this.Checkout_Button);
            this.Checkout_Box.Controls.Add(this.Payment_Field);
            this.Checkout_Box.Controls.Add(this.Payment_Label);
            this.Checkout_Box.Controls.Add(this.ID_Field);
            this.Checkout_Box.Controls.Add(this.Id_Label);
            this.Checkout_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Checkout_Box.Location = new System.Drawing.Point(12, 411);
            this.Checkout_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Checkout_Box.Name = "Checkout_Box";
            this.Checkout_Box.Padding = new System.Windows.Forms.Padding(2);
            this.Checkout_Box.Size = new System.Drawing.Size(607, 76);
            this.Checkout_Box.TabIndex = 4;
            this.Checkout_Box.TabStop = false;
            this.Checkout_Box.Text = "Checkout";
            // 
            // Checkout_Button
            // 
            this.Checkout_Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Checkout_Button.Location = new System.Drawing.Point(466, 30);
            this.Checkout_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Checkout_Button.Name = "Checkout_Button";
            this.Checkout_Button.Size = new System.Drawing.Size(98, 30);
            this.Checkout_Button.TabIndex = 5;
            this.Checkout_Button.Text = "Checkout";
            this.Checkout_Button.UseVisualStyleBackColor = false;
            this.Checkout_Button.Click += new System.EventHandler(this.Checkout_Button_Click);
            // 
            // Payment_Field
            // 
            this.Payment_Field.AutoSize = true;
            this.Payment_Field.Location = new System.Drawing.Point(306, 34);
            this.Payment_Field.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Payment_Field.Name = "Payment_Field";
            this.Payment_Field.Size = new System.Drawing.Size(20, 24);
            this.Payment_Field.TabIndex = 4;
            this.Payment_Field.Text = "0";
            // 
            // Payment_Label
            // 
            this.Payment_Label.AutoSize = true;
            this.Payment_Label.Location = new System.Drawing.Point(152, 34);
            this.Payment_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Payment_Label.Name = "Payment_Label";
            this.Payment_Label.Size = new System.Drawing.Size(141, 24);
            this.Payment_Label.TabIndex = 2;
            this.Payment_Label.Text = "Customer Pays:";
            // 
            // ID_Field
            // 
            this.ID_Field.AutoSize = true;
            this.ID_Field.Location = new System.Drawing.Point(106, 34);
            this.ID_Field.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID_Field.Name = "ID_Field";
            this.ID_Field.Size = new System.Drawing.Size(0, 24);
            this.ID_Field.TabIndex = 1;
            // 
            // Id_Label
            // 
            this.Id_Label.AutoSize = true;
            this.Id_Label.Location = new System.Drawing.Point(11, 34);
            this.Id_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Id_Label.Name = "Id_Label";
            this.Id_Label.Size = new System.Drawing.Size(91, 24);
            this.Id_Label.TabIndex = 0;
            this.Id_Label.Text = "Order ID: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DeliveryApp.Properties.Resources.G06IipmsgyY;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 679);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 506);
            this.Controls.Add(this.Checkout_Box);
            this.Controls.Add(this.Being_Delivered_Box);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Delivery_Box);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(640, 545);
            this.Name = "DeliveryForm";
            this.Text = "DeliveryForm";
            this.Delivery_Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Delivery_Table)).EndInit();
            this.Being_Delivered_Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.In_Delivery_Table)).EndInit();
            this.Checkout_Box.ResumeLayout(false);
            this.Checkout_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Delivery_Box;
        private System.Windows.Forms.DataGridView Delivery_Table;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.GroupBox Being_Delivered_Box;
        private System.Windows.Forms.DataGridView In_Delivery_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cusomer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cusomer_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accept_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox Checkout_Box;
        private System.Windows.Forms.Label Id_Label;
        private System.Windows.Forms.Button Checkout_Button;
        private System.Windows.Forms.Label Payment_Field;
        private System.Windows.Forms.Label Payment_Label;
        private System.Windows.Forms.Label ID_Field;
    }
}