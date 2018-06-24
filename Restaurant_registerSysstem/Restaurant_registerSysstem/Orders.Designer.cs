namespace Restaurant_registerSysstem
{
    partial class Orders
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
            this.Orders_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Orders_list
            // 
            this.Orders_list.FormattingEnabled = true;
            this.Orders_list.Location = new System.Drawing.Point(39, 27);
            this.Orders_list.Name = "Orders_list";
            this.Orders_list.Size = new System.Drawing.Size(392, 277);
            this.Orders_list.TabIndex = 0;
            this.Orders_list.SelectedIndexChanged += new System.EventHandler(this.Orders_list_SelectedIndexChanged);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 340);
            this.Controls.Add(this.Orders_list);
            this.Name = "Orders";
            this.Text = "Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Orders_FormClosing);
            this.Load += new System.EventHandler(this.Orders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Orders_list;
    }
}