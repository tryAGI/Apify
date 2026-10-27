
#nullable enable

namespace Apify
{
    /// <summary>
    /// A summary of the webhook that triggered this dispatch.
    /// </summary>
    public sealed partial class WebhookDispatchWebhookSummary
    {
        /// <summary>
        /// ID of the webhook. The API returns it under `_id`, not `id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionType")]
        public string? ActionType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public global::Apify.WebhookCondition? Condition { get; set; }

        /// <summary>
        /// URL of the HTTP request sent by the webhook. It is `null` for hook actions other than the conventional HTTP case (e.g. Slack or email notifications).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestUrl")]
        public string? RequestUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAdHoc")]
        public bool? IsAdHoc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isApifyIntegration")]
        public bool? IsApifyIntegration { get; set; }

        /// <summary>
        /// Slack message configuration. Present only when `actionType` is `SLACK_MESSAGE`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slackMessage")]
        public global::Apify.WebhookSlackMessage? SlackMessage { get; set; }

        /// <summary>
        /// Gmail email configuration. Present only when `actionType` is `GOOGLE_MAIL`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("googleMail")]
        public global::Apify.WebhookGoogleMail? GoogleMail { get; set; }

        /// <summary>
        /// Google Drive upload configuration. Present only when `actionType` is `GOOGLE_DRIVE`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("googleDrive")]
        public global::Apify.WebhookGoogleDrive? GoogleDrive { get; set; }

        /// <summary>
        /// GitHub issue configuration. Present only when `actionType` is `GITHUB_ISSUE`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("githubIssue")]
        public global::Apify.WebhookGithubIssue? GithubIssue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDispatchWebhookSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the webhook. The API returns it under `_id`, not `id`.
        /// </param>
        /// <param name="actionType"></param>
        /// <param name="condition"></param>
        /// <param name="requestUrl">
        /// URL of the HTTP request sent by the webhook. It is `null` for hook actions other than the conventional HTTP case (e.g. Slack or email notifications).
        /// </param>
        /// <param name="isAdHoc"></param>
        /// <param name="isApifyIntegration"></param>
        /// <param name="slackMessage">
        /// Slack message configuration. Present only when `actionType` is `SLACK_MESSAGE`.
        /// </param>
        /// <param name="googleMail">
        /// Gmail email configuration. Present only when `actionType` is `GOOGLE_MAIL`.
        /// </param>
        /// <param name="googleDrive">
        /// Google Drive upload configuration. Present only when `actionType` is `GOOGLE_DRIVE`.
        /// </param>
        /// <param name="githubIssue">
        /// GitHub issue configuration. Present only when `actionType` is `GITHUB_ISSUE`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDispatchWebhookSummary(
            string? id,
            string? actionType,
            global::Apify.WebhookCondition? condition,
            string? requestUrl,
            bool? isAdHoc,
            bool? isApifyIntegration,
            global::Apify.WebhookSlackMessage? slackMessage,
            global::Apify.WebhookGoogleMail? googleMail,
            global::Apify.WebhookGoogleDrive? googleDrive,
            global::Apify.WebhookGithubIssue? githubIssue)
        {
            this.Id = id;
            this.ActionType = actionType;
            this.Condition = condition;
            this.RequestUrl = requestUrl;
            this.IsAdHoc = isAdHoc;
            this.IsApifyIntegration = isApifyIntegration;
            this.SlackMessage = slackMessage;
            this.GoogleMail = googleMail;
            this.GoogleDrive = googleDrive;
            this.GithubIssue = githubIssue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDispatchWebhookSummary" /> class.
        /// </summary>
        public WebhookDispatchWebhookSummary()
        {
        }

    }
}