using DealAnalyzerAPI.Model;


namespace DealAnalyzerAPI.Data
{
    public interface IRepository
    {
        Task <IEnumerable<Investors>> GetAllInvestorsAsync();
        Task<IEnumerable<Analysis>> GetAllAnalysesAsync();
        Task <IEnumerable<Analysis>> CheckInvestorExistsAsync(string userName);

    }
}
