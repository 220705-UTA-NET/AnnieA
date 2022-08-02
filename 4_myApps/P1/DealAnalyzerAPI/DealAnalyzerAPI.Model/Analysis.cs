namespace DealAnalyzerAPI.Model
{
    public class Analysis
    {
        // Fields
        public int Id { get; set; }
        public string TimeStamp { get; set; }
        public string InvestorId { get; set; }
        public string PropertyAddress { get; set; }
        public decimal AskingPrice { get; set; }
        public decimal RepairEstimate { get; set; }
        public decimal AfterRepairValue { get; set; }
        public decimal ProjectCostPercentage { get; set; }
        public string ExitId { get; set; }


        // Constructors

        public Analysis() { }

        public Analysis(int Id, string TimeStamp, string InvestorId, string PropertyAddress, decimal AskingPrice, decimal RepairEstimate, decimal AfterRepairValue, decimal ProjectCostPercentage, string ExitId)
        {
            this.Id = Id;
            this.TimeStamp = TimeStamp;
            this.InvestorId = InvestorId;
            this.PropertyAddress = PropertyAddress;
            this.AskingPrice = AskingPrice;
            this.RepairEstimate = RepairEstimate;
            this.AfterRepairValue = AfterRepairValue;
            this.ProjectCostPercentage = ProjectCostPercentage;
            this.ExitId = ExitId;
        }

        // Methods

    }
}