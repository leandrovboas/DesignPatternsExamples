using ExempleStrategyPattern.Interface;
using System;

namespace ExempleStrategyPattern.Impostos
{
    public class ICMS: IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50;
        }
    }
}
