
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecodeAndVerifyData
    {
        /// <summary>
        /// The original object that was encoded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decoded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Decoded { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encodedByUserId")]
        public string? EncodedByUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isVerifiedUser")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsVerifiedUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeAndVerifyData" /> class.
        /// </summary>
        /// <param name="decoded">
        /// The original object that was encoded.
        /// </param>
        /// <param name="isVerifiedUser"></param>
        /// <param name="encodedByUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecodeAndVerifyData(
            object decoded,
            bool isVerifiedUser,
            string? encodedByUserId)
        {
            this.Decoded = decoded ?? throw new global::System.ArgumentNullException(nameof(decoded));
            this.EncodedByUserId = encodedByUserId;
            this.IsVerifiedUser = isVerifiedUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeAndVerifyData" /> class.
        /// </summary>
        public DecodeAndVerifyData()
        {
        }

    }
}