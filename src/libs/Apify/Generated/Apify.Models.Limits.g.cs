
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Limits
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyUsageUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxMonthlyUsageUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyActorComputeUnits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxMonthlyActorComputeUnits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyExternalDataTransferGbytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxMonthlyExternalDataTransferGbytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyProxySerps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxMonthlyProxySerps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMonthlyResidentialProxyGbytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxMonthlyResidentialProxyGbytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxActorMemoryGbytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxActorMemoryGbytes { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("maxConcurrentActorJobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxConcurrentActorJobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTeamAccountSeatCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTeamAccountSeatCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataRetentionDays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DataRetentionDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Limits" /> class.
        /// </summary>
        /// <param name="maxMonthlyUsageUsd"></param>
        /// <param name="maxMonthlyActorComputeUnits"></param>
        /// <param name="maxMonthlyExternalDataTransferGbytes"></param>
        /// <param name="maxMonthlyProxySerps"></param>
        /// <param name="maxMonthlyResidentialProxyGbytes"></param>
        /// <param name="maxActorMemoryGbytes"></param>
        /// <param name="maxActorCount"></param>
        /// <param name="maxActorTaskCount"></param>
        /// <param name="maxConcurrentActorJobs"></param>
        /// <param name="maxTeamAccountSeatCount"></param>
        /// <param name="dataRetentionDays"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Limits(
            double maxMonthlyUsageUsd,
            double maxMonthlyActorComputeUnits,
            double maxMonthlyExternalDataTransferGbytes,
            int maxMonthlyProxySerps,
            double maxMonthlyResidentialProxyGbytes,
            double maxActorMemoryGbytes,
            int maxActorCount,
            int maxActorTaskCount,
            int maxConcurrentActorJobs,
            int maxTeamAccountSeatCount,
            int dataRetentionDays)
        {
            this.MaxMonthlyUsageUsd = maxMonthlyUsageUsd;
            this.MaxMonthlyActorComputeUnits = maxMonthlyActorComputeUnits;
            this.MaxMonthlyExternalDataTransferGbytes = maxMonthlyExternalDataTransferGbytes;
            this.MaxMonthlyProxySerps = maxMonthlyProxySerps;
            this.MaxMonthlyResidentialProxyGbytes = maxMonthlyResidentialProxyGbytes;
            this.MaxActorMemoryGbytes = maxActorMemoryGbytes;
            this.MaxActorCount = maxActorCount;
            this.MaxActorTaskCount = maxActorTaskCount;
            this.MaxConcurrentActorJobs = maxConcurrentActorJobs;
            this.MaxTeamAccountSeatCount = maxTeamAccountSeatCount;
            this.DataRetentionDays = dataRetentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Limits" /> class.
        /// </summary>
        public Limits()
        {
        }

    }
}