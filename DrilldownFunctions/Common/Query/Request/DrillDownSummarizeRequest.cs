
using System.Collections.Generic;

namespace DrilldownFunctions.Common.Query.Request
{
    public class DrillDownSummarizeRequest
    {
        public Filter Filter { get; set; }
        public List<Dimension> Dimensions { get; set; }
        public List<Measure> Measures { get; set; }
    }

    public class Filter
    {
        public List<Dimension> Dimensions { get; set; }
    }

    public class Dimension
    {
        public string DimensionName { get; set; }
        public string[] FilterValues { get; set; }
    }
    public class Measure
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
