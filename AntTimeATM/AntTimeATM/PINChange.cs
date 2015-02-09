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

namespace AntTimeATM
{
    public partial class PINChange : Form
    {
        public PINChange()
        {
            InitializeComponent();
        }

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Neo\Documents\Database.accdb";

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox_pwdFirst.Text == textBox_pwdSecond.Text)
            {
                // Update Password
                string query = "UPDATE tbl_details SET pin='"+textBox_pwdSecond.Text.ToString()+"' WHERE card_no='"+Program.card_no.ToString()+"'";

                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand(query,conn);
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.UpdateCommand = conn.CreateCommand();
                adapter.UpdateCommand.CommandText = query;
                adapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Updated Successfully !!");

                //Navigate to Home Page
                new Form1().Show();
                
                
            }
            else
            {
                MessageBox.Show(null,"You Password didn't Match :'(",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
