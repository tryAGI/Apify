
#nullable enable

namespace Apify
{
    /// <summary>
    /// Editor form values, such as the frequency settings the cron expression was built from.
    /// </summary>
    public sealed partial class ScheduleUiStateData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cronExpression")]
        public string? CronExpression { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleUiStateData" /> class.
        /// </summary>
        /// <param name="cronExpression"></param>
        /// <param name="timezone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleUiStateData(
            string? cronExpression,
            string? timezone)
        {
            this.CronExpression = cronExpression;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleUiStateData" /> class.
        /// </summary>
        public ScheduleUiStateData()
        {
        }

    }
}