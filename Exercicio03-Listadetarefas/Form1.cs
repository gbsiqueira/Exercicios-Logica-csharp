using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio03_Listadetarefas
{
    public partial class Form1 : Form
    {   //criando a lista de tarefas
        List<string> listadetarefas = new List<string>
        {
        
        };

            
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadcionar_Click(object sender, EventArgs e)
        {   //validação de campos
            if(string.IsNullOrWhiteSpace(txttarefa.Text))
            {   //mensagem de erro
                MessageBox.Show("Favor escreva a tarefa que Deseja adicionar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttarefa.Focus();
                txttarefa.BackColor = Color.Red;
                //limpa a label
                lblacao.Text = "";

                return;

            }
            else
            {   //voltando a backcolor normal
                txttarefa.BackColor = Color.White;
                //criando e declarando a variavel
                string tarefa = txttarefa.Text;

                //verificando se a variavel possui mais de 3 caracteres
                if(tarefa.Length >=3)
                {
                   
                    //adicionando a lista de tarefas
                    listadetarefas.Add(tarefa);
                    //chamando a função de limpar tela
                    Limpartela();
                    //colcoando o cursor na txtbox
                    txttarefa.Focus();
                    //limpando a txtbox
                    txttarefa.Clear();
                    //mensagem na label
                    lblacao.Text = "Você adicionou uma tarefa a sua lista";

                }
                else
                {   //caso não tenha, mensagem de erro
                    MessageBox.Show("A tarefa não pode conter menos de 3 caracteres", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttarefa.Focus();
                    txttarefa.BackColor = Color.Red;
                }


            }
        }

        private void Limpartela()
        {   //limpando a os itens da lista do design
            lsttarefas.Items.Clear();

            //lendo os dados da lista e adicionando na lista do design
            foreach (string tarefas in listadetarefas)
            {   
                lsttarefas.Items.Add(tarefas);
            }


        }

        private void btnremover_Click(object sender, EventArgs e)
        {   //vando se o usuario selecionou algum item da lista
            if (lsttarefas.SelectedIndex <0)
            {   //mensagem de erro
                MessageBox.Show("Selecione um item da lista que deseja remover", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblacao.Text = "";
                return;
                
            }
            else
            {  //colocando o foco na txtbox
                txttarefa.Focus();
                //voltando a cor padrão
                txttarefa.BackColor = Color.White;
                //removendo da lista de dado o dado selecionado
                listadetarefas.RemoveAt(lsttarefas.SelectedIndex);
                //chamando a função limpar tela 
                Limpartela();
                //mensagem na label
                lblacao.Text = "Você removeu uma tarefa da sua lista";
                
            }
        }
    }
}
