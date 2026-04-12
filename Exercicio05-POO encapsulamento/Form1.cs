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
            {  //CHAMA O METODO LIMPAR TUDO
                limpartudo();
                //ATRIBUINDO A VARIAVEL VALOR
                decimal valor = decimal.Parse(txtsaldo.Text);
                //CHAMANDO O METODO ADICIONAR SALDO DO MEU OBJETO E DANDO A MINHA VARIAVEL VALOR A ELE
                conta1.AdicionarSaldo(valor);
                //EXIBINDO O MEU SALDO ATUAL
                txtsaldoatual.Text = Convert.ToString(conta1.Saldo);

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
            {   //CHAMA O METODO LIMPARTUDO
                limpartudo();
                //ATRIBUINDO A VARIAVEL VALOR
                decimal valor = decimal.Parse(txtsaldo.Text);

                if (conta1.RemoverSaldo(valor))
                {
                    txtsaldo.Text = Convert.ToString(conta1.Saldo);
                }
                else
                {
                    MessageBox.Show("O valor que deseja retirar não pode ser 0 e nem maior do que o valor que possui em sua conta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsaldo.BackColor = Color.Red;
                    txtsaldo.Focus();
                }

            }
            catch
            {
                //CASO NAO CONSIGA CONVERTER OS VALORES
                MessageBox.Show("Favor informe o valor corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsaldo.BackColor = Color.Red;
                txtsaldo.Focus();

            }
        }
    }
}
