
#nullable enable

namespace Apify
{
    /// <summary>
    /// Aliased request queue IDs for this run.
    /// </summary>
    public sealed partial class RunStorageIdsRequestQueues
    {
        /// <summary>
        /// ID of the default request queue for this run.<br/>
        /// Example: FL35cSF7jrxr3BY39
        /// </summary>
        /// <example>FL35cSF7jrxr3BY39</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public string? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStorageIdsRequestQueues" /> class.
        /// </summary>
        /// <param name="default">
        /// ID of the default request queue for this run.<br/>
        /// Example: FL35cSF7jrxr3BY39
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStorageIdsRequestQueues(
            string? @default)
        {
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStorageIdsRequestQueues" /> class.
        /// </summary>
        public RunStorageIdsRequestQueues()
        {
        }
    }
}