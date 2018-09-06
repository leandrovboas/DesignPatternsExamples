using ExempleStrategyPattern.Impostos;
using ExempleStrategyPattern.Interface;
using System;

namespace ExempleStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto iccc = new ICCC();
            var orcamento = new Orcamento(500.0);
            Console.WriteLine("Valor Orçamemto: " + orcamento.Valor);
            CalculadorDeImposto.RealizaCalculo(orcamento, iss);
            CalculadorDeImposto.RealizaCalculo(orcamento, icms);
            CalculadorDeImposto.RealizaCalculo(orcamento, iccc);
            Console.ReadKey();
        }
    }
}
