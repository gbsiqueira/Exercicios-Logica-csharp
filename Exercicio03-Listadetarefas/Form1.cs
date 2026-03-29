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
