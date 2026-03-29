
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Dataset
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("accessedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AccessedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ItemCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleanItemCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CleanItemCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actId")]
        public string? ActId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actRunId")]
        public string? ActRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<string>? Fields { get; set; }

        /// <summary>
        /// Defines the schema of items in your dataset, the full specification can be found in [Apify docs](/platform/actors/development/actor-definition/dataset-schema)<br/>
        /// Example: {"actorSpecification":1,"title":"My dataset","views":{"overview":{"title":"Overview","transformation":{"fields":["linkUrl"]},"display":{"component":"table","properties":{"linkUrl":{"label":"Link URL","format":"link"}}}}}}
        /// </summary>
        /// <example>{"actorSpecification":1,"title":"My dataset","views":{"overview":{"title":"Overview","transformation":{"fields":["linkUrl"]},"display":{"component":"table","properties":{"linkUrl":{"label":"Link URL","format":"link"}}}}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consoleUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConsoleUrl { get; set; }

        /// <summary>
        /// A public link to access the dataset items directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsPublicUrl")]
        public string? ItemsPublicUrl { get; set; }

        /// <summary>
        /// A secret key for generating signed public URLs. It is only provided to clients with WRITE permission for the dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urlSigningSecretKey")]
        public string? UrlSigningSecretKey { get; set; }

        /// <summary>
        /// Defines the general access level for the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generalAccess")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.GeneralAccessJsonConverter))]
        public global::Apify.GeneralAccess? GeneralAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::Apify.DatasetStats? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="accessedAt"></param>
        /// <param name="itemCount"></param>
        /// <param name="cleanItemCount"></param>
        /// <param name="consoleUrl"></param>
        /// <param name="name"></param>
        /// <param name="actId"></param>
        /// <param name="actRunId"></param>
        /// <param name="fields"></param>
        /// <param name="schema">
        /// Defines the schema of items in your dataset, the full specification can be found in [Apify docs](/platform/actors/development/actor-definition/dataset-schema)<br/>
        /// Example: {"actorSpecification":1,"title":"My dataset","views":{"overview":{"title":"Overview","transformation":{"fields":["linkUrl"]},"display":{"component":"table","properties":{"linkUrl":{"label":"Link URL","format":"link"}}}}}}
        /// </param>
        /// <param name="itemsPublicUrl">
        /// A public link to access the dataset items directly.
        /// </param>
        /// <param name="urlSigningSecretKey">
        /// A secret key for generating signed public URLs. It is only provided to clients with WRITE permission for the dataset.
        /// </param>
        /// <param name="generalAccess">
        /// Defines the general access level for the resource.
        /// </param>
        /// <param name="stats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Dataset(
            string id,
            string userId,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt,
            global::System.DateTime accessedAt,
            int itemCount,
            int cleanItemCount,
            string consoleUrl,
            string? name,
            string? actId,
            string? actRunId,
            global::System.Collections.Generic.IList<string>? fields,
            object? schema,
            string? itemsPublicUrl,
            string? urlSigningSecretKey,
            global::Apify.GeneralAccess? generalAccess,
            global::Apify.DatasetStats? stats)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.AccessedAt = accessedAt;
            this.ItemCount = itemCount;
            this.CleanItemCount = cleanItemCount;
            this.ActId = actId;
            this.ActRunId = actRunId;
            this.Fields = fields;
            this.Schema = schema;
            this.ConsoleUrl = consoleUrl ?? throw new global::System.ArgumentNullException(nameof(consoleUrl));
            this.ItemsPublicUrl = itemsPublicUrl;
            this.UrlSigningSecretKey = urlSigningSecretKey;
            this.GeneralAccess = generalAccess;
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}