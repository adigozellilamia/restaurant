namespace Restaurant_registerSysstem
{
    partial class Menecer
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
            this.cmb_ofisant = new System.Windows.Forms.ComboBox();
            this.lbl_ofisant = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_ofisant
            // 
            this.cmb_ofisant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_ofisant.FormattingEnabled = true;
            this.cmb_ofisant.Location = new System.Drawing.Point(100, 118);
            this.cmb_ofisant.Name = "cmb_ofisant";
            this.cmb_ofisant.Size = new System.Drawing.Size(203, 28);
            this.cmb_ofisant.TabIndex = 0;
            this.cmb_ofisant.SelectedIndexChanged += new System.EventHandler(this.cmb_ofisant_SelectedIndexChanged);
            // 
            // lbl_ofisant
            // 
            this.lbl_ofisant.AutoSize = true;
            this.lbl_ofisant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ofisant.Location = new System.Drawing.Point(96, 86);
            this.lbl_ofisant.Name = "lbl_ofisant";
            this.lbl_ofisant.Size = new System.Drawing.Size(74, 25);
            this.lbl_ofisant.TabIndex = 1;
            this.lbl_ofisant.Text = "Ofisant";
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_select.Location = new System.Drawing.Point(136, 177);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(132, 41);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // Menecer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 329);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.lbl_ofisant);
            this.Controls.Add(this.cmb_ofisant);
            this.Name = "Menecer";
            this.Text = "Menecer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menecer_FormClosing);
            this.Load += new System.EventHandler(this.Menecer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_ofisant;
        private System.Windows.Forms.Label lbl_ofisant;
        private System.Windows.Forms.Button btn_select;
    }
}