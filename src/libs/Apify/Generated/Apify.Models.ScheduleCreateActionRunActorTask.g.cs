
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScheduleCreateActionRunActorTask
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"RUN_ACTOR_TASK"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "RUN_ACTOR_TASK";

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
        /// Initializes a new instance of the <see cref="ScheduleCreateActionRunActorTask" /> class.
        /// </summary>
        /// <param name="actorTaskId"></param>
        /// <param name="input"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleCreateActionRunActorTask(
            string actorTaskId,
            object? input,
            string type = "RUN_ACTOR_TASK")
        {
            this.Type = type;
            this.ActorTaskId = actorTaskId ?? throw new global::System.ArgumentNullException(nameof(actorTaskId));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCreateActionRunActorTask" /> class.
        /// </summary>
        public ScheduleCreateActionRunActorTask()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ScheduleCreateActionRunActorTask"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ScheduleCreateActionRunActorTask FromActorTaskId(string actorTaskId)
        {
            return new ScheduleCreateActionRunActorTask
            {
                ActorTaskId = actorTaskId,
            };
        }

    }
}