
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildMeta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.RunOriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.RunOrigin Origin { get; set; }

        /// <summary>
        /// IP address of the client that started the build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientIp")]
        public string? ClientIp { get; set; }

        /// <summary>
        /// User agent of the client that started the build. Returned only to the Actor owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAgent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// URL of the GitHub Actions run that started the build. Present only for builds started from CI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("githubActionsRunUrl")]
        public string? GithubActionsRunUrl { get; set; }

        /// <summary>
        /// ID of the Actor run that started the build. Returned only to the Actor owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorRunId")]
        public string? ActorRunId { get; set; }

        /// <summary>
        /// ID of the webhook dispatch that started the build. Returned only to the Actor owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookDispatchId")]
        public string? WebhookDispatchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildMeta" /> class.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="clientIp">
        /// IP address of the client that started the build.
        /// </param>
        /// <param name="userAgent">
        /// User agent of the client that started the build. Returned only to the Actor owner.
        /// </param>
        /// <param name="githubActionsRunUrl">
        /// URL of the GitHub Actions run that started the build. Present only for builds started from CI.
        /// </param>
        /// <param name="actorRunId">
        /// ID of the Actor run that started the build. Returned only to the Actor owner.
        /// </param>
        /// <param name="webhookDispatchId">
        /// ID of the webhook dispatch that started the build. Returned only to the Actor owner.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildMeta(
            global::Apify.RunOrigin origin,
            string? clientIp,
            string? userAgent,
            string? githubActionsRunUrl,
            string? actorRunId,
            string? webhookDispatchId)
        {
            this.Origin = origin;
            this.ClientIp = clientIp;
            this.UserAgent = userAgent;
            this.GithubActionsRunUrl = githubActionsRunUrl;
            this.ActorRunId = actorRunId;
            this.WebhookDispatchId = webhookDispatchId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildMeta" /> class.
        /// </summary>
        public BuildMeta()
        {
        }

    }
}