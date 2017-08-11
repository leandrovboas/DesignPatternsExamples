using ExempleStrategyPattern.Interface;

namespace ExempleStrategyPattern.Impostos
{
    public class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000) return orcamento.Valor * 0.05;
            if (orcamento.Valor > 1000 && orcamento.Valor > 3000) return orcamento.Valor * 0.07;
            if (orcamento.Valor < 3000) return orcamento.Valor * 0.08 + 30;
            return 0;
        }
    }
}
