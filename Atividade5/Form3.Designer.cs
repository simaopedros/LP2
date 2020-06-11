namespace Atividade5
{
    partial class FormExercicio3
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
            this.txtTexto01 = new System.Windows.Forms.TextBox();
            this.txtTexto02 = new System.Windows.Forms.TextBox();
            this.lblTexto01 = new System.Windows.Forms.Label();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto01
            // 
            this.txtTexto01.Location = new System.Drawing.Point(57, 41);
            this.txtTexto01.Name = "txtTexto01";
            this.txtTexto01.Size = new System.Drawing.Size(309, 20);
            this.txtTexto01.TabIndex = 0;
            this.txtTexto01.TextChanged += new System.EventHandler(this.txtTexto01_TextChanged);
            // 
            // txtTexto02
            // 
            this.txtTexto02.Location = new System.Drawing.Point(57, 93);
            this.txtTexto02.Name = "txtTexto02";
            this.txtTexto02.Size = new System.Drawing.Size(309, 20);
            this.txtTexto02.TabIndex = 1;
            this.txtTexto02.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblTexto01
            // 
            this.lblTexto01.AutoSize = true;
            this.lblTexto01.Location = new System.Drawing.Point(57, 17);
            this.lblTexto01.Name = "lblTexto01";
            this.lblTexto01.Size = new System.Drawing.Size(35, 13);
            this.lblTexto01.TabIndex = 2;
            this.lblTexto01.Text = "label1";
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Location = new System.Drawing.Point(56, 73);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(35, 13);
            this.lblTexto2.TabIndex = 3;
            this.lblTexto2.Text = "label2";
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(57, 146);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(89, 68);
            this.btn01.TabIndex = 4;
            this.btn01.Text = "Remove TEXTO do TEXO 2";
            this.btn01.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(166, 146);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(87, 68);
            this.btn02.TabIndex = 5;
            this.btn02.Text = "Remove TEXTO do TEXO 2 - Replace";
            this.btn02.UseVisualStyleBackColor = true;
            // 
            // btn03
            // 
            this.btn03.Location = new System.Drawing.Point(275, 146);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(90, 68);
            this.btn03.TabIndex = 6;
            this.btn03.Text = "Inverte TEXTO 1";
            this.btn03.UseVisualStyleBackColor = true;
            // 
            // FormExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.lblTexto01);
            this.Controls.Add(this.txtTexto02);
            this.Controls.Add(this.txtTexto01);
            this.Name = "FormExercicio3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto01;
        private System.Windows.Forms.TextBox txtTexto02;
        private System.Windows.Forms.Label lblTexto01;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn03;
    }
}