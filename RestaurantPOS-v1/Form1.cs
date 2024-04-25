using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPOS_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void cbFries_CheckedChanged(object sender, EventArgs e)
        {
            if(cbFries.Checked)
            {
                txtFries.Enabled = true;
            }
            if(cbFries.Checked == false)
            {
                txtFries.Enabled = false;
                txtFries.Text = "0";
            }
            
        }

        private void cbBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBurger.Checked)
            {
                txtBurger.Enabled = true;
            }
            if (cbBurger.Checked == false)
            {
                txtBurger.Enabled = false;
                txtBurger.Text = "0";
            }
        }

        private void cbSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSalad.Checked)
            {
                txtSalad.Enabled = true;
            }
            if (cbSalad.Checked == false)
            {
                txtSalad.Enabled = false;
                txtSalad.Text = "0";
            }
        }

        private void cdSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (cdSandwich.Checked)
            {
                txtSandwich.Enabled = true;
            }
            if (cdSandwich.Checked == false)
            {
                txtSandwich.Enabled = false;
                txtSandwich.Text = "0";
            }
        }

        private void cbChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChicken.Checked)
            {
                txtChicken.Enabled = true;
            }
            if (cbChicken.Checked == false)
            {
                txtChicken.Enabled = false;
                txtChicken.Text = "0";
            }
        }

        private void cbCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheese.Checked)
            {
                txtCheese.Enabled = true;
            }
            if (cbCheese.Checked == false)
            {
                txtCheese.Enabled = false;
                txtCheese.Text = "0";
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
