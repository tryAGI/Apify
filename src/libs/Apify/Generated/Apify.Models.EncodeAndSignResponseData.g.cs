
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EncodeAndSignResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Encoded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EncodeAndSignResponseData" /> class.
        /// </summary>
        /// <param name="encoded"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EncodeAndSignResponseData(
            string encoded)
        {
            this.Encoded = encoded ?? throw new global::System.ArgumentNullException(nameof(encoded));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncodeAndSignResponseData" /> class.
        /// </summary>
        public EncodeAndSignResponseData()
        {
        }
    }
}