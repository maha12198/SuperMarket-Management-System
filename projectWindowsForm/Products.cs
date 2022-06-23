using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectWindowsForm
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3S66HKH;Initial Catalog=SuperMarket;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            SellerForm cat = new SellerForm();
            cat.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void fillcomo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Category_name from Category", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Category_name",typeof(string));
            dt.Load(rdr);
            comboBox1.ValueMember = "Category_name";
            comboBox1.DataSource = dt;
            con.Close();


 
        }
        private void Products_Load(object sender, EventArgs e)
        {
            loading();
            fillcomo();

            // Resize the master DataGridView columns to fit the newly loaded data.
            dataGridView1.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Catogerys cat  = new Catogerys();
            cat.Show();
            this.Hide();
        }

        private void loading()
        {
            con.Open();
            string query = "select * from Product";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                string query = "insert into  Product   values(" + IDTEXT.Text + ",'" + NAMETEXT.Text + "','" + PRICETEXT.Text + "','" + QUANTEXT.Text + "','"+ comboBox1.SelectedValue.ToString() +"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("add  success");
                con.Close();
                loading();

            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                IDTEXT.Text = row.Cells[0].Value.ToString();
                NAMETEXT.Text = row.Cells[1].Value.ToString();
                PRICETEXT.Text = row.Cells[2].Value.ToString();
                QUANTEXT.Text = row.Cells[3].Value.ToString();
                 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                if (IDTEXT.Text == "")
                {
                    MessageBox.Show("Select the Product to delet");
                }
                else
                {
                    con.Open();
                    string query1 = "delete from  Product where  Product_id=" + IDTEXT.Text + "";
                    SqlCommand cmd = new SqlCommand(query1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("delete  success");
                    con.Close();
                    loading();
                }

            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                if (IDTEXT.Text == "" || NAMETEXT.Text == "" || PRICETEXT.Text == "" ||QUANTEXT.Text=="")
                {
                    MessageBox.Show("missing data");
                }
                else
                {
                    con.Open();
                    string query1 = "update    Product set  Product_id='" + IDTEXT.Text + "',Product_name='" + NAMETEXT.Text + "',Product_price='" + PRICETEXT.Text +  "',Product_Qty='" + QUANTEXT.Text + "' where Product_id=" + IDTEXT.Text + ";";
                    SqlCommand cmd = new SqlCommand(query1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("update  success");
                    con.Close();
                    loading();
                }

            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
