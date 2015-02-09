using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntTimeATM
{
    public partial class CashWithDrawal : Form
    {
        public CashWithDrawal()
        {
            InitializeComponent();
        }

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Neo\Documents\Database.accdb";

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM tbl_details WHERE card_no='" + Program.card_no.ToString() + "'", conn);
            conn.Open();

            try
            {
                int i;
                string curr_balance=null;
                i = Convert.ToInt32(cmd.ExecuteScalar());

                if (i == 1)
                {
                    string qry = "SELECT * FROM tbl_details WHERE card_no='" + Program.card_no.ToString() + "'";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(qry, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "name");

                    DataTable dtable = ds.Tables[0];

                    foreach (DataRow dtRow in dtable.Rows)
                    {

                        curr_balance = dtRow["balance"].ToString();

                    }

                    Int32 difference= Int32.Parse(curr_balance)-Int32.Parse(textBox_amount.Text.ToString());
                    
                    if(difference>0)
                    {
                        string query = "UPDATE tbl_details SET balance='" + difference.ToString() + "' WHERE card_no='" + Program.card_no.ToString() + "'";

                        conn.Close();
                        cmd = new OleDbCommand(query, conn);
                        conn.Open();
                        adapter = new OleDbDataAdapter();
                        adapter.UpdateCommand = conn.CreateCommand();
                        adapter.UpdateCommand.CommandText = query;
                        adapter.UpdateCommand.ExecuteNonQuery();

                        MessageBox.Show(null, "Please, Collect Your Cash !!","Status",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        //Navigate to Home Page
                        new CollectAmount().Show();
                        this.Hide();
                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(null, "Error : " + ex.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Navigate to Thank you Page
            new CollectAmount().Show();
        }

        private void button_100_Click(object sender, EventArgs e)
        {
           
            textBox_amount.Text = (Int64.Parse(textBox_amount.Text.ToString()) + 100).ToString();
        }

        private void button_500_Click(object sender, EventArgs e)
        {
           
           textBox_amount.Text = (Int64.Parse(textBox_amount.Text.ToString()) + 500).ToString();
        }

        private void button_1000_Click(object sender, EventArgs e)
        {
            
            textBox_amount.Text = (Int64.Parse(textBox_amount.Text.ToString()) + 1000).ToString();
        }
    }
}
