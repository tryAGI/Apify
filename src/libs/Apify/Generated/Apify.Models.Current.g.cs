
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Current
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyUsageUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MonthlyUsageUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyActorComputeUnits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MonthlyActorComputeUnits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyExternalDataTransferGbytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MonthlyExternalDataTransferGbytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyProxySerps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MonthlyProxySerps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyResidentialProxyGbytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MonthlyResidentialProxyGbytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorMemoryGbytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ActorMemoryGbytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActorCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorTaskCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActorTaskCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeActorJobCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActiveActorJobCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamAccountSeatCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TeamAccountSeatCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduleCount")]
        public int? ScheduleCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Current" /> class.
        /// </summary>
        /// <param name="monthlyUsageUsd"></param>
        /// <param name="monthlyActorComputeUnits"></param>
        /// <param name="monthlyExternalDataTransferGbytes"></param>
        /// <param name="monthlyProxySerps"></param>
        /// <param name="monthlyResidentialProxyGbytes"></param>
        /// <param name="actorMemoryGbytes"></param>
        /// <param name="actorCount"></param>
        /// <param name="actorTaskCount"></param>
        /// <param name="activeActorJobCount"></param>
        /// <param name="teamAccountSeatCount"></param>
        /// <param name="scheduleCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Current(
            double monthlyUsageUsd,
            double monthlyActorComputeUnits,
            double monthlyExternalDataTransferGbytes,
            int monthlyProxySerps,
            double monthlyResidentialProxyGbytes,
            double actorMemoryGbytes,
            int actorCount,
            int actorTaskCount,
            int activeActorJobCount,
            int teamAccountSeatCount,
            int? scheduleCount)
        {
            this.MonthlyUsageUsd = monthlyUsageUsd;
            this.MonthlyActorComputeUnits = monthlyActorComputeUnits;
            this.MonthlyExternalDataTransferGbytes = monthlyExternalDataTransferGbytes;
            this.MonthlyProxySerps = monthlyProxySerps;
            this.MonthlyResidentialProxyGbytes = monthlyResidentialProxyGbytes;
            this.ActorMemoryGbytes = actorMemoryGbytes;
            this.ActorCount = actorCount;
            this.ActorTaskCount = actorTaskCount;
            this.ActiveActorJobCount = activeActorJobCount;
            this.TeamAccountSeatCount = teamAccountSeatCount;
            this.ScheduleCount = scheduleCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Current" /> class.
        /// </summary>
        public Current()
        {
        }

    }
}