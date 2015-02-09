using AntTimeATM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntTimeATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            // Navigate to Casd.cs form
            new Card().Show();
            this.Hide();
        }
    }
}
