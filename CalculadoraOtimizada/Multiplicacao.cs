using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOtimizada
{
    public class Multiplicacao : OperacaoMatematica
    {
        public Multiplicacao(double valorX, double valorY) : base(valorX, valorY)
        {
        }

        public override double Calcular()
        {
            return ValorX * ValorY;
        }
        public override string Descricao => "Multiplicação";
    }
}
