using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinalModulo10
{
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            string nome = boxNome.Text; 
            int nif = Convert.ToInt32 (boxNIF.Text);
            int numeroConta = Convert.ToInt32 (boxNumConta.Text);
            double saldoInicial = Convert.ToInt32 (boxSaldoIn.Text);
            string profissao = boxProfissao.Text;
            string password = boxPassword.Text;

            Menu menu = new Menu();
            menu.ShowDialog();


        }
    }
}
