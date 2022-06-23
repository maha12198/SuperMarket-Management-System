using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(password.Text==""||username.Text=="")
            {

                MessageBox.Show("Enter username the password");
                 
            }
            else
            {
                if (comboBox1.SelectedIndex > -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "Admen")

                    {
                        if (password.Text == "Admen" && username.Text == "Admen")
                        {
                            Products pro = new Products();
                            pro.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("you are in seller rol");
                    }
                    
                  }
                else { ; }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
