using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DealAnalyzerAPI.Data;
using DealAnalyzerAPI.Model;

namespace DealAnalyzerAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class InvestorsController : ControllerBase
    {
        // Fields
        private readonly IRepository _repo;
        private readonly ILogger<InvestorsController> _logger;

        // Constructor

        public InvestorsController(IRepository repo, ILogger<InvestorsController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        // Methods

        // GET /api/investors


        [HttpGet("allinvestors")]
        public async Task<ActionResult<IEnumerable<Investors>>>  GetAllInvestors()
        {
            IEnumerable<Investors> investors;

            try
            {
                investors = await _repo.GetAllInvestorsAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return StatusCode(500);
            }

            return investors.ToList();
        }

        [HttpGet("allAnalyses")]
        public async Task<ActionResult<IEnumerable<Analysis>>> GetAllAnalyses()
        {
            IEnumerable<Analysis> analyses;

            try
            {
                analyses = await _repo.GetAllAnalysesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return StatusCode(500);
            }

            return analyses.ToList();
        }
        // check if the investor exists
        // list count = 0 then investor doesn't exist presumbly
        // if list count > 0 then return list of transactions
        // in console app, ask you



        [HttpGet("investorExists/{username}")]
        public async Task<ActionResult<IEnumerable<Analysis>>> InvestorExists(string username)
        {
            IEnumerable<Analysis> transactions;

            try
            {
                transactions = await _repo.CheckInvestorExistsAsync(username);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return StatusCode(500);
            }

            return transactions.ToList();
        }
    }
}
