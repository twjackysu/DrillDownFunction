using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrilldownFunctions.Common.Query.Request
{
    /// <summary>
    /// Represents a request to retrieve a list of fields for a specific feature,
    /// with an option to include hidden fields.
    /// </summary>
    public class DrillDownFieldsRequest
    {
        /// <summary>
        /// The name of the feature for which the fields are being requested.
        /// This is used to determine the specific functionality or module
        /// that the request is targeting.
        /// </summary>
        public string FeatureName { get; set; }

        /// <summary>
        /// Indicates whether hidden fields should be included in the response.
        /// Setting this to true will retrieve all fields, including those not
        /// normally visible or accessible in standard queries.
        /// </summary>
        public bool IncludeHiddenFields { get; set; }
    }
}
