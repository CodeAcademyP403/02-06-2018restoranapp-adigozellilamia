using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        ArrayList products = new ArrayList(); 
        public Form1()
        {
            InitializeComponent();


            
            products.AddRange(new Product[]{
                new Product
                {
                    name="Free",
                    count=5,
                    price=3,
                    ProductCategory=ProductCategory.Garnet,

                },
                new Product
                {
                    name="Pizza",
                    count=3,
                    price=15,
                    ProductCategory=ProductCategory.MainFood,

                },
                new Product
                {
                    name="Chikenburger",
                    count=15,
                    price=4,
                    ProductCategory=ProductCategory.MainFood,

                },
                new Product
                {
                    name="Tomato",
                    count=5,
                    price=3,
                    ProductCategory=ProductCategory.Soups,

                },
                new Product
                {
                    name="Chees cake",
                    count=2,
                    price=8,
                    ProductCategory=ProductCategory.Dessert,

                },
                new Product
                {
                    name="Napaleon",
                    count=1,
                    price=13,
                    ProductCategory=ProductCategory.Dessert,

                },
                new Product
                {
                    name="Sezar",
                    count=6,
                    price=7,
                    ProductCategory=ProductCategory.Salad,

                },
                new Product
                {
                    name="Mashroom",
                    count=2,
                    price=3,
                    ProductCategory=ProductCategory.Soups,

                },
                new Product
                {
                    name="Juice fresh",
                    count=1,
                    price=7,
                    ProductCategory=ProductCategory.Drinks,

                },
                new Product
                {
                    name="Water",
                    count=30,
                    price=1.30,
                    ProductCategory=ProductCategory.Drinks,

                },


                });
            comboBox1.DataSource = Enum.GetValues(typeof(ProductCategory));
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = (sender as ComboBox).SelectedItem.ToString();
            ProductCategory gorunmeli_olan = (ProductCategory)Enum.Parse(typeof(ProductCategory), selectItem);
            Cmbx_food_name.Items.Clear();
            foreach (Product item in products)
            {
                if (item.ProductCategory == gorunmeli_olan)
                {
                    Cmbx_food_name.Items.Add(item.name);
                }
            }
        }
       
        private void Cmbx_food_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = (sender as ComboBox).SelectedItem.ToString();
            TxtBx_price.Text="";
            foreach (Product item in products)
            {
                if (item.name == selectItem)
                {
                    TxtBx_price.Text = Convert.ToString(item.price);
                }
                
            }
            //selectItem = ((Product)(sender as ComboBox).SelectedValue);
            //TxtBx_price.Text = Convert.ToString(selectItem.price);

            //TxtBx_count.Text = "";
            //foreach (Product item in products)
            //{
            //    TxtBx_count.Text = Convert.ToString(item.count);
            //}


        }

        ArrayList product = new ArrayList();
        
        private void Btn_order_Click(object sender, EventArgs e)
        {
            Product prd = new Product();
            prd.count = Convert.ToByte(TxtBx_count.Text);
            prd.price = Convert.ToDouble(TxtBx_price.Text);

            //prd.name = Cmbx_food_name.GetItemText(Cmbx_food_name.SelectedItem);
            prd.name = Cmbx_food_name.SelectedItem.ToString();
            product.Add(prd);
            Ordered form = new Ordered();
            form.ShowingArray(product);
            form.AddDataListBox();
            form.Show();
            
        }

        
    }
}
