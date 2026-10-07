
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequestResourceVariant2
    {
        /// <summary>
        /// A unique identifier assigned to the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestResourceVariant2" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier assigned to the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestResourceVariant2(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestResourceVariant2" /> class.
        /// </summary>
        public RequestResourceVariant2()
        {
        }

    }
}