﻿namespace WFCadastroProduto
{
    partial class FormCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            btnSalvar = new Button();
            lblCodigo = new Label();
            lblCategoria = new Label();
            lblNomeProduto = new Label();
            lblPreco = new Label();
            lblDataVencimento = new Label();
            lblObservacao = new Label();
            rtbObservacao = new RichTextBox();
            txtCodigo = new TextBox();
            txtNomeProduto = new TextBox();
            dtpVencimento = new DateTimePicker();
            cbxCategoria = new ComboBox();
            nudPreco = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(106, 333);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 42);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 31);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(152, 31);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(12, 97);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(103, 15);
            lblNomeProduto.TabIndex = 3;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(12, 152);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço";
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Location = new Point(152, 152);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(113, 15);
            lblDataVencimento.TabIndex = 5;
            lblDataVencimento.Text = "Data de Vencimento";
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(12, 216);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(69, 15);
            lblObservacao.TabIndex = 6;
            lblObservacao.Text = "Observação";
            // 
            // rtbObservacao
            // 
            rtbObservacao.BackColor = Color.Lavender;
            rtbObservacao.Location = new Point(12, 234);
            rtbObservacao.Name = "rtbObservacao";
            rtbObservacao.Size = new Size(263, 83);
            rtbObservacao.TabIndex = 6;
            rtbObservacao.Text = "";
            // 
            // txtCodigo
            // 
            txtCodigo.ImeMode = ImeMode.NoControl;
            txtCodigo.Location = new Point(12, 49);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(103, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(12, 115);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(263, 23);
            txtNomeProduto.TabIndex = 3;
            // 
            // dtpVencimento
            // 
            dtpVencimento.Format = DateTimePickerFormat.Short;
            dtpVencimento.Location = new Point(152, 174);
            dtpVencimento.Name = "dtpVencimento";
            dtpVencimento.Size = new Size(123, 23);
            dtpVencimento.TabIndex = 5;
            // 
            // cbxCategoria
            // 
            cbxCategoria.AccessibleRole = AccessibleRole.None;
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Alimentos Basicos", "Bebidas", "Doces", "Higiene", "Hortifruti" });
            cbxCategoria.Location = new Point(152, 49);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(123, 23);
            cbxCategoria.TabIndex = 2;
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            nudPreco.Location = new Point(12, 174);
            nudPreco.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(103, 23);
            nudPreco.TabIndex = 4;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 387);
            Controls.Add(nudPreco);
            Controls.Add(cbxCategoria);
            Controls.Add(dtpVencimento);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtCodigo);
            Controls.Add(rtbObservacao);
            Controls.Add(lblObservacao);
            Controls.Add(lblDataVencimento);
            Controls.Add(lblPreco);
            Controls.Add(lblNomeProduto);
            Controls.Add(lblCategoria);
            Controls.Add(lblCodigo);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastroProduto";
            Load += FormCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Label lblCodigo;
        private Label lblCategoria;
        private Label lblNomeProduto;
        private Label lblPreco;
        private Label lblDataVencimento;
        private Label lblObservacao;
        private RichTextBox rtbObservacao;
        private TextBox txtCodigo;
        private TextBox txtNomeProduto;
        private DateTimePicker dtpVencimento;
        private ComboBox cbxCategoria;
        private NumericUpDown nudPreco;
    }
}