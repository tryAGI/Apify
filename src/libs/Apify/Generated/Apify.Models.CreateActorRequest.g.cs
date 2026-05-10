
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateActorRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPublic")]
        public bool? IsPublic { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("restartOnError")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? RestartOnError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::System.Collections.Generic.IList<global::Apify.Version>? Versions { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateActorRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
        /// <param name="isPublic"></param>
        /// <param name="seoTitle"></param>
        /// <param name="seoDescription"></param>
        /// <param name="versions"></param>
        /// <param name="pricingInfos"></param>
        /// <param name="categories"></param>
        /// <param name="defaultRunOptions"></param>
        /// <param name="actorStandby"></param>
        /// <param name="exampleRunInput"></param>
        /// <param name="isDeprecated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateActorRequest(
            string? name,
            string? description,
            string? title,
            bool? isPublic,
            string? seoTitle,
            string? seoDescription,
            global::System.Collections.Generic.IList<global::Apify.Version>? versions,
            global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>? pricingInfos,
            global::System.Collections.Generic.IList<string>? categories,
            global::Apify.DefaultRunOptions? defaultRunOptions,
            global::Apify.ActorStandby? actorStandby,
            global::Apify.ExampleRunInput? exampleRunInput,
            bool? isDeprecated)
        {
            this.Name = name;
            this.Description = description;
            this.Title = title;
            this.IsPublic = isPublic;
            this.SeoTitle = seoTitle;
            this.SeoDescription = seoDescription;
            this.Versions = versions;
            this.PricingInfos = pricingInfos;
            this.Categories = categories;
            this.DefaultRunOptions = defaultRunOptions;
            this.ActorStandby = actorStandby;
            this.ExampleRunInput = exampleRunInput;
            this.IsDeprecated = isDeprecated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateActorRequest" /> class.
        /// </summary>
        public CreateActorRequest()
        {
        }

    }
}