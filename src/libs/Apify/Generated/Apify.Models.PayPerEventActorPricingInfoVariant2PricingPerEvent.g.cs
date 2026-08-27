
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PayPerEventActorPricingInfoVariant2PricingPerEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorChargeEvents")]
        public global::System.Collections.Generic.Dictionary<string, global::Apify.ActorChargeEvent>? ActorChargeEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayPerEventActorPricingInfoVariant2PricingPerEvent" /> class.
        /// </summary>
        /// <param name="actorChargeEvents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PayPerEventActorPricingInfoVariant2PricingPerEvent(
            global::System.Collections.Generic.Dictionary<string, global::Apify.ActorChargeEvent>? actorChargeEvents)
        {
            this.ActorChargeEvents = actorChargeEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayPerEventActorPricingInfoVariant2PricingPerEvent" /> class.
        /// </summary>
        public PayPerEventActorPricingInfoVariant2PricingPerEvent()
        {
        }

    }
}