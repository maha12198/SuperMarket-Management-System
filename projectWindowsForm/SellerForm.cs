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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        //DB Connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3S66HKH;Initial Catalog=SuperMarket;Integrated Security=True");


        private void SellerForm_Load(object sender, EventArgs e)
        {
            loading();


            // Resize the master DataGridView columns to fit the newly loaded data.
            dataGridView1.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



        }
        private void loading()
        {
            try
            {
                con.Open();
                string query = "select * from Seller";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                con.Close();
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
                con.Close();
            }

        }


        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into  Seller   values(" + Sid.Text + ",'" + Sname.Text + "','" + Sage.Text + "','" + Sphone.Text + "','" + Spass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("add  success");
                con.Close();
                loading();

            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
                con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {

                if (Sid.Text == "" || Sname.Text == "" || Sage.Text == "" || Sphone.Text == "" ||Spass.Text=="")
                {
                    MessageBox.Show("missing data");
                }
                else
                {
                    con.Open();
                    string query1 = "update Seller set Seller_id='" + Sid.Text + "',Seller_name='" + Sname.Text + "',Seller_age='" + Sage.Text + "',Seller_phone='" + Sphone.Text + "',password='" + Spass.Text + "' where Seller_id=" + Sid.Text + ";";
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
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                if (Sid.Text == "")
                {
                    MessageBox.Show("Please Select the Seller ID to delete");
                }
                else
                {
                    con.Open();
                    string query1 = "delete from Seller where Seller_id=" + Sid.Text + "";
                    SqlCommand cmd = new SqlCommand(query1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller deleted sucessfully");
                    con.Close();
                    loading();
                }

            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //    Sid.Text = row.Cells[0].Value.ToString();
            //    Sname.Text = row.Cells[1].Value.ToString();
            //    Sage.Text = row.Cells[2].Value.ToString();
            //    Sphone.Text = row.Cells[3].Value.ToString();
            //    Spass.Text = row.Cells[3].Value.ToString();

            //}
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int indexRow = e.RowIndex;
            //MessageBox.Show(indexRow.ToString());

            //if (indexRow >= 0)
            //{
            //    DataGridViewRow row = dataGridView1.Rows[indexRow];

            //    Sid.Text = row.Cells[0].Value.ToString();
            //    Sname.Text = row.Cells[1].Value.ToString();
            //    Sage.Text = row.Cells[2].Value.ToString();
            //    Sphone.Text = row.Cells[3].Value.ToString();
            //    Spass.Text = row.Cells[3].Value.ToString();

            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Catogerys cat = new Catogerys();
            cat.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products cat = new Products();
            cat.Show();
            this.Hide();
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexRow = e.RowIndex;
            //MessageBox.Show(indexRow.ToString());

            if (indexRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                Sid.Text = row.Cells[0].Value.ToString();
                Sname.Text = row.Cells[1].Value.ToString();
                Sage.Text = row.Cells[2].Value.ToString();
                Sphone.Text = row.Cells[3].Value.ToString();
                Spass.Text = row.Cells[3].Value.ToString();

            }
        }
    }
}
