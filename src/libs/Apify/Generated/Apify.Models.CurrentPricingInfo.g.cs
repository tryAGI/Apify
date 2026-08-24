
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
        [global::System.Text.Json.Serialization.JsonPropertyName("trialMinutes")]
        public int? TrialMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitName")]
        public string? UnitName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricePerUnitUsd")]
        public double? PricePerUnitUsd { get; set; }

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
        /// <param name="trialMinutes"></param>
        /// <param name="unitName"></param>
        /// <param name="pricePerUnitUsd"></param>
        /// <param name="minimalMaxTotalChargeUsd"></param>
        /// <param name="pricingPerEvent">
        /// Per-event pricing configuration for pay-per-event Actors.
        /// </param>
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
            int? trialMinutes,
            string? unitName,
            double? pricePerUnitUsd,
            double? minimalMaxTotalChargeUsd,
            object? pricingPerEvent)
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
            this.TrialMinutes = trialMinutes;
            this.UnitName = unitName;
            this.PricePerUnitUsd = pricePerUnitUsd;
            this.MinimalMaxTotalChargeUsd = minimalMaxTotalChargeUsd;
            this.PricingPerEvent = pricingPerEvent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentPricingInfo" /> class.
        /// </summary>
        public CurrentPricingInfo()
        {
        }

    }
}