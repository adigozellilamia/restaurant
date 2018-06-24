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
    public partial class Restaurant : Form
    {
        public Restaurant()
        {
            
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           
            Login login = new Login(this);
            login.Show();
            this.Hide();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            this.Hide();
        }

        private void Restaurant_Load(object sender, EventArgs e)
        {

        }
    }
}
