using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Request;

namespace DrilldownFunctions.Common.Factory
{

    public abstract class SourceFactory
    {
        public abstract AbstractDrillDownFieldsQuery CreateFieldsQuery(DrillDownFieldsRequest request);
        public abstract AbstractDrillDownSummarizeQuery CreateSummarizeQuery(DrillDownSummarizeRequest request);
        public abstract AbstractDrillDownDetailsQuery CreateDetailsQuery(DrillDownDetailsRequest request);
    }
}
