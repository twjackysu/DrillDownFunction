using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Response;
using System;

namespace DrilldownFunctions.Functions.AzureCosmosDB.Query
{
    internal class AzureCosmosDBDrillDownDimensionsQuery : AbstractDrillDownDimensionsQuery
    {
        private AppSettings _appSettings;
        public AzureCosmosDBDrillDownDimensionsQuery(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }
        public override DrillDownDimensionsResponse ExecuteDrillDownDimensionsQuery()
        {
            throw new NotImplementedException();
        }
    }
}
