
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
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyBasePriceUsd")]
        public double? MonthlyBasePriceUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyUsageCreditsUsd")]
        public double? MonthlyUsageCreditsUsd { get; set; }

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
        public global::System.Collections.Generic.IList<string>? EnabledPlatformFeatures { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyUsageUsd")]
        public double? MaxMonthlyUsageUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxActorMemoryGbytes")]
        public double? MaxActorMemoryGbytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyActorComputeUnits")]
        public double? MaxMonthlyActorComputeUnits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyResidentialProxyGbytes")]
        public double? MaxMonthlyResidentialProxyGbytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyProxySerps")]
        public int? MaxMonthlyProxySerps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyExternalDataTransferGbytes")]
        public double? MaxMonthlyExternalDataTransferGbytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxActorCount")]
        public int? MaxActorCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxActorTaskCount")]
        public int? MaxActorTaskCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataRetentionDays")]
        public int? DataRetentionDays { get; set; }

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
        public int? TeamAccountSeatCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportLevel")]
        public string? SupportLevel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableAddOns")]
        public global::System.Collections.Generic.IList<string>? AvailableAddOns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public string? Tier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiRateLimitBoosts")]
        public int? ApiRateLimitBoosts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxScheduleCount")]
        public int? MaxScheduleCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxConcurrentActorRuns")]
        public int? MaxConcurrentActorRuns { get; set; }

        /// <summary>
        /// Pricing details for this plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planPricing")]
        public object? PlanPricing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Plan" /> class.
        /// </summary>
        /// <param name="availableProxyGroups">
        /// A dictionary mapping proxy group names to the number of available proxies in each group.<br/>
        /// The keys are proxy group names (e.g., "RESIDENTIAL", "DATACENTER") and values are<br/>
        /// the count of available proxies.<br/>
        /// Example: {"RESIDENTIAL":1000,"DATACENTER":500,"GOOGLE_SERP":200}
        /// </param>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="isEnabled"></param>
        /// <param name="monthlyBasePriceUsd"></param>
        /// <param name="monthlyUsageCreditsUsd"></param>
        /// <param name="usageDiscountPercent"></param>
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
        /// <param name="teamAccountSeatCount"></param>
        /// <param name="supportLevel"></param>
        /// <param name="availableAddOns"></param>
        /// <param name="tier"></param>
        /// <param name="apiRateLimitBoosts"></param>
        /// <param name="maxScheduleCount"></param>
        /// <param name="maxConcurrentActorRuns"></param>
        /// <param name="planPricing">
        /// Pricing details for this plan.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Plan(
            global::System.Collections.Generic.Dictionary<string, int> availableProxyGroups,
            string? id,
            string? description,
            bool? isEnabled,
            double? monthlyBasePriceUsd,
            double? monthlyUsageCreditsUsd,
            double? usageDiscountPercent,
            global::System.Collections.Generic.IList<string>? enabledPlatformFeatures,
            double? maxMonthlyUsageUsd,
            double? maxActorMemoryGbytes,
            double? maxMonthlyActorComputeUnits,
            double? maxMonthlyResidentialProxyGbytes,
            int? maxMonthlyProxySerps,
            double? maxMonthlyExternalDataTransferGbytes,
            int? maxActorCount,
            int? maxActorTaskCount,
            int? dataRetentionDays,
            int? teamAccountSeatCount,
            string? supportLevel,
            global::System.Collections.Generic.IList<string>? availableAddOns,
            string? tier,
            int? apiRateLimitBoosts,
            int? maxScheduleCount,
            int? maxConcurrentActorRuns,
            object? planPricing)
        {
            this.Id = id;
            this.Description = description;
            this.IsEnabled = isEnabled;
            this.MonthlyBasePriceUsd = monthlyBasePriceUsd;
            this.MonthlyUsageCreditsUsd = monthlyUsageCreditsUsd;
            this.UsageDiscountPercent = usageDiscountPercent;
            this.EnabledPlatformFeatures = enabledPlatformFeatures;
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
            this.SupportLevel = supportLevel;
            this.AvailableAddOns = availableAddOns;
            this.Tier = tier;
            this.ApiRateLimitBoosts = apiRateLimitBoosts;
            this.MaxScheduleCount = maxScheduleCount;
            this.MaxConcurrentActorRuns = maxConcurrentActorRuns;
            this.PlanPricing = planPricing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plan" /> class.
        /// </summary>
        public Plan()
        {
        }

    }
}