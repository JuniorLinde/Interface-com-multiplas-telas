namespace AplicativoComMultiplasJanelas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonDeletarProduto = new Button();
            dataGridView1 = new DataGridView();
            buttonVerProdutos = new Button();
            buttonVerFornecedores = new Button();
            buttonVerClientes = new Button();
            buttonVerCompras = new Button();
            buttonVerVendas = new Button();
            buttonNovoFornecedor = new Button();
            buttonDeletarFornecedor = new Button();
            ButtonAdicionarProduto = new Button();
            buttonAdicionarCliente = new Button();
            buttonDeletarCliente = new Button();
            buttonAdicionarCompra = new Button();
            buttonDeletarCompra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ButtonDeletarProduto
            // 
            ButtonDeletarProduto.BackColor = SystemColors.ActiveCaption;
            ButtonDeletarProduto.Location = new Point(12, 70);
            ButtonDeletarProduto.Name = "ButtonDeletarProduto";
            ButtonDeletarProduto.Size = new Size(111, 23);
            ButtonDeletarProduto.TabIndex = 1;
            ButtonDeletarProduto.Text = "Deletar Produto";
            ButtonDeletarProduto.UseVisualStyleBackColor = false;
            ButtonDeletarProduto.Click += ButtonDeletarProduto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(627, 253);
            dataGridView1.TabIndex = 2;
            // 
            // buttonVerProdutos
            // 
            buttonVerProdutos.BackColor = SystemColors.AppWorkspace;
            buttonVerProdutos.Location = new Point(12, 12);
            buttonVerProdutos.Name = "buttonVerProdutos";
            buttonVerProdutos.Size = new Size(111, 23);
            buttonVerProdutos.TabIndex = 3;
            buttonVerProdutos.Text = "Produtos";
            buttonVerProdutos.UseVisualStyleBackColor = false;
            buttonVerProdutos.Click += buttonVerProdutos_Click;
            // 
            // buttonVerFornecedores
            // 
            buttonVerFornecedores.BackColor = SystemColors.AppWorkspace;
            buttonVerFornecedores.Location = new Point(129, 12);
            buttonVerFornecedores.Name = "buttonVerFornecedores";
            buttonVerFornecedores.Size = new Size(123, 23);
            buttonVerFornecedores.TabIndex = 4;
            buttonVerFornecedores.Text = "Fornecedores";
            buttonVerFornecedores.UseVisualStyleBackColor = false;
            buttonVerFornecedores.Click += buttonVerFornecedores_Click;
            // 
            // buttonVerClientes
            // 
            buttonVerClientes.BackColor = SystemColors.AppWorkspace;
            buttonVerClientes.Location = new Point(387, 12);
            buttonVerClientes.Name = "buttonVerClientes";
            buttonVerClientes.Size = new Size(123, 23);
            buttonVerClientes.TabIndex = 5;
            buttonVerClientes.Text = "Clientes";
            buttonVerClientes.UseVisualStyleBackColor = false;
            buttonVerClientes.Click += buttonVerClientes_Click;
            // 
            // buttonVerCompras
            // 
            buttonVerCompras.BackColor = SystemColors.AppWorkspace;
            buttonVerCompras.Location = new Point(258, 12);
            buttonVerCompras.Name = "buttonVerCompras";
            buttonVerCompras.Size = new Size(123, 23);
            buttonVerCompras.TabIndex = 6;
            buttonVerCompras.Text = "Compras";
            buttonVerCompras.UseVisualStyleBackColor = false;
            buttonVerCompras.Click += buttonVerCompras_Click;
            // 
            // buttonVerVendas
            // 
            buttonVerVendas.BackColor = SystemColors.AppWorkspace;
            buttonVerVendas.Location = new Point(516, 12);
            buttonVerVendas.Name = "buttonVerVendas";
            buttonVerVendas.Size = new Size(123, 23);
            buttonVerVendas.TabIndex = 7;
            buttonVerVendas.Text = "Vendas";
            buttonVerVendas.UseVisualStyleBackColor = false;
            buttonVerVendas.Click += buttonVerVendas_Click;
            // 
            // buttonNovoFornecedor
            // 
            buttonNovoFornecedor.BackColor = SystemColors.ActiveCaption;
            buttonNovoFornecedor.Location = new Point(129, 41);
            buttonNovoFornecedor.Name = "buttonNovoFornecedor";
            buttonNovoFornecedor.Size = new Size(123, 23);
            buttonNovoFornecedor.TabIndex = 8;
            buttonNovoFornecedor.Text = "Novo Fornecedor";
            buttonNovoFornecedor.UseVisualStyleBackColor = false;
            buttonNovoFornecedor.Click += buttonNovoFornecedor_Click;
            // 
            // buttonDeletarFornecedor
            // 
            buttonDeletarFornecedor.BackColor = SystemColors.ActiveCaption;
            buttonDeletarFornecedor.Location = new Point(129, 70);
            buttonDeletarFornecedor.Name = "buttonDeletarFornecedor";
            buttonDeletarFornecedor.Size = new Size(123, 23);
            buttonDeletarFornecedor.TabIndex = 9;
            buttonDeletarFornecedor.Text = "Deletar";
            buttonDeletarFornecedor.UseVisualStyleBackColor = false;
            buttonDeletarFornecedor.Click += buttonDeletarFornecedor_Click;
            // 
            // ButtonAdicionarProduto
            // 
            ButtonAdicionarProduto.BackColor = SystemColors.ActiveCaption;
            ButtonAdicionarProduto.Location = new Point(12, 41);
            ButtonAdicionarProduto.Name = "ButtonAdicionarProduto";
            ButtonAdicionarProduto.Size = new Size(111, 23);
            ButtonAdicionarProduto.TabIndex = 0;
            ButtonAdicionarProduto.Text = "Novo Produto";
            ButtonAdicionarProduto.UseVisualStyleBackColor = false;
            ButtonAdicionarProduto.Click += ButtonAdicionarProduto_Click;
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.BackColor = SystemColors.ActiveCaption;
            buttonAdicionarCliente.Location = new Point(387, 41);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(123, 23);
            buttonAdicionarCliente.TabIndex = 10;
            buttonAdicionarCliente.Text = "Novo Cliente";
            buttonAdicionarCliente.UseVisualStyleBackColor = false;
            buttonAdicionarCliente.Click += buttonAdicionarCliente_Click;
            // 
            // buttonDeletarCliente
            // 
            buttonDeletarCliente.BackColor = SystemColors.ActiveCaption;
            buttonDeletarCliente.Location = new Point(387, 70);
            buttonDeletarCliente.Name = "buttonDeletarCliente";
            buttonDeletarCliente.Size = new Size(123, 23);
            buttonDeletarCliente.TabIndex = 11;
            buttonDeletarCliente.Text = "Deletar Cliente";
            buttonDeletarCliente.UseVisualStyleBackColor = false;
            buttonDeletarCliente.Click += buttonDeletarCliente_Click;
            // 
            // buttonAdicionarCompra
            // 
            buttonAdicionarCompra.BackColor = SystemColors.ActiveCaption;
            buttonAdicionarCompra.Location = new Point(258, 41);
            buttonAdicionarCompra.Name = "buttonAdicionarCompra";
            buttonAdicionarCompra.Size = new Size(123, 23);
            buttonAdicionarCompra.TabIndex = 12;
            buttonAdicionarCompra.Text = "Nova Compra";
            buttonAdicionarCompra.UseVisualStyleBackColor = false;
            buttonAdicionarCompra.Click += buttonAdicionarCompra_Click;
            // 
            // buttonDeletarCompra
            // 
            buttonDeletarCompra.BackColor = SystemColors.ActiveCaption;
            buttonDeletarCompra.Location = new Point(258, 70);
            buttonDeletarCompra.Name = "buttonDeletarCompra";
            buttonDeletarCompra.Size = new Size(123, 23);
            buttonDeletarCompra.TabIndex = 13;
            buttonDeletarCompra.Text = "Deletar Compra";
            buttonDeletarCompra.UseVisualStyleBackColor = false;
            buttonDeletarCompra.Click += buttonDeletarCompra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 364);
            Controls.Add(buttonDeletarCompra);
            Controls.Add(buttonAdicionarCompra);
            Controls.Add(buttonDeletarCliente);
            Controls.Add(buttonAdicionarCliente);
            Controls.Add(buttonDeletarFornecedor);
            Controls.Add(buttonNovoFornecedor);
            Controls.Add(buttonVerVendas);
            Controls.Add(buttonVerCompras);
            Controls.Add(buttonVerClientes);
            Controls.Add(buttonVerFornecedores);
            Controls.Add(buttonVerProdutos);
            Controls.Add(dataGridView1);
            Controls.Add(ButtonDeletarProduto);
            Controls.Add(ButtonAdicionarProduto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button ButtonDeletarProduto;
        private DataGridView dataGridView1;
        private Button buttonVerProdutos;
        private Button buttonVerFornecedores;
        private Button buttonVerClientes;
        private Button buttonVerCompras;
        private Button buttonVerVendas;
        private Button buttonNovoFornecedor;
        private Button buttonDeletarFornecedor;
        private Button ButtonAdicionarProduto;
        private Button buttonAdicionarCliente;
        private Button buttonDeletarCliente;
        private Button buttonAdicionarCompra;
        private Button buttonDeletarCompra;
    }
}
