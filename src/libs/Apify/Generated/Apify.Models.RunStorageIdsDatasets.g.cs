
#nullable enable

namespace Apify
{
    /// <summary>
    /// Aliased dataset IDs for this run.
    /// </summary>
    public sealed partial class RunStorageIdsDatasets
    {
        /// <summary>
        /// ID of the default dataset for this run.<br/>
        /// Example: wmKPijuyDnPZAPRMk
        /// </summary>
        /// <example>wmKPijuyDnPZAPRMk</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public string? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStorageIdsDatasets" /> class.
        /// </summary>
        /// <param name="default">
        /// ID of the default dataset for this run.<br/>
        /// Example: wmKPijuyDnPZAPRMk
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStorageIdsDatasets(
            string? @default)
        {
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStorageIdsDatasets" /> class.
        /// </summary>
        public RunStorageIdsDatasets()
        {
        }

    }
}