namespace Locadora_Veiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Veiculo> veiculos = new List<Veiculo>
        {
            new Carro("HILUX", "Toyota", 2022, 500),
            new Moto("XTZ 250", "Yamaha", 2021, 180),
            new Caminhao("Scania R450", "Scania", 2020, 800)
        };

            while (true)
            {
                Console.WriteLine("Escolha um veículo para alugar:");
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {veiculos[i].Modelo} ({veiculos[i].Marca} - {veiculos[i].Ano})");
                }
                Console.WriteLine("4. Sair");

                try
                {
                    int opcao = int.Parse(Console.ReadLine());
                    if (opcao == 4) break;

                    if (opcao < 1 || opcao > veiculos.Count)
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        continue;
                    }

                    Console.Write("Informe o número de dias de aluguel: ");
                    int dias = int.Parse(Console.ReadLine());

                    decimal custo = veiculos[opcao - 1].CalcularAluguel(dias);
                    Console.WriteLine($"Veículo: {veiculos[opcao - 1].Modelo} | Marca: {veiculos[opcao - 1].Marca} | Ano: {veiculos[opcao - 1].Ano} | Custo por {dias} dias: R$ {custo:F2}\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                }
            }
        }
    }
}
