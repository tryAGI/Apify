
#nullable enable

namespace Apify
{
    /// <summary>
    /// A dictionary mapping proxy group names to the number of available proxies in each group.<br/>
    /// The keys are proxy group names (e.g., "RESIDENTIAL", "DATACENTER") and values are<br/>
    /// the count of available proxies.<br/>
    /// Example: {"RESIDENTIAL":1000,"DATACENTER":500,"GOOGLE_SERP":200}
    /// </summary>
    public sealed partial class AvailableProxyGroups
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}