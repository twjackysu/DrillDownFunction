using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Response;
using System;

namespace DrilldownFunctions.Functions.AzureCosmosDB.Query
{
    internal class AzureCosmosDBDrillDownDetailsQuery : AbstractDrillDownDetailsQuery
    {
        private AppSettings _appSettings;
        public AzureCosmosDBDrillDownDetailsQuery(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }
        public override DrillDownDetailsResponse ExecuteDrillDownDetailsQuery()
        {
            throw new NotImplementedException();
        }
    }
}
