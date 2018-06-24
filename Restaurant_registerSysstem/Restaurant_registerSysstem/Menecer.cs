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
    public partial class Menecer : Form
    {
        List<Ofisant> ofisant= new List<Ofisant>();
        List<Menecer_name> menecer_name = new List<Menecer_name>();
        Restaurant form;
        public Menecer_name menecer;
        public Menecer(Restaurant form,Menecer_name mngr)
        {
            this.menecer = mngr;
            this.form = form;
            InitializeComponent();
        }

        private void Menecer_Load(object sender, EventArgs e)
        {
            cmb_ofisant.DataSource = Enum.GetValues(typeof(Ofisant));

        } 

        private void Menecer_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }
        string selectItem;
        private void cmb_ofisant_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectItem = (sender as ComboBox).SelectedItem.ToString();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
           
                    MessageBox.Show(this.selectItem);
                    Ofisant gorunmeli_olan = (Ofisant)Enum.Parse(typeof(Ofisant), this.selectItem);
                    Orders order = new Orders(form, gorunmeli_olan);
                    order.Show();
                    this.Hide();
                
        }
    }
}
