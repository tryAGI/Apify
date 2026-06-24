
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Actor
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
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restartOnError")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? RestartOnError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPublic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPublic { get; set; }

        /// <summary>
        /// Determines the permission level that the Actor requires to run. For details, see [Actor permissions](https://docs.apify.com/platform/actors/development/permissions).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorPermissionLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ActorPermissionLevelJsonConverter))]
        public global::Apify.ActorPermissionLevel? ActorPermissionLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modifiedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.ActorStats Stats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.Version> Versions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingInfos")]
        public global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>? PricingInfos { get; set; }

        /// <summary>
        /// The default settings applied to an Actor run. Can be overridden elsewhere.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRunOptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.DefaultRunOptions DefaultRunOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exampleRunInput")]
        public global::Apify.ExampleRunInput? ExampleRunInput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDeprecated")]
        public bool? IsDeprecated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentKey")]
        public string? DeploymentKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taggedBuilds")]
        public global::Apify.TaggedBuilds? TaggedBuilds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorStandby")]
        public global::Apify.ActorStandby? ActorStandby { get; set; }

        /// <summary>
        /// A brief, LLM-generated readme summary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readmeSummary")]
        public string? ReadmeSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seoTitle")]
        public string? SeoTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seoDescription")]
        public string? SeoDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standbyUrl")]
        public string? StandbyUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notice")]
        public string? Notice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCritical")]
        public bool? IsCritical { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isGeneric")]
        public bool? IsGeneric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSourceCodeHidden")]
        public bool? IsSourceCodeHidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasNoDataset")]
        public bool? HasNoDataset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Actor" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="isPublic"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="stats"></param>
        /// <param name="versions"></param>
        /// <param name="defaultRunOptions">
        /// The default settings applied to an Actor run. Can be overridden elsewhere.
        /// </param>
        /// <param name="description"></param>
        /// <param name="actorPermissionLevel">
        /// Determines the permission level that the Actor requires to run. For details, see [Actor permissions](https://docs.apify.com/platform/actors/development/permissions).
        /// </param>
        /// <param name="pricingInfos"></param>
        /// <param name="exampleRunInput"></param>
        /// <param name="isDeprecated"></param>
        /// <param name="deploymentKey"></param>
        /// <param name="title"></param>
        /// <param name="taggedBuilds"></param>
        /// <param name="actorStandby"></param>
        /// <param name="readmeSummary">
        /// A brief, LLM-generated readme summary
        /// </param>
        /// <param name="seoTitle"></param>
        /// <param name="seoDescription"></param>
        /// <param name="pictureUrl"></param>
        /// <param name="standbyUrl"></param>
        /// <param name="notice"></param>
        /// <param name="categories"></param>
        /// <param name="isCritical"></param>
        /// <param name="isGeneric"></param>
        /// <param name="isSourceCodeHidden"></param>
        /// <param name="hasNoDataset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Actor(
            string id,
            string userId,
            string name,
            string username,
            bool isPublic,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt,
            global::Apify.ActorStats stats,
            global::System.Collections.Generic.IList<global::Apify.Version> versions,
            global::Apify.DefaultRunOptions defaultRunOptions,
            string? description,
            global::Apify.ActorPermissionLevel? actorPermissionLevel,
            global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>? pricingInfos,
            global::Apify.ExampleRunInput? exampleRunInput,
            bool? isDeprecated,
            string? deploymentKey,
            string? title,
            global::Apify.TaggedBuilds? taggedBuilds,
            global::Apify.ActorStandby? actorStandby,
            string? readmeSummary,
            string? seoTitle,
            string? seoDescription,
            string? pictureUrl,
            string? standbyUrl,
            string? notice,
            global::System.Collections.Generic.IList<string>? categories,
            bool? isCritical,
            bool? isGeneric,
            bool? isSourceCodeHidden,
            bool? hasNoDataset)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Description = description;
            this.IsPublic = isPublic;
            this.ActorPermissionLevel = actorPermissionLevel;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.Stats = stats ?? throw new global::System.ArgumentNullException(nameof(stats));
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
            this.PricingInfos = pricingInfos;
            this.DefaultRunOptions = defaultRunOptions ?? throw new global::System.ArgumentNullException(nameof(defaultRunOptions));
            this.ExampleRunInput = exampleRunInput;
            this.IsDeprecated = isDeprecated;
            this.DeploymentKey = deploymentKey;
            this.Title = title;
            this.TaggedBuilds = taggedBuilds;
            this.ActorStandby = actorStandby;
            this.ReadmeSummary = readmeSummary;
            this.SeoTitle = seoTitle;
            this.SeoDescription = seoDescription;
            this.PictureUrl = pictureUrl;
            this.StandbyUrl = standbyUrl;
            this.Notice = notice;
            this.Categories = categories;
            this.IsCritical = isCritical;
            this.IsGeneric = isGeneric;
            this.IsSourceCodeHidden = isSourceCodeHidden;
            this.HasNoDataset = hasNoDataset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Actor" /> class.
        /// </summary>
        public Actor()
        {
        }

    }
}