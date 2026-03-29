
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPublic")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorPermissionLevel")]
        public global::Apify.ActorPermissionLevel? ActorPermissionLevel { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restartOnError")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? RestartOnError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::System.Collections.Generic.IList<global::Apify.CreateOrUpdateVersionRequest>? Versions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingInfos")]
        public global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>? PricingInfos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRunOptions")]
        public global::Apify.DefaultRunOptions? DefaultRunOptions { get; set; }

        /// <summary>
        /// An object to modify tags on the Actor's builds. The key is the tag name (e.g., _latest_), and the value is either an object with a `buildId` or `null`.<br/>
        /// This operation is a patch; any existing tags that you omit from this object will be preserved.<br/>
        /// - **To create or reassign a tag**, provide the tag name with a `buildId`. e.g., to assign the _latest_ tag:<br/>
        ///   &amp;nbsp;<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "latest": {<br/>
        ///       "buildId": "z2EryhbfhgSyqj6Hn"<br/>
        ///     }<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - **To remove a tag**, provide the tag name with a `null` value. e.g., to remove the _beta_ tag:<br/>
        ///   &amp;nbsp;<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "beta": null<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - **To perform multiple operations**, combine them. The following reassigns _latest_ and removes _beta_, while preserving any other existing tags.<br/>
        ///   &amp;nbsp;<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "latest": {<br/>
        ///       "buildId": "z2EryhbfhgSyqj6Hn"<br/>
        ///     },<br/>
        ///     "beta": null<br/>
        ///   }<br/>
        ///   ```<br/>
        /// Example: {"latest":{"buildId":"z2EryhbfhgSyqj6Hn"},"beta":null}
        /// </summary>
        /// <example>{"latest":{"buildId":"z2EryhbfhgSyqj6Hn"},"beta":null}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("taggedBuilds")]
        public global::System.Collections.Generic.Dictionary<string, global::Apify.BuildTag?>? TaggedBuilds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorStandby")]
        public global::Apify.ActorStandby? ActorStandby { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateActorRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="isPublic"></param>
        /// <param name="actorPermissionLevel"></param>
        /// <param name="seoTitle"></param>
        /// <param name="seoDescription"></param>
        /// <param name="title"></param>
        /// <param name="versions"></param>
        /// <param name="pricingInfos"></param>
        /// <param name="categories"></param>
        /// <param name="defaultRunOptions"></param>
        /// <param name="taggedBuilds">
        /// An object to modify tags on the Actor's builds. The key is the tag name (e.g., _latest_), and the value is either an object with a `buildId` or `null`.<br/>
        /// This operation is a patch; any existing tags that you omit from this object will be preserved.<br/>
        /// - **To create or reassign a tag**, provide the tag name with a `buildId`. e.g., to assign the _latest_ tag:<br/>
        ///   &amp;nbsp;<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "latest": {<br/>
        ///       "buildId": "z2EryhbfhgSyqj6Hn"<br/>
        ///     }<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - **To remove a tag**, provide the tag name with a `null` value. e.g., to remove the _beta_ tag:<br/>
        ///   &amp;nbsp;<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "beta": null<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - **To perform multiple operations**, combine them. The following reassigns _latest_ and removes _beta_, while preserving any other existing tags.<br/>
        ///   &amp;nbsp;<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "latest": {<br/>
        ///       "buildId": "z2EryhbfhgSyqj6Hn"<br/>
        ///     },<br/>
        ///     "beta": null<br/>
        ///   }<br/>
        ///   ```<br/>
        /// Example: {"latest":{"buildId":"z2EryhbfhgSyqj6Hn"},"beta":null}
        /// </param>
        /// <param name="actorStandby"></param>
        /// <param name="exampleRunInput"></param>
        /// <param name="isDeprecated"></param>
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