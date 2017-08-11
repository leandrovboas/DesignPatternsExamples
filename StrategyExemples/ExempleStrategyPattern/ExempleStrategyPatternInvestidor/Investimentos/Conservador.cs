using ExempleStrategyPatternInvestidor.Interface;

namespace ExempleStrategyPatternInvestidor.Investimentos
{
    public class Conservador : ITipoInvestimento
    {
        public double Calcula(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
