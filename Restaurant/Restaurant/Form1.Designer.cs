namespace Restaurant
{
    partial class Form1
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
            this.btn_admin = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.Cmbx_food_name = new System.Windows.Forms.ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.TxtBx_price = new System.Windows.Forms.TextBox();
            this.Lbl_count = new System.Windows.Forms.Label();
            this.TxtBx_count = new System.Windows.Forms.TextBox();
            this.Btn_order = new System.Windows.Forms.Button();
            this.grBx_order = new System.Windows.Forms.GroupBox();
            this.grBx_order.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(465, 43);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(104, 37);
            this.btn_admin.TabIndex = 1;
            this.btn_admin.Text = "Login admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(55, 28);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(43, 13);
            this.lbl_category.TabIndex = 1;
            this.lbl_category.Text = "Categry";
            // 
            // Cmbx_food_name
            // 
            this.Cmbx_food_name.FormattingEnabled = true;
            this.Cmbx_food_name.Location = new System.Drawing.Point(55, 107);
            this.Cmbx_food_name.Name = "Cmbx_food_name";
            this.Cmbx_food_name.Size = new System.Drawing.Size(252, 21);
            this.Cmbx_food_name.TabIndex = 2;
            this.Cmbx_food_name.SelectedIndexChanged += new System.EventHandler(this.Cmbx_food_name_SelectedIndexChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(55, 88);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(60, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Food name";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(55, 151);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(31, 13);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price";
            // 
            // TxtBx_price
            // 
            this.TxtBx_price.Location = new System.Drawing.Point(55, 168);
            this.TxtBx_price.Name = "TxtBx_price";
            this.TxtBx_price.Size = new System.Drawing.Size(252, 20);
            this.TxtBx_price.TabIndex = 5;
            // 
            // Lbl_count
            // 
            this.Lbl_count.AutoSize = true;
            this.Lbl_count.Location = new System.Drawing.Point(55, 211);
            this.Lbl_count.Name = "Lbl_count";
            this.Lbl_count.Size = new System.Drawing.Size(35, 13);
            this.Lbl_count.TabIndex = 6;
            this.Lbl_count.Text = "Count";
            // 
            // TxtBx_count
            // 
            this.TxtBx_count.Location = new System.Drawing.Point(55, 228);
            this.TxtBx_count.Name = "TxtBx_count";
            this.TxtBx_count.Size = new System.Drawing.Size(252, 20);
            this.TxtBx_count.TabIndex = 7;
            // 
            // Btn_order
            // 
            this.Btn_order.Location = new System.Drawing.Point(118, 276);
            this.Btn_order.Name = "Btn_order";
            this.Btn_order.Size = new System.Drawing.Size(122, 34);
            this.Btn_order.TabIndex = 8;
            this.Btn_order.Text = "Order";
            this.Btn_order.UseVisualStyleBackColor = true;
            this.Btn_order.Click += new System.EventHandler(this.Btn_order_Click);
            // 
            // grBx_order
            // 
            this.grBx_order.Controls.Add(this.Btn_order);
            this.grBx_order.Controls.Add(this.TxtBx_count);
            this.grBx_order.Controls.Add(this.Lbl_count);
            this.grBx_order.Controls.Add(this.TxtBx_price);
            this.grBx_order.Controls.Add(this.lbl_price);
            this.grBx_order.Controls.Add(this.lbl_name);
            this.grBx_order.Controls.Add(this.Cmbx_food_name);
            this.grBx_order.Controls.Add(this.lbl_category);
            this.grBx_order.Controls.Add(this.comboBox1);
            this.grBx_order.Location = new System.Drawing.Point(47, 39);
            this.grBx_order.Name = "grBx_order";
            this.grBx_order.Size = new System.Drawing.Size(371, 330);
            this.grBx_order.TabIndex = 0;
            this.grBx_order.TabStop = false;
            this.grBx_order.Text = "Order";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.grBx_order);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grBx_order.ResumeLayout(false);
            this.grBx_order.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox Cmbx_food_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox TxtBx_price;
        private System.Windows.Forms.Label Lbl_count;
        private System.Windows.Forms.TextBox TxtBx_count;
        private System.Windows.Forms.Button Btn_order;
        private System.Windows.Forms.GroupBox grBx_order;
    }
}

