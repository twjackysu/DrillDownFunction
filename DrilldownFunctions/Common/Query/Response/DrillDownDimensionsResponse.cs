using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrilldownFunctions.Common.Query.Response
{
    public class DrillDownDimensionsResponse
    {
        public List<Dimension> Dimensions { get; set; }
    }
    public class Dimension
    {
        public string DimensionName { get; set; }
        public string DimensionType { get; set; }
    }
}
