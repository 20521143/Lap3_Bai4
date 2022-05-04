using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap3_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void bn_Sever_Click(object sender, EventArgs e)
        {
            Sever sever = new Sever();
            sever.Show();
        }
    }
}
