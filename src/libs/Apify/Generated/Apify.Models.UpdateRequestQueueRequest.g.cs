
#nullable enable

namespace Apify
{
    /// <summary>
    /// Request object for updating a request queue.<br/>
    /// Example: {"name":"new-request-queue-name","generalAccess":"RESTRICTED"}
    /// </summary>
    public sealed partial class UpdateRequestQueueRequest
    {
        /// <summary>
        /// The new name for the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateRequestQueueRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The new name for the request queue.
        /// </param>
        /// <param name="generalAccess">
        /// Defines the general access level for the resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRequestQueueRequest(
            string? name,
            global::Apify.GeneralAccess? generalAccess)
        {
            this.Name = name;
            this.GeneralAccess = generalAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequestQueueRequest" /> class.
        /// </summary>
        public UpdateRequestQueueRequest()
        {
        }

    }
}