using AntTimeATM.Forms;
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
    public partial class MiniStatement : Form
    {
        public MiniStatement()
        {
            InitializeComponent();
        }

        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Neo\Documents\Database.accdb";

        private void MiniStatement_Load(object sender, EventArgs e)
        {
            string card_no = Program.card_no.ToString();
            //sMessageBox.Show(card_no.ToString());

            OleDbConnection conn = new OleDbConnection(str);
            OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM tbl_details WHERE card_no='"+Program.card_no.ToString()+"'", conn);
            conn.Open();

            try
            {
                int i;
                i = Convert.ToInt32(cmd.ExecuteScalar());

                if (i == 1)
                {
                    string qry = "SELECT * FROM tbl_details WHERE card_no='"+Program.card_no.ToString()+"'";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(qry, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "name");

                    DataTable dtable= ds.Tables[0];

                    foreach(DataRow dtRow in dtable.Rows)
                    {
                        textBox_name.Text = dtRow["name"].ToString();
                        textBox_cardNo.Text = dtRow["card_no"].ToString();
                        textBox_balance.Text = dtRow["balance"].ToString();
                    }
                    
                    
                    
                }
                else
                {
                    MessageBox.Show(null, "Invalid Card Number !!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Error : " + ex.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }
    }
}
