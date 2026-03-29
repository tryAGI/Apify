
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduleCreateActionScheduleCreateActionRunActorTask
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ScheduleCreateActionScheduleCreateActionRunActorTaskTypeJsonConverter))]
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTaskType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ScheduleCreateActionScheduleCreateActionRunActorTask" /> class.
        /// </summary>
        /// <param name="actorTaskId"></param>
        /// <param name="type"></param>
        /// <param name="input"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleCreateActionScheduleCreateActionRunActorTask(
            string actorTaskId,
            global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTaskType type,
            object? input)
        {
            this.Type = type;
            this.ActorTaskId = actorTaskId ?? throw new global::System.ArgumentNullException(nameof(actorTaskId));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCreateActionScheduleCreateActionRunActorTask" /> class.
        /// </summary>
        public ScheduleCreateActionScheduleCreateActionRunActorTask()
        {
        }
    }
}