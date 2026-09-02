
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTaskRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::Apify.TaskOptions? Options { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.AnyOfJsonConverter<global::Apify.TaskInput, global::System.Collections.Generic.IList<global::Apify.TaskInput>, object>))]
        public global::Apify.AnyOf<global::Apify.TaskInput, global::System.Collections.Generic.IList<global::Apify.TaskInput>, object>? Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorStandby")]
        public global::Apify.ActorStandby? ActorStandby { get; set; }

        /// <summary>
        /// Configuration that controls how the published task appears on its public landing page.<br/>
        /// Editing this object requires write permission to the Actor that the task belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicConfig")]
        public global::Apify.TaskPublicConfig? PublicConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequest" /> class.
        /// </summary>
        /// <param name="actId"></param>
        /// <param name="name"></param>
        /// <param name="options"></param>
        /// <param name="input"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="actorStandby"></param>
        /// <param name="publicConfig">
        /// Configuration that controls how the published task appears on its public landing page.<br/>
        /// Editing this object requires write permission to the Actor that the task belongs to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTaskRequest(
            string actId,
            string? name,
            global::Apify.TaskOptions? options,
            global::Apify.AnyOf<global::Apify.TaskInput, global::System.Collections.Generic.IList<global::Apify.TaskInput>, object>? input,
            string? title,
            string? description,
            global::Apify.ActorStandby? actorStandby,
            global::Apify.TaskPublicConfig? publicConfig)
        {
            this.ActId = actId ?? throw new global::System.ArgumentNullException(nameof(actId));
            this.Name = name;
            this.Options = options;
            this.Input = input;
            this.Title = title;
            this.Description = description;
            this.ActorStandby = actorStandby;
            this.PublicConfig = publicConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequest" /> class.
        /// </summary>
        public CreateTaskRequest()
        {
        }

    }
}