
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetListItem
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

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
        /// Initializes a new instance of the <see cref="DatasetListItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="accessedAt"></param>
        /// <param name="itemCount"></param>
        /// <param name="cleanItemCount"></param>
        /// <param name="actId"></param>
        /// <param name="actRunId"></param>
        /// <param name="title"></param>
        /// <param name="username"></param>
        /// <param name="generalAccess">
        /// Defines the general access level for the resource.
        /// </param>
        /// <param name="stats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetListItem(
            string id,
            string name,
            string userId,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt,
            global::System.DateTime accessedAt,
            int itemCount,
            int cleanItemCount,
            string? actId,
            string? actRunId,
            string? title,
            string? username,
            global::Apify.GeneralAccess? generalAccess,
            global::Apify.DatasetStats? stats)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.AccessedAt = accessedAt;
            this.ItemCount = itemCount;
            this.CleanItemCount = cleanItemCount;
            this.ActId = actId;
            this.ActRunId = actRunId;
            this.Title = title;
            this.Username = username;
            this.GeneralAccess = generalAccess;
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetListItem" /> class.
        /// </summary>
        public DatasetListItem()
        {
        }

    }
}