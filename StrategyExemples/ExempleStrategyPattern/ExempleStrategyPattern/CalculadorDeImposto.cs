using ExempleStrategyPattern.Interface;
using System;

namespace ExempleStrategyPattern
{
    public class CalculadorDeImposto
    {
        public static void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            //CalculadoraDeImpostos apenas exibe um mensagem na tela, ela não é necessária. 
            //Mas agora imagine que, além de calcular o imposto, 
            //essa classe precisasse fazer mais alguma coisa, 
            //como por exemplo, alterar o status do Orçamento, ou notificar algum outro objeto desse valor calculado.
            var valor = imposto.Calcula(orcamento);
            Console.Write(imposto.GetType().Name + ": ");
            Console.WriteLine(valor);
        }

    }
}
