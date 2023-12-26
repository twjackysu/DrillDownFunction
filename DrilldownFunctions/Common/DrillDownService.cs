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
        public DrillDownFieldsResponse ExecuteFieldsQuery(DrillDownFieldsRequest request)
        {
            var _abstractFieldsQuery = _factory.CreateFieldsQuery(request);
            return _abstractFieldsQuery.ExecuteDrillDownFieldsQuery();
        }
        public DrillDownSummarizeResponse ExecuteSummarizeQuery(DrillDownSummarizeRequest request)
        {
            var _abstractSummarizeQuery = _factory.CreateSummarizeQuery(request);
            return _abstractSummarizeQuery.ExecuteDrillDownSummarizeQuery();
        }
        public DrillDownDetailsResponse ExecuteDetailsQuery(DrillDownDetailsRequest request)
        {
            var _abstractDetailsQuery = _factory.CreateDetailsQuery(request);
            return _abstractDetailsQuery.ExecuteDrillDownDetailsQuery();
        }
    }
}
