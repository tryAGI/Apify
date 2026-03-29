
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PriceTiers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantityAbove")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double QuantityAbove { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discountPercent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DiscountPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tierQuantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TierQuantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitPriceUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UnitPriceUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PriceUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceTiers" /> class.
        /// </summary>
        /// <param name="quantityAbove"></param>
        /// <param name="discountPercent"></param>
        /// <param name="tierQuantity"></param>
        /// <param name="unitPriceUsd"></param>
        /// <param name="priceUsd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PriceTiers(
            double quantityAbove,
            double discountPercent,
            double tierQuantity,
            double unitPriceUsd,
            double priceUsd)
        {
            this.QuantityAbove = quantityAbove;
            this.DiscountPercent = discountPercent;
            this.TierQuantity = tierQuantity;
            this.UnitPriceUsd = unitPriceUsd;
            this.PriceUsd = priceUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceTiers" /> class.
        /// </summary>
        public PriceTiers()
        {
        }
    }
}