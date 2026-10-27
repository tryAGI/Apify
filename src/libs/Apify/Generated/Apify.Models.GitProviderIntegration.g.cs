
#nullable enable

namespace Apify
{
    /// <summary>
    /// A connected git provider account the user can create repositories through.
    /// </summary>
    public sealed partial class GitProviderIntegration
    {
        /// <summary>
        /// The provider ID to use in the `providerId` path parameter: `github-app` for the GitHub App, or the ID of a<br/>
        /// connected GitLab or Bitbucket integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.GitProviderIntegrationProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.GitProviderIntegrationProvider Provider { get; set; }

        /// <summary>
        /// The workspaces the account can create a repository in. Empty if listing them failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.GitProviderWorkspace> Workspaces { get; set; }

        /// <summary>
        /// URL where the user can install the GitHub App on another account or organization. Only for the GitHub App.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addWorkspaceUrl")]
        public string? AddWorkspaceUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitProviderIntegration" /> class.
        /// </summary>
        /// <param name="id">
        /// The provider ID to use in the `providerId` path parameter: `github-app` for the GitHub App, or the ID of a<br/>
        /// connected GitLab or Bitbucket integration.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="workspaces">
        /// The workspaces the account can create a repository in. Empty if listing them failed.
        /// </param>
        /// <param name="addWorkspaceUrl">
        /// URL where the user can install the GitHub App on another account or organization. Only for the GitHub App.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GitProviderIntegration(
            string id,
            global::Apify.GitProviderIntegrationProvider provider,
            global::System.Collections.Generic.IList<global::Apify.GitProviderWorkspace> workspaces,
            string? addWorkspaceUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Provider = provider;
            this.Workspaces = workspaces ?? throw new global::System.ArgumentNullException(nameof(workspaces));
            this.AddWorkspaceUrl = addWorkspaceUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitProviderIntegration" /> class.
        /// </summary>
        public GitProviderIntegration()
        {
        }

    }
}