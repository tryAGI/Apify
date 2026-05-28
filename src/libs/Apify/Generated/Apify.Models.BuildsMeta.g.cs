
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildsMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.RunOriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.RunOrigin Origin { get; set; }

        /// <summary>
        /// IP address of the client that started the build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientIp")]
        public string? ClientIp { get; set; }

        /// <summary>
        /// User agent of the client that started the build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAgent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildsMeta" /> class.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="clientIp">
        /// IP address of the client that started the build.
        /// </param>
        /// <param name="userAgent">
        /// User agent of the client that started the build.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildsMeta(
            global::Apify.RunOrigin origin,
            string? clientIp,
            string? userAgent)
        {
            this.Origin = origin;
            this.ClientIp = clientIp;
            this.UserAgent = userAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildsMeta" /> class.
        /// </summary>
        public BuildsMeta()
        {
        }

    }
}