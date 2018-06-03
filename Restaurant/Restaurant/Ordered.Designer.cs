namespace Restaurant
{
    partial class Ordered
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
            this.List_order = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // List_order
            // 
            this.List_order.FormattingEnabled = true;
            this.List_order.Location = new System.Drawing.Point(12, 18);
            this.List_order.Name = "List_order";
            this.List_order.Size = new System.Drawing.Size(348, 212);
            this.List_order.TabIndex = 0;
            // 
            // Ordered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 254);
            this.Controls.Add(this.List_order);
            this.Name = "Ordered";
            this.Text = "Ordered";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox List_order;
    }
}