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
    {
        List<string> listadetarefas = new List<string>
        {
        
        };

            
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadcionar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txttarefa.Text))
            {
                MessageBox.Show("Favor escreva a tarefa que Deseja adicionar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttarefa.Focus();
                txttarefa.BackColor = Color.Red;

            }
            else
            {
                txttarefa.BackColor = Color.White;
                string tarefa = txttarefa.Text;

                if(tarefa.Length >=3)
                {
                    txttarefa.BackColor = Color.White;

                    listadetarefas.Add(tarefa);
                    Limpartela();
                    txttarefa.Focus();

                }
                else
                {
                    MessageBox.Show("A tarefa não pode conter menos de 3 caracteres", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttarefa.Focus();
                    txttarefa.BackColor = Color.Red;
                }


            }
        }

        private void Limpartela()
        {
            lsttarefas.Items.Clear();

            foreach (string tarefas in listadetarefas)
            {
                lsttarefas.Items.Add(tarefas);
            }


        }











    }
}
