
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeyValueStore
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
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("consoleUrl")]
        public string? ConsoleUrl { get; set; }

        /// <summary>
        /// A public link to access keys of the key-value store directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keysPublicUrl")]
        public string? KeysPublicUrl { get; set; }

        /// <summary>
        /// A public link to access records of the key-value store directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordsPublicUrl")]
        public string? RecordsPublicUrl { get; set; }

        /// <summary>
        /// Optional JSON schema describing the keys stored in the key-value store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// A secret key for generating signed public URLs. It is only provided to clients with WRITE permission for the key-value store.
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
        public global::Apify.KeyValueStoreStats? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyValueStore" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="accessedAt"></param>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="username"></param>
        /// <param name="actId"></param>
        /// <param name="actRunId"></param>
        /// <param name="consoleUrl"></param>
        /// <param name="keysPublicUrl">
        /// A public link to access keys of the key-value store directly.
        /// </param>
        /// <param name="recordsPublicUrl">
        /// A public link to access records of the key-value store directly.
        /// </param>
        /// <param name="schema">
        /// Optional JSON schema describing the keys stored in the key-value store.
        /// </param>
        /// <param name="urlSigningSecretKey">
        /// A secret key for generating signed public URLs. It is only provided to clients with WRITE permission for the key-value store.
        /// </param>
        /// <param name="generalAccess">
        /// Defines the general access level for the resource.
        /// </param>
        /// <param name="stats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyValueStore(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt,
            global::System.DateTime accessedAt,
            string? name,
            string? userId,
            string? username,
            string? actId,
            string? actRunId,
            string? consoleUrl,
            string? keysPublicUrl,
            string? recordsPublicUrl,
            object? schema,
            string? urlSigningSecretKey,
            global::Apify.GeneralAccess? generalAccess,
            global::Apify.KeyValueStoreStats? stats)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.UserId = userId;
            this.Username = username;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.AccessedAt = accessedAt;
            this.ActId = actId;
            this.ActRunId = actRunId;
            this.ConsoleUrl = consoleUrl;
            this.KeysPublicUrl = keysPublicUrl;
            this.RecordsPublicUrl = recordsPublicUrl;
            this.Schema = schema;
            this.UrlSigningSecretKey = urlSigningSecretKey;
            this.GeneralAccess = generalAccess;
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyValueStore" /> class.
        /// </summary>
        public KeyValueStore()
        {
        }

    }
}