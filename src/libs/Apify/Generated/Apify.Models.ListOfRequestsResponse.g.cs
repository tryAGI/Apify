
#nullable enable

namespace Apify
{
    /// <summary>
    /// Response containing a list of requests from the request queue.<br/>
    /// Example: {"data":{"items":[{"id":"dnjkDMKLmdlkmlkmld","retryCount":0,"uniqueKey":"http://example.com","url":"http://example.com","method":"GET","loadedUrl":"http://example.com/example-1","payload":null,"noRetry":false,"errorMessages":null,"headers":null,"userData":{"label":"DETAIL","image":"https://picserver1.eu"},"handledAt":"2019-06-16T10:23:31.607Z"},{"id":"dnjkDMKLmdlkmlkmld","retryCount":0,"uniqueKey":"http://example.com","url":"http://example.com","method":"GET","loadedUrl":"http://example.com/example-1","payload":null,"noRetry":false,"errorMessages":null,"headers":null,"userData":{"label":"DETAIL","image":"https://picserver1.eu"},"handledAt":"2019-06-16T10:23:31.607Z"}],"limit":2,"exclusiveStartId":"Ihnsp8YrvJ8102Kj"}}
    /// </summary>
    public sealed partial class ListOfRequestsResponse
    {
        /// <summary>
        /// A paginated list of requests from the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.ListOfRequests Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfRequestsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A paginated list of requests from the request queue.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOfRequestsResponse(
            global::Apify.ListOfRequests data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfRequestsResponse" /> class.
        /// </summary>
        public ListOfRequestsResponse()
        {
        }
    }
}