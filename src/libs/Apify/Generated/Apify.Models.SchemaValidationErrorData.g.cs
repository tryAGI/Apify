
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemaValidationErrorData
    {
        /// <summary>
        /// A list of invalid items in the received array of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalidItems")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.InvalidItem> InvalidItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaValidationErrorData" /> class.
        /// </summary>
        /// <param name="invalidItems">
        /// A list of invalid items in the received array of items.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemaValidationErrorData(
            global::System.Collections.Generic.IList<global::Apify.InvalidItem> invalidItems)
        {
            this.InvalidItems = invalidItems ?? throw new global::System.ArgumentNullException(nameof(invalidItems));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaValidationErrorData" /> class.
        /// </summary>
        public SchemaValidationErrorData()
        {
        }
    }
}