namespace TN01_WFCadastroContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblNome = new Label();
            txtNome = new TextBox();
            lblSobrenome = new Label();
            txtSobrenome = new TextBox();
            lblDDD = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            mkdTelefone = new MaskedTextBox();
            rdbPessoal = new RadioButton();
            rdbComercial = new RadioButton();
            rdbRecado = new RadioButton();
            label1 = new Label();
            btnSalvar = new Button();
            btnVoltar = new Button();
            label2 = new Label();
            label3 = new Label();
            gbxTelefone = new GroupBox();
            gbxTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(46, 34);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(45, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(140, 23);
            txtNome.TabIndex = 1;
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(230, 34);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(71, 15);
            lblSobrenome.TabIndex = 2;
            lblSobrenome.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(230, 52);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(282, 23);
            txtSobrenome.TabIndex = 3;
            // 
            // lblDDD
            // 
            lblDDD.AutoSize = true;
            lblDDD.Location = new Point(45, 118);
            lblDDD.Name = "lblDDD";
            lblDDD.Size = new Size(83, 15);
            lblDDD.TabIndex = 4;
            lblDDD.Text = "DDD/Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(46, 227);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(46, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(358, 23);
            txtEmail.TabIndex = 7;
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(45, 136);
            mkdTelefone.Mask = "(99) 00000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(100, 23);
            mkdTelefone.TabIndex = 8;
            mkdTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(7, 32);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 10;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(96, 32);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 11;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(218, 32);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 12;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 91);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 13;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(437, 288);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(92, 37);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(326, 288);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(91, 37);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(1, 92);
            label2.Name = "label2";
            label2.Size = new Size(555, 14);
            label2.TabIndex = 16;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(1, 214);
            label3.Name = "label3";
            label3.Size = new Size(555, 13);
            label3.TabIndex = 17;
            // 
            // gbxTelefone
            // 
            gbxTelefone.Controls.Add(rdbPessoal);
            gbxTelefone.Controls.Add(rdbRecado);
            gbxTelefone.Controls.Add(rdbComercial);
            gbxTelefone.Location = new Point(230, 118);
            gbxTelefone.Name = "gbxTelefone";
            gbxTelefone.Size = new Size(299, 79);
            gbxTelefone.TabIndex = 18;
            gbxTelefone.TabStop = false;
            gbxTelefone.Text = "Tipo Telefone";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 337);
            Controls.Add(gbxTelefone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(mkdTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblDDD);
            Controls.Add(txtSobrenome);
            Controls.Add(lblSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Cadastrar Contato";
            gbxTelefone.ResumeLayout(false);
            gbxTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblSobrenome;
        private TextBox txtSobrenome;
        private Label lblDDD;
        private Label lblEmail;
        private TextBox txtEmail;
        private MaskedTextBox mkdTelefone;
        private RadioButton rdbPessoal;
        private RadioButton rdbComercial;
        private RadioButton rdbRecado;
        private Label label1;
        private Button btnSalvar;
        private Button btnVoltar;
        private Label label2;
        private Label label3;
        private GroupBox gbxTelefone;
    }
}
