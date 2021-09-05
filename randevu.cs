using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRS
{
    public partial class randevu : Form
    {
        public randevu()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randevukayıt frm3 = new Randevukayıt();
            frm3.Show();
            this.Hide();
        }

       
    }
}
