
#nullable enable

namespace Apify
{
    /// <summary>
    /// Custom user data attached to the request. Can contain arbitrary fields.
    /// </summary>
    public sealed partial class RequestUserData
    {
        /// <summary>
        /// Optional label for categorizing the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Optional image URL associated with the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestUserData" /> class.
        /// </summary>
        /// <param name="label">
        /// Optional label for categorizing the request.
        /// </param>
        /// <param name="image">
        /// Optional image URL associated with the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestUserData(
            string? label,
            string? image)
        {
            this.Label = label;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestUserData" /> class.
        /// </summary>
        public RequestUserData()
        {
        }
    }
}