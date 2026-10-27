
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateGitRepoRequest
    {
        /// <summary>
        /// Where to create the repository, as the `id` of one of the provider's workspaces. On GitLab, this is the<br/>
        /// numeric namespace ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Workspace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPrivate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPrivate { get; set; }

        /// <summary>
        /// Files to commit as the initial commit. Can't be combined with `templateArchiveUrl`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::Apify.GitRepoFile>? Files { get; set; }

        /// <summary>
        /// URL of an Actor template archive whose files are committed as the initial commit. Can't be combined with<br/>
        /// `files`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateArchiveUrl")]
        public string? TemplateArchiveUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGitRepoRequest" /> class.
        /// </summary>
        /// <param name="workspace">
        /// Where to create the repository, as the `id` of one of the provider's workspaces. On GitLab, this is the<br/>
        /// numeric namespace ID.
        /// </param>
        /// <param name="repoName"></param>
        /// <param name="isPrivate"></param>
        /// <param name="files">
        /// Files to commit as the initial commit. Can't be combined with `templateArchiveUrl`.
        /// </param>
        /// <param name="templateArchiveUrl">
        /// URL of an Actor template archive whose files are committed as the initial commit. Can't be combined with<br/>
        /// `files`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGitRepoRequest(
            string workspace,
            string repoName,
            bool isPrivate,
            global::System.Collections.Generic.IList<global::Apify.GitRepoFile>? files,
            string? templateArchiveUrl)
        {
            this.Workspace = workspace ?? throw new global::System.ArgumentNullException(nameof(workspace));
            this.RepoName = repoName ?? throw new global::System.ArgumentNullException(nameof(repoName));
            this.IsPrivate = isPrivate;
            this.Files = files;
            this.TemplateArchiveUrl = templateArchiveUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGitRepoRequest" /> class.
        /// </summary>
        public CreateGitRepoRequest()
        {
        }

    }
}