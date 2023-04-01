using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Request;
using DrilldownFunctions.Common.Query.Response;
using System;

namespace DrilldownFunctions.Functions.AzureCosmosDB.Query
{
    internal class AzureCosmosDBDrillDownDetailsQuery : AbstractDrillDownDetailsQuery
    {
        private readonly AppSettings _appSettings;
        private readonly DrillDownDetailsRequest _detailsRequest;
        public AzureCosmosDBDrillDownDetailsQuery(AppSettings appSettings, DrillDownDetailsRequest detailsRequest)
        {
            _appSettings = appSettings;
            _detailsRequest = detailsRequest;
        }
        public override DrillDownDetailsResponse ExecuteDrillDownDetailsQuery()
        {
            throw new NotImplementedException();
        }
    }
}
