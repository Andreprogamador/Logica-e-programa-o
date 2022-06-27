namespace While
{
    partial class FrmWhile
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
            this.lblMultiplus = new System.Windows.Forms.Label();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.btnMultiplos = new System.Windows.Forms.Button();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMultiplus
            // 
            this.lblMultiplus.AutoSize = true;
            this.lblMultiplus.Location = new System.Drawing.Point(22, 34);
            this.lblMultiplus.Name = "lblMultiplus";
            this.lblMultiplus.Size = new System.Drawing.Size(460, 37);
            this.lblMultiplus.TabIndex = 0;
            this.lblMultiplus.Text = "Mostrar os múltiplos de 3 de 1 a 99";
            this.lblMultiplus.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Location = new System.Drawing.Point(22, 142);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(454, 37);
            this.lblNumeros.TabIndex = 1;
            this.lblNumeros.Text = "Mostrar os números de 100 a 1000";
            // 
            // lblAlunos
            // 
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Location = new System.Drawing.Point(22, 248);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(236, 37);
            this.lblAlunos.TabIndex = 2;
            this.lblAlunos.Text = "Notas dos alunos";
            // 
            // btnMultiplos
            // 
            this.btnMultiplos.BackColor = System.Drawing.Color.Maroon;
            this.btnMultiplos.Location = new System.Drawing.Point(29, 74);
            this.btnMultiplos.Name = "btnMultiplos";
            this.btnMultiplos.Size = new System.Drawing.Size(142, 50);
            this.btnMultiplos.TabIndex = 3;
            this.btnMultiplos.Text = "button1";
            this.btnMultiplos.UseVisualStyleBackColor = false;
            this.btnMultiplos.Click += new System.EventHandler(this.btnMultiplos_Click);
            // 
            // btnNumeros
            // 
            this.btnNumeros.BackColor = System.Drawing.Color.Maroon;
            this.btnNumeros.Location = new System.Drawing.Point(29, 182);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(142, 50);
            this.btnNumeros.TabIndex = 4;
            this.btnNumeros.Text = "button2";
            this.btnNumeros.UseVisualStyleBackColor = false;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackColor = System.Drawing.Color.Maroon;
            this.btnAlunos.Location = new System.Drawing.Point(29, 288);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(142, 50);
            this.btnAlunos.TabIndex = 5;
            this.btnAlunos.Text = "button3";
            this.btnAlunos.UseVisualStyleBackColor = false;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // FrmWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(646, 363);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.btnMultiplos);
            this.Controls.Add(this.lblAlunos);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.lblMultiplus);
            this.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmWhile";
            this.Text = "While";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMultiplus;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Button btnMultiplos;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Button btnAlunos;
    }
}

