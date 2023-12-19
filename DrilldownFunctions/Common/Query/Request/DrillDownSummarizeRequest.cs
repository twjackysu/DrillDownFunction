
using DrilldownFunctions.Common.DTOs.Dimensions;
using System.Collections.Generic;

namespace DrilldownFunctions.Common.Query.Request
{
    /// <summary>
    /// Represents a request to summarize data based on specific criteria for a particular feature.
    /// </summary>
    public class DrillDownSummarizeRequest
    {
        /// <summary>
        /// The name of the feature for which the data summarization is requested.
        /// This identifies the specific functionality or module targeted by the request.
        /// </summary>
        public string FeatureName { get; set; }

        /// <summary>
        /// The filter criteria for the summarization request, specifying which data should be considered.
        /// </summary>
        public SummarizeRequestFilter Filter { get; set; }

        /// <summary>
        /// The dimensions to be used for data summarization.
        /// </summary>
        public SummarizeRequestDimension Dimension { get; set; }

        /// <summary>
        /// The measures to be used for data summarization, defining how data should be aggregated.
        /// </summary>
        public SummarizeRequestMeasure Measure { get; set; }
    }

    /// <summary>
    /// Represents the filtering criteria for a data summarization request.
    /// </summary>
    public class SummarizeRequestFilter
    {
        /// <summary>
        /// A list of dimensions used to define the filtering criteria for summarization.
        /// </summary>
        public List<SummarizeRequestDimension> Fields { get; set; }
    }

    /// <summary>
    /// Represents the dimensions involved in a data summarization request.
    /// </summary>
    public class SummarizeRequestDimension
    {
        /// <summary>
        /// A list of filtered fields defining the dimensions for data summarization.
        /// </summary>
        public List<FilteredField> Fields { get; set; }
    }

    /// <summary>
    /// Represents the measures involved in a data summarization request.
    /// </summary>
    public class SummarizeRequestMeasure
    {
        /// <summary>
        /// A list of fields defining the measures for data aggregation in the summarization.
        /// </summary>
        public List<MeasureField> Fields { get; set; }
    }

}
