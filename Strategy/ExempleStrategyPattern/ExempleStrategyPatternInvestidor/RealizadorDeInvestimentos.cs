using ExempleStrategyPatternInvestidor.Interface;
using System;

namespace ExempleStrategyPatternInvestidor
{
    public class RealizadorDeInvestimentos
    {
        public static void Realiza(Conta conta, ITipoInvestimento tipoInvestimento)
        {
            var resultado = tipoInvestimento.Calcula(conta);
            conta.Deposita(resultado * 0.75);
            Console.Write(tipoInvestimento.GetType().Name + ": ");
            Console.WriteLine("Novo saldo: " + conta.Saldo.ToString("0.##"));
        }
    }
}
