
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActorChargeEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventPriceUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EventPriceUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTitle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventDescription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorChargeEvent" /> class.
        /// </summary>
        /// <param name="eventPriceUsd"></param>
        /// <param name="eventTitle"></param>
        /// <param name="eventDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorChargeEvent(
            double eventPriceUsd,
            string eventTitle,
            string eventDescription)
        {
            this.EventPriceUsd = eventPriceUsd;
            this.EventTitle = eventTitle ?? throw new global::System.ArgumentNullException(nameof(eventTitle));
            this.EventDescription = eventDescription ?? throw new global::System.ArgumentNullException(nameof(eventDescription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorChargeEvent" /> class.
        /// </summary>
        public ActorChargeEvent()
        {
        }

    }
}