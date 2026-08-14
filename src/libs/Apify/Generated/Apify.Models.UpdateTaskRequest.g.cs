
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTaskRequest
    {
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
        public global::Apify.TaskInput? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorStandby")]
        public global::Apify.ActorStandby? ActorStandby { get; set; }

        /// <summary>
        /// Configuration that controls how the published task appears on its public landing page.<br/>
        /// Editing this object requires write permission to the Actor that the task belongs to.<br/>
        /// The fields you send are merged into the stored configuration, so you only need to include<br/>
        /// the ones you're changing. To clear a field, set it to `null`. Sending `publicConfig: null`<br/>
        /// is rejected, so the object as a whole can't be cleared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicConfig")]
        public global::Apify.TaskPublicConfig? PublicConfig { get; set; }

        /// <summary>
        /// Set to `true` to publish the task on its public landing page, or `false` to unpublish it.<br/>
        /// Sending the value the task already has does nothing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPublic")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTaskRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="options"></param>
        /// <param name="input"></param>
        /// <param name="title"></param>
        /// <param name="actorStandby"></param>
        /// <param name="publicConfig">
        /// Configuration that controls how the published task appears on its public landing page.<br/>
        /// Editing this object requires write permission to the Actor that the task belongs to.<br/>
        /// The fields you send are merged into the stored configuration, so you only need to include<br/>
        /// the ones you're changing. To clear a field, set it to `null`. Sending `publicConfig: null`<br/>
        /// is rejected, so the object as a whole can't be cleared.
        /// </param>
        /// <param name="isPublic">
        /// Set to `true` to publish the task on its public landing page, or `false` to unpublish it.<br/>
        /// Sending the value the task already has does nothing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTaskRequest(
            string? name,
            global::Apify.TaskOptions? options,
            global::Apify.TaskInput? input,
            string? title,
            global::Apify.ActorStandby? actorStandby,
            global::Apify.TaskPublicConfig? publicConfig,
            bool? isPublic)
        {
            this.Name = name;
            this.Options = options;
            this.Input = input;
            this.Title = title;
            this.ActorStandby = actorStandby;
            this.PublicConfig = publicConfig;
            this.IsPublic = isPublic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTaskRequest" /> class.
        /// </summary>
        public UpdateTaskRequest()
        {
        }

    }
}