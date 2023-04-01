using DrilldownFunctions.Common.Factory;
using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Request;
using DrilldownFunctions.Functions.AzureCosmosDB.Query;
using Microsoft.Extensions.Options;

namespace DrilldownFunctions.Functions.AzureCosmosDB
{
    public class AzureCosmosDBFactory: SourceFactory
    {
        private readonly IOptionsMonitor<AppSettings> _appSettings;
        public AzureCosmosDBFactory(IOptionsMonitor<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }
        public override AbstractDrillDownDimensionsQuery CreateDimensionsQuery()
        {
            return new AzureCosmosDBDrillDownDimensionsQuery(_appSettings.CurrentValue);
        }
        public override AbstractDrillDownSummarizeQuery CreateSummarizeQuery(DrillDownSummarizeRequest summarizeRequest)
        {
            return new AzureCosmosDBDrillDownSummarizeQuery(_appSettings.CurrentValue, summarizeRequest);
        }
        public override AbstractDrillDownDetailsQuery CreateDetailsQuery(DrillDownDetailsRequest detailsRequest)
        {
            return new AzureCosmosDBDrillDownDetailsQuery(_appSettings.CurrentValue, detailsRequest);
        }
    }
}
