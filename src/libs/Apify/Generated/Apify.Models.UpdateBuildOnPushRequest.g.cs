
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateBuildOnPushRequest
    {
        /// <summary>
        /// The connected git account to register the push webhook through: `github-app` for the GitHub App, or the ID<br/>
        /// of a connected GitLab or Bitbucket integration, as returned by the [Get git provider integrations](/api/v2/integrations-git-get) endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

        /// <summary>
        /// `true` registers the push webhook so that pushes to the repository build the version; `false` turns it off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBuildOnPushRequest" /> class.
        /// </summary>
        /// <param name="providerId">
        /// The connected git account to register the push webhook through: `github-app` for the GitHub App, or the ID<br/>
        /// of a connected GitLab or Bitbucket integration, as returned by the [Get git provider integrations](/api/v2/integrations-git-get) endpoint.
        /// </param>
        /// <param name="enabled">
        /// `true` registers the push webhook so that pushes to the repository build the version; `false` turns it off.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateBuildOnPushRequest(
            string providerId,
            bool enabled)
        {
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBuildOnPushRequest" /> class.
        /// </summary>
        public UpdateBuildOnPushRequest()
        {
        }

    }
}