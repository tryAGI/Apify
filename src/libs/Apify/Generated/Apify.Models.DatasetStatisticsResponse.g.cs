
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetStatisticsResponse
    {
        /// <summary>
        /// Example: {"fieldStatistics":{"name":{"nullCount":122},"price":{"min":59,"max":89}}}
        /// </summary>
        /// <example>{"fieldStatistics":{"name":{"nullCount":122},"price":{"min":59,"max":89}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.DatasetStatistics Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetStatisticsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Example: {"fieldStatistics":{"name":{"nullCount":122},"price":{"min":59,"max":89}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetStatisticsResponse(
            global::Apify.DatasetStatistics data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetStatisticsResponse" /> class.
        /// </summary>
        public DatasetStatisticsResponse()
        {
        }

    }
}