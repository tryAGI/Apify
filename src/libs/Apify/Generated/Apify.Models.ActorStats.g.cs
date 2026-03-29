
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActorStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalBuilds")]
        public int? TotalBuilds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRuns")]
        public int? TotalRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsers")]
        public int? TotalUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsers7Days")]
        public int? TotalUsers7Days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsers30Days")]
        public int? TotalUsers30Days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsers90Days")]
        public int? TotalUsers90Days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalMetamorphs")]
        public int? TotalMetamorphs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastRunStartedAt")]
        public global::System.DateTime? LastRunStartedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorStats" /> class.
        /// </summary>
        /// <param name="totalBuilds"></param>
        /// <param name="totalRuns"></param>
        /// <param name="totalUsers"></param>
        /// <param name="totalUsers7Days"></param>
        /// <param name="totalUsers30Days"></param>
        /// <param name="totalUsers90Days"></param>
        /// <param name="totalMetamorphs"></param>
        /// <param name="lastRunStartedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorStats(
            int? totalBuilds,
            int? totalRuns,
            int? totalUsers,
            int? totalUsers7Days,
            int? totalUsers30Days,
            int? totalUsers90Days,
            int? totalMetamorphs,
            global::System.DateTime? lastRunStartedAt)
        {
            this.TotalBuilds = totalBuilds;
            this.TotalRuns = totalRuns;
            this.TotalUsers = totalUsers;
            this.TotalUsers7Days = totalUsers7Days;
            this.TotalUsers30Days = totalUsers30Days;
            this.TotalUsers90Days = totalUsers90Days;
            this.TotalMetamorphs = totalMetamorphs;
            this.LastRunStartedAt = lastRunStartedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorStats" /> class.
        /// </summary>
        public ActorStats()
        {
        }
    }
}