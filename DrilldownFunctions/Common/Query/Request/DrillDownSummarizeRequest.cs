
using System.Collections.Generic;

namespace DrilldownFunctions.Common.Query.Request
{
    public class DrillDownSummarizeRequest
    {
        public SummarizeRequestFilter Filter { get; set; }
        public List<SummarizeRequestDimension> Dimensions { get; set; }
        public List<SummarizeRequestMeasure> Measures { get; set; }
    }

    public class SummarizeRequestFilter
    {
        public List<SummarizeRequestDimension> Dimensions { get; set; }
    }

    public class SummarizeRequestDimension
    {
        public string DimensionName { get; set; }
        public string[] FilterValues { get; set; }
    }
    public class SummarizeRequestMeasure
    {
        public string DimensionName { get; set; }
        public SummarizeType Summarize { get; set; }
    }

    public enum SummarizeType
    {
        Count,
        DistinctCount,
        Sum,
        Average,
        Maximun,
        Minimun
    }
}
