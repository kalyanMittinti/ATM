using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AntTimeATM.Forms
{
    public partial class Card : Form
    {
        public static string card_no="";

        public Card()
        {
            InitializeComponent();
        }

        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb";

        private void button1_Click(object sender, EventArgs e)
        {
            //Set Card Number
            Program.card_no = textBox_cardNumber.Text.ToString();

            OleDbConnection conn = new OleDbConnection(str);
            OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM tbl_details WHERE card_no='"+textBox_cardNumber.Text.ToString()+"'",conn);
            conn.Open();

            try
            {
                int i;
                i = Convert.ToInt32(cmd.ExecuteScalar());

                if(i==1)
                {
                    // Navigate to PIN
                    new Pin().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(null,"Invalid Card Number !!","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(null, "Error : "+ex.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
    }
}
