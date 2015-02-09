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
    public partial class CollectAmount : Form
    {
        public CollectAmount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // First Page
            this.Hide();
            new Form1().Show();
            
        }
    }
}
