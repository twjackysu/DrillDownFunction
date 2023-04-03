
using System.Collections.Generic;

namespace DrilldownFunctions.Common.Query.Request
{
    public class DrillDownDetailsRequest
    {
        public DetailsRequestFilter Filter { get; set; }
        public DetailsRequestDetails Details { get; set; }
    }

    public class DetailsRequestFilter
    {
        public DetailsRequestFilterDimensions[] Dimensions { get; set; }
    }

    public class DetailsRequestFilterDimensions
    {
        public string DimensionName { get; set; }
        public string[] SpecifiedValues { get; set; }
    }

    public class DetailsRequestDetails
    {
        public List<DetailsRequestDimension> Dimensions { get; set; }
    }

    public class DetailsRequestDimension
    {
        public string DimensionName { get; set; }
    }
}
