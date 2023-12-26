using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Response;
using DrilldownFunctions.Data;
using System;
using System.Collections.Generic;
using Microsoft.Azure.Cosmos;
using DrilldownFunctions.Common.Query.Request;

namespace DrilldownFunctions.Functions.AzureCosmosDB.Query
{
    internal class AzureCosmosDBDrillDownDimensionsQuery : AbstractDrillDownFieldsQuery
    {
        private readonly AppSettings _appSettings;
        private readonly DrilldownDbContext _dbContext;
        private readonly DrillDownFieldsRequest _request;
        public AzureCosmosDBDrillDownDimensionsQuery(AppSettings appSettings, DrilldownDbContext dbContext, DrillDownFieldsRequest request)
        {
            _appSettings = appSettings;
            _dbContext = dbContext;
            _request = request;
        }

        public override DrillDownFieldsResponse ExecuteDrillDownFieldsQuery()
        {
            throw new NotImplementedException();
        }
    }
}
