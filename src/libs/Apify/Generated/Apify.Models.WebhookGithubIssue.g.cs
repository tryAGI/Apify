
#nullable enable

namespace Apify
{
    /// <summary>
    /// GitHub issue configuration. Present only when `actionType` is `GITHUB_ISSUE`.
    /// </summary>
    public sealed partial class WebhookGithubIssue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userIntegrationId")]
        public string? UserIntegrationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public string? Repository { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGithubIssue" /> class.
        /// </summary>
        /// <param name="userIntegrationId"></param>
        /// <param name="repository"></param>
        /// <param name="title"></param>
        /// <param name="body"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookGithubIssue(
            string? userIntegrationId,
            string? repository,
            string? title,
            string? body)
        {
            this.UserIntegrationId = userIntegrationId;
            this.Repository = repository;
            this.Title = title;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGithubIssue" /> class.
        /// </summary>
        public WebhookGithubIssue()
        {
        }

    }
}