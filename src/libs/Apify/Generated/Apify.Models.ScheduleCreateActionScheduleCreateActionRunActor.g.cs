
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduleCreateActionScheduleCreateActionRunActor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ScheduleCreateActionScheduleCreateActionRunActorTypeJsonConverter))]
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActorType Type { get; set; }

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
        public global::Apify.OptionalRunOptions? RunOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCreateActionScheduleCreateActionRunActor" /> class.
        /// </summary>
        /// <param name="actorId"></param>
        /// <param name="type"></param>
        /// <param name="runInput"></param>
        /// <param name="runOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleCreateActionScheduleCreateActionRunActor(
            string actorId,
            global::Apify.ScheduleCreateActionScheduleCreateActionRunActorType type,
            global::Apify.ScheduleActionRunInput? runInput,
            global::Apify.OptionalRunOptions? runOptions)
        {
            this.Type = type;
            this.ActorId = actorId ?? throw new global::System.ArgumentNullException(nameof(actorId));
            this.RunInput = runInput;
            this.RunOptions = runOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCreateActionScheduleCreateActionRunActor" /> class.
        /// </summary>
        public ScheduleCreateActionScheduleCreateActionRunActor()
        {
        }
    }
}