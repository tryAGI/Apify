
#nullable enable

namespace Apify
{
    /// <summary>
    /// Common pagination fields for list responses.
    /// </summary>
    public sealed partial class PaginationResponse
    {
        /// <summary>
        /// The total number of items available across all pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// The starting position for this page of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Offset { get; set; }

        /// <summary>
        /// The maximum number of items returned per page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// Whether the results are sorted in descending order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Desc { get; set; }

        /// <summary>
        /// The number of items returned in this response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// The total number of items available across all pages.
        /// </param>
        /// <param name="offset">
        /// The starting position for this page of results.
        /// </param>
        /// <param name="limit">
        /// The maximum number of items returned per page.
        /// </param>
        /// <param name="desc">
        /// Whether the results are sorted in descending order.
        /// </param>
        /// <param name="count">
        /// The number of items returned in this response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginationResponse(
            int total,
            int offset,
            int limit,
            bool desc,
            int count)
        {
            this.Total = total;
            this.Offset = offset;
            this.Limit = limit;
            this.Desc = desc;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationResponse" /> class.
        /// </summary>
        public PaginationResponse()
        {
        }
    }
}