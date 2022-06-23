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
    public partial class Catogerys : Form
    {
        public Catogerys()
        {
            InitializeComponent();
        }
        //SuperMarketEntities context = new SuperMarketEntities();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3S66HKH;Initial Catalog=SuperMarket;Integrated Security=True");

        private void loading()
        {
            con.Open();
            string query = "select * from Category";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
            con.Close();
        }
    
        private void test_Load(object sender, EventArgs e)
        {

            loading();

            // Resize the master DataGridView columns to fit the newly loaded data.
            dataGridView1.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                IDt.Text = row.Cells[0].Value.ToString();
                Namet.Text = row.Cells[1].Value.ToString();
                DESt.Text = row.Cells[2].Value.ToString();
            }

            //
            //    IDt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //    Namet.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //    DESt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string query = "insert into Category values(" + IDt.Text + ",'" + Namet.Text + "','" + DESt.Text + "')";
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                if (IDt.Text == "")
                {
                    MessageBox.Show("Select the category to delet");
                }
                else
                {
                    con.Open();
                    string query1 = "delete from  Category where  Category_id=" + IDt.Text + "";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                if (IDt.Text == ""|| Namet.Text=="" ||DESt.Text=="")
                {
                    MessageBox.Show("missing data");
                }
                else
                {
                    con.Open();
                    string query1 = "update    Category set  Category_name='" + Namet.Text + "',Category_des='" + DESt.Text + "' where Category_id="+IDt.Text+";";
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

        private void button4_Click(object sender, EventArgs e)
        {
            Products cat = new Products();
            cat.Show();
            this.Hide();
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SellerForm cat = new SellerForm();
            cat.Show();
            this.Hide();
        }
    }
}
