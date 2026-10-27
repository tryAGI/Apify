
#nullable enable

namespace Apify
{
    /// <summary>
    /// Selects which dataset item fields are included in the output.
    /// </summary>
    public sealed partial class WebhookDatasetTransformation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<string>? Fields { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("omit")]
        public global::System.Collections.Generic.IList<string>? Omit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDatasetTransformation" /> class.
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="omit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDatasetTransformation(
            global::System.Collections.Generic.IList<string>? fields,
            global::System.Collections.Generic.IList<string>? omit)
        {
            this.Fields = fields;
            this.Omit = omit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDatasetTransformation" /> class.
        /// </summary>
        public WebhookDatasetTransformation()
        {
        }

    }
}