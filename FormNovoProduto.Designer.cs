namespace AplicativoComMultiplasJanelas
{
    partial class FormNovoProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNomeDoProduto = new Label();
            textBoxNome = new TextBox();
            labelFabricante = new Label();
            textBoxFabricante = new TextBox();
            labelPrecodeCompra = new Label();
            labelPrecoVenda = new Label();
            numericUpDownPrecoCompra = new NumericUpDown();
            numericUpDownPrecoVenda = new NumericUpDown();
            ButtonOk = new Button();
            ButtonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoVenda).BeginInit();
            SuspendLayout();
            // 
            // labelNomeDoProduto
            // 
            labelNomeDoProduto.AutoSize = true;
            labelNomeDoProduto.BackColor = SystemColors.ActiveCaption;
            labelNomeDoProduto.Location = new Point(12, 9);
            labelNomeDoProduto.Name = "labelNomeDoProduto";
            labelNomeDoProduto.Size = new Size(106, 15);
            labelNomeDoProduto.TabIndex = 0;
            labelNomeDoProduto.Text = "Nome do Produto:";
            // 
            // textBoxNome
            // 
            textBoxNome.BackColor = Color.FromArgb(255, 255, 192);
            textBoxNome.Location = new Point(124, 6);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(120, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelFabricante
            // 
            labelFabricante.AutoSize = true;
            labelFabricante.BackColor = SystemColors.ActiveCaption;
            labelFabricante.Location = new Point(12, 46);
            labelFabricante.Name = "labelFabricante";
            labelFabricante.Size = new Size(65, 15);
            labelFabricante.TabIndex = 2;
            labelFabricante.Text = "Fabricante:";
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.BackColor = Color.FromArgb(255, 255, 192);
            textBoxFabricante.Location = new Point(124, 46);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(120, 23);
            textBoxFabricante.TabIndex = 3;
            // 
            // labelPrecodeCompra
            // 
            labelPrecodeCompra.AutoSize = true;
            labelPrecodeCompra.BackColor = SystemColors.ActiveCaption;
            labelPrecodeCompra.Location = new Point(12, 87);
            labelPrecodeCompra.Name = "labelPrecodeCompra";
            labelPrecodeCompra.Size = new Size(102, 15);
            labelPrecodeCompra.TabIndex = 4;
            labelPrecodeCompra.Text = "Preço de Compra:";
            // 
            // labelPrecoVenda
            // 
            labelPrecoVenda.AutoSize = true;
            labelPrecoVenda.BackColor = SystemColors.ActiveCaption;
            labelPrecoVenda.Location = new Point(12, 129);
            labelPrecoVenda.Name = "labelPrecoVenda";
            labelPrecoVenda.Size = new Size(91, 15);
            labelPrecoVenda.TabIndex = 6;
            labelPrecoVenda.Text = "Preço de Venda:";
            // 
            // numericUpDownPrecoCompra
            // 
            numericUpDownPrecoCompra.BackColor = Color.FromArgb(255, 255, 192);
            numericUpDownPrecoCompra.DecimalPlaces = 2;
            numericUpDownPrecoCompra.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownPrecoCompra.Location = new Point(124, 85);
            numericUpDownPrecoCompra.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrecoCompra.Name = "numericUpDownPrecoCompra";
            numericUpDownPrecoCompra.Size = new Size(120, 23);
            numericUpDownPrecoCompra.TabIndex = 8;
            numericUpDownPrecoCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownPrecoVenda
            // 
            numericUpDownPrecoVenda.BackColor = Color.FromArgb(255, 255, 192);
            numericUpDownPrecoVenda.DecimalPlaces = 2;
            numericUpDownPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownPrecoVenda.Location = new Point(124, 121);
            numericUpDownPrecoVenda.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrecoVenda.Name = "numericUpDownPrecoVenda";
            numericUpDownPrecoVenda.Size = new Size(120, 23);
            numericUpDownPrecoVenda.TabIndex = 9;
            numericUpDownPrecoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // ButtonOk
            // 
            ButtonOk.BackColor = SystemColors.ActiveCaption;
            ButtonOk.Location = new Point(288, 152);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(75, 23);
            ButtonOk.TabIndex = 10;
            ButtonOk.Text = "Ok";
            ButtonOk.UseVisualStyleBackColor = false;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.BackColor = Color.FromArgb(255, 192, 192);
            ButtonCancelar.Location = new Point(369, 152);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(75, 23);
            ButtonCancelar.TabIndex = 11;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = false;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // FormNovoProduto
            // 
            AcceptButton = ButtonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ButtonCancelar;
            ClientSize = new Size(459, 180);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonOk);
            Controls.Add(numericUpDownPrecoVenda);
            Controls.Add(numericUpDownPrecoCompra);
            Controls.Add(labelPrecoVenda);
            Controls.Add(labelPrecodeCompra);
            Controls.Add(textBoxFabricante);
            Controls.Add(labelFabricante);
            Controls.Add(textBoxNome);
            Controls.Add(labelNomeDoProduto);
            Name = "FormNovoProduto";
            Text = "FormNovoProduto";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNomeDoProduto;
        private TextBox textBoxNome;
        private Label labelFabricante;
        private TextBox textBoxFabricante;
        private Label labelPrecodeCompra;
        private Label labelPrecoVenda;
        private TextBox textBox4;
        private NumericUpDown numericUpDownPrecoCompra;
        private NumericUpDown numericUpDownPrecoVenda;
        private Button ButtonOk;
        private Button ButtonCancelar;
    }
}