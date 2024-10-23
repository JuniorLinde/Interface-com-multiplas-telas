namespace AplicativoComVariasJanelas
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
            labelNome = new Label();
            labelFabricante = new Label();
            labelPrecoCompra = new Label();
            labelPrecoVenda = new Label();
            textBoxNome = new TextBox();
            textBoxFabricante = new TextBox();
            numericUpDownPrecoCompra = new NumericUpDown();
            numericUpDownPrecoVenda = new NumericUpDown();
            buttonOK = new Button();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoVenda).BeginInit();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 26);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(132, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome do Produto:";
            // 
            // labelFabricante
            // 
            labelFabricante.AutoSize = true;
            labelFabricante.Location = new Point(12, 86);
            labelFabricante.Name = "labelFabricante";
            labelFabricante.Size = new Size(80, 20);
            labelFabricante.TabIndex = 1;
            labelFabricante.Text = "Fabricante:";
            // 
            // labelPrecoCompra
            // 
            labelPrecoCompra.AutoSize = true;
            labelPrecoCompra.Location = new Point(12, 142);
            labelPrecoCompra.Name = "labelPrecoCompra";
            labelPrecoCompra.Size = new Size(127, 20);
            labelPrecoCompra.TabIndex = 2;
            labelPrecoCompra.Text = "Preço de Compra:\r\n";
            // 
            // labelPrecoVenda
            // 
            labelPrecoVenda.AutoSize = true;
            labelPrecoVenda.Location = new Point(13, 213);
            labelPrecoVenda.Name = "labelPrecoVenda";
            labelPrecoVenda.Size = new Size(115, 20);
            labelPrecoVenda.TabIndex = 3;
            labelPrecoVenda.Text = "Preço de Venda:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(186, 23);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(150, 27);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Location = new Point(186, 80);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(150, 27);
            textBoxFabricante.TabIndex = 5;
            // 
            // numericUpDownPrecoCompra
            // 
            numericUpDownPrecoCompra.DecimalPlaces = 2;
            numericUpDownPrecoCompra.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownPrecoCompra.Location = new Point(186, 142);
            numericUpDownPrecoCompra.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrecoCompra.Name = "numericUpDownPrecoCompra";
            numericUpDownPrecoCompra.Size = new Size(150, 27);
            numericUpDownPrecoCompra.TabIndex = 6;
            numericUpDownPrecoCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownPrecoVenda
            // 
            numericUpDownPrecoVenda.DecimalPlaces = 2;
            numericUpDownPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownPrecoVenda.Location = new Point(186, 206);
            numericUpDownPrecoVenda.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrecoVenda.Name = "numericUpDownPrecoVenda";
            numericUpDownPrecoVenda.Size = new Size(150, 27);
            numericUpDownPrecoVenda.TabIndex = 7;
            numericUpDownPrecoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(369, 251);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 8;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(481, 251);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormNovoProduto
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(648, 310);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOK);
            Controls.Add(numericUpDownPrecoVenda);
            Controls.Add(numericUpDownPrecoCompra);
            Controls.Add(textBoxFabricante);
            Controls.Add(textBoxNome);
            Controls.Add(labelPrecoVenda);
            Controls.Add(labelPrecoCompra);
            Controls.Add(labelFabricante);
            Controls.Add(labelNome);
            Name = "FormNovoProduto";
            Text = "FormNovoProduto";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelFabricante;
        private Label labelPrecoCompra;
        private Label labelPrecoVenda;
        private TextBox textBoxNome;
        private TextBox textBoxFabricante;
        private NumericUpDown numericUpDownPrecoCompra;
        private NumericUpDown numericUpDownPrecoVenda;
        private Button buttonOK;
        private Button buttonCancelar;
    }
}