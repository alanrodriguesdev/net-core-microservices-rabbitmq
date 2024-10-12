namespace Domain.Models
{
    public class OperationBase
    {
        public decimal averageCost = 0m;
        public int totalQuantity = 0;
        public decimal accumulatedLoss = 0m;

        public void InitializeVariables()
        {
            this.averageCost = 0m;
            this.totalQuantity = 0;
            this.accumulatedLoss = 0m;
        }
    }
}
