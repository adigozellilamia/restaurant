namespace Restaurant_registerSysstem
{
    partial class Admin
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
            this.btn_select = new System.Windows.Forms.Button();
            this.lbl_menecer = new System.Windows.Forms.Label();
            this.cmb_menecer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_select.Location = new System.Drawing.Point(137, 161);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(132, 41);
            this.btn_select.TabIndex = 5;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // lbl_menecer
            // 
            this.lbl_menecer.AutoSize = true;
            this.lbl_menecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_menecer.Location = new System.Drawing.Point(97, 70);
            this.lbl_menecer.Name = "lbl_menecer";
            this.lbl_menecer.Size = new System.Drawing.Size(89, 25);
            this.lbl_menecer.TabIndex = 4;
            this.lbl_menecer.Text = "Menecer";
            // 
            // cmb_menecer
            // 
            this.cmb_menecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_menecer.FormattingEnabled = true;
            this.cmb_menecer.Location = new System.Drawing.Point(101, 102);
            this.cmb_menecer.Name = "cmb_menecer";
            this.cmb_menecer.Size = new System.Drawing.Size(203, 28);
            this.cmb_menecer.TabIndex = 3;
            this.cmb_menecer.SelectedIndexChanged += new System.EventHandler(this.cmb_menecer_SelectedIndexChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 311);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.lbl_menecer);
            this.Controls.Add(this.cmb_menecer);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label lbl_menecer;
        private System.Windows.Forms.ComboBox cmb_menecer;
    }
}