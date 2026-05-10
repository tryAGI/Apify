
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Task
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
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modifiedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedAt")]
        public global::System.DateTime? RemovedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::Apify.TaskStats? Stats { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standbyUrl")]
        public string? StandbyUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="actId"></param>
        /// <param name="name"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="username"></param>
        /// <param name="removedAt"></param>
        /// <param name="stats"></param>
        /// <param name="options"></param>
        /// <param name="input"></param>
        /// <param name="title"></param>
        /// <param name="actorStandby"></param>
        /// <param name="standbyUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Task(
            string id,
            string userId,
            string actId,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt,
            string? username,
            global::System.DateTime? removedAt,
            global::Apify.TaskStats? stats,
            global::Apify.TaskOptions? options,
            global::Apify.TaskInput? input,
            string? title,
            global::Apify.ActorStandby? actorStandby,
            string? standbyUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ActId = actId ?? throw new global::System.ArgumentNullException(nameof(actId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Username = username;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.RemovedAt = removedAt;
            this.Stats = stats;
            this.Options = options;
            this.Input = input;
            this.Title = title;
            this.ActorStandby = actorStandby;
            this.StandbyUrl = standbyUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        public Task()
        {
        }

    }
}