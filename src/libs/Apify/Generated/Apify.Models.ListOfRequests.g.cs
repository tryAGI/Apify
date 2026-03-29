
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// A paginated list of requests from the request queue.
    /// </summary>
    public sealed partial class ListOfRequests
    {
        /// <summary>
        /// The array of requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.Request> Items { get; set; }

        /// <summary>
        /// The total number of requests matching the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// The maximum number of requests returned in this response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// The ID of the last request from the previous page, used for pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclusiveStartId")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ExclusiveStartId { get; set; }

        /// <summary>
        /// A cursor string used for current page of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// A cursor string to be used to continue pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfRequests" /> class.
        /// </summary>
        /// <param name="items">
        /// The array of requests.
        /// </param>
        /// <param name="limit">
        /// The maximum number of requests returned in this response.
        /// </param>
        /// <param name="count">
        /// The total number of requests matching the query.
        /// </param>
        /// <param name="cursor">
        /// A cursor string used for current page of results.
        /// </param>
        /// <param name="nextCursor">
        /// A cursor string to be used to continue pagination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOfRequests(
            global::System.Collections.Generic.IList<global::Apify.Request> items,
            int limit,
            int? count,
            string? cursor,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Count = count;
            this.Limit = limit;
            this.Cursor = cursor;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfRequests" /> class.
        /// </summary>
        public ListOfRequests()
        {
        }
    }
}