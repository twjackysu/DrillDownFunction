using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Request;
using DrilldownFunctions.Common.Query.Response;
using System;

namespace DrilldownFunctions.Functions.AzureCosmosDB.Query
{
    internal class AzureCosmosDBDrillDownSummarizeQuery: AbstractDrillDownSummarizeQuery
    {
        private readonly AppSettings _appSettings;
        private readonly DrillDownSummarizeRequest _summarizeRequest;
        public AzureCosmosDBDrillDownSummarizeQuery(AppSettings appSettings, DrillDownSummarizeRequest summarizeRequest)
        {
            _appSettings = appSettings;
            _summarizeRequest = summarizeRequest;
        }
        public override DrillDownSummarizeResponse ExecuteDrillDownSummarizeQuery()
        {
            throw new NotImplementedException();
        }
    }
}
