
#nullable enable

namespace Apify
{
    /// <summary>
    /// Cost of a single pay-per-event event type charged during the run.
    /// </summary>
    public sealed partial class RunEventUsage
    {
        /// <summary>
        /// Total cost of all charges of this event in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTotalUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EventTotalUsd { get; set; }

        /// <summary>
        /// Human-readable title of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTitle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventTitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEventUsage" /> class.
        /// </summary>
        /// <param name="eventTotalUsd">
        /// Total cost of all charges of this event in USD.
        /// </param>
        /// <param name="eventTitle">
        /// Human-readable title of the event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunEventUsage(
            double eventTotalUsd,
            string eventTitle)
        {
            this.EventTotalUsd = eventTotalUsd;
            this.EventTitle = eventTitle ?? throw new global::System.ArgumentNullException(nameof(eventTitle));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEventUsage" /> class.
        /// </summary>
        public RunEventUsage()
        {
        }

    }
}