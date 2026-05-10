
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MonthlyUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageCycle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.UsageCycle UsageCycle { get; set; }

        /// <summary>
        /// A map of usage item names (e.g., ACTOR_COMPUTE_UNITS) to their usage details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyServiceUsage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Apify.UsageItem> MonthlyServiceUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyServiceUsages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.DailyServiceUsages> DailyServiceUsages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsageCreditsUsdBeforeVolumeDiscount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalUsageCreditsUsdBeforeVolumeDiscount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsageCreditsUsdAfterVolumeDiscount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalUsageCreditsUsdAfterVolumeDiscount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyUsage" /> class.
        /// </summary>
        /// <param name="usageCycle"></param>
        /// <param name="monthlyServiceUsage">
        /// A map of usage item names (e.g., ACTOR_COMPUTE_UNITS) to their usage details.
        /// </param>
        /// <param name="dailyServiceUsages"></param>
        /// <param name="totalUsageCreditsUsdBeforeVolumeDiscount"></param>
        /// <param name="totalUsageCreditsUsdAfterVolumeDiscount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MonthlyUsage(
            global::Apify.UsageCycle usageCycle,
            global::System.Collections.Generic.Dictionary<string, global::Apify.UsageItem> monthlyServiceUsage,
            global::System.Collections.Generic.IList<global::Apify.DailyServiceUsages> dailyServiceUsages,
            double totalUsageCreditsUsdBeforeVolumeDiscount,
            double totalUsageCreditsUsdAfterVolumeDiscount)
        {
            this.UsageCycle = usageCycle ?? throw new global::System.ArgumentNullException(nameof(usageCycle));
            this.MonthlyServiceUsage = monthlyServiceUsage ?? throw new global::System.ArgumentNullException(nameof(monthlyServiceUsage));
            this.DailyServiceUsages = dailyServiceUsages ?? throw new global::System.ArgumentNullException(nameof(dailyServiceUsages));
            this.TotalUsageCreditsUsdBeforeVolumeDiscount = totalUsageCreditsUsdBeforeVolumeDiscount;
            this.TotalUsageCreditsUsdAfterVolumeDiscount = totalUsageCreditsUsdAfterVolumeDiscount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyUsage" /> class.
        /// </summary>
        public MonthlyUsage()
        {
        }

    }
}