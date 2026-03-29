
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CurrentPricingInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingModel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PricingModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentPricingInfo" /> class.
        /// </summary>
        /// <param name="pricingModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CurrentPricingInfo(
            string pricingModel)
        {
            this.PricingModel = pricingModel ?? throw new global::System.ArgumentNullException(nameof(pricingModel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentPricingInfo" /> class.
        /// </summary>
        public CurrentPricingInfo()
        {
        }
    }
}