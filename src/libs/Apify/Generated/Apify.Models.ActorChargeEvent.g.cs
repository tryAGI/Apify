
#nullable enable

namespace Apify
{
    /// <summary>
    /// Definition of a single chargeable event for a pay-per-event Actor. Each event is either flat-priced<br/>
    /// (`eventPriceUsd` is set) or tier-priced (`eventTieredPricingUsd` is set); the two are mutually exclusive.
    /// </summary>
    public sealed partial class ActorChargeEvent
    {
        /// <summary>
        /// Human-readable title shown to users in the billing UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTitle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventTitle { get; set; }

        /// <summary>
        /// Human-readable description of what triggers this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventDescription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventDescription { get; set; }

        /// <summary>
        /// Flat price per event in USD. Present only for non-tiered events. Mutually exclusive with `eventTieredPricingUsd`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventPriceUsd")]
        public double? EventPriceUsd { get; set; }

        /// <summary>
        /// Tiered price-per-event pricing for a single charge event, keyed by subscription tier (e.g. `FREE`, `BRONZE`,<br/>
        /// `SILVER`, `GOLD`, `PLATINUM`, `DIAMOND`). The actual price applied is resolved from the user's tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTieredPricingUsd")]
        public global::System.Collections.Generic.Dictionary<string, global::Apify.TieredPricingPerEventEntry>? EventTieredPricingUsd { get; set; }

        /// <summary>
        /// Whether this event is the Actor's primary chargeable event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPrimaryEvent")]
        public bool? IsPrimaryEvent { get; set; }

        /// <summary>
        /// Whether this event can only be charged once per Actor run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isOneTimeEvent")]
        public bool? IsOneTimeEvent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorChargeEvent" /> class.
        /// </summary>
        /// <param name="eventTitle">
        /// Human-readable title shown to users in the billing UI.
        /// </param>
        /// <param name="eventDescription">
        /// Human-readable description of what triggers this event.
        /// </param>
        /// <param name="eventPriceUsd">
        /// Flat price per event in USD. Present only for non-tiered events. Mutually exclusive with `eventTieredPricingUsd`.
        /// </param>
        /// <param name="eventTieredPricingUsd">
        /// Tiered price-per-event pricing for a single charge event, keyed by subscription tier (e.g. `FREE`, `BRONZE`,<br/>
        /// `SILVER`, `GOLD`, `PLATINUM`, `DIAMOND`). The actual price applied is resolved from the user's tier.
        /// </param>
        /// <param name="isPrimaryEvent">
        /// Whether this event is the Actor's primary chargeable event.
        /// </param>
        /// <param name="isOneTimeEvent">
        /// Whether this event can only be charged once per Actor run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorChargeEvent(
            string eventTitle,
            string eventDescription,
            double? eventPriceUsd,
            global::System.Collections.Generic.Dictionary<string, global::Apify.TieredPricingPerEventEntry>? eventTieredPricingUsd,
            bool? isPrimaryEvent,
            bool? isOneTimeEvent)
        {
            this.EventTitle = eventTitle ?? throw new global::System.ArgumentNullException(nameof(eventTitle));
            this.EventDescription = eventDescription ?? throw new global::System.ArgumentNullException(nameof(eventDescription));
            this.EventPriceUsd = eventPriceUsd;
            this.EventTieredPricingUsd = eventTieredPricingUsd;
            this.IsPrimaryEvent = isPrimaryEvent;
            this.IsOneTimeEvent = isOneTimeEvent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorChargeEvent" /> class.
        /// </summary>
        public ActorChargeEvent()
        {
        }

    }
}