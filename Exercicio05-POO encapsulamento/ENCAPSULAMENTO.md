🏦 MiniBank - Sistema de Gestão de Saldo
Este é um projeto desenvolvido em C# (WinForms) para exercitar conceitos avançados de Programação Orientada a Objetos e Manipulação de Coleções. O sistema simula as operações básicas de uma conta bancária, com validações de segurança e histórico de transações.

🚀 Funcionalidades
Depósito: Adiciona valores ao saldo com validação (apenas valores positivos).

Saque: Retira valores verificando se há saldo suficiente.

Extrato em Tempo Real: Cada operação gera um registro com data e hora em um ListBox.

Interface Responsiva: Feedback visual (mudança de cores e mensagens) para erros de preenchimento.

🛠️ Conceitos Aplicados
Neste projeto, foquei em aplicar boas práticas de desenvolvimento:

Encapsulamento: O saldo (_saldo) é privado, sendo acessado apenas por propriedades e modificado exclusivamente através de métodos validados.

Separação de Responsabilidades: A lógica de negócio reside na classe SaldoClasse, enquanto o formulário (Form1) lida apenas com a interface do usuário.

Tratamento de Exceções: Uso de blocos try-catch para evitar que o programa trave com entradas de dados inválidas.

Coleções (List): Utilização de List<string> para armazenar o histórico de transações de forma dinâmica.

Laços de Repetição: Uso do foreach para percorrer a lista de extrato e atualizar a interface.
