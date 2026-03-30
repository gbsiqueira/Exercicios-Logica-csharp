using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio04_POO
{
    public partial class Form1 : Form
    {   //Criando a lista
        List<Componentes> Estoque = new List<Componentes>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {   //Validando campos
            if (string.IsNullOrWhiteSpace(txtnome.Text) || string.IsNullOrWhiteSpace(txtpreco.Text))
            {   //mensagem de erro
                MessageBox.Show("Todos os campos devem ser preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Cores das txtbox vermelhas
                txtpreco.BackColor = Color.Red;
                txtnome.BackColor = Color.Red;
                //focando o cursor na txtbox nome
                txtnome.Focus();
                
                return;

            }
            
               
                try
                {   //instanciando um novo objeto
                    Componentes Novapeca = new Componentes();

                    //Atribuindo valores
                    Novapeca.Nome = txtnome.Text;
                    Novapeca.Valor = decimal.Parse (txtpreco.Text);

                    //Adiciona nos dados da lista
                    Estoque.Add(Novapeca);
                    //chamando a função atualizar
                    Atualizar();


                }
                catch
                {   //Mensagem de erro
                    MessageBox.Show("Veja se o valor está correto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //focando o cursor na txt preço
                    txtpreco.Focus();
                }

            
            
        }
        private void Atualizar ()
        {   //limpando a lista visual
            lstinventario.Items.Clear();
            //Lendo cada item dos dados da lista e adicionando na lista visual
            foreach (var item in Estoque)
            {
                lstinventario.Items.Add($"{item.Nome} tem o valor de {item.Valor:C}");
            }
            //voltando as cores normais
            txtpreco.BackColor = Color.White;
            txtnome.BackColor = Color.White;
            //limpando txtbox, e dando foco a txtnome
            txtnome.Clear();
            txtpreco.Clear();
            txtnome.Focus();
           
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {   //chamando a função atualizar
            Atualizar();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            if (lstinventario.SelectedIndex <0)
            {   //mensagem de erro
                MessageBox.Show("Favor selecione um item na lista", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {  //removendo o item selecinado dos dados da lista
                Estoque.RemoveAt(lstinventario.SelectedIndex);
                //chamando a função atualizar
                Atualizar();
            }
        }
    }
}