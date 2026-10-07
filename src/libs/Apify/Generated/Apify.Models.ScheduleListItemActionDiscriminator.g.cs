
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScheduleListItemActionDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ScheduleListItemActionDiscriminatorTypeJsonConverter))]
        public global::Apify.ScheduleListItemActionDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleListItemActionDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleListItemActionDiscriminator(
            global::Apify.ScheduleListItemActionDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleListItemActionDiscriminator" /> class.
        /// </summary>
        public ScheduleListItemActionDiscriminator()
        {
        }

    }
}