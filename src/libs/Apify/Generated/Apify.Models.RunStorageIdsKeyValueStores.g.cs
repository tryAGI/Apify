
#nullable enable

namespace Apify
{
    /// <summary>
    /// Aliased key-value store IDs for this run.
    /// </summary>
    public sealed partial class RunStorageIdsKeyValueStores
    {
        /// <summary>
        /// ID of the default key-value store for this run.<br/>
        /// Example: eJNzqsbPiopwJcgGQ
        /// </summary>
        /// <example>eJNzqsbPiopwJcgGQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public string? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStorageIdsKeyValueStores" /> class.
        /// </summary>
        /// <param name="default">
        /// ID of the default key-value store for this run.<br/>
        /// Example: eJNzqsbPiopwJcgGQ
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStorageIdsKeyValueStores(
            string? @default)
        {
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStorageIdsKeyValueStores" /> class.
        /// </summary>
        public RunStorageIdsKeyValueStores()
        {
        }
    }
}