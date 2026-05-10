
#nullable enable

namespace Apify
{
    /// <summary>
    /// Response containing the result of updating a request in the request queue.
    /// </summary>
    public sealed partial class UpdateRequestResponse
    {
        /// <summary>
        /// Result of registering a request in the request queue, either by adding a new request or updating an existing one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.RequestRegistration Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequestResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Result of registering a request in the request queue, either by adding a new request or updating an existing one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRequestResponse(
            global::Apify.RequestRegistration data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequestResponse" /> class.
        /// </summary>
        public UpdateRequestResponse()
        {
        }

    }
}