
#nullable enable

namespace Apify
{
    /// <summary>
    /// The public part of the connection's OAuth client configuration.
    /// </summary>
    public sealed partial class ActorOAuthConnectionCredentials
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Display name of a `CUSTOM` provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Logo URL of a `CUSTOM` provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorOAuthConnectionCredentials" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="scope"></param>
        /// <param name="label">
        /// Display name of a `CUSTOM` provider.
        /// </param>
        /// <param name="imageUrl">
        /// Logo URL of a `CUSTOM` provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorOAuthConnectionCredentials(
            string? clientId,
            string? scope,
            string? label,
            string? imageUrl)
        {
            this.ClientId = clientId;
            this.Scope = scope;
            this.Label = label;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorOAuthConnectionCredentials" /> class.
        /// </summary>
        public ActorOAuthConnectionCredentials()
        {
        }

    }
}