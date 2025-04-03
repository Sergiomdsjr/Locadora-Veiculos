using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Veiculos
{
    internal interface IVeiculo
    {
        decimal CalcularAluguel(int dias);
    }
}
