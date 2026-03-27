using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio02_Listadetenis
{
    public partial class Form1 : Form
    {

        //Criando a lista com os dados dos itens
        List <string> nometenis = new List<string>();

        public Form1()
        {
            InitializeComponent();

            
            
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {   //validação de campo vazio
            if (string.IsNullOrWhiteSpace(txtnome.Text))
            {   //mensagem de campo vazio
                MessageBox.Show("Informe um nome válido", "Atenção",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {    //caso nao esteja vazio, ele cria uma variavel e atribui a textbox, depois coloca o resultado do metodo adicionar em uma variável bool
                string textodigitado = txtnome.Text;
                bool tenisadicionar = adicionartenis(textodigitado);

                //se o resultado for verdadeiro ele fala que voce adicionou
                if (tenisadicionar==true)
                {
                    lblfrase.Text = "Você adiciou um item a sua lista";
                    

                }//caso o contrario o item ja existe
                else
                {
                    lblfrase.Text = "Este item já está na sua lista";
                }
                //limpa a txtbox 
                txtnome.Clear();
                txtnome.Focus();
            }



        }

        private void btnremover_Click(object sender, EventArgs e)
        {   //validação de campo vazio
            if (string.IsNullOrWhiteSpace(txtnome.Text))
            {    //mensagem de campo vazio
                MessageBox.Show("Informe um nome válido", "Atenção",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {//caso contrario ele cria uma variavel e atribui a uma textbox, e pega o resultado da função removertenis e cria uma variavel bool
                string textodigitado = txtnome.Text;
                bool tenisremover = Removertenis(textodigitado);
                
                //se for verdadeiro ele fala que voce removeu um item
                if (tenisremover ==true)
                {
                    lblfrase.Text = "Você removeu um item a sua lista";
                    

                }
                else
                {//caso contrario ele não esta na sua lista
                    lblfrase.Text = "Este item não está na sua lista";
                }
                //limpa a txtbox
                txtnome.Clear();
                txtnome.Focus();
                



            }
        }

        private void Limpartela()
        {   //essa função limpa os itens da lista, e preenche denovo usando os dados da lista
            
            lsttenis.Items.Clear();

            foreach (string tenis in nometenis) 
            { 
                lsttenis.Items.Add(tenis);
            
            }
    
               
            
            

        }   

        private bool adicionartenis(string tenis)
        {   //se não tiver o nome do tenis ele cria nos dados da lista, limpa e atualiza a interface
            if (!nometenis.Contains(tenis))
            {
               
                nometenis.Add(tenis);
                Limpartela();
                return true;

            }//caso tenha ele devolve false pro button
            return false;

        }

        private bool Removertenis(string tenis)
        {   //caso tenha o nome do tenis ele remove nos dados da lista, limpa e atualiza a interface
            if (nometenis.Contains(tenis))
            {
                
                nometenis.Remove(tenis);
                Limpartela();
                return true;


            }//caso nao tenha ele retorna false para o button
            return false;


        }

        private void btnlimpartela_Click(object sender, EventArgs e)
        {   //esse botao chama a função de limpar a tela
            Limpartela();
        }
    }
}
