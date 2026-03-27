namespace Exercicio02_Listadetenis
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
            this.lsttenis = new System.Windows.Forms.ListBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblfrase = new System.Windows.Forms.Label();
            this.btnlimpartela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsttenis
            // 
            this.lsttenis.FormattingEnabled = true;
            this.lsttenis.Location = new System.Drawing.Point(96, 78);
            this.lsttenis.Name = "lsttenis";
            this.lsttenis.Size = new System.Drawing.Size(220, 134);
            this.lsttenis.TabIndex = 0;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(360, 234);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 1;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(258, 234);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(75, 23);
            this.btnremover.TabIndex = 2;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de tenis:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(96, 236);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(111, 20);
            this.txtnome.TabIndex = 4;
            // 
            // lblfrase
            // 
            this.lblfrase.AutoSize = true;
            this.lblfrase.Location = new System.Drawing.Point(93, 270);
            this.lblfrase.Name = "lblfrase";
            this.lblfrase.Size = new System.Drawing.Size(0, 13);
            this.lblfrase.TabIndex = 5;
            // 
            // btnlimpartela
            // 
            this.btnlimpartela.Location = new System.Drawing.Point(315, 282);
            this.btnlimpartela.Name = "btnlimpartela";
            this.btnlimpartela.Size = new System.Drawing.Size(75, 23);
            this.btnlimpartela.TabIndex = 6;
            this.btnlimpartela.Text = "Limpar";
            this.btnlimpartela.UseVisualStyleBackColor = true;
            this.btnlimpartela.Click += new System.EventHandler(this.btnlimpartela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.btnlimpartela);
            this.Controls.Add(this.lblfrase);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.lsttenis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsttenis;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblfrase;
        private System.Windows.Forms.Button btnlimpartela;
    }
}

