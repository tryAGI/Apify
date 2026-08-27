
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InvalidItem
    {
        /// <summary>
        /// The position of the invalid item in the array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemPosition")]
        public int? ItemPosition { get; set; }

        /// <summary>
        /// A complete list of AJV validation error objects for the invalid item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validationErrors")]
        public global::System.Collections.Generic.IList<global::Apify.ValidationError>? ValidationErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidItem" /> class.
        /// </summary>
        /// <param name="itemPosition">
        /// The position of the invalid item in the array.
        /// </param>
        /// <param name="validationErrors">
        /// A complete list of AJV validation error objects for the invalid item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvalidItem(
            int? itemPosition,
            global::System.Collections.Generic.IList<global::Apify.ValidationError>? validationErrors)
        {
            this.ItemPosition = itemPosition;
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidItem" /> class.
        /// </summary>
        public InvalidItem()
        {
        }

    }
}