
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScheduleListItemVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Notification settings for this schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications")]
        public global::Apify.ScheduleNotifications? Notifications { get; set; }

        /// <summary>
        /// Present only when the schedule was created by a third-party integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationTracking")]
        public global::Apify.IntegrationTracking? IntegrationTracking { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.ScheduleListItemAction> Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleListItemVariant2" /> class.
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="title"></param>
        /// <param name="notifications">
        /// Notification settings for this schedule.
        /// </param>
        /// <param name="integrationTracking">
        /// Present only when the schedule was created by a third-party integration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleListItemVariant2(
            global::System.Collections.Generic.IList<global::Apify.ScheduleListItemAction> actions,
            string? title,
            global::Apify.ScheduleNotifications? notifications,
            global::Apify.IntegrationTracking? integrationTracking)
        {
            this.Title = title;
            this.Notifications = notifications;
            this.IntegrationTracking = integrationTracking;
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleListItemVariant2" /> class.
        /// </summary>
        public ScheduleListItemVariant2()
        {
        }

    }
}