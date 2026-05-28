
#nullable enable

namespace Apify
{
    /// <summary>
    /// Represents a folder in the Actor's source code structure. Distinguished from<br/>
    /// SourceCodeFile by the presence of the `folder` property set to `true`.
    /// </summary>
    public sealed partial class SourceCodeFolder
    {
        /// <summary>
        /// The folder path relative to the Actor's root directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Always `true` for folders. Used to distinguish folders from files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Folder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceCodeFolder" /> class.
        /// </summary>
        /// <param name="name">
        /// The folder path relative to the Actor's root directory.
        /// </param>
        /// <param name="folder">
        /// Always `true` for folders. Used to distinguish folders from files.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceCodeFolder(
            string name,
            bool folder)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Folder = folder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceCodeFolder" /> class.
        /// </summary>
        public SourceCodeFolder()
        {
        }

    }
}