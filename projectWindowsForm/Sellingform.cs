using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectWindowsForm
{
    public partial class Sellingform : Form
    {
        public Sellingform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3S66HKH;Initial Catalog=SuperMarket;Integrated Security=True");


        private void loading()
        {
            con.Open();
            string query = "select * from Product";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            con.Close();
        }
     
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sellingform_Load(object sender, EventArgs e)
        {
            loading();
            //label7.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "product ID";
            dataGridView1.Columns[1].Name = "Product Name";
            dataGridView1.Columns[2].Name = "Price";
            dataGridView1.Columns[3].Name = "Quntity";
            dataGridView1.Columns[4].Name = "total";
            dataGridView1.Columns[5].Name = "Date Time";



            // Resize the master DataGridView columns to fit the newly loaded data.
            dataGridView1.AutoResizeColumns();
            dataGridView2.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                Sbilld.Text = row.Cells[0].Value.ToString();
                Sproname.Text = row.Cells[1].Value.ToString();
                PRICETEX.Text = row.Cells[2].Value.ToString();
                QUANTEX.Text = row.Cells[3].Value.ToString();

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        public int total;
        private void button5_Click(object sender, EventArgs e)
        {
            int n=0,total = int.Parse(PRICETEX.Text) * int.Parse(this.QUANTEX.Text);
            int Grdtota1=0;
            DataGridViewRow newrowe = new DataGridViewRow();
            newrowe.CreateCells(dataGridView1);
            newrowe.Cells[0].Value = n + 1;
            newrowe.Cells[1].Value = Sproname.Text;
            newrowe.Cells[2].Value = PRICETEX.Text;
            newrowe.Cells[3].Value = this.QUANTEX.Text;
            newrowe.Cells[4].Value = int.Parse(PRICETEX.Text) * int.Parse(this.QUANTEX.Text);
            newrowe.Cells[5].Value = DateTime.Now;

            dataGridView1.Rows.Add(newrowe);
            Grdtota1 += total;
            amtbl.Text = "Rs" + Grdtota1;
 


        }

        private void dataviewcreatrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into  Bill   values(" + Sbilld.Text + ",'" + sellerName.Text + "','" + DateTime.Now + "','" + total + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("add  success");
                con.Close();
                //loading();

            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }
        }

        private void btnLocation_ID_Click(object sender, EventArgs e)
        {
            OpenFileDialog f1 = new OpenFileDialog();
            f1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (f1.ShowDialog() == DialogResult.OK)
            {
                textPath_ID.Text = f1.FileName;
            }
        }

        private void textPath_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Id_Click(object sender, EventArgs e)
        {

            if (textPath_ID.Text != "")
            {
                TextWriter writer = new StreamWriter(textPath_ID.Text);
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Data is saved");
            }
            else
            {
                textPath_ID.Text = "Invalid Data";
                textPath_ID.ForeColor = Color.Red;
                MessageBox.Show("Please Enter Your text Location");


            }
        }

        private void openFile_ID_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textPath_ID.Text = openFile.FileName;
                string[] data = File.ReadAllLines(textPath_ID.Text.ToString());
                string[] line;

                for (int i = 0; i < data.Length; i++)
                {
                    line = data[i].Split('|');
                    String[] row = new string[line.Length];

                    for (int j = 0; j < row.Length; j++)
                    {
                        row[j] = line[j].Trim();
                    }
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Products cat = new Products();
        //    cat.Show();
        //    this.Hide();
        //}
    }
}
