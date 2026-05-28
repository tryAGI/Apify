
#nullable enable

namespace Apify
{
    /// <summary>
    /// Run status counts over the past 30 days.
    /// </summary>
    public sealed partial class ActorStatsPublicActorRunStats30Days
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ABORTED")]
        public int? Aborted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("FAILED")]
        public int? Failed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("SUCCEEDED")]
        public int? Succeeded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TIMED-OUT")]
        public int? TimedOut { get; set; }

        /// <summary>
        /// 
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
        /// <param name="aborted"></param>
        /// <param name="failed"></param>
        /// <param name="succeeded"></param>
        /// <param name="timedOut"></param>
        /// <param name="total"></param>
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