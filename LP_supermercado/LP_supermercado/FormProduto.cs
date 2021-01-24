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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formLogin = new Form1();
            this.Hide();
            formLogin.Closed += (s, args) => this.Close();
            formLogin.Show();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lpSupermercadoDataSet.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.lpSupermercadoDataSet.produtos);

        }

        private void dtGridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dtGridProdutos.CurrentCell.Value.ToString());

        }
    }
}
