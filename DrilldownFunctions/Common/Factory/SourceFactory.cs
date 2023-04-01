using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Request;

namespace DrilldownFunctions.Common.Factory
{

    public abstract class SourceFactory
    {
        public abstract AbstractDrillDownDimensionsQuery CreateDimensionsQuery();
        public abstract AbstractDrillDownSummarizeQuery CreateSummarizeQuery(DrillDownSummarizeRequest summarizeRequest);
        public abstract AbstractDrillDownDetailsQuery CreateDetailsQuery(DrillDownDetailsRequest detailsRequest);
    }
}
