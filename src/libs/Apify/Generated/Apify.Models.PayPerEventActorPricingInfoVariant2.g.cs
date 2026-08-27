
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PayPerEventActorPricingInfoVariant2
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"PAY_PER_EVENT"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingModel")]
        public string PricingModel { get; set; } = "PAY_PER_EVENT";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingPerEvent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.PayPerEventActorPricingInfoVariant2PricingPerEvent PricingPerEvent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimalMaxTotalChargeUsd")]
        public double? MinimalMaxTotalChargeUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayPerEventActorPricingInfoVariant2" /> class.
        /// </summary>
        /// <param name="pricingPerEvent"></param>
        /// <param name="minimalMaxTotalChargeUsd"></param>
        /// <param name="pricingModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PayPerEventActorPricingInfoVariant2(
            global::Apify.PayPerEventActorPricingInfoVariant2PricingPerEvent pricingPerEvent,
            double? minimalMaxTotalChargeUsd,
            string pricingModel = "PAY_PER_EVENT")
        {
            this.PricingModel = pricingModel;
            this.PricingPerEvent = pricingPerEvent ?? throw new global::System.ArgumentNullException(nameof(pricingPerEvent));
            this.MinimalMaxTotalChargeUsd = minimalMaxTotalChargeUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayPerEventActorPricingInfoVariant2" /> class.
        /// </summary>
        public PayPerEventActorPricingInfoVariant2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PayPerEventActorPricingInfoVariant2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PayPerEventActorPricingInfoVariant2 FromPricingPerEvent(global::Apify.PayPerEventActorPricingInfoVariant2PricingPerEvent pricingPerEvent)
        {
            return new PayPerEventActorPricingInfoVariant2
            {
                PricingPerEvent = pricingPerEvent,
            };
        }

    }
}