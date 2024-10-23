using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoComVariasJanelas
{
    public partial class FormNovoProduto : Form
    {
        public string Nome { get { return textBoxNome.Text; } }
        public string Fabricante { get { return textBoxFabricante.Text; } }
        public decimal PrecoCompra { get { return numericUpDownPrecoCompra.Value; } }
        public decimal PrecoVenda { get { return numericUpDownPrecoVenda.Value; } }
        public FormNovoProduto()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
