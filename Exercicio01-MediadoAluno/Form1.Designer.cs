namespace Exercicio01_MediadoAluno
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
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsituacao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnlimpartd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(53, 179);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(100, 20);
            this.txtnota1.TabIndex = 0;
            this.txtnota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota1_KeyPress);
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(191, 179);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 20);
            this.txtnota2.TabIndex = 1;
            this.txtnota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota2_KeyPress);
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(334, 179);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(100, 20);
            this.txtnota3.TabIndex = 2;
            this.txtnota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota3_KeyPress);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(320, 223);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(100, 33);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular Média";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota (1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota (2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota (3)";
            // 
            // txtmedia
            // 
            this.txtmedia.Enabled = false;
            this.txtmedia.Location = new System.Drawing.Point(81, 230);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(100, 20);
            this.txtmedia.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Média da Nota";
            // 
            // lblsituacao
            // 
            this.lblsituacao.AutoSize = true;
            this.lblsituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsituacao.Location = new System.Drawing.Point(202, 231);
            this.lblsituacao.Name = "lblsituacao";
            this.lblsituacao.Size = new System.Drawing.Size(0, 16);
            this.lblsituacao.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Insira três notas para calcular a média e ver a situação do aluno:";
            // 
            // btnlimpartd
            // 
            this.btnlimpartd.Location = new System.Drawing.Point(334, 279);
            this.btnlimpartd.Name = "btnlimpartd";
            this.btnlimpartd.Size = new System.Drawing.Size(76, 23);
            this.btnlimpartd.TabIndex = 11;
            this.btnlimpartd.Text = "Limpar tudo";
            this.btnlimpartd.UseVisualStyleBackColor = true;
            this.btnlimpartd.Click += new System.EventHandler(this.btnlimpartd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.btnlimpartd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsituacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnlimpartd;
    }
}

