using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Veiculos
{
    class Moto : Veiculo
    {
        public Moto(string modelo, string marca, int ano, decimal valorBaseDiario)
            : base(modelo, marca, ano, valorBaseDiario) { }

        public override decimal CalcularAluguel(int dias)
        {
            return (ValorBaseDiario * dias) * 0.9m; 
        }
    }
}
