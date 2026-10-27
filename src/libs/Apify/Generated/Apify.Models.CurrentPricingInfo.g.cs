
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
        /// Apify's share of the revenue generated under this pricing info record, as a fraction between 0 and 1. Set by the Apify platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apifyMarginPercentage")]
        public double? ApifyMarginPercentage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifiedAboutChangeAt")]
        public global::System.DateTime? NotifiedAboutChangeAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifiedAboutFutureChangeAt")]
        public global::System.DateTime? NotifiedAboutFutureChangeAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPriceChangeNotificationSuppressed")]
        public bool? IsPriceChangeNotificationSuppressed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forceContainsSignificantPriceChange")]
        public bool? ForceContainsSignificantPriceChange { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPPEPlatformUsagePaidByUser")]
        public bool? IsPPEPlatformUsagePaidByUser { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasonForChange")]
        public string? ReasonForChange { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimalMaxTotalChargeUsd")]
        public double? MinimalMaxTotalChargeUsd { get; set; }

        /// <summary>
        /// Per-event pricing configuration for pay-per-event Actors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingPerEvent")]
        public object? PricingPerEvent { get; set; }

        /// <summary>
        /// Price per unit in USD. Present only for `FLAT_PRICE_PER_MONTH` and non-tiered `PRICE_PER_DATASET_ITEM` pricing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricePerUnitUsd")]
        public double? PricePerUnitUsd { get; set; }

        /// <summary>
        /// Length of the free trial in minutes. Present only for `FLAT_PRICE_PER_MONTH` pricing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trialMinutes")]
        public int? TrialMinutes { get; set; }

        /// <summary>
        /// Name of the charged unit. Present only for `PRICE_PER_DATASET_ITEM` pricing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitName")]
        public string? UnitName { get; set; }

        /// <summary>
        /// Price per unit for each pricing tier. Present only for tiered `PRICE_PER_DATASET_ITEM` pricing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tieredPricing")]
        public global::System.Collections.Generic.Dictionary<string, global::Apify.CurrentPricingInfoTieredPricing2>? TieredPricing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifiedAboutRentalToPpePriceChangeAt")]
        public global::System.DateTime? NotifiedAboutRentalToPpePriceChangeAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentPricingInfo" /> class.
        /// </summary>
        /// <param name="pricingModel"></param>
        /// <param name="apifyMarginPercentage">
        /// Apify's share of the revenue generated under this pricing info record, as a fraction between 0 and 1. Set by the Apify platform.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="startedAt"></param>
        /// <param name="notifiedAboutChangeAt"></param>
        /// <param name="notifiedAboutFutureChangeAt"></param>
        /// <param name="isPriceChangeNotificationSuppressed"></param>
        /// <param name="forceContainsSignificantPriceChange"></param>
        /// <param name="isPPEPlatformUsagePaidByUser"></param>
        /// <param name="reasonForChange"></param>
        /// <param name="minimalMaxTotalChargeUsd"></param>
        /// <param name="pricingPerEvent">
        /// Per-event pricing configuration for pay-per-event Actors.
        /// </param>
        /// <param name="pricePerUnitUsd">
        /// Price per unit in USD. Present only for `FLAT_PRICE_PER_MONTH` and non-tiered `PRICE_PER_DATASET_ITEM` pricing.
        /// </param>
        /// <param name="trialMinutes">
        /// Length of the free trial in minutes. Present only for `FLAT_PRICE_PER_MONTH` pricing.
        /// </param>
        /// <param name="unitName">
        /// Name of the charged unit. Present only for `PRICE_PER_DATASET_ITEM` pricing.
        /// </param>
        /// <param name="tieredPricing">
        /// Price per unit for each pricing tier. Present only for tiered `PRICE_PER_DATASET_ITEM` pricing.
        /// </param>
        /// <param name="notifiedAboutRentalToPpePriceChangeAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CurrentPricingInfo(
            string pricingModel,
            double? apifyMarginPercentage,
            global::System.DateTime? createdAt,
            global::System.DateTime? startedAt,
            global::System.DateTime? notifiedAboutChangeAt,
            global::System.DateTime? notifiedAboutFutureChangeAt,
            bool? isPriceChangeNotificationSuppressed,
            bool? forceContainsSignificantPriceChange,
            bool? isPPEPlatformUsagePaidByUser,
            string? reasonForChange,
            double? minimalMaxTotalChargeUsd,
            object? pricingPerEvent,
            double? pricePerUnitUsd,
            int? trialMinutes,
            string? unitName,
            global::System.Collections.Generic.Dictionary<string, global::Apify.CurrentPricingInfoTieredPricing2>? tieredPricing,
            global::System.DateTime? notifiedAboutRentalToPpePriceChangeAt)
        {
            this.PricingModel = pricingModel ?? throw new global::System.ArgumentNullException(nameof(pricingModel));
            this.ApifyMarginPercentage = apifyMarginPercentage;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.NotifiedAboutChangeAt = notifiedAboutChangeAt;
            this.NotifiedAboutFutureChangeAt = notifiedAboutFutureChangeAt;
            this.IsPriceChangeNotificationSuppressed = isPriceChangeNotificationSuppressed;
            this.ForceContainsSignificantPriceChange = forceContainsSignificantPriceChange;
            this.IsPPEPlatformUsagePaidByUser = isPPEPlatformUsagePaidByUser;
            this.ReasonForChange = reasonForChange;
            this.MinimalMaxTotalChargeUsd = minimalMaxTotalChargeUsd;
            this.PricingPerEvent = pricingPerEvent;
            this.PricePerUnitUsd = pricePerUnitUsd;
            this.TrialMinutes = trialMinutes;
            this.UnitName = unitName;
            this.TieredPricing = tieredPricing;
            this.NotifiedAboutRentalToPpePriceChangeAt = notifiedAboutRentalToPpePriceChangeAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentPricingInfo" /> class.
        /// </summary>
        public CurrentPricingInfo()
        {
        }

    }
}