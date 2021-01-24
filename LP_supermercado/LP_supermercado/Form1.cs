using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP_supermercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            var formRegist = new FormRegist();
            this.Hide();
            formRegist.Closed += (s, args) => this.Close();
            formRegist.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var formProduto = new FormProduto();
            this.Hide();
            formProduto.Closed += (s, args) => this.Close();
            formProduto.Show();
        }
    }
}
