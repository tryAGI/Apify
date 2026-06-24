
#nullable enable

namespace Apify
{
    /// <summary>
    /// Represents a single file in the Actor's source code.
    /// </summary>
    public sealed partial class SourceCodeFile
    {
        /// <summary>
        /// Format of the file's content, `TEXT` for plain text and `BASE64` for encoded content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.SourceCodeFileFormatJsonConverter))]
        public global::Apify.SourceCodeFileFormat? Format { get; set; }

        /// <summary>
        /// The contents of the file. Interpreted based on the value of `format`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The path of the file relative to the Actor's root directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceCodeFile" /> class.
        /// </summary>
        /// <param name="name">
        /// The path of the file relative to the Actor's root directory.
        /// </param>
        /// <param name="format">
        /// Format of the file's content, `TEXT` for plain text and `BASE64` for encoded content.
        /// </param>
        /// <param name="content">
        /// The contents of the file. Interpreted based on the value of `format`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceCodeFile(
            string name,
            global::Apify.SourceCodeFileFormat? format,
            string? content)
        {
            this.Format = format;
            this.Content = content;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceCodeFile" /> class.
        /// </summary>
        public SourceCodeFile()
        {
        }

    }
}