
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ValidationError
    {
        /// <summary>
        /// The path to the instance being validated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instancePath")]
        public string? InstancePath { get; set; }

        /// <summary>
        /// The path to the schema that failed the validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemaPath")]
        public string? SchemaPath { get; set; }

        /// <summary>
        /// The validation keyword that caused the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyword")]
        public string? Keyword { get; set; }

        /// <summary>
        /// A message describing the validation error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional parameters specific to the validation error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError" /> class.
        /// </summary>
        /// <param name="instancePath">
        /// The path to the instance being validated.
        /// </param>
        /// <param name="schemaPath">
        /// The path to the schema that failed the validation.
        /// </param>
        /// <param name="keyword">
        /// The validation keyword that caused the error.
        /// </param>
        /// <param name="message">
        /// A message describing the validation error.
        /// </param>
        /// <param name="params">
        /// Additional parameters specific to the validation error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationError(
            string? instancePath,
            string? schemaPath,
            string? keyword,
            string? message,
            object? @params)
        {
            this.InstancePath = instancePath;
            this.SchemaPath = schemaPath;
            this.Keyword = keyword;
            this.Message = message;
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError" /> class.
        /// </summary>
        public ValidationError()
        {
        }

    }
}