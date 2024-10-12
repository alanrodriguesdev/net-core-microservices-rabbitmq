using Domain.Models;
using Domain.Services;

namespace Infrastructure.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(Operations sellOperation, decimal averageCost, ref decimal accumulatedLoss)
        {
            decimal totalSaleValue = sellOperation.Quantity * sellOperation.UnitCost;

            decimal saleProfit = (sellOperation.UnitCost - averageCost) * sellOperation.Quantity;

            if (totalSaleValue <= 20000 && saleProfit > 0)
                return 0.00m;


            if (saleProfit < 0)
            {
                accumulatedLoss += -saleProfit;
                return 0.00m;
            }

            if (accumulatedLoss > 0)
            {
                if (accumulatedLoss >= saleProfit)
                {
                    accumulatedLoss -= saleProfit;
                    return 0.00m;
                }
                else
                {
                    saleProfit -= accumulatedLoss;
                    accumulatedLoss = 0;
                }
            }

            return Math.Round(saleProfit * 0.20m, 2);
        }
    }
}
