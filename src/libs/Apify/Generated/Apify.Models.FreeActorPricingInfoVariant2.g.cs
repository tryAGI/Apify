
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FreeActorPricingInfoVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingModel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.PricingModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.PricingModel PricingModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FreeActorPricingInfoVariant2" /> class.
        /// </summary>
        /// <param name="pricingModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FreeActorPricingInfoVariant2(
            global::Apify.PricingModel pricingModel)
        {
            this.PricingModel = pricingModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FreeActorPricingInfoVariant2" /> class.
        /// </summary>
        public FreeActorPricingInfoVariant2()
        {
        }
    }
}