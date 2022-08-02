using DealAnalyzerAPI.Model;
using Microsoft.Extensions.Logging;

using System;
using System.Text;
using System.Data.SqlClient;

namespace DealAnalyzerAPI.Data
{
    public class SQLRepository : IRepository
    {
        // Fields
        // only this class should be able to read it
        private readonly string _connectionString;
        private readonly ILogger<SQLRepository> _logger;

        // Constructor
        public SQLRepository(string connectionString, ILogger<SQLRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        // Methods
        // To get all the records from a table of our database
        // Communicate async with my database

        public async Task<IEnumerable<Investors>> GetAllInvestorsAsync()
        {
            List<Investors> oResult = new();

            using SqlConnection oConnection = new(_connectionString);
            await oConnection.OpenAsync();
            string cmdText = "SELECT Id, Username, Name FROM Deals.Investors;";
            using SqlCommand oCmdText = new(cmdText, oConnection);

            // reader response
            using SqlDataReader dataReader = await oCmdText.ExecuteReaderAsync();

            //something to hold the records read
            while (await dataReader.ReadAsync())
            {
                int id = dataReader.GetInt32(0);
                string username = dataReader.GetString(1);
                string name = dataReader.GetString(2);
                string email = dataReader.GetString(3);

                Investors oTmpInvestors = new Investors(id, username, name, email);
                oResult.Add(oTmpInvestors);
            }
            await oConnection.CloseAsync();

            _logger.LogInformation("Executed GetAllInvestorsAsync, returned {0} results", oResult.Count);

            return oResult;
        }

        public async Task<IEnumerable<Analysis>> GetAllAnalysesAsync()
        {
            List<Analysis> oResult = new();

            using SqlConnection oConnection = new(_connectionString);
            await oConnection.OpenAsync();
            string cmdText = "SELECT TransId, TimeStamp, InvestorUsername, PropertyAddress, AskingPrice, RepairEstimate, AfterRepairValue, ProjectCostPercentage, ExitId FROM Deals.Analysis;";
            using SqlCommand oCmdText = new(cmdText, oConnection);

            // reader response
            using SqlDataReader dataReader = await oCmdText.ExecuteReaderAsync();

            //something to hold the records read
            while (await dataReader.ReadAsync())
            {
                int transId = dataReader.GetInt32(0);
                string timeStamp = dataReader.GetString(1);
                string investorUsername = dataReader.GetString(2);
                string propertyAddress = dataReader.GetString(3);
                decimal askingPrice = dataReader.GetInt32(4);
                decimal repairEstimate = dataReader.GetInt32(5);
                decimal afterRepairValue = dataReader.GetInt32(6);
                decimal projectCostPercentage = dataReader.GetInt32(7);
                string exitId = dataReader.GetString(8);


                Analysis oTmpAnalysis = new Analysis(transId, timeStamp, investorUsername, propertyAddress, askingPrice, repairEstimate, afterRepairValue, projectCostPercentage, exitId);
                oResult.Add(oTmpAnalysis);
            }
            await oConnection.CloseAsync();

            _logger.LogInformation("Executed GetAllAnalysesAsync, returned {0} results", oResult.Count);

            return oResult;
        }

        public async Task<string> CheckInvestorExistsAsync(string username)
        {

            List<Investors> oResult = new();

            using SqlConnection oConnection = new(_connectionString);
            await oConnection.OpenAsync();
            string cmdText = "SELECT Id, Username, Name FROM Deals.Investors;";
            using SqlCommand oCmdText = new(cmdText, oConnection);

            // reader response
            using SqlDataReader dataReader = await oCmdText.ExecuteReaderAsync();

            //something to hold the records read
            while (await dataReader.ReadAsync())
            {
                int id = dataReader.GetInt32(0);
                string userName = dataReader.GetString(1);
                string name = dataReader.GetString(2);

                Investors oTmpInvestors = new Investors(id, username, name);
                oResult.Add(oTmpInvestors);
            }
            await oConnection.CloseAsync();

            _logger.LogInformation("Executed GetAllInvestorsAsync, returned {0} results", oResult.Count);

            return oResult;

        }
    }
}