
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScheduleVariant2
    {
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
        /// Notification settings for this schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications")]
        public global::Apify.ScheduleVariant2Notifications? Notifications { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.ScheduleAction> Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleVariant2" /> class.
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
        /// <param name="notifications">
        /// Notification settings for this schedule.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleVariant2(
            global::System.Collections.Generic.IList<global::Apify.ScheduleAction> actions,
            string? description,
            string? title,
            global::Apify.ScheduleVariant2Notifications? notifications)
        {
            this.Description = description;
            this.Title = title;
            this.Notifications = notifications;
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleVariant2" /> class.
        /// </summary>
        public ScheduleVariant2()
        {
        }

    }
}