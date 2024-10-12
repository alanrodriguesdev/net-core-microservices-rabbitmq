using Domain.Models;
using Domain.Services;
using Infrastructure.Parsers;
using Newtonsoft.Json;

namespace Application.Services
{
    public class OperationHandler : OperationBase, IOperationHandler
    {
        private readonly IJsonParser _jsonParser;
        private readonly ITaxCalculator _taxCalculator;

        public OperationHandler(IJsonParser jsonParser, ITaxCalculator taxCalculator)
        {
            _jsonParser = jsonParser;
            _taxCalculator = taxCalculator;            
        }
        public string? HandleOperations(string jsonInput)
        {
            var operation = _jsonParser.Parse(jsonInput);

            if (operation == null)
                return null;

            return ProcessOperations(operation);
        }

        public string ProcessOperations(List<List<Operations>> operations)
        {
            List<TaxResult> results = [];

            InitializeVariables();

            return string.Empty;

            //foreach (var op in operations)
            //{
            //    if (op.Operation == "buy")
            //    {
            //        UpdateAverageCost(op);

            //        results.Add(new TaxResult { Tax = 0.00m });
            //    }
            //    else if (op.Operation == "sell")
            //    {
            //        decimal tax = _taxCalculator.CalculateTax(op, averageCost, ref accumulatedLoss);
            //        results.Add(new TaxResult { Tax = tax });
            //    }
            //}

            //return JsonConvert.SerializeObject(results, Formatting.None);
        }
        private void UpdateAverageCost(Operations buyOperation)
        {
            totalQuantity += buyOperation.Quantity;
            averageCost = ((totalQuantity - buyOperation.Quantity) * averageCost + buyOperation.Quantity * buyOperation.UnitCost) / totalQuantity;
        }
    }
}
