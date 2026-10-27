
#nullable enable

namespace Apify
{
    /// <summary>
    /// An OAuth connection configured on an Actor. Secret credentials are never returned.
    /// </summary>
    public sealed partial class ActorOAuthConnection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oAuthProviderType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ActorOAuthConnectionOAuthProviderTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.ActorOAuthConnectionOAuthProviderType OAuthProviderType { get; set; }

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
        /// The public part of the connection's OAuth client configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Apify.ActorOAuthConnectionCredentials? Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorOAuthConnection" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actorId"></param>
        /// <param name="oAuthProviderType"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="credentials">
        /// The public part of the connection's OAuth client configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorOAuthConnection(
            string id,
            string actorId,
            global::Apify.ActorOAuthConnectionOAuthProviderType oAuthProviderType,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt,
            global::Apify.ActorOAuthConnectionCredentials? credentials)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ActorId = actorId ?? throw new global::System.ArgumentNullException(nameof(actorId));
            this.OAuthProviderType = oAuthProviderType;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.Credentials = credentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorOAuthConnection" /> class.
        /// </summary>
        public ActorOAuthConnection()
        {
        }

    }
}