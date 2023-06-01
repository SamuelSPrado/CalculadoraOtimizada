using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOtimizada
{
    public abstract class OperacaoMatematica : IOperacaoMatematica
    {
        protected double ValorX;
        protected double ValorY;
        public abstract string Descricao { get; }
        public virtual void SetValores(double valorX, double valorY)
        {
            this.ValorX = valorX;
            this.ValorY = valorY;
        }
        public abstract double Calcular();

        public OperacaoMatematica(double valorX, double valorY)
        {
            this.ValorX = valorX;
            this.ValorY = valorY;
        }
    }
}
