using Application.Services;
using IoC;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        var services = ConfigureServices();

        var serviceProvider = services.BuildServiceProvider();

        var operationHandler = serviceProvider.GetService<IOperationHandler>();

        //string jsonInput = "";
        //string line;

        //while (true)
        //{
        //    line = Console.ReadLine() ?? string.Empty;

        //    if (line == null || line.Trim() == "")
        //        break;

        //    jsonInput += line.Trim();
        //}


        //if (string.IsNullOrWhiteSpace(jsonInput))
        //    return;

        //var jsonOutput = operationHandler?.HandleOperations(jsonInput);

        //Console.WriteLine(jsonOutput);

        while (true)
        {
            // Método para ler a entrada JSON até que o usuário pressione Enter vazio
            string jsonInput = ReadJsonInput();

            if (string.IsNullOrWhiteSpace(jsonInput))
                break;

            var jsonOutput = operationHandler?.HandleOperations(jsonInput);

            Console.WriteLine(jsonOutput);
            Console.WriteLine(" ");
        }

    }

    private static string ReadJsonInput()
    {
        string jsonInput = "";
        string line;

        while (true)
        {
            line = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(line))
                break;

            jsonInput += line.Trim();
        }

        return jsonInput;
    }

    private static IServiceCollection ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddProjectDependencies();

        return services;
    }
}