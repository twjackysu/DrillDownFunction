namespace DrilldownFunctions.Common.DTOs.Field
{
    public interface IField
    {
        public string FieldName { get; set; }
    }
    public interface IFieldWithType : IField
    {
        public string FieldType { get; set; }
    }
    public interface IFilteredField : IField
    {
        public string[] FilterValues { get; set; }
    }
    public interface IMeasureField : IField
    {
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
