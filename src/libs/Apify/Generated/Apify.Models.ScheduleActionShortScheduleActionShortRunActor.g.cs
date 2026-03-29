
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduleActionShortScheduleActionShortRunActor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ScheduleActionShortScheduleActionShortRunActorTypeJsonConverter))]
        public global::Apify.ScheduleActionShortScheduleActionShortRunActorType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleActionShortScheduleActionShortRunActor" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actorId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleActionShortScheduleActionShortRunActor(
            string id,
            string actorId,
            global::Apify.ScheduleActionShortScheduleActionShortRunActorType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.ActorId = actorId ?? throw new global::System.ArgumentNullException(nameof(actorId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleActionShortScheduleActionShortRunActor" /> class.
        /// </summary>
        public ScheduleActionShortScheduleActionShortRunActor()
        {
        }
    }
}