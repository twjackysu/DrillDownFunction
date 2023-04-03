using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Request;
using DrilldownFunctions.Common.Query.Response;
using DrilldownFunctions.Data;
using System;

namespace DrilldownFunctions.Functions.AzureCosmosDB.Query
{
    internal class AzureCosmosDBDrillDownDetailsQuery : AbstractDrillDownDetailsQuery
    {
        private readonly AppSettings _appSettings;
        private readonly DrillDownDetailsRequest _detailsRequest;
        private readonly DrilldownDbContext _dbContext;
        public AzureCosmosDBDrillDownDetailsQuery(AppSettings appSettings, DrilldownDbContext dbContext, DrillDownDetailsRequest detailsRequest)
        {
            _appSettings = appSettings;
            _detailsRequest = detailsRequest;
            _dbContext = dbContext;
        }
        public override DrillDownDetailsResponse ExecuteDrillDownDetailsQuery()
        {
            throw new NotImplementedException();
        }
    }
}
