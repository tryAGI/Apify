
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduleActionRunActorTask
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
        /// Initializes a new instance of the <see cref="ScheduleActionRunActorTask" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actorTaskId"></param>
        /// <param name="input"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleActionRunActorTask(
            string id,
            string actorTaskId,
            object? input,
            string type = "RUN_ACTOR_TASK")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.ActorTaskId = actorTaskId ?? throw new global::System.ArgumentNullException(nameof(actorTaskId));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleActionRunActorTask" /> class.
        /// </summary>
        public ScheduleActionRunActorTask()
        {
        }
    }
}