
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduleActionScheduleActionRunActorTask
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ScheduleActionScheduleActionRunActorTaskTypeJsonConverter))]
        public global::Apify.ScheduleActionScheduleActionRunActorTaskType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorTaskId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorTaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleActionScheduleActionRunActorTask" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actorTaskId"></param>
        /// <param name="type"></param>
        /// <param name="input"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleActionScheduleActionRunActorTask(
            string id,
            string actorTaskId,
            global::Apify.ScheduleActionScheduleActionRunActorTaskType type,
            object? input)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.ActorTaskId = actorTaskId ?? throw new global::System.ArgumentNullException(nameof(actorTaskId));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleActionScheduleActionRunActorTask" /> class.
        /// </summary>
        public ScheduleActionScheduleActionRunActorTask()
        {
        }
    }
}