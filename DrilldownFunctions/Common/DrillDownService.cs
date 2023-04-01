using DrilldownFunctions.Common.Factory;
using DrilldownFunctions.Common.Query.Request;
using DrilldownFunctions.Common.Query.Response;

namespace DrilldownFunctions.Common
{
    public class DrillDownService
    {
        private SourceFactory _factory;
        // Constructor
        public DrillDownService(SourceFactory factory)
        {
            _factory = factory;
        }
        public DrillDownDimensionsResponse ExecuteDimensionsQuery()
        {
            var _abstractDimensionsQuery = _factory.CreateDimensionsQuery();
            return _abstractDimensionsQuery.ExecuteDrillDownDimensionsQuery();
        }
        public DrillDownSummarizeResponse ExecuteSummarizeQuery(DrillDownSummarizeRequest summarizeRequest)
        {
            var _abstractSummarizeQuery = _factory.CreateSummarizeQuery(summarizeRequest);
            return _abstractSummarizeQuery.ExecuteDrillDownSummarizeQuery();
        }
        public DrillDownDetailsResponse ExecuteDetailsQuery(DrillDownDetailsRequest detailsRequest)
        {
            var _abstractDetailsQuery = _factory.CreateDetailsQuery(detailsRequest);
            return _abstractDetailsQuery.ExecuteDrillDownDetailsQuery();
        }
    }
}
