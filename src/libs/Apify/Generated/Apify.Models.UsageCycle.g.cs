
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageCycle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCycle" /> class.
        /// </summary>
        /// <param name="startAt"></param>
        /// <param name="endAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageCycle(
            global::System.DateTime startAt,
            global::System.DateTime endAt)
        {
            this.StartAt = startAt;
            this.EndAt = endAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCycle" /> class.
        /// </summary>
        public UsageCycle()
        {
        }

    }
}