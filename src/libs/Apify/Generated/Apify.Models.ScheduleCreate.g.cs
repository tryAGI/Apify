
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduleCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isExclusive")]
        public bool? IsExclusive { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>? Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isEnabled"></param>
        /// <param name="isExclusive"></param>
        /// <param name="cronExpression"></param>
        /// <param name="timezone"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
        /// <param name="actions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleCreate(
            string? name,
            bool? isEnabled,
            bool? isExclusive,
            string? cronExpression,
            string? timezone,
            string? description,
            string? title,
            global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>? actions)
        {
            this.Name = name;
            this.IsEnabled = isEnabled;
            this.IsExclusive = isExclusive;
            this.CronExpression = cronExpression;
            this.Timezone = timezone;
            this.Description = description;
            this.Title = title;
            this.Actions = actions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCreate" /> class.
        /// </summary>
        public ScheduleCreate()
        {
        }

    }
}