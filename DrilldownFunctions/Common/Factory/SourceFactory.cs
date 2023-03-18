using DrilldownFunctions.Common.Query;
using DrilldownFunctions.Common.Query.Request;

namespace DrilldownFunctions.Common.Factory
{

    public abstract class SourceFactory
    {
        public abstract AbstractDrillDownDimensionsQuery CreateDimensionsQuery();
        public abstract AbstractDrillDownDataQuery CreateDataQuery(DrillDownDataRequest dataRequest);
        public abstract AbstractDrillDownDetailsQuery CreateDetailsQuery(DrillDownDetailsRequest detailsRequest);
    }
}
