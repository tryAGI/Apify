
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateActorRequest
    {
        /// <summary>
        /// The identifier of the Actor. Use lowercase letters, numbers, and hyphens. Spaces or special characters aren't allowed. Must be unique across your account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Short description of the Actor, displayed in Apify Store and Console.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the Actor is available to users in Apify Store. If `false`, the Actor is private and only visible to you.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPublic")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorPermissionLevel")]
        public global::Apify.ActorPermissionLevel? ActorPermissionLevel { get; set; }

        /// <summary>
        /// Name of the Actor to display by search engines such as Google. Can be different from the Actor's name displayed in Apify Store and Console. Recommended length is 40-50 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seoTitle")]
        public string? SeoTitle { get; set; }

        /// <summary>
        /// Description of the Actor to display by search engines such as Google. Recommended length is 140-156 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seoDescription")]
        public string? SeoDescription { get; set; }

        /// <summary>
        /// Human-readable name of the Actor, displayed in Apify Store and Console. Can contain spaces and capital letters. Recommended length is 40-50 characters. You can change this title without affecting the Actor's URL or SEO.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restartOnError")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? RestartOnError { get; set; }

        /// <summary>
        /// An array of `Version` objects. Each object represents a specific version of the Actor's source code: its location, builds, and environment configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::System.Collections.Generic.IList<global::Apify.CreateOrUpdateVersionRequest>? Versions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingInfos")]
        public global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>? PricingInfos { get; set; }

        /// <summary>
        /// A list of categories that best define the Actor. Reflected in Apify Store's search and filtering options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// The default settings applied to an Actor run. Can be overridden by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRunOptions")]
        public global::Apify.DefaultRunOptions? DefaultRunOptions { get; set; }

        /// <summary>
        /// A dictionary that maps tag names to specific builds. For details, see [Update build tags](#update-build-tags).<br/>
        /// Example: {"latest":{"buildId":"z2EryhbfhgSyqj6Hn"},"beta":null}
        /// </summary>
        /// <example>{"latest":{"buildId":"z2EryhbfhgSyqj6Hn"},"beta":null}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("taggedBuilds")]
        public global::System.Collections.Generic.Dictionary<string, global::Apify.BuildTag?>? TaggedBuilds { get; set; }

        /// <summary>
        /// The configuration of the Actor's standby mode. For details, see [Standby mode](https://docs.apify.com/platform/actors/development/programming-interface/standby).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorStandby")]
        public global::Apify.ActorStandby? ActorStandby { get; set; }

        /// <summary>
        /// Sample input payload that demonstrates what a typical run input for an Actor looks like. Used when no explicit input for a run is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exampleRunInput")]
        public global::Apify.ExampleRunInput? ExampleRunInput { get; set; }

        /// <summary>
        /// Whether the Actor is deprecated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDeprecated")]
        public bool? IsDeprecated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateActorRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The identifier of the Actor. Use lowercase letters, numbers, and hyphens. Spaces or special characters aren't allowed. Must be unique across your account.
        /// </param>
        /// <param name="description">
        /// Short description of the Actor, displayed in Apify Store and Console.
        /// </param>
        /// <param name="isPublic">
        /// Whether the Actor is available to users in Apify Store. If `false`, the Actor is private and only visible to you.
        /// </param>
        /// <param name="actorPermissionLevel"></param>
        /// <param name="seoTitle">
        /// Name of the Actor to display by search engines such as Google. Can be different from the Actor's name displayed in Apify Store and Console. Recommended length is 40-50 characters.
        /// </param>
        /// <param name="seoDescription">
        /// Description of the Actor to display by search engines such as Google. Recommended length is 140-156 characters.
        /// </param>
        /// <param name="title">
        /// Human-readable name of the Actor, displayed in Apify Store and Console. Can contain spaces and capital letters. Recommended length is 40-50 characters. You can change this title without affecting the Actor's URL or SEO.
        /// </param>
        /// <param name="versions">
        /// An array of `Version` objects. Each object represents a specific version of the Actor's source code: its location, builds, and environment configuration.
        /// </param>
        /// <param name="pricingInfos"></param>
        /// <param name="categories">
        /// A list of categories that best define the Actor. Reflected in Apify Store's search and filtering options.
        /// </param>
        /// <param name="defaultRunOptions">
        /// The default settings applied to an Actor run. Can be overridden by the user.
        /// </param>
        /// <param name="taggedBuilds">
        /// A dictionary that maps tag names to specific builds. For details, see [Update build tags](#update-build-tags).<br/>
        /// Example: {"latest":{"buildId":"z2EryhbfhgSyqj6Hn"},"beta":null}
        /// </param>
        /// <param name="actorStandby">
        /// The configuration of the Actor's standby mode. For details, see [Standby mode](https://docs.apify.com/platform/actors/development/programming-interface/standby).
        /// </param>
        /// <param name="exampleRunInput">
        /// Sample input payload that demonstrates what a typical run input for an Actor looks like. Used when no explicit input for a run is provided.
        /// </param>
        /// <param name="isDeprecated">
        /// Whether the Actor is deprecated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateActorRequest(
            string? name,
            string? description,
            bool? isPublic,
            global::Apify.ActorPermissionLevel? actorPermissionLevel,
            string? seoTitle,
            string? seoDescription,
            string? title,
            global::System.Collections.Generic.IList<global::Apify.CreateOrUpdateVersionRequest>? versions,
            global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>? pricingInfos,
            global::System.Collections.Generic.IList<string>? categories,
            global::Apify.DefaultRunOptions? defaultRunOptions,
            global::System.Collections.Generic.Dictionary<string, global::Apify.BuildTag?>? taggedBuilds,
            global::Apify.ActorStandby? actorStandby,
            global::Apify.ExampleRunInput? exampleRunInput,
            bool? isDeprecated)
        {
            this.Name = name;
            this.Description = description;
            this.IsPublic = isPublic;
            this.ActorPermissionLevel = actorPermissionLevel;
            this.SeoTitle = seoTitle;
            this.SeoDescription = seoDescription;
            this.Title = title;
            this.Versions = versions;
            this.PricingInfos = pricingInfos;
            this.Categories = categories;
            this.DefaultRunOptions = defaultRunOptions;
            this.TaggedBuilds = taggedBuilds;
            this.ActorStandby = actorStandby;
            this.ExampleRunInput = exampleRunInput;
            this.IsDeprecated = isDeprecated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateActorRequest" /> class.
        /// </summary>
        public UpdateActorRequest()
        {
        }

    }
}