namespace Atividade4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblQtdFilhos = new System.Windows.Forms.Label();
            this.btnCalcularDesconto = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblAlicotaINSS = new System.Windows.Forms.Label();
            this.lblAlicotaIRPF = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.cxbCasado = new System.Windows.Forms.CheckBox();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroDeFilhos = new System.Windows.Forms.MaskedTextBox();
            this.txtAlicotaINSS = new System.Windows.Forms.MaskedTextBox();
            this.txtALicotaIRPF = new System.Windows.Forms.MaskedTextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.MaskedTextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.MaskedTextBox();
            this.txtDescontoINSS = new System.Windows.Forms.MaskedTextBox();
            this.txtDescontoIRPF = new System.Windows.Forms.MaskedTextBox();
            this.grpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(108, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Funcionario";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(30, 77);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(67, 13);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salário Bruto";
            // 
            // lblQtdFilhos
            // 
            this.lblQtdFilhos.AutoSize = true;
            this.lblQtdFilhos.Location = new System.Drawing.Point(30, 110);
            this.lblQtdFilhos.Name = "lblQtdFilhos";
            this.lblQtdFilhos.Size = new System.Drawing.Size(86, 13);
            this.lblQtdFilhos.TabIndex = 2;
            this.lblQtdFilhos.Text = "Numero de filhos";
            // 
            // btnCalcularDesconto
            // 
            this.btnCalcularDesconto.Location = new System.Drawing.Point(383, 335);
            this.btnCalcularDesconto.Name = "btnCalcularDesconto";
            this.btnCalcularDesconto.Size = new System.Drawing.Size(219, 39);
            this.btnCalcularDesconto.TabIndex = 3;
            this.btnCalcularDesconto.Text = "Calcular Desconto";
            this.btnCalcularDesconto.UseVisualStyleBackColor = true;
            this.btnCalcularDesconto.Click += new System.EventHandler(this.btnCalcularDesconto_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(160, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(30, 191);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(38, 13);
            this.lblDados.TabIndex = 11;
            this.lblDados.Text = "Dados";
            this.lblDados.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAlicotaINSS
            // 
            this.lblAlicotaINSS.AutoSize = true;
            this.lblAlicotaINSS.Location = new System.Drawing.Point(30, 235);
            this.lblAlicotaINSS.Name = "lblAlicotaINSS";
            this.lblAlicotaINSS.Size = new System.Drawing.Size(67, 13);
            this.lblAlicotaINSS.TabIndex = 12;
            this.lblAlicotaINSS.Text = "Alicota INSS";
            // 
            // lblAlicotaIRPF
            // 
            this.lblAlicotaIRPF.AutoSize = true;
            this.lblAlicotaIRPF.Location = new System.Drawing.Point(30, 278);
            this.lblAlicotaIRPF.Name = "lblAlicotaIRPF";
            this.lblAlicotaIRPF.Size = new System.Drawing.Size(66, 13);
            this.lblAlicotaIRPF.TabIndex = 13;
            this.lblAlicotaIRPF.Text = "Alicota IRPF";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(30, 315);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(74, 13);
            this.lblSalarioFamilia.TabIndex = 14;
            this.lblSalarioFamilia.Text = "Sálario Familia";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(30, 356);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioLiquido.TabIndex = 15;
            this.lblSalarioLiquido.Text = "Sálario Liquido";
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdbFeminino);
            this.grpSexo.Controls.Add(this.rdbMasculino);
            this.grpSexo.Location = new System.Drawing.Point(384, 35);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(218, 117);
            this.grpSexo.TabIndex = 16;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(21, 26);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(34, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "M";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(21, 70);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(31, 17);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "F";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // cxbCasado
            // 
            this.cxbCasado.AutoSize = true;
            this.cxbCasado.Location = new System.Drawing.Point(384, 186);
            this.cxbCasado.Name = "cxbCasado";
            this.cxbCasado.Size = new System.Drawing.Size(62, 17);
            this.cxbCasado.TabIndex = 17;
            this.cxbCasado.Text = "Casado";
            this.cxbCasado.UseVisualStyleBackColor = true;
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(381, 241);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescontoINSS.TabIndex = 18;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Location = new System.Drawing.Point(380, 278);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescontoIRPF.TabIndex = 19;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(160, 74);
            this.txtSalarioBruto.Mask = "00000,00";
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(180, 20);
            this.txtSalarioBruto.TabIndex = 22;
            // 
            // txtNumeroDeFilhos
            // 
            this.txtNumeroDeFilhos.Location = new System.Drawing.Point(160, 114);
            this.txtNumeroDeFilhos.Mask = "00000";
            this.txtNumeroDeFilhos.Name = "txtNumeroDeFilhos";
            this.txtNumeroDeFilhos.Size = new System.Drawing.Size(180, 20);
            this.txtNumeroDeFilhos.TabIndex = 23;
            this.txtNumeroDeFilhos.ValidatingType = typeof(int);
            // 
            // txtAlicotaINSS
            // 
            this.txtAlicotaINSS.Enabled = false;
            this.txtAlicotaINSS.Location = new System.Drawing.Point(160, 232);
            this.txtAlicotaINSS.Name = "txtAlicotaINSS";
            this.txtAlicotaINSS.Size = new System.Drawing.Size(180, 20);
            this.txtAlicotaINSS.TabIndex = 24;
            // 
            // txtALicotaIRPF
            // 
            this.txtALicotaIRPF.Enabled = false;
            this.txtALicotaIRPF.Location = new System.Drawing.Point(160, 279);
            this.txtALicotaIRPF.Name = "txtALicotaIRPF";
            this.txtALicotaIRPF.Size = new System.Drawing.Size(180, 20);
            this.txtALicotaIRPF.TabIndex = 25;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Location = new System.Drawing.Point(160, 316);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(180, 20);
            this.txtSalarioFamilia.TabIndex = 26;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(160, 353);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(180, 20);
            this.txtSalarioLiquido.TabIndex = 27;
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Enabled = false;
            this.txtDescontoINSS.Location = new System.Drawing.Point(484, 241);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(118, 20);
            this.txtDescontoINSS.TabIndex = 28;
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Enabled = false;
            this.txtDescontoIRPF.Location = new System.Drawing.Point(484, 275);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.Size = new System.Drawing.Size(118, 20);
            this.txtDescontoIRPF.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(674, 425);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.txtALicotaIRPF);
            this.Controls.Add(this.txtAlicotaINSS);
            this.Controls.Add(this.txtNumeroDeFilhos);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.cxbCasado);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblAlicotaIRPF);
            this.Controls.Add(this.lblAlicotaINSS);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCalcularDesconto);
            this.Controls.Add(this.lblQtdFilhos);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblQtdFilhos;
        private System.Windows.Forms.Button btnCalcularDesconto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblAlicotaINSS;
        private System.Windows.Forms.Label lblAlicotaIRPF;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.CheckBox cxbCasado;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.MaskedTextBox txtSalarioBruto;
        private System.Windows.Forms.MaskedTextBox txtNumeroDeFilhos;
        private System.Windows.Forms.MaskedTextBox txtAlicotaINSS;
        private System.Windows.Forms.MaskedTextBox txtALicotaIRPF;
        private System.Windows.Forms.MaskedTextBox txtSalarioFamilia;
        private System.Windows.Forms.MaskedTextBox txtSalarioLiquido;
        private System.Windows.Forms.MaskedTextBox txtDescontoINSS;
        private System.Windows.Forms.MaskedTextBox txtDescontoIRPF;
    }
}

