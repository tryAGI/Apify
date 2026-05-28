
#nullable enable

namespace Apify
{
    /// <summary>
    /// Response containing the result of a batch delete operation.
    /// </summary>
    public sealed partial class BatchDeleteResponse
    {
        /// <summary>
        /// Result of a batch delete operation containing successfully deleted and failed requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.BatchDeleteResult Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Result of a batch delete operation containing successfully deleted and failed requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchDeleteResponse(
            global::Apify.BatchDeleteResult data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteResponse" /> class.
        /// </summary>
        public BatchDeleteResponse()
        {
        }

    }
}