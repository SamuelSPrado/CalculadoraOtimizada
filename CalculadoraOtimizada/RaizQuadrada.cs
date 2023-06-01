using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOtimizada
{
    public class RaizQuadrada : IOperacaoMatematica
    {
        private double Valor;

        public string Descricao { get { return "Raiz quadrada"; } }

        public void SetValores(double valorX, double valorY)
        {
            this.Valor = valorX;
        }

        public RaizQuadrada(double valor)
        {
            this.Valor = valor;
        }

        public double Calcular()
        {
            try
            {
                if (Valor <= 0)
                {
                    throw new ArgumentException("Raiz quadrada de número negativo não é permitida.");
                }
                return Math.Sqrt(Valor);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
