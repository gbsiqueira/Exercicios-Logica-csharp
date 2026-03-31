namespace Exercicio05_POO_Encapsulamento_Banco
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
            this.lblsaldo = new System.Windows.Forms.Label();
            this.btndepositar = new System.Windows.Forms.Button();
            this.btnsacar = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaldo.Location = new System.Drawing.Point(120, 64);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(61, 18);
            this.lblsaldo.TabIndex = 0;
            this.lblsaldo.Text = "R$0,00";
            // 
            // btndepositar
            // 
            this.btndepositar.Location = new System.Drawing.Point(60, 140);
            this.btndepositar.Name = "btndepositar";
            this.btndepositar.Size = new System.Drawing.Size(86, 30);
            this.btndepositar.TabIndex = 1;
            this.btndepositar.Text = "Depositar";
            this.btndepositar.UseVisualStyleBackColor = true;
            // 
            // btnsacar
            // 
            this.btnsacar.Location = new System.Drawing.Point(170, 140);
            this.btnsacar.Name = "btnsacar";
            this.btnsacar.Size = new System.Drawing.Size(86, 30);
            this.btnsacar.TabIndex = 2;
            this.btnsacar.Text = "Sacar";
            this.btnsacar.UseVisualStyleBackColor = true;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(102, 103);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Saldo no banco";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.btnsacar);
            this.Controls.Add(this.btndepositar);
            this.Controls.Add(this.lblsaldo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.Button btndepositar;
        private System.Windows.Forms.Button btnsacar;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label1;
    }
}

