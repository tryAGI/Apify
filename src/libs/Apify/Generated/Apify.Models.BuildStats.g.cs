
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMillis")]
        public int? DurationMillis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runTimeSecs")]
        public double? RunTimeSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computeUnits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ComputeUnits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildStats" /> class.
        /// </summary>
        /// <param name="computeUnits"></param>
        /// <param name="durationMillis"></param>
        /// <param name="runTimeSecs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildStats(
            double computeUnits,
            int? durationMillis,
            double? runTimeSecs)
        {
            this.DurationMillis = durationMillis;
            this.RunTimeSecs = runTimeSecs;
            this.ComputeUnits = computeUnits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildStats" /> class.
        /// </summary>
        public BuildStats()
        {
        }

    }
}