using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBG_CG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLetsGo_Click(object sender, EventArgs e)
        {
            MainPage mainForm = new MainPage();
            mainForm.Show();
            this.Hide();
        }
    }
}
