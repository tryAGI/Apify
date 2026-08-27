
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListOfRequestQueuesVariant2
    {
        /// <summary>
        /// Whether the listing was filtered to only unnamed request queues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unnamed")]
        public bool? Unnamed { get; set; }

        /// <summary>
        /// The array of request queues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.RequestQueueShort> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfRequestQueuesVariant2" /> class.
        /// </summary>
        /// <param name="items">
        /// The array of request queues.
        /// </param>
        /// <param name="unnamed">
        /// Whether the listing was filtered to only unnamed request queues.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOfRequestQueuesVariant2(
            global::System.Collections.Generic.IList<global::Apify.RequestQueueShort> items,
            bool? unnamed)
        {
            this.Unnamed = unnamed;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfRequestQueuesVariant2" /> class.
        /// </summary>
        public ListOfRequestQueuesVariant2()
        {
        }

    }
}