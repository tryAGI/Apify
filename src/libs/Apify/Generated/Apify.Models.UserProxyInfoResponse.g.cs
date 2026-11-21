
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserProxyInfoResponse
    {
        /// <summary>
        /// Reduced user data with only the fields Apify Proxy reads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.UserProxyInfo Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProxyInfoResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Reduced user data with only the fields Apify Proxy reads.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProxyInfoResponse(
            global::Apify.UserProxyInfo data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProxyInfoResponse" /> class.
        /// </summary>
        public UserProxyInfoResponse()
        {
        }

    }
}