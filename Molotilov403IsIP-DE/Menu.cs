using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molotilov403IsIP_DE
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableClient tali = new TableClient();
            tali.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientService clse = new ClientService();
            clse.Show();
            this.Hide();
        }
    }
}
