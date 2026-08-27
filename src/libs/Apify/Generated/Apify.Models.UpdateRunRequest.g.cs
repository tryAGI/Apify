
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRunRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runId")]
        public string? RunId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusMessage")]
        public string? StatusMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isStatusMessageTerminal")]
        public bool? IsStatusMessageTerminal { get; set; }

        /// <summary>
        /// Defines the general access level for the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generalAccess")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.GeneralAccessJsonConverter))]
        public global::Apify.GeneralAccess? GeneralAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRunRequest" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="statusMessage"></param>
        /// <param name="isStatusMessageTerminal"></param>
        /// <param name="generalAccess">
        /// Defines the general access level for the resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRunRequest(
            string? runId,
            string? statusMessage,
            bool? isStatusMessageTerminal,
            global::Apify.GeneralAccess? generalAccess)
        {
            this.RunId = runId;
            this.StatusMessage = statusMessage;
            this.IsStatusMessageTerminal = isStatusMessageTerminal;
            this.GeneralAccess = generalAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRunRequest" /> class.
        /// </summary>
        public UpdateRunRequest()
        {
        }

    }
}