using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Response;
using DrilldownFunctions.Data;
using System;
using System.Collections.Generic;

namespace DrilldownFunctions.Functions.AzureCosmosDB.Query
{
    internal class AzureCosmosDBDrillDownDimensionsQuery : AbstractDrillDownDimensionsQuery
    {
        private readonly AppSettings _appSettings;
        private readonly DrilldownDbContext _dbContext;
        public AzureCosmosDBDrillDownDimensionsQuery(AppSettings appSettings, DrilldownDbContext dbContext)
        {
            _appSettings = appSettings;
            _dbContext = dbContext;
        }
        public override DrillDownDimensionsResponse ExecuteDrillDownDimensionsQuery()
        {
            var entityType = _dbContext.Model.FindEntityType(typeof(Data.Models.NationalIncome));

            var list = new List<DimensionsResponseDimension>();
            foreach (var property in entityType.GetProperties())
            {
                list.Add(new DimensionsResponseDimension()
                {
                    DimensionName = property.Name,
                    DimensionType = property.ClrType.Name
                });
            };

            return new DrillDownDimensionsResponse()
            {
                Dimensions = list
            };
        }
    }
}
