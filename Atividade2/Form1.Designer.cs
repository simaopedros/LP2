namespace Atividade2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnMasc = new System.Windows.Forms.RadioButton();
            this.rdbtnFem = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbnAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblResultadoCalculo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPesoAtual = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnFem);
            this.groupBox1.Controls.Add(this.rdbtnMasc);
            this.groupBox1.Location = new System.Drawing.Point(28, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbtnMasc
            // 
            this.rdbtnMasc.AutoSize = true;
            this.rdbtnMasc.Location = new System.Drawing.Point(18, 35);
            this.rdbtnMasc.Name = "rdbtnMasc";
            this.rdbtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rdbtnMasc.TabIndex = 2;
            this.rdbtnMasc.TabStop = true;
            this.rdbtnMasc.Text = "Masculino";
            this.rdbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rdbtnFem
            // 
            this.rdbtnFem.AutoSize = true;
            this.rdbtnFem.Location = new System.Drawing.Point(18, 58);
            this.rdbtnFem.Name = "rdbtnFem";
            this.rdbtnFem.Size = new System.Drawing.Size(67, 17);
            this.rdbtnFem.TabIndex = 3;
            this.rdbtnFem.TabStop = true;
            this.rdbtnFem.Text = "Feminino";
            this.rdbtnFem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Calculo de IMC";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbnAltura
            // 
            this.lbnAltura.AutoSize = true;
            this.lbnAltura.Location = new System.Drawing.Point(30, 218);
            this.lbnAltura.Name = "lbnAltura";
            this.lbnAltura.Size = new System.Drawing.Size(34, 13);
            this.lbnAltura.TabIndex = 2;
            this.lbnAltura.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(93, 214);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(76, 20);
            this.txtAltura.TabIndex = 3;
            // 
            // lblResultadoCalculo
            // 
            this.lblResultadoCalculo.AutoSize = true;
            this.lblResultadoCalculo.Location = new System.Drawing.Point(30, 249);
            this.lblResultadoCalculo.Name = "lblResultadoCalculo";
            this.lblResultadoCalculo.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoCalculo.TabIndex = 5;
            this.lblResultadoCalculo.Text = "label4";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(32, 293);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(137, 32);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(29, 188);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(58, 13);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso Atual";
            // 
            // txtPesoAtual
            // 
            this.txtPesoAtual.Location = new System.Drawing.Point(93, 181);
            this.txtPesoAtual.Name = "txtPesoAtual";
            this.txtPesoAtual.Size = new System.Drawing.Size(76, 20);
            this.txtPesoAtual.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 357);
            this.Controls.Add(this.txtPesoAtual);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultadoCalculo);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lbnAltura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnFem;
        private System.Windows.Forms.RadioButton rdbtnMasc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbnAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblResultadoCalculo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPesoAtual;
    }
}

