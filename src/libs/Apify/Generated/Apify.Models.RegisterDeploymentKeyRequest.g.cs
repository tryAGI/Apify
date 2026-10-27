
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegisterDeploymentKeyRequest
    {
        /// <summary>
        /// ID or `username~name` of the Actor whose deployment key to register.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorId { get; set; }

        /// <summary>
        /// URL of the repository to register the key on. Its host must match the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterDeploymentKeyRequest" /> class.
        /// </summary>
        /// <param name="actorId">
        /// ID or `username~name` of the Actor whose deployment key to register.
        /// </param>
        /// <param name="repoName">
        /// URL of the repository to register the key on. Its host must match the provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterDeploymentKeyRequest(
            string actorId,
            string repoName)
        {
            this.ActorId = actorId ?? throw new global::System.ArgumentNullException(nameof(actorId));
            this.RepoName = repoName ?? throw new global::System.ArgumentNullException(nameof(repoName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterDeploymentKeyRequest" /> class.
        /// </summary>
        public RegisterDeploymentKeyRequest()
        {
        }

    }
}