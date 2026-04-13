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
        public const decimal Valormaximosaque = 1000;

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
                Extrato.Add($"Você adicionou {valor:C} em sua conta as {DateTime.Now}");
                return true;
            }
            else
            {
                return false;
               
            }
        }
        //Criando um novo objeto para retornar uma mensagem de erro para o usuario
        public string Mensagemerro { get; private set; }
       


        public bool RemoverSaldo(decimal valor)
        {   //SE O VALOR FOR MENOR QUE 0 COLOQUE ESSA MENSAGEM EM MENSAGEM ERRO
            if (valor <= 0)
            {
                Mensagemerro = "O valor deve ser maior que 0";

                return false;
            }
            //CASO FOR MAIOR QUE O SALDO NA CONTA RETORNE FALSE E COLOQUE ESSA MENSAGEM EM MENSAGEM ERRO
            if (valor > _saldo)
            {   
                Mensagemerro = "O valor de saque não pode ser maior do que possui na conta";
                return false;
            }
            //VALOR FOR MAIOR QUE 1000
            if (valor > Valormaximosaque)
            {
                Mensagemerro = "Você não pode sacar mais de R$ 1000 de uma vez";
                return false;
            }
          
            //CASO PASSE DE TODAS AS CONDIÇÕES
            _saldo -= valor;

            //ADICIONANDO A MINHA LIST, O VALOR QUE EU ADICIONEI E A HORA
            Extrato.Add($"Você retirou {valor:C} a sua conta as {DateTime.Now}");
            //RETORNE TRUE
            return true;
        }


    }
}
