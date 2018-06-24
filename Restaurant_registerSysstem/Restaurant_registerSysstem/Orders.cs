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
    public partial class Orders : Form
    {
       private Restaurant form { get; set; }
        private Login logform { get; set; }
        public Ofisant ofisant;
        List<Product> product = new List<Product>();
        public Orders(Restaurant _resForm, Ofisant ofisant_name)
        {
            this.ofisant = ofisant_name;
            this.form = _resForm;
            //logform = _form;
            InitializeComponent();
            product.AddRange(new Product[]{
                new Product
                {
                    name="Free",
                    count=2,
                    price=3,
                    ProductCategory=ProductCategory.Garnet,
                    Ofisant=Ofisant.Lamia,

                },
                new Product
                {
                    name="Pizza",
                    count=1,
                    price=15,
                    ProductCategory=ProductCategory.MainFood,
                    Ofisant=Ofisant.Lamia,

                },
                new Product
                {
                    name="Chikenburger",
                    count=1,
                    price=4,
                    ProductCategory=ProductCategory.MainFood,
                    Ofisant=Ofisant.Zuleyxa,

                },
                new Product
                {
                    name="Napaleon",
                    count=2,
                    price=13,
                    ProductCategory=ProductCategory.Dessert,
                    Ofisant=Ofisant.Zuleyxa,
                },
                new Product
                {
                    name="Juice fresh",
                    count=1,
                    price=7,
                    ProductCategory=ProductCategory.Drinks,
                    Ofisant=Ofisant.Ofisant_3

                },
                new Product
                {
                    name="Water",
                    count=30,
                    price=1.30,
                    ProductCategory=ProductCategory.Drinks,
                    Ofisant=Ofisant.Lamia,

                },

            });

            ShowingArray(product);
            AddListBox();
        }
       
        public void ShowingArray(List<Product> prd)
        {

            product = prd;
        }
        public void AddDataListBox()
        {

            foreach (Product item in product)
            {

                    Orders_list.Items.Add(item.name);
                    Orders_list.Items.Add(item.price);
                    Orders_list.Items.Add(item.count);

                

            }
        }

        public void AddListBox()
        {
           
            foreach (Product prd in product)
            {
                if (this.ofisant == prd.Ofisant)
                {
                    Orders_list.Items.Add(prd.name);
                    Orders_list.Items.Add(prd.price);
                    Orders_list.Items.Add(prd.count);
                    Orders_list.Items.Add(prd.Ofisant);

                }
                
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void Orders_list_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Orders_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }
    }
}
