using System.ComponentModel;

namespace AplicativoComMultiplasJanelas
{
    public partial class Form1 : Form
    {
        private BindingList<Produto> Produtos = new BindingList<Produto>();
        private BindingList<Cliente> Clientes = new BindingList<Cliente>();
        private BindingList<Fornecedor> Fornecedores = new BindingList<Fornecedor>();
        private BindingList<Venda> Vendas = new BindingList<Venda>();
        private BindingList<Compra> Compra = new BindingList<Compra>();
        public Form1()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = Produtos;
        }

        private void ButtonAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormNovoProduto fnp = new FormNovoProduto();
            DialogResult resultado = fnp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                //string textoProduto = $"{fnp.Nome}-{fnp.Fabricante}(R${fnp.PrecoCompra})(R${fnp.PrecoVenda})";
                //listBoxProdutos.Items.Add(textoProduto);

                Produto produto = new Produto();

                if (Produtos.Count == 0) produto.Id = 1;
                else produto.Id = Produtos.Max(x => x.Id) + 1;

                produto.Nome = fnp.Nome;
                produto.Fabricante = fnp.Fabricante;
                produto.PrecoVenda = fnp.PrecoVenda;
                produto.PrecoCompra = fnp.PrecoCompra;

                Produtos.Add(produto);
            }
        }

        private void ButtonDeletarProduto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Produtos)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonVerProdutos_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Produtos;
        }

        private void buttonVerFornecedores_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Fornecedores;
        }

        private void buttonVerClientes_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Clientes;
        }

        private void buttonVerCompras_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Compra;
        }

        private void buttonVerVendas_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Vendas;
        }

        private void buttonNovoFornecedor_Click(object sender, EventArgs e)
        {
            FormNovoFornecedor fnf = new FormNovoFornecedor();
            var resultado = fnf.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();

                if (Fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = Fornecedores.Max(x => x.Id) + 1;

                fornecedor.NomeEmpresa = fnf.NomeEmpresa;
                fornecedor.NomeContato = fnf.NomeContato;
                fornecedor.Endereco = fnf.Endereco;
                fornecedor.Email = fnf.Email;
                fornecedor.Telefone = fnf.Telefone;
                Fornecedores.Add(fornecedor);

            }
        }

        private void buttonDeletarFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Fornecedores)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Fornecedores.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            FormNovoCliente fnc = new FormNovoCliente();
            var resultado = fnc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente();

                if (Clientes.Count == 0) cliente.Id = 1;
                else cliente.Id = Clientes.Max(x => x.Id) + 1;

                cliente.Nome = fnc.Nome;
                cliente.EnderecoFisico = fnc.Endereco;
                cliente.EnderecoEmail = fnc.Email;
                cliente.Telefone = fnc.Telefone;
                Clientes.Add(cliente);
            }
        }

        private void buttonDeletarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Clientes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Clientes.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonAdicionarCompra_Click(object sender, EventArgs e)
        {
            if (Fornecedores.Count == 0)
            {
                MessageBox.Show("Você Precisa Cadastrar Fornecedores Antes de Efetuar Uma Compra.");
                return;
            }

            if (Produtos.Count == 0)
            {
                MessageBox.Show("Você Precisa Cadastrar Produtos Antes de Efetuar Uma Compra.")
            }

            FormNovaCompra fnc = new FormNovaCompra(Fornecedores, Produtos);
            var resultado = fnc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Compra compra = new Compra();
                if (Compras.Count == 0) compra.Id = 1;
                else compra.Id = Compras.Max(x => x.Id) + 1;

                compra.IdProduto = fnc.IdProduto;
                compra.IdFornecedor = fnc.IdFornecedor;
                compra.Quantidade = (int)fnc.Quantidade;
                compra.Desconto = fnc.Desconto;
                compra.DataCompra = DateTime.Now;

                Compras.(compra);
                this.dataGridView1.DataSource = Compras;
            }
        }

        private void buttonDeletarCompra_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Compras)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                   Compras.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }
    }
}
