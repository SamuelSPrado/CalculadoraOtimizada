using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOtimizada
{
    public class Divisao : OperacaoMatematica
    {
        public Divisao(double valorX, double valorY) : base(valorX, valorY)
        {
        }

        public override double Calcular()
        {
            try
            {
                if (ValorY == 0)
                {
                    throw new DivideByZeroException("Divisão por zero não é permitida.");
                }
                else
                {
                    return ValorX / ValorY;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }
        public override string Descricao => "Divisão";
    }
}
