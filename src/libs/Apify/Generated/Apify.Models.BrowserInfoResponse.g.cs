
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BrowserInfoResponse
    {
        /// <summary>
        /// HTTP method of the request.<br/>
        /// Example: GET
        /// </summary>
        /// <example>GET</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        /// IP address of the client.<br/>
        /// Example: 1.2.3.4
        /// </summary>
        /// <example>1.2.3.4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientIp")]
        public string? ClientIp { get; set; }

        /// <summary>
        /// Two-letter country code resolved from the client IP address.<br/>
        /// Example: US
        /// </summary>
        /// <example>US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Length of the request body in bytes.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bodyLength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BodyLength { get; set; }

        /// <summary>
        /// Request headers. Omitted when `skipHeaders=true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// Raw request headers as a flat list of alternating name/value strings.<br/>
        /// Included only when `rawHeaders=true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawHeaders")]
        public global::System.Collections.Generic.IList<string>? RawHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserInfoResponse" /> class.
        /// </summary>
        /// <param name="method">
        /// HTTP method of the request.<br/>
        /// Example: GET
        /// </param>
        /// <param name="bodyLength">
        /// Length of the request body in bytes.<br/>
        /// Example: 0
        /// </param>
        /// <param name="clientIp">
        /// IP address of the client.<br/>
        /// Example: 1.2.3.4
        /// </param>
        /// <param name="countryCode">
        /// Two-letter country code resolved from the client IP address.<br/>
        /// Example: US
        /// </param>
        /// <param name="headers">
        /// Request headers. Omitted when `skipHeaders=true`.
        /// </param>
        /// <param name="rawHeaders">
        /// Raw request headers as a flat list of alternating name/value strings.<br/>
        /// Included only when `rawHeaders=true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserInfoResponse(
            string method,
            long bodyLength,
            string? clientIp,
            string? countryCode,
            object? headers,
            global::System.Collections.Generic.IList<string>? rawHeaders)
        {
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.ClientIp = clientIp;
            this.CountryCode = countryCode;
            this.BodyLength = bodyLength;
            this.Headers = headers;
            this.RawHeaders = rawHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserInfoResponse" /> class.
        /// </summary>
        public BrowserInfoResponse()
        {
        }
    }
}