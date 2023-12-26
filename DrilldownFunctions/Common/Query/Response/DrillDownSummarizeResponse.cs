using System.Collections.Generic;

namespace DrilldownFunctions.Common.Query.Response
{
    public class DrillDownSummarizeResponse
    {
        public Dictionary<string, string[]> DimensionValueSet { get; set; }
        public List<Dictionary<string, string>> Data { get; set; }
    }
}
