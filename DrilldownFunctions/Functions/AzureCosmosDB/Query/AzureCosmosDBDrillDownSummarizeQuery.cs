using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Request;
using DrilldownFunctions.Common.Query.Response;
using DrilldownFunctions.Data;
using System;

namespace DrilldownFunctions.Functions.AzureCosmosDB.Query
{
    internal class AzureCosmosDBDrillDownSummarizeQuery: AbstractDrillDownSummarizeQuery
    {
        private readonly AppSettings _appSettings;
        private readonly DrillDownSummarizeRequest _summarizeRequest;
        private readonly DrilldownDbContext _dbContext;
        public AzureCosmosDBDrillDownSummarizeQuery(AppSettings appSettings, DrilldownDbContext dbContext, DrillDownSummarizeRequest summarizeRequest)
        {
            _appSettings = appSettings;
            _summarizeRequest = summarizeRequest;
            _dbContext = dbContext;
        }
        public override DrillDownSummarizeResponse ExecuteDrillDownSummarizeQuery()
        {
            throw new NotImplementedException();
        }
    }
}
