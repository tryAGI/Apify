
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ACTOR_COMPUTE_UNITS")]
        public double? ActorComputeUnits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUsage" /> class.
        /// </summary>
        /// <param name="actorComputeUnits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildUsage(
            double? actorComputeUnits)
        {
            this.ActorComputeUnits = actorComputeUnits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUsage" /> class.
        /// </summary>
        public BuildUsage()
        {
        }

    }
}