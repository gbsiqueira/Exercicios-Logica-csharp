using System;
// Fazer a lista funcionar
using System.Collections.Generic;
using System.ComponentModel;

namespace Exercicio06BancoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> contas = new List<Conta>();
            bool Loopescolha = false; while (!Loopescolha)
            {
                Console.Clear();

                Console.WriteLine("O que você deseja fazer? 1: Entrar em uma conta, 2: Criar uma conta, 3: Sair do banco");

                string Escolha = Console.ReadLine();

                switch (Escolha)
                {
                    case "1":

                        Console.WriteLine("Digite o CPF do titular");
                        string BuscaCpf = Console.ReadLine();

                        // variavel pra ajudar a achar a uma conta, começa em null 
                        Conta AcharConta = null;

                        foreach (var c in contas)
                        {
                            if (c.Titular.Cpf == BuscaCpf)
                            {
                                AcharConta = c;
                                break;
                            }

                        }

                        if (AcharConta != null)
                        {
                            Console.WriteLine($"Você entrou na conta do Titular {AcharConta.Titular.Nome}");
                            Console.WriteLine($"Seu saldo e de {AcharConta.Saldo:C}");
                        }
                        else
                        {
                            Console.WriteLine("Erro, sua conta não foi encontrada");
                        }

                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal : ");

                        Console.ReadKey();

                        break;

                    case "2":

                        Console.WriteLine("Qual o seu nome?");
                        string Nome = Console.ReadLine();

                        Console.WriteLine("Digite seu CPF : ");
                        String Cpf = Console.ReadLine();


                        User NovoUsuario = new User();
                        Conta NovaConta = new Conta();

                        NovoUsuario.Nome = Nome;
                        NovoUsuario.Cpf = Cpf;


                        // Atribuindo o titular com o usuario 
                        NovaConta.Titular = NovoUsuario;



                        contas.Add(NovaConta);

                        Console.WriteLine("Sucesso! sua conta foi criada, aperte qualquer tecla para sair");
                        Console.ReadKey();

                        break;

                    case "3":

                        Loopescolha = true;

                        break;

                    default:

                        Console.WriteLine("Apenas essas 3 opções são permitidas");

                        break;
                }
            }
        }

    }
}





