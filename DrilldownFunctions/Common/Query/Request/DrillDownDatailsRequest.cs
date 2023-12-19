
using DrilldownFunctions.Common.DTOs.Dimensions;
using System.Collections.Generic;

namespace DrilldownFunctions.Common.Query.Request
{
    /// <summary>
    /// Represents a request for detailed drill-down data.
    /// </summary>
    public class DrillDownDetailsRequest
    {
        /// <summary>
        /// Determines the specific feature to which this request is related.
        /// </summary>
        public string FeatureName { get; set; }

        /// <summary>
        /// Filter configuration for the request, specifying which data should be filtered out.
        /// </summary>
        public DetailsRequestFilter Filter { get; set; }

        /// <summary>
        /// Detail configuration for the request, specifying which data should be included in the response.
        /// </summary>
        public DetailsRequestDetails Details { get; set; }
    }

    /// <summary>
    /// Represents the filtering criteria for a drill-down details request.
    /// Additional customization information for filtering can be included in DetailsRequestFilter.
    /// </summary>
    public class DetailsRequestFilter
    {
        /// <summary>
        /// An array of fields used to define the filtering criteria.
        /// </summary>
        public FilteredField[] Fields { get; set; }
    }

    /// <summary>
    /// Represents the details to be retrieved in a drill-down details request.
    /// Additional customization information for data retrieval can be included in DetailsRequestDetails.
    /// </summary>
    public class DetailsRequestDetails
    {
        /// <summary>
        /// A list of fields that determine the data to be included in the response.
        /// </summary>
        public List<FieldBase> Fields { get; set; }
    }

}
