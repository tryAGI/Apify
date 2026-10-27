
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
        /// The tag passed when starting the build. Present only when the `tag` parameter was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Whether this is a debug build. Present only on debug builds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug")]
        public bool? Debug { get; set; }

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
        /// <param name="tag">
        /// The tag passed when starting the build. Present only when the `tag` parameter was used.
        /// </param>
        /// <param name="debug">
        /// Whether this is a debug build. Present only on debug builds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildOptions(
            bool? useCache,
            bool? betaPackages,
            long? memoryMbytes,
            long? diskMbytes,
            string? tag,
            bool? debug)
        {
            this.UseCache = useCache;
            this.BetaPackages = betaPackages;
            this.MemoryMbytes = memoryMbytes;
            this.DiskMbytes = diskMbytes;
            this.Tag = tag;
            this.Debug = debug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildOptions" /> class.
        /// </summary>
        public BuildOptions()
        {
        }

    }
}