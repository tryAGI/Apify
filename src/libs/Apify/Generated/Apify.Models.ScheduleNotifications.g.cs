
#nullable enable

namespace Apify
{
    /// <summary>
    /// Notification settings for this schedule.
    /// </summary>
    public sealed partial class ScheduleNotifications
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public bool? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleNotifications" /> class.
        /// </summary>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleNotifications(
            bool? email)
        {
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleNotifications" /> class.
        /// </summary>
        public ScheduleNotifications()
        {
        }

    }
}