
#nullable enable

namespace Apify
{
    /// <summary>
    /// Response containing locked requests from the request queue head.<br/>
    /// Example: {"data":{"limit":3,"queueModifiedAt":"2018-03-14T23:00:00.000Z","hadMultipleClients":true,"lockSecs":60,"items":[{"id":"8OamqXBCpPHxyj9","retryCount":0,"uniqueKey":"http://example.com","url":"http://example.com","method":"GET","lockExpiresAt":"2022-06-14T23:00:00.000Z"},{"id":"8OamqXBCpPHxyx9","retryCount":0,"uniqueKey":"http://example.com/a","url":"http://example.com/a","method":"GET","lockExpiresAt":"2022-06-14T23:00:00.000Z"},{"id":"8OamqXBCpPHxy08","retryCount":0,"uniqueKey":"http://example.com/a/b","url":"http://example.com/a/b","method":"GET","lockExpiresAt":"2022-06-14T23:00:00.000Z"}]}}
    /// </summary>
    public sealed partial class HeadAndLockResponse
    {
        /// <summary>
        /// A batch of locked requests from the request queue head.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.LockedRequestQueueHead Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadAndLockResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A batch of locked requests from the request queue head.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeadAndLockResponse(
            global::Apify.LockedRequestQueueHead data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadAndLockResponse" /> class.
        /// </summary>
        public HeadAndLockResponse()
        {
        }
    }
}