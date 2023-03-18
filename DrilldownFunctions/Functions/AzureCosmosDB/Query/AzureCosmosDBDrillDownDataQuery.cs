using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Response;
using System;

namespace DrilldownFunctions.Functions.AzureCosmosDB.Query
{
    internal class AzureCosmosDBDrillDownDataQuery: AbstractDrillDownDataQuery
    {
        private AppSettings _appSettings;
        public AzureCosmosDBDrillDownDataQuery(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }
        public override DrillDownDataResponse ExecuteDrillDownDataQuery()
        {
            throw new NotImplementedException();
        }
    }
}
