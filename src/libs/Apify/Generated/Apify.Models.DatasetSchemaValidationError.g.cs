
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetSchemaValidationError
    {
        /// <summary>
        /// The type of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A human-readable message describing the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Apify.SchemaValidationErrorData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSchemaValidationError" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the error.
        /// </param>
        /// <param name="message">
        /// A human-readable message describing the error.
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetSchemaValidationError(
            string? type,
            string? message,
            global::Apify.SchemaValidationErrorData? data)
        {
            this.Type = type;
            this.Message = message;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSchemaValidationError" /> class.
        /// </summary>
        public DatasetSchemaValidationError()
        {
        }
    }
}