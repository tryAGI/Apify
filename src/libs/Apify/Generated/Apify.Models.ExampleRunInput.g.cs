
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExampleRunInput
    {
        /// <summary>
        /// Sample input, serialized as a string.<br/>
        /// Example: { "helloWorld": 123 }
        /// </summary>
        /// <example>{ "helloWorld": 123 }</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// MIME type of `body`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleRunInput" /> class.
        /// </summary>
        /// <param name="body">
        /// Sample input, serialized as a string.<br/>
        /// Example: { "helloWorld": 123 }
        /// </param>
        /// <param name="contentType">
        /// MIME type of `body`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExampleRunInput(
            string? body,
            string? contentType)
        {
            this.Body = body;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleRunInput" /> class.
        /// </summary>
        public ExampleRunInput()
        {
        }

    }
}