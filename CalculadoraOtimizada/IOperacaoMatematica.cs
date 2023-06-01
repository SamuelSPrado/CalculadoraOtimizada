using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOtimizada
{
    public interface IOperacaoMatematica
    {      
        string Descricao { get; }
        void SetValores(double valorX, double valorY);
        double Calcular();
    }
}
