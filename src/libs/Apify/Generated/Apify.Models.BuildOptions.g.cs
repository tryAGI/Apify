
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildOptions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useCache")]
        public bool? UseCache { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaPackages")]
        public bool? BetaPackages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMbytes")]
        public long? MemoryMbytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskMbytes")]
        public long? DiskMbytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildOptions" /> class.
        /// </summary>
        /// <param name="useCache"></param>
        /// <param name="betaPackages"></param>
        /// <param name="memoryMbytes"></param>
        /// <param name="diskMbytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildOptions(
            bool? useCache,
            bool? betaPackages,
            long? memoryMbytes,
            long? diskMbytes)
        {
            this.UseCache = useCache;
            this.BetaPackages = betaPackages;
            this.MemoryMbytes = memoryMbytes;
            this.DiskMbytes = diskMbytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildOptions" /> class.
        /// </summary>
        public BuildOptions()
        {
        }

    }
}