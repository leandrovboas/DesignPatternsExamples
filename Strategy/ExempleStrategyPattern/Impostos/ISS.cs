using ExempleStrategyPattern.Interface;
using System;

namespace ExempleStrategyPattern.Impostos
{
    public class ISS: IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
