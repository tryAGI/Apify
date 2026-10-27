
#nullable enable

namespace Apify
{
    /// <summary>
    /// Gmail email configuration. Present only when `actionType` is `GOOGLE_MAIL`.
    /// </summary>
    public sealed partial class WebhookGoogleMail
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userIntegrationId")]
        public string? UserIntegrationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailTo")]
        public global::System.Collections.Generic.IList<string>? EmailTo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachmentFormat")]
        public string? AttachmentFormat { get; set; }

        /// <summary>
        /// Selects which dataset item fields are included in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachmentTransformation")]
        public global::Apify.WebhookDatasetTransformation? AttachmentTransformation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGoogleMail" /> class.
        /// </summary>
        /// <param name="userIntegrationId"></param>
        /// <param name="emailTo"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="attachmentFormat"></param>
        /// <param name="attachmentTransformation">
        /// Selects which dataset item fields are included in the output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookGoogleMail(
            string? userIntegrationId,
            global::System.Collections.Generic.IList<string>? emailTo,
            string? subject,
            string? body,
            string? attachmentFormat,
            global::Apify.WebhookDatasetTransformation? attachmentTransformation)
        {
            this.UserIntegrationId = userIntegrationId;
            this.EmailTo = emailTo;
            this.Subject = subject;
            this.Body = body;
            this.AttachmentFormat = attachmentFormat;
            this.AttachmentTransformation = attachmentTransformation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGoogleMail" /> class.
        /// </summary>
        public WebhookGoogleMail()
        {
        }

    }
}