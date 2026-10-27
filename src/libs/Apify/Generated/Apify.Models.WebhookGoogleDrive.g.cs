
#nullable enable

namespace Apify
{
    /// <summary>
    /// Google Drive upload configuration. Present only when `actionType` is `GOOGLE_DRIVE`.
    /// </summary>
    public sealed partial class WebhookGoogleDrive
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userIntegrationId")]
        public string? UserIntegrationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Selects which dataset item fields are included in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transformation")]
        public global::Apify.WebhookDatasetTransformation? Transformation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGoogleDrive" /> class.
        /// </summary>
        /// <param name="userIntegrationId"></param>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        /// <param name="transformation">
        /// Selects which dataset item fields are included in the output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookGoogleDrive(
            string? userIntegrationId,
            string? filename,
            string? format,
            global::Apify.WebhookDatasetTransformation? transformation)
        {
            this.UserIntegrationId = userIntegrationId;
            this.Filename = filename;
            this.Format = format;
            this.Transformation = transformation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGoogleDrive" /> class.
        /// </summary>
        public WebhookGoogleDrive()
        {
        }

    }
}