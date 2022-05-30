using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selctedInventory = (string)listBox1.SelectedItem;

            string gift = " ";
            string color = " ";
            string shipping = " ";

            //radio button, select color 
            if(radioButton1.Checked)
            {
                color = "Space Grey";
            }
            if(radioButton2.Checked)
            {
                color = "Silver";
            }
            if(radioButton3.Checked)
            {
                color = "Gold";
            }
            if(radioButton4.Checked)
            {
                color = "Sierra Blue";
            }


            //checkbox selecting shipping
            if(checkBox2.Checked)
            {
                shipping = "Your order will ship between 2 to 3 days";
            }
            else
            {
                shipping = "Your order will ship between 4 to 7 days";
            }

            //display order
            label3.Text = "You have ordered " + color + " " + selctedInventory;
            label4.Text = shipping;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
