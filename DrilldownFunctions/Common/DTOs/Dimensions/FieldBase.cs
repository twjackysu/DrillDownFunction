using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrilldownFunctions.Common.DTOs.Dimensions
{
    public class FieldBase: IField
    {
        public string FieldName { get; set; }
    }
    public class FieldWithType : FieldBase, IFieldWithType
    {
        public string FieldType { get; set; }
    }
    public class FilteredField : FieldBase, IFilteredField
    {
        public string[] FilterValues { get; set; }
    }
    public class MeasureField : FieldBase, IMeasureField
    {
        public SummarizeType Summarize { get; set; }
    }
}
