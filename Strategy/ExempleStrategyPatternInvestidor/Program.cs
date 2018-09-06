using ExempleStrategyPatternInvestidor.Interface;
using ExempleStrategyPatternInvestidor.Investimentos;
using System;

namespace ExempleStrategyPatternInvestidor
{
    class Program
    {
        static void Main(string[] args)
        {
            ITipoInvestimento arrojado = new Arrojado();
            ITipoInvestimento moderado = new Moderado();
            ITipoInvestimento conservador = new Conservador();
            var conta = new Conta();
            conta.Deposita(500.0);
            Console.WriteLine("Valor investimento: " + conta.Saldo);
            RealizadorDeInvestimentos.Realiza(conta, arrojado);
            RealizadorDeInvestimentos.Realiza(conta, moderado);
            RealizadorDeInvestimentos.Realiza(conta, conservador);
            Console.ReadKey();
        }
    }
}
