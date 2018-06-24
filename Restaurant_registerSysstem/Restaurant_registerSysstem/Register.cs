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
    public partial class Register : Form
    {
        Form form;
        private Restaurant restaurant;
        public Register(Restaurant _restaurant)
        {
            this.restaurant = _restaurant;
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
