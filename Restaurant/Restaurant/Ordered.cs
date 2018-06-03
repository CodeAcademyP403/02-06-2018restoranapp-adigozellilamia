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
    public partial class Ordered : Form
    {
        ArrayList product = new ArrayList();  //lokal olaraq bu variable a sen iki form arasinda reletion qurub gondermelisen (((((((((((((((((( uzlme ya bidene baxaq
        public Ordered()
        {
            InitializeComponent();
         
        }
        public void ShowingArray(ArrayList prd)
        {

            product = prd;
            //MessageBox.Show(name);
        }
        public void AddDataListBox()
        {
          
            foreach (Product item in product)
            {
                List_order.Items.Add(item.name);
                List_order.Items.Add(item.price);
                List_order.Items.Add(item.count);
                
            }
        }
        private void List_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            List_order.Items.Clear();
            foreach (Product item in product)
            {
                //List_order.Items.Add(item.name);
                // List_order.Items.Add(item.price);
                // List_order.Items.Add(item.count);
                MessageBox.Show(item.name);
            }
        }
    }
}
