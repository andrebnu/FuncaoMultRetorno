using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncaoMultRetorno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVai_Click(object sender, EventArgs e)
        {

        }

        private void rbExec03_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExec03.Checked)
            {
                new Exec03().Show();
                this.Hide();

            }
        }
    }
}
