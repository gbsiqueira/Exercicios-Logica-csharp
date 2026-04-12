namespace Exercicio05_POO_encapsulamento
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
            this.lst = new System.Windows.Forms.ListBox();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnretirar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(72, 82);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(188, 160);
            this.lst.TabIndex = 0;
            // 
            // txtsaldo
            // 
            this.txtsaldo.Location = new System.Drawing.Point(43, 32);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(100, 20);
            this.txtsaldo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Simulando um mini banco com POO encapsulamento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnatualizar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnretirar);
            this.groupBox1.Controls.Add(this.btnadicionar);
            this.groupBox1.Controls.Add(this.txtsaldo);
            this.groupBox1.Location = new System.Drawing.Point(304, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(20, 71);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 34);
            this.btnadicionar.TabIndex = 0;
            this.btnadicionar.Text = "Adicionar Saldo";
            this.btnadicionar.UseVisualStyleBackColor = true;
            // 
            // btnretirar
            // 
            this.btnretirar.Location = new System.Drawing.Point(101, 71);
            this.btnretirar.Name = "btnretirar";
            this.btnretirar.Size = new System.Drawing.Size(75, 34);
            this.btnretirar.TabIndex = 1;
            this.btnretirar.Text = "Remover Saldo";
            this.btnretirar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insira o Valor:";
            // 
            // btnatualizar
            // 
            this.btnatualizar.Location = new System.Drawing.Point(200, 77);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(75, 23);
            this.btnatualizar.TabIndex = 5;
            this.btnatualizar.Text = "Atualizar Lista";
            this.btnatualizar.UseVisualStyleBackColor = true;
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaldo.Location = new System.Drawing.Point(301, 208);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(0, 16);
            this.lblsaldo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.lblsaldo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnretirar;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Label lblsaldo;
    }
}

