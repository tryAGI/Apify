
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserProxyInfoPlan
    {
        /// <summary>
        /// A dictionary mapping proxy group names to the number of available proxies in each group.<br/>
        /// The keys are proxy group names (e.g., "RESIDENTIAL", "DATACENTER") and values are<br/>
        /// the count of available proxies.<br/>
        /// Example: {"RESIDENTIAL":1000,"DATACENTER":500,"GOOGLE_SERP":200}
        /// </summary>
        /// <example>{"RESIDENTIAL":1000,"DATACENTER":500,"GOOGLE_SERP":200}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableProxyGroups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> AvailableProxyGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProxyInfoPlan" /> class.
        /// </summary>
        /// <param name="availableProxyGroups">
        /// A dictionary mapping proxy group names to the number of available proxies in each group.<br/>
        /// The keys are proxy group names (e.g., "RESIDENTIAL", "DATACENTER") and values are<br/>
        /// the count of available proxies.<br/>
        /// Example: {"RESIDENTIAL":1000,"DATACENTER":500,"GOOGLE_SERP":200}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProxyInfoPlan(
            global::System.Collections.Generic.Dictionary<string, int> availableProxyGroups)
        {
            this.AvailableProxyGroups = availableProxyGroups ?? throw new global::System.ArgumentNullException(nameof(availableProxyGroups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProxyInfoPlan" /> class.
        /// </summary>
        public UserProxyInfoPlan()
        {
        }

    }
}