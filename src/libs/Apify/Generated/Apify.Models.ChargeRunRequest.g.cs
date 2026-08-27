
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChargeRunRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRunRequest" /> class.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChargeRunRequest(
            string eventName,
            int count)
        {
            this.EventName = eventName ?? throw new global::System.ArgumentNullException(nameof(eventName));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRunRequest" /> class.
        /// </summary>
        public ChargeRunRequest()
        {
        }

    }
}