using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Veiculos
{
    abstract class Veiculo : IVeiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public decimal ValorBaseDiario { get; set; }

        public Veiculo(string modelo, string marca, int ano, decimal valorBaseDiario)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            ValorBaseDiario = valorBaseDiario;
        }

        public abstract decimal CalcularAluguel(int dias);
    }

}
