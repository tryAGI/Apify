
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookResource
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
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAdHoc")]
        public bool? IsAdHoc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Type of action the webhook performs: `HTTP_REQUEST`, `SLACK_MESSAGE`, `GOOGLE_MAIL`, `GOOGLE_DRIVE` or `GITHUB_ISSUE`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionType")]
        public string? ActionType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isApifyIntegration")]
        public bool? IsApifyIntegration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldInterpolateStrings")]
        public bool? ShouldInterpolateStrings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTypes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.WebhookEventType> EventTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.WebhookCondition Condition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreSslErrors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IgnoreSslErrors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doNotRetry")]
        public bool? DoNotRetry { get; set; }

        /// <summary>
        /// URL of the HTTP request sent by the webhook. It is omitted or `null` for hook actions other than the conventional HTTP case (e.g. Slack or email notifications).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestUrl")]
        public string? RequestUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payloadTemplate")]
        public string? PayloadTemplate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headersTemplate")]
        public string? HeadersTemplate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastDispatch")]
        public global::Apify.WebhookLastDispatch? LastDispatch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::Apify.WebhookStats? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookResource" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="userId"></param>
        /// <param name="eventTypes"></param>
        /// <param name="condition"></param>
        /// <param name="ignoreSslErrors"></param>
        /// <param name="isAdHoc"></param>
        /// <param name="isEnabled"></param>
        /// <param name="actionType">
        /// Type of action the webhook performs: `HTTP_REQUEST`, `SLACK_MESSAGE`, `GOOGLE_MAIL`, `GOOGLE_DRIVE` or `GITHUB_ISSUE`.
        /// </param>
        /// <param name="isApifyIntegration"></param>
        /// <param name="shouldInterpolateStrings"></param>
        /// <param name="doNotRetry"></param>
        /// <param name="requestUrl">
        /// URL of the HTTP request sent by the webhook. It is omitted or `null` for hook actions other than the conventional HTTP case (e.g. Slack or email notifications).
        /// </param>
        /// <param name="payloadTemplate"></param>
        /// <param name="headersTemplate"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
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
        /// <param name="lastDispatch"></param>
        /// <param name="stats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookResource(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt,
            string userId,
            global::System.Collections.Generic.IList<global::Apify.WebhookEventType> eventTypes,
            global::Apify.WebhookCondition condition,
            bool ignoreSslErrors,
            bool? isAdHoc,
            bool? isEnabled,
            string? actionType,
            bool? isApifyIntegration,
            bool? shouldInterpolateStrings,
            bool? doNotRetry,
            string? requestUrl,
            string? payloadTemplate,
            string? headersTemplate,
            string? title,
            string? description,
            global::Apify.WebhookSlackMessage? slackMessage,
            global::Apify.WebhookGoogleMail? googleMail,
            global::Apify.WebhookGoogleDrive? googleDrive,
            global::Apify.WebhookGithubIssue? githubIssue,
            global::Apify.WebhookLastDispatch? lastDispatch,
            global::Apify.WebhookStats? stats)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.IsAdHoc = isAdHoc;
            this.IsEnabled = isEnabled;
            this.ActionType = actionType;
            this.IsApifyIntegration = isApifyIntegration;
            this.ShouldInterpolateStrings = shouldInterpolateStrings;
            this.EventTypes = eventTypes ?? throw new global::System.ArgumentNullException(nameof(eventTypes));
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.IgnoreSslErrors = ignoreSslErrors;
            this.DoNotRetry = doNotRetry;
            this.RequestUrl = requestUrl;
            this.PayloadTemplate = payloadTemplate;
            this.HeadersTemplate = headersTemplate;
            this.Title = title;
            this.Description = description;
            this.SlackMessage = slackMessage;
            this.GoogleMail = googleMail;
            this.GoogleDrive = googleDrive;
            this.GithubIssue = githubIssue;
            this.LastDispatch = lastDispatch;
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookResource" /> class.
        /// </summary>
        public WebhookResource()
        {
        }

    }
}