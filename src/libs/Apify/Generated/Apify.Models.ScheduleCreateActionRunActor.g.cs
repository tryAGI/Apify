
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduleCreateActionRunActor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"RUN_ACTOR"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "RUN_ACTOR";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runInput")]
        public global::Apify.ScheduleActionRunInput? RunInput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runOptions")]
        public global::Apify.TaskOptions? RunOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCreateActionRunActor" /> class.
        /// </summary>
        /// <param name="actorId"></param>
        /// <param name="runInput"></param>
        /// <param name="runOptions"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleCreateActionRunActor(
            string actorId,
            global::Apify.ScheduleActionRunInput? runInput,
            global::Apify.TaskOptions? runOptions,
            string type = "RUN_ACTOR")
        {
            this.Type = type;
            this.ActorId = actorId ?? throw new global::System.ArgumentNullException(nameof(actorId));
            this.RunInput = runInput;
            this.RunOptions = runOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCreateActionRunActor" /> class.
        /// </summary>
        public ScheduleCreateActionRunActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ScheduleCreateActionRunActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ScheduleCreateActionRunActor FromActorId(string actorId)
        {
            return new ScheduleCreateActionRunActor
            {
                ActorId = actorId,
            };
        }

    }
}