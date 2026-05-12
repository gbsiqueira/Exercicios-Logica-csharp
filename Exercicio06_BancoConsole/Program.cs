using System;
// Fazer a lista funcionar
using System.Collections.Generic;
using System.ComponentModel;

List<Conta> contas = new List<Conta>();

bool Loopescolha = false;

while (!Loopescolha)
{
    Console.Clear();

    Console.WriteLine("O que você deseja fazer? 1: Entrar em uma conta, 2: Criar uma conta, 3: Sair do banco");

    string Escolha = Console.ReadLine();

    switch (Escolha)
    {
        case "1":

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