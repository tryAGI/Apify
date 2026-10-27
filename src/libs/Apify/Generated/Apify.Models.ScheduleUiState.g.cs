
#nullable enable

namespace Apify
{
    /// <summary>
    /// State of the schedule editor in Apify Console. It's removed when an API update changes `cronExpression` or `timezone`.
    /// </summary>
    public sealed partial class ScheduleUiState
    {
        /// <summary>
        /// Version of the editor state format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Editor form values, such as the frequency settings the cron expression was built from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Apify.ScheduleUiStateData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleUiState" /> class.
        /// </summary>
        /// <param name="version">
        /// Version of the editor state format.
        /// </param>
        /// <param name="data">
        /// Editor form values, such as the frequency settings the cron expression was built from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleUiState(
            int? version,
            global::Apify.ScheduleUiStateData? data)
        {
            this.Version = version;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleUiState" /> class.
        /// </summary>
        public ScheduleUiState()
        {
        }

    }
}