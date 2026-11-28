
#nullable enable

namespace Apify
{
    /// <summary>
    /// Actor usage statistics and Apify Store metrics returned by the Store endpoint.
    /// </summary>
    public sealed partial class StoreActorStats
    {
        /// <summary>
        /// The total number of Actor users, including its owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalUsers { get; set; }

        /// <summary>
        /// The total number of runs of the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRuns")]
        public int? TotalRuns { get; set; }

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
        /// The average rating of the Actor in Apify Store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorReviewRating")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ActorReviewRating { get; set; }

        /// <summary>
        /// The number of reviews the Actor has received in Apify Store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorReviewCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActorReviewCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreActorStats" /> class.
        /// </summary>
        /// <param name="totalUsers">
        /// The total number of Actor users, including its owner.
        /// </param>
        /// <param name="actorReviewRating">
        /// The average rating of the Actor in Apify Store.
        /// </param>
        /// <param name="actorReviewCount">
        /// The number of reviews the Actor has received in Apify Store.
        /// </param>
        /// <param name="totalRuns">
        /// The total number of runs of the Actor.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreActorStats(
            int totalUsers,
            double actorReviewRating,
            int actorReviewCount,
            int? totalRuns,
            int? totalUsers7Days,
            int? totalUsers30Days,
            int? totalUsers90Days)
        {
            this.TotalUsers = totalUsers;
            this.TotalRuns = totalRuns;
            this.TotalUsers7Days = totalUsers7Days;
            this.TotalUsers30Days = totalUsers30Days;
            this.TotalUsers90Days = totalUsers90Days;
            this.ActorReviewRating = actorReviewRating;
            this.ActorReviewCount = actorReviewCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreActorStats" /> class.
        /// </summary>
        public StoreActorStats()
        {
        }

    }
}