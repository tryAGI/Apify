
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StoreListActor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userFullName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserFullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Example: [MARKETING, LEAD_GENERATION]
        /// </summary>
        /// <example>[MARKETING, LEAD_GENERATION]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notice")]
        public string? Notice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userPictureUrl")]
        public string? UserPictureUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.ActorStats Stats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentPricingInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.CurrentPricingInfo CurrentPricingInfo { get; set; }

        /// <summary>
        /// Whether the Actor is whitelisted for agentic payment processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isWhiteListedForAgenticPayments")]
        public bool? IsWhiteListedForAgenticPayments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorReviewCount")]
        public int? ActorReviewCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorReviewRating")]
        public double? ActorReviewRating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bookmarkCount")]
        public int? BookmarkCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("badge")]
        public string? Badge { get; set; }

        /// <summary>
        /// A brief, LLM-generated readme summary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readmeSummary")]
        public string? ReadmeSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreListActor" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="userFullName"></param>
        /// <param name="description"></param>
        /// <param name="stats"></param>
        /// <param name="currentPricingInfo"></param>
        /// <param name="categories">
        /// Example: [MARKETING, LEAD_GENERATION]
        /// </param>
        /// <param name="notice"></param>
        /// <param name="pictureUrl"></param>
        /// <param name="userPictureUrl"></param>
        /// <param name="url"></param>
        /// <param name="isWhiteListedForAgenticPayments">
        /// Whether the Actor is whitelisted for agentic payment processing.
        /// </param>
        /// <param name="actorReviewCount"></param>
        /// <param name="actorReviewRating"></param>
        /// <param name="bookmarkCount"></param>
        /// <param name="badge"></param>
        /// <param name="readmeSummary">
        /// A brief, LLM-generated readme summary
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreListActor(
            string id,
            string title,
            string name,
            string username,
            string userFullName,
            string description,
            global::Apify.ActorStats stats,
            global::Apify.CurrentPricingInfo currentPricingInfo,
            global::System.Collections.Generic.IList<string>? categories,
            string? notice,
            string? pictureUrl,
            string? userPictureUrl,
            string? url,
            bool? isWhiteListedForAgenticPayments,
            int? actorReviewCount,
            double? actorReviewRating,
            int? bookmarkCount,
            string? badge,
            string? readmeSummary)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.UserFullName = userFullName ?? throw new global::System.ArgumentNullException(nameof(userFullName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Categories = categories;
            this.Notice = notice;
            this.PictureUrl = pictureUrl;
            this.UserPictureUrl = userPictureUrl;
            this.Url = url;
            this.Stats = stats ?? throw new global::System.ArgumentNullException(nameof(stats));
            this.CurrentPricingInfo = currentPricingInfo ?? throw new global::System.ArgumentNullException(nameof(currentPricingInfo));
            this.IsWhiteListedForAgenticPayments = isWhiteListedForAgenticPayments;
            this.ActorReviewCount = actorReviewCount;
            this.ActorReviewRating = actorReviewRating;
            this.BookmarkCount = bookmarkCount;
            this.Badge = badge;
            this.ReadmeSummary = readmeSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreListActor" /> class.
        /// </summary>
        public StoreListActor()
        {
        }

    }
}