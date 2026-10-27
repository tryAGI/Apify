
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TaskStats
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRuns")]
        public int? TotalRuns { get; set; }

        /// <summary>
        /// Time when the last run of the task started. In the task list, it's `null` if the task has no runs. In a single task, it's omitted if the task has no runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastRunStartedAt")]
        public global::System.DateTime? LastRunStartedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskStats" /> class.
        /// </summary>
        /// <param name="totalRuns"></param>
        /// <param name="lastRunStartedAt">
        /// Time when the last run of the task started. In the task list, it's `null` if the task has no runs. In a single task, it's omitted if the task has no runs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskStats(
            int? totalRuns,
            global::System.DateTime? lastRunStartedAt)
        {
            this.TotalRuns = totalRuns;
            this.LastRunStartedAt = lastRunStartedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskStats" /> class.
        /// </summary>
        public TaskStats()
        {
        }

    }
}