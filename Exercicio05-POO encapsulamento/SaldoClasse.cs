using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio05_POO_encapsulamento
{
    internal class SaldoClasse
    {
        private decimal _saldo;

        public decimal Saldo
        {   //RETORNANDO O VALOR DENTRO DO MEU OBJETO PRIVADO
            get
            {
                return _saldo;
            }
        }

        public void AdicionarSaldo(decimal valor)
        {   //SE MEU VALOR FOR MAIOR QUE 0
            if (valor > 0 )
            {    //SOME O VALOR DENTRO DO MEU OBJETO PRIVADO COM O VALOR DA MINHA VARIAVEL
                _saldo += valor;
            }
            else
            {   //CASO AO CONTRARIO MOSTRE ESSA MENSAGEM
                MessageBox.Show("O valor deve ser maior que 0", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        public bool RemoverSaldo(decimal valor)
        {   //SE VALOR FOR MAIOR QUE 0 E MENOR QUE O VALOR DENTRO DE _saldo
            if (valor > 0 && valor < _saldo)
            {   //RETIRE
                _saldo -= valor;
                //RETORNE TRUE
                return true;
            }
            //SENÃO
            else
            {   //RETORNE FALSE
                return false;
            }
        }


    }
}
