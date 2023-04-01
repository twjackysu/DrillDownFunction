using DrilldownFunctions.Common.Query.Request;
using DrilldownFunctions.Common.Query.Response;

namespace DrilldownFunctions.Common.Query
{
    public abstract class AbstractDrillDownSummarizeQuery
    {
        public abstract DrillDownSummarizeResponse ExecuteDrillDownSummarizeQuery();
    }
}
