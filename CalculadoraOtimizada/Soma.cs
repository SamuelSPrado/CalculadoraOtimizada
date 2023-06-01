using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOtimizada
{
    public class Soma : OperacaoMatematica
    {
        public Soma(double valorX, double valorY) : base(valorX, valorY) { }

        public override double Calcular()
        {
            return ValorX + ValorY;
        }
        public override string Descricao => "Soma";
    }
}
