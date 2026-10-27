
#nullable enable

namespace Apify
{
    /// <summary>
    /// Information about the third-party integration that created the resource.
    /// </summary>
    public sealed partial class IntegrationTracking
    {
        /// <summary>
        /// Name of the integration platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        public string? Platform { get; set; }

        /// <summary>
        /// ID of the integration app.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        public string? AppId { get; set; }

        /// <summary>
        /// Whether the resource was created by an AI tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAiTool")]
        public bool? IsAiTool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationTracking" /> class.
        /// </summary>
        /// <param name="platform">
        /// Name of the integration platform.
        /// </param>
        /// <param name="appId">
        /// ID of the integration app.
        /// </param>
        /// <param name="isAiTool">
        /// Whether the resource was created by an AI tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationTracking(
            string? platform,
            string? appId,
            bool? isAiTool)
        {
            this.Platform = platform;
            this.AppId = appId;
            this.IsAiTool = isAiTool;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationTracking" /> class.
        /// </summary>
        public IntegrationTracking()
        {
        }

    }
}