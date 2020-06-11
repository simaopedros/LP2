namespace Atividade5
{
    partial class formExercicio4
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
            this.txtTextos = new System.Windows.Forms.RichTextBox();
            this.btnContaNumero = new System.Windows.Forms.Button();
            this.btnLocalizaEspaco = new System.Windows.Forms.Button();
            this.btnContaCaracteres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTextos
            // 
            this.txtTextos.Location = new System.Drawing.Point(47, 37);
            this.txtTextos.Name = "txtTextos";
            this.txtTextos.Size = new System.Drawing.Size(455, 96);
            this.txtTextos.TabIndex = 0;
            this.txtTextos.Text = "";
            this.txtTextos.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnContaNumero
            // 
            this.btnContaNumero.Location = new System.Drawing.Point(47, 184);
            this.btnContaNumero.Name = "btnContaNumero";
            this.btnContaNumero.Size = new System.Drawing.Size(138, 66);
            this.btnContaNumero.TabIndex = 1;
            this.btnContaNumero.Text = "Conta Numeros";
            this.btnContaNumero.UseVisualStyleBackColor = true;
            this.btnContaNumero.Click += new System.EventHandler(this.btnContaNumero_Click);
            // 
            // btnLocalizaEspaco
            // 
            this.btnLocalizaEspaco.Location = new System.Drawing.Point(206, 184);
            this.btnLocalizaEspaco.Name = "btnLocalizaEspaco";
            this.btnLocalizaEspaco.Size = new System.Drawing.Size(128, 66);
            this.btnLocalizaEspaco.TabIndex = 2;
            this.btnLocalizaEspaco.Text = "Localiza Primeir Espaco";
            this.btnLocalizaEspaco.UseVisualStyleBackColor = true;
            // 
            // btnContaCaracteres
            // 
            this.btnContaCaracteres.Location = new System.Drawing.Point(357, 184);
            this.btnContaCaracteres.Name = "btnContaCaracteres";
            this.btnContaCaracteres.Size = new System.Drawing.Size(145, 66);
            this.btnContaCaracteres.TabIndex = 3;
            this.btnContaCaracteres.Text = "Conta Caracteres";
            this.btnContaCaracteres.UseVisualStyleBackColor = true;
            this.btnContaCaracteres.Click += new System.EventHandler(this.button3_Click);
            // 
            // formExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 336);
            this.Controls.Add(this.btnContaCaracteres);
            this.Controls.Add(this.btnLocalizaEspaco);
            this.Controls.Add(this.btnContaNumero);
            this.Controls.Add(this.txtTextos);
            this.Name = "formExercicio4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.formExercicio4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTextos;
        private System.Windows.Forms.Button btnContaNumero;
        private System.Windows.Forms.Button btnLocalizaEspaco;
        private System.Windows.Forms.Button btnContaCaracteres;
    }
}