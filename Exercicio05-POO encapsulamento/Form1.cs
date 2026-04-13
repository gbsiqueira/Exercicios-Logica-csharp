using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio05_POO_encapsulamento
{
    public partial class Form1 : Form
    {   //INSTANCIANDO UM OBJETO
        SaldoClasse conta1 = new SaldoClasse();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsaldo.Text))
            {   //VALIDAÇÃO DOS CAMPOS
                MessageBox.Show("Favor informe o valor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsaldo.BackColor = Color.Red;
                txtsaldo.Focus();
                return;

            }
            try
            { 
                //ATRIBUINDO A VARIAVEL VALOR
                decimal valor = decimal.Parse(txtsaldo.Text);
                //SE CASO O VALOR RETORNADO FOR TRUE
                if (conta1.AdicionarSaldo(valor))
                {   //MOSTRA O VALOR DA CONTA1 
                    txtsaldoatual.Text = Convert.ToString(conta1.Saldo);
                }
                else
                {
                    //CASO AO CONTRARIO MOSTRE ESSA MENSAGEM
                    MessageBox.Show("O valor deve ser maior que 0", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //CHAMA O METODO LIMPAR TUDO
                limpartudo();

            }
            catch
            {
                //CASO NAO CONSIGA CONVERTER OS VALORES
                MessageBox.Show("Favor informe o valor corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsaldo.BackColor = Color.Red;
                txtsaldo.Focus();
            }

        }
        private void limpartudo()
        {   //VOLTA A COR AO NORMAL DA TXTBOX, E FOCA O CURSOR NELA
            txtsaldo.BackColor = Color.White;
            txtsaldo.Focus();
            //ATUALIZANDO O SALDO
            txtsaldoatual.Text = Convert.ToString(conta1.Saldo);
            //LIMPANDO OS ITEMS DA MINHA LISTBOX
            lst.Items.Clear();
            //ATUALIZANDO A LISTBOX
            foreach (string frase in conta1.Extrato)
            {
                lst.Items.Add(frase);
            }

        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {   //CHAMA O METODO LIMPARTUDO;
            limpartudo();
        }

        private void btnretirar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsaldo.Text))
            {   //VALIDAÇÃO DOS CAMPOS
                MessageBox.Show("Favor informe o valor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsaldo.BackColor = Color.Red;
                txtsaldo.Focus();
                return;

            }
            try
            {   
                //ATRIBUINDO A VARIAVEL VALOR
                decimal valor = decimal.Parse(txtsaldo.Text);

                if (conta1.RemoverSaldo(valor))
                {   
                    txtsaldoatual.Text = Convert.ToString(conta1.Saldo);
                }
                else
                {
                    //COLOCANDO MEU METODO STRING PARA EXIBIR UMA MENSAGEM PERSONALIZADA
                    MessageBox.Show($"{conta1.Mensagemerro}", "falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsaldo.BackColor = Color.Red;
                    txtsaldo.Focus();
                }
                //CHAMA O METODO LIMPARTUDO
                limpartudo();

            }
            catch
            {
                //CASO NAO CONSIGA CONVERTER OS VALORES
                MessageBox.Show("Favor informe o valor corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsaldo.BackColor = Color.Red;
                txtsaldo.Focus();

            }
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
