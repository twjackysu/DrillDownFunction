using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrilldownFunctions.Common.Query.Response
{
    public class DrillDownSummarizeResponse
    {
        public Dictionary<string, string[]> DimensionValueSet { get; set; }
        public List<Dictionary<string, string>> Data { get; set; }
    }
}
