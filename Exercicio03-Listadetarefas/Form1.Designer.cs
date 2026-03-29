namespace Exercicio03_Listadetarefas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttarefa = new System.Windows.Forms.TextBox();
            this.btnadcionar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.lsttarefas = new System.Windows.Forms.ListBox();
            this.lblacao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsttarefas);
            this.groupBox2.Location = new System.Drawing.Point(105, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 273);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txttarefa
            // 
            this.txttarefa.Location = new System.Drawing.Point(25, 28);
            this.txttarefa.Name = "txttarefa";
            this.txttarefa.Size = new System.Drawing.Size(100, 20);
            this.txttarefa.TabIndex = 1;
            // 
            // btnadcionar
            // 
            this.btnadcionar.Location = new System.Drawing.Point(143, 26);
            this.btnadcionar.Name = "btnadcionar";
            this.btnadcionar.Size = new System.Drawing.Size(75, 23);
            this.btnadcionar.TabIndex = 2;
            this.btnadcionar.Text = "Adicionar";
            this.btnadcionar.UseVisualStyleBackColor = true;
            this.btnadcionar.Click += new System.EventHandler(this.btnadcionar_Click);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(25, 91);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(75, 23);
            this.btnremover.TabIndex = 3;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(143, 91);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 4;
            this.btnlimpar.Text = "Atualizar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // lsttarefas
            // 
            this.lsttarefas.FormattingEnabled = true;
            this.lsttarefas.Location = new System.Drawing.Point(41, 32);
            this.lsttarefas.Name = "lsttarefas";
            this.lsttarefas.Size = new System.Drawing.Size(346, 212);
            this.lsttarefas.TabIndex = 0;
            // 
            // lblacao
            // 
            this.lblacao.AutoSize = true;
            this.lblacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacao.Location = new System.Drawing.Point(553, 215);
            this.lblacao.Name = "lblacao";
            this.lblacao.Size = new System.Drawing.Size(0, 15);
            this.lblacao.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttarefa);
            this.groupBox1.Controls.Add(this.btnadcionar);
            this.groupBox1.Controls.Add(this.btnlimpar);
            this.groupBox1.Controls.Add(this.btnremover);
            this.groupBox1.Location = new System.Drawing.Point(553, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 134);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista de Tarefas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblacao);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttarefa;
        private System.Windows.Forms.ListBox lsttarefas;
        private System.Windows.Forms.Button btnadcionar;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label lblacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

