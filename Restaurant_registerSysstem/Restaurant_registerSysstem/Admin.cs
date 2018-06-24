using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_registerSysstem
{
    public partial class Admin : Form
    {

        Restaurant form;
        public Admin(Restaurant form)
        {
            this.form = form;
            InitializeComponent();
            cmb_menecer.DataSource = Enum.GetValues(typeof(Menecer_name));

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        
        string selectedItem;
        private void cmb_menecer_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = (sender as ComboBox).SelectedItem.ToString();
        }


        private void btn_select_Click(object sender, EventArgs e)
        {

            Menecer_name selectedMenecer = (Menecer_name)Enum.Parse(typeof(Menecer_name), this.selectedItem);

            Menecer menecer = new Menecer(form, selectedMenecer);
            menecer.Show(); 
            this.Hide();
        }
    }


}
