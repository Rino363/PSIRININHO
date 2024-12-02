using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinalModulo10
{
    internal class ContaBancaria_Classe
    {
        private double SaldoConta { get; set; } = 0.0;
        private string NomeCliente { get; set; }
        private string ProfissaoCliente { get; set; }
        private int NIFCliente { get; set; } = 999999999;
        private int NumContaCliente { get; set; } = 000000000-00-0;
        private DateTime DataAbertura { get; } = DateTime.Now;

        public ArrayList MovimentosCliente = new ArrayList();

        public ContaBancaria_Classe()
        {
            SaldoConta = 0.0;
            DataAbertura = DateTime.Now;
        }

        public ContaBancaria_Classe(double saldoConta, string nomeCliente, string profissaoCliente, int nifCliente, int numContaCliente)
        {
            SaldoConta = saldoConta;
            nomeCliente = nomeCliente;
            profissaoCliente = profissaoCliente;
            NIFCliente = nifCliente;
            numContaCliente = numContaCliente;
        }
    }

    public class Movimento
    {
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }

        public Movimento(DateTime data, string tipo, double valor)
        {
            Data = data;
            Tipo = tipo;
            Valor = valor;
        }
    }
}
