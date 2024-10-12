using System.Text.Json;
using System.Text.Json.Serialization;

namespace TesteStdinNubank
{
    public class Operacao
    {
        [JsonPropertyName("operation")]
        public string Operation { get; set; }

        [JsonPropertyName("unit-cost")]
        public decimal UnitCost { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }

    class Program
    {
        static void Main()
        {
            string line;

            // Lê as entradas linha por linha
            while ((line = Console.ReadLine()) != null)
            {
                // Verifica se a linha está vazia para sair do loop
                if (string.IsNullOrWhiteSpace(line))
                {
                    break;
                }

                try
                {
                    // Converte a linha JSON em uma lista de operações
                    var operacoes = JsonSerializer.Deserialize<List<Operacao>>(line);

                    // Processa as operações
                    foreach (var operacao in operacoes)
                    {
                        Console.WriteLine($"Operação: {operacao.Operation}, Custo Unitário: {operacao.UnitCost:F2}, Quantidade: {operacao.Quantity}");
                    }
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"Erro ao processar o JSON: {ex.Message}");
                }
            }
        }
    }
}
