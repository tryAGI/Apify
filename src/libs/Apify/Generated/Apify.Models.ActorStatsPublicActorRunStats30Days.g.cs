
#nullable enable

namespace Apify
{
    /// <summary>
    /// Run status counts from the last 30 days. Only for public Actors.<br/>
    /// Excludes runs started by the Actor's owner.
    /// </summary>
    public sealed partial class ActorStatsPublicActorRunStats30Days
    {
        /// <summary>
        /// The number of runs that were aborted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ABORTED")]
        public int? Aborted { get; set; }

        /// <summary>
        /// The number of runs that failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("FAILED")]
        public int? Failed { get; set; }

        /// <summary>
        /// The number of runs that succeeded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("SUCCEEDED")]
        public int? Succeeded { get; set; }

        /// <summary>
        /// The number of runs that timed out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TIMED-OUT")]
        public int? TimedOut { get; set; }

        /// <summary>
        /// The total number of runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TOTAL")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorStatsPublicActorRunStats30Days" /> class.
        /// </summary>
        /// <param name="aborted">
        /// The number of runs that were aborted.
        /// </param>
        /// <param name="failed">
        /// The number of runs that failed.
        /// </param>
        /// <param name="succeeded">
        /// The number of runs that succeeded.
        /// </param>
        /// <param name="timedOut">
        /// The number of runs that timed out.
        /// </param>
        /// <param name="total">
        /// The total number of runs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorStatsPublicActorRunStats30Days(
            int? aborted,
            int? failed,
            int? succeeded,
            int? timedOut,
            int? total)
        {
            this.Aborted = aborted;
            this.Failed = failed;
            this.Succeeded = succeeded;
            this.TimedOut = timedOut;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorStatsPublicActorRunStats30Days" /> class.
        /// </summary>
        public ActorStatsPublicActorRunStats30Days()
        {
        }

    }
}