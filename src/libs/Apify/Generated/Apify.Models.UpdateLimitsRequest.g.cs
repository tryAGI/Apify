
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateLimitsRequest
    {
        /// <summary>
        /// If your platform usage in the billing period exceeds the prepaid usage, you will be charged extra. Setting this property you can update your hard limit on monthly platform usage to prevent accidental overage or to limit the extra charges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyUsageUsd")]
        public double? MaxMonthlyUsageUsd { get; set; }

        /// <summary>
        /// Apify securely stores your ten most recent Actor runs indefinitely, ensuring they are always accessible. Unnamed storages and other Actor runs are automatically deleted after the retention period. If you're subscribed, you can change it to keep data for longer or to limit your usage. [Lear more](https://docs.apify.com/platform/storage/usage#data-retention).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataRetentionDays")]
        public int? DataRetentionDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLimitsRequest" /> class.
        /// </summary>
        /// <param name="maxMonthlyUsageUsd">
        /// If your platform usage in the billing period exceeds the prepaid usage, you will be charged extra. Setting this property you can update your hard limit on monthly platform usage to prevent accidental overage or to limit the extra charges.
        /// </param>
        /// <param name="dataRetentionDays">
        /// Apify securely stores your ten most recent Actor runs indefinitely, ensuring they are always accessible. Unnamed storages and other Actor runs are automatically deleted after the retention period. If you're subscribed, you can change it to keep data for longer or to limit your usage. [Lear more](https://docs.apify.com/platform/storage/usage#data-retention).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateLimitsRequest(
            double? maxMonthlyUsageUsd,
            int? dataRetentionDays)
        {
            this.MaxMonthlyUsageUsd = maxMonthlyUsageUsd;
            this.DataRetentionDays = dataRetentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLimitsRequest" /> class.
        /// </summary>
        public UpdateLimitsRequest()
        {
        }

    }
}