
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduleActionShortRunActorTask
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleActionShortRunActorTask" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actorTaskId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleActionShortRunActorTask(
            string id,
            string actorTaskId,
            string type = "RUN_ACTOR_TASK")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.ActorTaskId = actorTaskId ?? throw new global::System.ArgumentNullException(nameof(actorTaskId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleActionShortRunActorTask" /> class.
        /// </summary>
        public ScheduleActionShortRunActorTask()
        {
        }

    }
}