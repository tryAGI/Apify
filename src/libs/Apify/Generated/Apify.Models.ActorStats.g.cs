
#nullable enable

namespace Apify
{
    /// <summary>
    /// Usage statistics and Apify Store metrics for the Actor.
    /// </summary>
    public sealed partial class ActorStats
    {
        /// <summary>
        /// The total number of builds of the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalBuilds")]
        public int? TotalBuilds { get; set; }

        /// <summary>
        /// The total number of runs of the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRuns")]
        public int? TotalRuns { get; set; }

        /// <summary>
        /// The total number of Actor users, including its owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsers")]
        public int? TotalUsers { get; set; }

        /// <summary>
        /// The number of active users of the Actor in the last 7 days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsers7Days")]
        public int? TotalUsers7Days { get; set; }

        /// <summary>
        /// The number of active users of the Actor in the last 30 days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsers30Days")]
        public int? TotalUsers30Days { get; set; }

        /// <summary>
        /// The number of active users of the Actor in the last 90 days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsers90Days")]
        public int? TotalUsers90Days { get; set; }

        /// <summary>
        /// The total number of times a run of another Actor was [metamorphed](https://docs.apify.com/platform/actors/development/programming-interface/metamorph) into this Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalMetamorphs")]
        public int? TotalMetamorphs { get; set; }

        /// <summary>
        /// The date and time the most recent run of the Actor started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastRunStartedAt")]
        public global::System.DateTime? LastRunStartedAt { get; set; }

        /// <summary>
        /// The number of reviews the Actor has received in Apify Store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorReviewCount")]
        public int? ActorReviewCount { get; set; }

        /// <summary>
        /// The average rating of the Actor in Apify Store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorReviewRating")]
        public double? ActorReviewRating { get; set; }

        /// <summary>
        /// The number of users who bookmarked the Actor in Apify Store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bookmarkCount")]
        public int? BookmarkCount { get; set; }

        /// <summary>
        /// Run status counts from the last 30 days. Only for public Actors.<br/>
        /// Excludes runs started by the Actor's owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicActorRunStats30Days")]
        public global::Apify.ActorStatsPublicActorRunStats30Days? PublicActorRunStats30Days { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorStats" /> class.
        /// </summary>
        /// <param name="totalBuilds">
        /// The total number of builds of the Actor.
        /// </param>
        /// <param name="totalRuns">
        /// The total number of runs of the Actor.
        /// </param>
        /// <param name="totalUsers">
        /// The total number of Actor users, including its owner.
        /// </param>
        /// <param name="totalUsers7Days">
        /// The number of active users of the Actor in the last 7 days.
        /// </param>
        /// <param name="totalUsers30Days">
        /// The number of active users of the Actor in the last 30 days.
        /// </param>
        /// <param name="totalUsers90Days">
        /// The number of active users of the Actor in the last 90 days.
        /// </param>
        /// <param name="totalMetamorphs">
        /// The total number of times a run of another Actor was [metamorphed](https://docs.apify.com/platform/actors/development/programming-interface/metamorph) into this Actor.
        /// </param>
        /// <param name="lastRunStartedAt">
        /// The date and time the most recent run of the Actor started.
        /// </param>
        /// <param name="actorReviewCount">
        /// The number of reviews the Actor has received in Apify Store.
        /// </param>
        /// <param name="actorReviewRating">
        /// The average rating of the Actor in Apify Store.
        /// </param>
        /// <param name="bookmarkCount">
        /// The number of users who bookmarked the Actor in Apify Store.
        /// </param>
        /// <param name="publicActorRunStats30Days">
        /// Run status counts from the last 30 days. Only for public Actors.<br/>
        /// Excludes runs started by the Actor's owner.
        /// </param>
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
            global::System.DateTime? lastRunStartedAt,
            int? actorReviewCount,
            double? actorReviewRating,
            int? bookmarkCount,
            global::Apify.ActorStatsPublicActorRunStats30Days? publicActorRunStats30Days)
        {
            this.TotalBuilds = totalBuilds;
            this.TotalRuns = totalRuns;
            this.TotalUsers = totalUsers;
            this.TotalUsers7Days = totalUsers7Days;
            this.TotalUsers30Days = totalUsers30Days;
            this.TotalUsers90Days = totalUsers90Days;
            this.TotalMetamorphs = totalMetamorphs;
            this.LastRunStartedAt = lastRunStartedAt;
            this.ActorReviewCount = actorReviewCount;
            this.ActorReviewRating = actorReviewRating;
            this.BookmarkCount = bookmarkCount;
            this.PublicActorRunStats30Days = publicActorRunStats30Days;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorStats" /> class.
        /// </summary>
        public ActorStats()
        {
        }

    }
}