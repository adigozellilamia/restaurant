namespace Restaurant_registerSysstem
{
    partial class Menu
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
            this.grBx_order = new System.Windows.Forms.GroupBox();
            this.lbl_ofisant = new System.Windows.Forms.Label();
            this.cmb_ofisant = new System.Windows.Forms.ComboBox();
            this.Btn_order = new System.Windows.Forms.Button();
            this.TxtBx_count = new System.Windows.Forms.TextBox();
            this.Lbl_count = new System.Windows.Forms.Label();
            this.TxtBx_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.Cmbx_food_name = new System.Windows.Forms.ComboBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.grBx_order.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBx_order
            // 
            this.grBx_order.Controls.Add(this.lbl_ofisant);
            this.grBx_order.Controls.Add(this.cmb_ofisant);
            this.grBx_order.Controls.Add(this.Btn_order);
            this.grBx_order.Controls.Add(this.TxtBx_count);
            this.grBx_order.Controls.Add(this.Lbl_count);
            this.grBx_order.Controls.Add(this.TxtBx_price);
            this.grBx_order.Controls.Add(this.lbl_price);
            this.grBx_order.Controls.Add(this.lbl_name);
            this.grBx_order.Controls.Add(this.Cmbx_food_name);
            this.grBx_order.Controls.Add(this.lbl_category);
            this.grBx_order.Controls.Add(this.cmb_category);
            this.grBx_order.Location = new System.Drawing.Point(21, 16);
            this.grBx_order.Name = "grBx_order";
            this.grBx_order.Size = new System.Drawing.Size(371, 348);
            this.grBx_order.TabIndex = 1;
            this.grBx_order.TabStop = false;
            this.grBx_order.Text = "Order";
            // 
            // lbl_ofisant
            // 
            this.lbl_ofisant.AutoSize = true;
            this.lbl_ofisant.Location = new System.Drawing.Point(55, 122);
            this.lbl_ofisant.Name = "lbl_ofisant";
            this.lbl_ofisant.Size = new System.Drawing.Size(40, 13);
            this.lbl_ofisant.TabIndex = 10;
            this.lbl_ofisant.Text = "Ofisant";
            // 
            // cmb_ofisant
            // 
            this.cmb_ofisant.FormattingEnabled = true;
            this.cmb_ofisant.Location = new System.Drawing.Point(55, 141);
            this.cmb_ofisant.Name = "cmb_ofisant";
            this.cmb_ofisant.Size = new System.Drawing.Size(252, 21);
            this.cmb_ofisant.TabIndex = 9;
            // 
            // Btn_order
            // 
            this.Btn_order.Location = new System.Drawing.Point(116, 296);
            this.Btn_order.Name = "Btn_order";
            this.Btn_order.Size = new System.Drawing.Size(122, 34);
            this.Btn_order.TabIndex = 8;
            this.Btn_order.Text = "Order";
            this.Btn_order.UseVisualStyleBackColor = true;
            this.Btn_order.Click += new System.EventHandler(this.Btn_order_Click);
            // 
            // TxtBx_count
            // 
            this.TxtBx_count.Location = new System.Drawing.Point(55, 251);
            this.TxtBx_count.Name = "TxtBx_count";
            this.TxtBx_count.Size = new System.Drawing.Size(252, 20);
            this.TxtBx_count.TabIndex = 7;
            // 
            // Lbl_count
            // 
            this.Lbl_count.AutoSize = true;
            this.Lbl_count.Location = new System.Drawing.Point(55, 234);
            this.Lbl_count.Name = "Lbl_count";
            this.Lbl_count.Size = new System.Drawing.Size(35, 13);
            this.Lbl_count.TabIndex = 6;
            this.Lbl_count.Text = "Count";
            // 
            // TxtBx_price
            // 
            this.TxtBx_price.Location = new System.Drawing.Point(55, 197);
            this.TxtBx_price.Name = "TxtBx_price";
            this.TxtBx_price.Size = new System.Drawing.Size(252, 20);
            this.TxtBx_price.TabIndex = 5;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(52, 180);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(31, 13);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(55, 70);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(60, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Food name";
            // 
            // Cmbx_food_name
            // 
            this.Cmbx_food_name.FormattingEnabled = true;
            this.Cmbx_food_name.Location = new System.Drawing.Point(55, 89);
            this.Cmbx_food_name.Name = "Cmbx_food_name";
            this.Cmbx_food_name.Size = new System.Drawing.Size(252, 21);
            this.Cmbx_food_name.TabIndex = 2;
            this.Cmbx_food_name.SelectedIndexChanged += new System.EventHandler(this.Cmbx_food_name_SelectedIndexChanged);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(55, 16);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(49, 13);
            this.lbl_category.TabIndex = 1;
            this.lbl_category.Text = "Category";
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(55, 35);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(252, 21);
            this.cmb_category.TabIndex = 0;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 376);
            this.Controls.Add(this.grBx_order);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.grBx_order.ResumeLayout(false);
            this.grBx_order.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBx_order;
        private System.Windows.Forms.Label lbl_ofisant;
        private System.Windows.Forms.ComboBox cmb_ofisant;
        private System.Windows.Forms.Button Btn_order;
        private System.Windows.Forms.TextBox TxtBx_count;
        private System.Windows.Forms.Label Lbl_count;
        private System.Windows.Forms.TextBox TxtBx_price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ComboBox Cmbx_food_name;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cmb_category;
    }
}