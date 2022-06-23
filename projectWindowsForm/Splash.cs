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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
     
        int Startpoint = 0;
    private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Startpoint += 1;
            progress.Value = Startpoint;
            if (progress.Value == 100)
            {
                progress.Value = 0;
                timer1.Stop();
                Form1 fr1 = new Form1();
                this.Hide();
                fr1.Show();
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void Splash_Load(object sender, EventArgs e)
        {
             timer1.Start();
        }
    }
}
