
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
        /// The ID of the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the user who owns the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The name of the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The username of the Actor owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Short description of the Actor, displayed in Apify Store and Console.
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
        /// Whether the Actor is available to users in Apify Store.
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
        /// The date and time the Actor was created. Follows the ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time the Actor was last modified. Follows the ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modifiedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ModifiedAt { get; set; }

        /// <summary>
        /// Usage statistics and Apify Store metrics for the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.ActorStats Stats { get; set; }

        /// <summary>
        /// An array of `Version` objects. Each object represents a specific version of the Actor's source code: its location, builds, and environment configuration.
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
        /// Whether the Actor is deprecated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDeprecated")]
        public bool? IsDeprecated { get; set; }

        /// <summary>
        /// The Actor's public SSH key, used as a deployment key for private Git repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentKey")]
        public string? DeploymentKey { get; set; }

        /// <summary>
        /// Human-readable name of the Actor, displayed in Apify Store and Console.
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
        /// An AI-generated Markdown summary of the Actor's README, optimized for search and AI agents. Contains an overview and a list of use cases. Generated only for public Actors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readmeSummary")]
        public string? ReadmeSummary { get; set; }

        /// <summary>
        /// Name of the Actor to display by search engines such as Google. Can be different from the Actor's name displayed in Apify Store and Console.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seoTitle")]
        public string? SeoTitle { get; set; }

        /// <summary>
        /// Description of the Actor to display by search engines such as Google.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seoDescription")]
        public string? SeoDescription { get; set; }

        /// <summary>
        /// URL of the Actor's icon, displayed on the Actor's page in Apify Store and Console.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// URL for sending requests to the Actor in Standby mode.<br/>
        /// `null` if the Standby mode isn't enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standbyUrl")]
        public string? StandbyUrl { get; set; }

        /// <summary>
        /// A warning displayed on the Actor's page in Apify Store and Console. Can be set by the Actor's developer or automatically by Apify's quality checks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ActorNoticeJsonConverter))]
        public global::Apify.ActorNotice? Notice { get; set; }

        /// <summary>
        /// A list of categories that best define the Actor. Reflected in Apify Store's search and filtering options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// Whether the Actor is maintained by Apify.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCritical")]
        public bool? IsCritical { get; set; }

        /// <summary>
        /// Whether the Actor is intended for developers. Set by Apify.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isGeneric")]
        public bool? IsGeneric { get; set; }

        /// <summary>
        /// Whether the Actor's source files are hidden on its detail page.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSourceCodeHidden")]
        public bool? IsSourceCodeHidden { get; set; }

        /// <summary>
        /// Whether the Actor stores results in a dataset. Set by Apify.
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
        /// <param name="id">
        /// The ID of the Actor.
        /// </param>
        /// <param name="userId">
        /// The ID of the user who owns the Actor.
        /// </param>
        /// <param name="name">
        /// The name of the Actor.
        /// </param>
        /// <param name="username">
        /// The username of the Actor owner.
        /// </param>
        /// <param name="isPublic">
        /// Whether the Actor is available to users in Apify Store.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the Actor was created. Follows the ISO 8601 format.
        /// </param>
        /// <param name="modifiedAt">
        /// The date and time the Actor was last modified. Follows the ISO 8601 format.
        /// </param>
        /// <param name="stats">
        /// Usage statistics and Apify Store metrics for the Actor.
        /// </param>
        /// <param name="versions">
        /// An array of `Version` objects. Each object represents a specific version of the Actor's source code: its location, builds, and environment configuration.
        /// </param>
        /// <param name="defaultRunOptions">
        /// The default settings applied to an Actor run. Can be overridden elsewhere.
        /// </param>
        /// <param name="description">
        /// Short description of the Actor, displayed in Apify Store and Console.
        /// </param>
        /// <param name="actorPermissionLevel">
        /// Determines the permission level that the Actor requires to run. For details, see [Actor permissions](https://docs.apify.com/platform/actors/development/permissions).
        /// </param>
        /// <param name="pricingInfos"></param>
        /// <param name="exampleRunInput"></param>
        /// <param name="isDeprecated">
        /// Whether the Actor is deprecated.
        /// </param>
        /// <param name="deploymentKey">
        /// The Actor's public SSH key, used as a deployment key for private Git repositories.
        /// </param>
        /// <param name="title">
        /// Human-readable name of the Actor, displayed in Apify Store and Console.
        /// </param>
        /// <param name="taggedBuilds"></param>
        /// <param name="actorStandby"></param>
        /// <param name="readmeSummary">
        /// An AI-generated Markdown summary of the Actor's README, optimized for search and AI agents. Contains an overview and a list of use cases. Generated only for public Actors.
        /// </param>
        /// <param name="seoTitle">
        /// Name of the Actor to display by search engines such as Google. Can be different from the Actor's name displayed in Apify Store and Console.
        /// </param>
        /// <param name="seoDescription">
        /// Description of the Actor to display by search engines such as Google.
        /// </param>
        /// <param name="pictureUrl">
        /// URL of the Actor's icon, displayed on the Actor's page in Apify Store and Console.
        /// </param>
        /// <param name="standbyUrl">
        /// URL for sending requests to the Actor in Standby mode.<br/>
        /// `null` if the Standby mode isn't enabled.
        /// </param>
        /// <param name="notice">
        /// A warning displayed on the Actor's page in Apify Store and Console. Can be set by the Actor's developer or automatically by Apify's quality checks.
        /// </param>
        /// <param name="categories">
        /// A list of categories that best define the Actor. Reflected in Apify Store's search and filtering options.
        /// </param>
        /// <param name="isCritical">
        /// Whether the Actor is maintained by Apify.
        /// </param>
        /// <param name="isGeneric">
        /// Whether the Actor is intended for developers. Set by Apify.
        /// </param>
        /// <param name="isSourceCodeHidden">
        /// Whether the Actor's source files are hidden on its detail page.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="hasNoDataset">
        /// Whether the Actor stores results in a dataset. Set by Apify.
        /// </param>
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
            global::Apify.ActorNotice? notice,
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