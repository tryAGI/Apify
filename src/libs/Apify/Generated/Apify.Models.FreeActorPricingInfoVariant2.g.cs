
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
        /// <default>"FREE"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingModel")]
        public string PricingModel { get; set; } = "FREE";

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
            string pricingModel = "FREE")
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