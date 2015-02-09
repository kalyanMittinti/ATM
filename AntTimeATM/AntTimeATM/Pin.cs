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
    public partial class Pin : Form
    {
        public Pin()
        {
            InitializeComponent();
        }

        static string enterPin;

        private void button_one_Click(object sender, EventArgs e)
        {
            textBox_Pin.Text += "1";
        }

        private void button_two_Click(object sender, EventArgs e)
        {
            textBox_Pin.Text += "2";
        }

        private void button_three_Click(object sender, EventArgs e)
        {
            textBox_Pin.Text += "3";
        }

        private void button_four_Click(object sender, EventArgs e)
        {
            textBox_Pin.Text += "4";
        }

        private void button_five_Click(object sender, EventArgs e)
        {
            textBox_Pin.Text += "5";
        }

        private void button_six_Click(object sender, EventArgs e)
        {
            textBox_Pin.Text += "6";
        }

        private void button_seven_Click(object sender, EventArgs e)
        {
            textBox_Pin.Text += "7";
        }

        private void button_eight_Click(object sender, EventArgs e)
        {
            textBox_Pin.Text += "8";
        }

        private void button_nine_Click(object sender, EventArgs e)
        {
            textBox_Pin.Text += "9";
        }

        private void button_zero_Click(object sender, EventArgs e)
        {
            textBox_Pin.Text += "0";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Pin.Clear();
        }

        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Neo\Documents\Database.accdb";

        private void button_enter_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(str);
            OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM tbl_details WHERE pin='" + textBox_Pin.Text.ToString() + "' AND card_no='"+Program.card_no.ToString()+"'", conn);
            conn.Open();

            try
            {
                int i;
                i = Convert.ToInt32(cmd.ExecuteScalar());

                if (i == 1)
                {
                    // Navigate to MainMenu
                    new MainMenu().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(null, "Invalid PIN !!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Error : " + ex.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            
        }
    }
}
