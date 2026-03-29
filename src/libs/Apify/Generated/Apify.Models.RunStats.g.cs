
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputBodyLen")]
        public int? InputBodyLen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("migrationCount")]
        public int? MigrationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rebootCount")]
        public int? RebootCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restartCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RestartCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resurrectCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResurrectCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memAvgBytes")]
        public double? MemAvgBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memMaxBytes")]
        public long? MemMaxBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memCurrentBytes")]
        public long? MemCurrentBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuAvgUsage")]
        public double? CpuAvgUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuMaxUsage")]
        public double? CpuMaxUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuCurrentUsage")]
        public double? CpuCurrentUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("netRxBytes")]
        public long? NetRxBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("netTxBytes")]
        public long? NetTxBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMillis")]
        public int? DurationMillis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runTimeSecs")]
        public double? RunTimeSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metamorph")]
        public int? Metamorph { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computeUnits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ComputeUnits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStats" /> class.
        /// </summary>
        /// <param name="restartCount"></param>
        /// <param name="resurrectCount"></param>
        /// <param name="computeUnits"></param>
        /// <param name="inputBodyLen"></param>
        /// <param name="migrationCount"></param>
        /// <param name="rebootCount"></param>
        /// <param name="memAvgBytes"></param>
        /// <param name="memMaxBytes"></param>
        /// <param name="memCurrentBytes"></param>
        /// <param name="cpuAvgUsage"></param>
        /// <param name="cpuMaxUsage"></param>
        /// <param name="cpuCurrentUsage"></param>
        /// <param name="netRxBytes"></param>
        /// <param name="netTxBytes"></param>
        /// <param name="durationMillis"></param>
        /// <param name="runTimeSecs"></param>
        /// <param name="metamorph"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStats(
            int restartCount,
            int resurrectCount,
            double computeUnits,
            int? inputBodyLen,
            int? migrationCount,
            int? rebootCount,
            double? memAvgBytes,
            long? memMaxBytes,
            long? memCurrentBytes,
            double? cpuAvgUsage,
            double? cpuMaxUsage,
            double? cpuCurrentUsage,
            long? netRxBytes,
            long? netTxBytes,
            int? durationMillis,
            double? runTimeSecs,
            int? metamorph)
        {
            this.InputBodyLen = inputBodyLen;
            this.MigrationCount = migrationCount;
            this.RebootCount = rebootCount;
            this.RestartCount = restartCount;
            this.ResurrectCount = resurrectCount;
            this.MemAvgBytes = memAvgBytes;
            this.MemMaxBytes = memMaxBytes;
            this.MemCurrentBytes = memCurrentBytes;
            this.CpuAvgUsage = cpuAvgUsage;
            this.CpuMaxUsage = cpuMaxUsage;
            this.CpuCurrentUsage = cpuCurrentUsage;
            this.NetRxBytes = netRxBytes;
            this.NetTxBytes = netTxBytes;
            this.DurationMillis = durationMillis;
            this.RunTimeSecs = runTimeSecs;
            this.Metamorph = metamorph;
            this.ComputeUnits = computeUnits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStats" /> class.
        /// </summary>
        public RunStats()
        {
        }
    }
}