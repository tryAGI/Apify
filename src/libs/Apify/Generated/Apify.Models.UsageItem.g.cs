
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseAmountUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BaseAmountUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseUnitPriceUsd")]
        public double? BaseUnitPriceUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amountAfterVolumeDiscountUsd")]
        public double? AmountAfterVolumeDiscountUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceTiers")]
        public global::System.Collections.Generic.IList<global::Apify.PriceTiers>? PriceTiers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageItem" /> class.
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="baseAmountUsd"></param>
        /// <param name="baseUnitPriceUsd"></param>
        /// <param name="amountAfterVolumeDiscountUsd"></param>
        /// <param name="priceTiers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageItem(
            double quantity,
            double baseAmountUsd,
            double? baseUnitPriceUsd,
            double? amountAfterVolumeDiscountUsd,
            global::System.Collections.Generic.IList<global::Apify.PriceTiers>? priceTiers)
        {
            this.Quantity = quantity;
            this.BaseAmountUsd = baseAmountUsd;
            this.BaseUnitPriceUsd = baseUnitPriceUsd;
            this.AmountAfterVolumeDiscountUsd = amountAfterVolumeDiscountUsd;
            this.PriceTiers = priceTiers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageItem" /> class.
        /// </summary>
        public UsageItem()
        {
        }

    }
}