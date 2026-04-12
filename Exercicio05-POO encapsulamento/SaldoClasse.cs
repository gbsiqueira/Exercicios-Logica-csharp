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
        //CRIANDO UMA LISTA NOVA PUBLIC CHAMADA EXTRATO, E COM GET
        public List<string> Extrato { get; } = new List<string>();
       

        //OBJETO _saldo PIVATE
        private decimal _saldo;
        //OBJETO Saldo PUBLIC
        public decimal Saldo
        {   //RETORNANDO O VALOR DENTRO DO MEU OBJETO PRIVADO
            get
            {
                return _saldo;
            }
        }

        public bool AdicionarSaldo(decimal valor)
        {   //SE MEU VALOR FOR MAIOR QUE 0
            if (valor > 0 )
            {    //SOME O VALOR DENTRO DO MEU OBJETO PRIVADO COM O VALOR DA MINHA VARIAVEL
                _saldo += valor;
                //ADICIONANDO A MINHA LIST, O VALOR QUE EU ADICIONEI E A HORA
                Extrato.Add($"Você adicionou {valor:C} a sua conta as {DateTime.Now}");
                return true;
            }
            else
            {
                return false;
               
            }
        }

        public bool RemoverSaldo(decimal valor)
        {   //SE VALOR FOR MAIOR QUE 0 E MENOR QUE O VALOR DENTRO DE _saldo
            if (valor > 0 && _saldo >= valor)
            {   //RETIRE
                _saldo -= valor;
                
                //ADICIONANDO A MINHA LIST, O VALOR QUE EU ADICIONEI E A HORA
                Extrato.Add($"Você retirou {valor:C} a sua conta as {DateTime.Now}");
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
