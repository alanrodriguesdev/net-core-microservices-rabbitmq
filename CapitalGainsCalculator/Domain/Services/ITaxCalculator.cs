using Domain.Models;

namespace Domain.Services
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(Operations sellOperation, decimal averageCost, ref decimal accumulatedLoss);
    }   
}
