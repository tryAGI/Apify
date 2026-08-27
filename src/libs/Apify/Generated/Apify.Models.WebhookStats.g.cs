
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookStats
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalDispatches")]
        public int? TotalDispatches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStats" /> class.
        /// </summary>
        /// <param name="totalDispatches"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookStats(
            int? totalDispatches)
        {
            this.TotalDispatches = totalDispatches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStats" /> class.
        /// </summary>
        public WebhookStats()
        {
        }

    }
}