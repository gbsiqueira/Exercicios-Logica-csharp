using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio01_MediadoAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {   //NAO DEIXA OS CAMPOS EM BRANCO
            if (string.IsNullOrWhiteSpace(txtnota1.Text) || string.IsNullOrWhiteSpace(txtnota2.Text) || string.IsNullOrWhiteSpace(txtnota3.Text))
            {
                MessageBox.Show("Favor informe todos os valores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnota1.Focus();
                txtnota1.BackColor = Color.Red;
                txtnota2.BackColor = Color.Red;
                txtnota3.BackColor = Color.Red;

                return;
            }
            //CRIANDO E DECLARANDO AS VARIAVEIS
            double nota1 = Convert.ToDouble(txtnota1.Text);
            double nota2 = Convert.ToDouble(txtnota2.Text);
            double nota3 = Convert.ToDouble(txtnota3.Text);
            //COLOCANDO UM INTERVALO DE NUMEROS PARA ELAS
            if (nota1 >= 0 && nota1 < 11 && nota2 >= 0 && nota2 < 11 && nota3 >= 0 && nota3 < 11)
            {   //LIMPANDPO AS TXTBOX
                txtnota1.BackColor = Color.White;
                txtnota2.BackColor = Color.White;
                txtnota3.BackColor = Color.White;
                //CRIANDO E CHAMANDO AS FUNÇOES E ATRIBUINDO VALORES AS VARIAVEIS DELAS
                double resultadomedia = Calculomedia(nota1, nota2, nota3);
                txtmedia.Text = resultadomedia.ToString("F1");
                string resultadotexto = Calculotexto(resultadomedia);
                lblsituacao.Text = resultadotexto;

            }
            else
            {   //MENSAGEM CASO O NUMERO ESTEJA FORA DESSE INTERVALO
                MessageBox.Show("Apenas Numeros entre 10 e 0", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnota1.Focus();
                txtnota1.BackColor = Color.Red;
                txtnota2.BackColor = Color.Red;
                txtnota3.BackColor = Color.Red;

                return;
            }

        }
        //FUNÇÃO DE CALCULAR A MEDIA
        private double Calculomedia(double nota1, double nota2, double nota3)
        {
            double resultado = 0;
            resultado = (nota1 + nota2 + nota3) / 3;
            return resultado;
        }
        //FUNÇÃO DE TEXTO DA SITUAÇÃO
        private string Calculotexto(double nota)
        {
            if (nota >= 7)
            {
                lblsituacao.ForeColor = Color.Blue;
                return "aprovado";
            }
            else if (nota >= 5)
            {
                lblsituacao.ForeColor = Color.Yellow;
                return "Recuperação";
            }
            else
            {
                lblsituacao.ForeColor = Color.Red;
                return "Reprovado";
            }

        }
        //TXTBOX1
        private void txtnota1_KeyPress(object sender, KeyPressEventArgs e)
        {


            // VERIFICA SE NAO E NUMERO, BACKSPACE E VIRGULA
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                // SE PASSAR E BLOQUEADA
                e.Handled = true;
            }

            // EVITA O USUARIO COLOCAR MAIS DE UMA VIRGULA
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }


        }
        //TXTBOX2
        private void txtnota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // VERIFICA SE NAO E NUMERO, BACKSPACE E VIRGULA
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                // SE PASSAR E BLOQUEADA
                e.Handled = true;
            }

            // EVITA O USUARIO COLOCAR MAIS DE UMA VIRGULA
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }
        //TXTBOX3
        private void txtnota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VERIFICA SE NAO E NUMERO, BACKSPACE E VIRGULA
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                // SE PASSAR E BLOQUEADA
                e.Handled = true;
            }

            // EVITA O USUARIO COLOCAR MAIS DE UMA VIRGULA
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }
        
        //BOTAO LIMPAR
        private void btnlimpartd_Click(object sender, EventArgs e)
        {
            //LIMPA OS ITENS DA TXTBOX
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            //LIMPA A MEDIA E A SITUAÇÃO
            txtmedia.Clear();
            lblsituacao.Text = "";
            lblsituacao.ForeColor = Color.Black;
            //CORES DO FUNDO BRANCAS
            txtnota1.BackColor = Color.White;
            txtnota2.BackColor = Color.White;
            txtnota3.BackColor = Color.White;
            //VOLTA O FOCO PARA A TXTBOX1
            txtnota1.Focus();
        }
    }
}
