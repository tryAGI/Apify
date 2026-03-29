
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Plan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyBasePriceUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MonthlyBasePriceUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyUsageCreditsUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MonthlyUsageCreditsUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageDiscountPercent")]
        public double? UsageDiscountPercent { get; set; }

        /// <summary>
        /// Example: [ACTORS, STORAGE, PROXY_SERPS, SCHEDULER, WEBHOOKS]
        /// </summary>
        /// <example>[ACTORS, STORAGE, PROXY_SERPS, SCHEDULER, WEBHOOKS]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledPlatformFeatures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EnabledPlatformFeatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyUsageUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxMonthlyUsageUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxActorMemoryGbytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxActorMemoryGbytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyActorComputeUnits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxMonthlyActorComputeUnits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyResidentialProxyGbytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxMonthlyResidentialProxyGbytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyProxySerps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxMonthlyProxySerps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyExternalDataTransferGbytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxMonthlyExternalDataTransferGbytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxActorCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxActorCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxActorTaskCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxActorTaskCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataRetentionDays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DataRetentionDays { get; set; }

        /// <summary>
        /// A dictionary mapping proxy group names to the number of available proxies in each group.<br/>
        /// The keys are proxy group names (e.g., "RESIDENTIAL", "DATACENTER") and values are<br/>
        /// the count of available proxies.<br/>
        /// Example: {"RESIDENTIAL":1000,"DATACENTER":500,"GOOGLE_SERP":200}
        /// </summary>
        /// <example>{"RESIDENTIAL":1000,"DATACENTER":500,"GOOGLE_SERP":200}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableProxyGroups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> AvailableProxyGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamAccountSeatCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TeamAccountSeatCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportLevel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SupportLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableAddOns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AvailableAddOns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Plan" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="isEnabled"></param>
        /// <param name="monthlyBasePriceUsd"></param>
        /// <param name="monthlyUsageCreditsUsd"></param>
        /// <param name="enabledPlatformFeatures">
        /// Example: [ACTORS, STORAGE, PROXY_SERPS, SCHEDULER, WEBHOOKS]
        /// </param>
        /// <param name="maxMonthlyUsageUsd"></param>
        /// <param name="maxActorMemoryGbytes"></param>
        /// <param name="maxMonthlyActorComputeUnits"></param>
        /// <param name="maxMonthlyResidentialProxyGbytes"></param>
        /// <param name="maxMonthlyProxySerps"></param>
        /// <param name="maxMonthlyExternalDataTransferGbytes"></param>
        /// <param name="maxActorCount"></param>
        /// <param name="maxActorTaskCount"></param>
        /// <param name="dataRetentionDays"></param>
        /// <param name="availableProxyGroups">
        /// A dictionary mapping proxy group names to the number of available proxies in each group.<br/>
        /// The keys are proxy group names (e.g., "RESIDENTIAL", "DATACENTER") and values are<br/>
        /// the count of available proxies.<br/>
        /// Example: {"RESIDENTIAL":1000,"DATACENTER":500,"GOOGLE_SERP":200}
        /// </param>
        /// <param name="teamAccountSeatCount"></param>
        /// <param name="supportLevel"></param>
        /// <param name="availableAddOns"></param>
        /// <param name="usageDiscountPercent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Plan(
            string id,
            string description,
            bool isEnabled,
            double monthlyBasePriceUsd,
            double monthlyUsageCreditsUsd,
            global::System.Collections.Generic.IList<string> enabledPlatformFeatures,
            double maxMonthlyUsageUsd,
            double maxActorMemoryGbytes,
            double maxMonthlyActorComputeUnits,
            double maxMonthlyResidentialProxyGbytes,
            int maxMonthlyProxySerps,
            double maxMonthlyExternalDataTransferGbytes,
            int maxActorCount,
            int maxActorTaskCount,
            int dataRetentionDays,
            global::System.Collections.Generic.Dictionary<string, int> availableProxyGroups,
            int teamAccountSeatCount,
            string supportLevel,
            global::System.Collections.Generic.IList<string> availableAddOns,
            double? usageDiscountPercent)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IsEnabled = isEnabled;
            this.MonthlyBasePriceUsd = monthlyBasePriceUsd;
            this.MonthlyUsageCreditsUsd = monthlyUsageCreditsUsd;
            this.UsageDiscountPercent = usageDiscountPercent;
            this.EnabledPlatformFeatures = enabledPlatformFeatures ?? throw new global::System.ArgumentNullException(nameof(enabledPlatformFeatures));
            this.MaxMonthlyUsageUsd = maxMonthlyUsageUsd;
            this.MaxActorMemoryGbytes = maxActorMemoryGbytes;
            this.MaxMonthlyActorComputeUnits = maxMonthlyActorComputeUnits;
            this.MaxMonthlyResidentialProxyGbytes = maxMonthlyResidentialProxyGbytes;
            this.MaxMonthlyProxySerps = maxMonthlyProxySerps;
            this.MaxMonthlyExternalDataTransferGbytes = maxMonthlyExternalDataTransferGbytes;
            this.MaxActorCount = maxActorCount;
            this.MaxActorTaskCount = maxActorTaskCount;
            this.DataRetentionDays = dataRetentionDays;
            this.AvailableProxyGroups = availableProxyGroups ?? throw new global::System.ArgumentNullException(nameof(availableProxyGroups));
            this.TeamAccountSeatCount = teamAccountSeatCount;
            this.SupportLevel = supportLevel ?? throw new global::System.ArgumentNullException(nameof(supportLevel));
            this.AvailableAddOns = availableAddOns ?? throw new global::System.ArgumentNullException(nameof(availableAddOns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plan" /> class.
        /// </summary>
        public Plan()
        {
        }
    }
}