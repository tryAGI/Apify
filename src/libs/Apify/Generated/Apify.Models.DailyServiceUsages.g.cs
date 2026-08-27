
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DailyServiceUsages
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// A map of service usage item names to their usage details.<br/>
        /// Example: {"ACTOR_COMPUTE_UNITS":{"quantity":60,"baseAmountUsd":0.00030000000000000003,"baseUnitPriceUsd":0.000005,"amountAfterVolumeDiscountUsd":0.00030000000000000003,"priceTiers":[]}}
        /// </summary>
        /// <example>{"ACTOR_COMPUTE_UNITS":{"quantity":60,"baseAmountUsd":0.00030000000000000003,"baseUnitPriceUsd":0.000005,"amountAfterVolumeDiscountUsd":0.00030000000000000003,"priceTiers":[]}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceUsage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Apify.UsageItem> ServiceUsage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsageCreditsUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalUsageCreditsUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyServiceUsages" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="serviceUsage">
        /// A map of service usage item names to their usage details.<br/>
        /// Example: {"ACTOR_COMPUTE_UNITS":{"quantity":60,"baseAmountUsd":0.00030000000000000003,"baseUnitPriceUsd":0.000005,"amountAfterVolumeDiscountUsd":0.00030000000000000003,"priceTiers":[]}}
        /// </param>
        /// <param name="totalUsageCreditsUsd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyServiceUsages(
            string date,
            global::System.Collections.Generic.Dictionary<string, global::Apify.UsageItem> serviceUsage,
            double totalUsageCreditsUsd)
        {
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.ServiceUsage = serviceUsage ?? throw new global::System.ArgumentNullException(nameof(serviceUsage));
            this.TotalUsageCreditsUsd = totalUsageCreditsUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyServiceUsages" /> class.
        /// </summary>
        public DailyServiceUsages()
        {
        }

    }
}