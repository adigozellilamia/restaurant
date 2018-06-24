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
    public partial class Login : Form
    {
        private Restaurant form { get; set; }
        List<Person> person = new List<Person>();
        public Login(Restaurant _form)
        {
       
            form = _form;
            InitializeComponent();
            person.AddRange(new Person[]{
                new Person
                {
                    Name="Lamia",
                    Email="lamia.adigozelli@icloud.com",
                    Password="123123",
                    Role=Role.Admin,

                },
                new Person
                {
                    Name="Said",
                    Email="said.aliyev@gmail.com",
                    Password="123123",
                    Role=Role.Menecer,

                },
                new Person
                {
                    Name="Zuleyxa",
                    Email="zuleyxa@gmail.com",
                    Password="123123",
                    Role=Role.Ofisant,

                },
                new Person
                {
                    Name="Lamia",
                    Email="lamia.adigozelli@gmail.com",
                    Password="123456",
                    Role=Role.Ofisant,

                },
            });
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cmb_role.DataSource = Enum.GetNames(typeof(Role));
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            foreach(Person prs in person)
            {

               if(txt_email.Text == prs.Email)
                  {
                    if ((txt_name.Text == prs.Name) && (txt_password.Text == prs.Password))
                    {
                        prs.Role = (Role)Enum.Parse(typeof(Role), cmb_role.SelectedItem.ToString());
                        
                        if (prs.Role == Role.Ofisant)
                        {
                            Ofisant sendedOfisant = (Ofisant)Enum.Parse(typeof(Ofisant), prs.Name);
                            Orders orders = new Orders( form, sendedOfisant);
                            orders.Show();
                            this.Hide();
                        }
                        else if (prs.Role == Role.Menecer)
                        {
                            Menecer_name selectedMenecer = (Menecer_name)Enum.Parse(typeof(Menecer_name),prs.Name);
                            Menecer menecer = new Menecer(this.form,selectedMenecer);
                            menecer.Show();
                            this.Hide();
                        }
                        else if(prs.Role== Role.Admin)
                        {
                            Admin admin = new Admin(this.form);
                            admin.Show();
                            this.Hide();
                        }

                        MessageBox.Show("You are succesfull Logined");
                        break;
                    }
                    else
                    {

                        MessageBox.Show("Email or password invalid");
                        break;
                    }
                }
                   
            }
        }
    }
}
