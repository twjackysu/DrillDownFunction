using DrilldownFunctions.Common.Factory;
using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Request;
using DrilldownFunctions.Data;
using DrilldownFunctions.Functions.AzureCosmosDB.Query;
using Microsoft.Extensions.Options;

namespace DrilldownFunctions.Functions.AzureCosmosDB
{
    public class AzureCosmosDBFactory: SourceFactory
    {
        private readonly IOptionsMonitor<AppSettings> _appSettings;
        private readonly DrilldownDbContext _dbContext;
        public AzureCosmosDBFactory(IOptionsMonitor<AppSettings> appSettings, DrilldownDbContext dbContext)
        {
            _appSettings = appSettings;
            _dbContext = dbContext;
        }
        public override AbstractDrillDownFieldsQuery CreateFieldsQuery()
        {
            return new AzureCosmosDBDrillDownDimensionsQuery(_appSettings.CurrentValue, _dbContext);
        }
        public override AbstractDrillDownSummarizeQuery CreateSummarizeQuery(DrillDownSummarizeRequest summarizeRequest)
        {
            return new AzureCosmosDBDrillDownSummarizeQuery(_appSettings.CurrentValue, _dbContext, summarizeRequest);
        }
        public override AbstractDrillDownDetailsQuery CreateDetailsQuery(DrillDownDetailsRequest detailsRequest)
        {
            return new AzureCosmosDBDrillDownDetailsQuery(_appSettings.CurrentValue, _dbContext, detailsRequest);
        }
    }
}
