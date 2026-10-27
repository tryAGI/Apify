
#nullable enable

namespace Apify
{
    /// <summary>
    /// Output links of the run, generated from the output schema of the Actor build. Present only if the build defines an output schema.<br/>
    /// Example: {"results":"https://api.apify.com/v2/datasets/wmKPijuyDnPZAPRMk/items"}
    /// </summary>
    public sealed partial class RunOutput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}