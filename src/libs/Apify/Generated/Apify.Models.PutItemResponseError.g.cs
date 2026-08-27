
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"error":{"type":"schema-validation-error","message":"Schema validation failed","data":{"invalidItems":[{"itemPosition":2,"validationErrors":[{"instancePath":"/1/stringField","schemaPath":"/items/properties/stringField/type","keyword":"type","params":{"type":"string"},"message":"must be string"}]}]}}}
    /// </summary>
    public sealed partial class PutItemResponseError
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.DatasetSchemaValidationError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutItemResponseError" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutItemResponseError(
            global::Apify.DatasetSchemaValidationError error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutItemResponseError" /> class.
        /// </summary>
        public PutItemResponseError()
        {
        }

    }
}