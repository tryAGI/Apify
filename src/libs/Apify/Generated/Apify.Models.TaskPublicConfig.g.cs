
#nullable enable

namespace Apify
{
    /// <summary>
    /// Public-facing configuration of a published task, used by the task's public landing page.<br/>
    /// The task's publication state is determined by `publishedAt` - a task is published when<br/>
    /// `publishedAt` is set and unpublished when it is `null`.
    /// </summary>
    public sealed partial class TaskPublicConfig
    {
        /// <summary>
        /// Time when the task was published, or `null` if the task isn't published.<br/>
        /// This field is server-controlled. To publish or unpublish a task, use the<br/>
        /// [Update task](/api/v2/actor-task-put) endpoint and set `isPublic`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedAt")]
        public global::System.DateTime? PublishedAt { get; set; }

        /// <summary>
        /// Name of the Actor task to display by search engines such as Google. Defaults to the task<br/>
        /// title. At most 60 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seoTitle")]
        public string? SeoTitle { get; set; }

        /// <summary>
        /// Description of the Actor task to display by search engines such as Google. Defaults to the<br/>
        /// task description. At most 160 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seoDescription")]
        public string? SeoDescription { get; set; }

        /// <summary>
        /// Names of the task input fields displayed on the public task page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSchemaFields")]
        public global::System.Collections.Generic.IList<string>? InputSchemaFields { get; set; }

        /// <summary>
        /// Name of the dataset from the Actor's dataset schema whose results are displayed. When<br/>
        /// `null`, the Actor's default dataset is used. That is, the only dataset the Actor declares,<br/>
        /// or the one named `default` when it declares several.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetName")]
        public string? DatasetName { get; set; }

        /// <summary>
        /// Key of the dataset view from the Actor's dataset schema used to display results. Must be<br/>
        /// one of the views declared on the resolved dataset. You can't publish a task without it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetView")]
        public string? DatasetView { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskPublicConfig" /> class.
        /// </summary>
        /// <param name="publishedAt">
        /// Time when the task was published, or `null` if the task isn't published.<br/>
        /// This field is server-controlled. To publish or unpublish a task, use the<br/>
        /// [Update task](/api/v2/actor-task-put) endpoint and set `isPublic`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="seoTitle">
        /// Name of the Actor task to display by search engines such as Google. Defaults to the task<br/>
        /// title. At most 60 characters.
        /// </param>
        /// <param name="seoDescription">
        /// Description of the Actor task to display by search engines such as Google. Defaults to the<br/>
        /// task description. At most 160 characters.
        /// </param>
        /// <param name="inputSchemaFields">
        /// Names of the task input fields displayed on the public task page.
        /// </param>
        /// <param name="datasetName">
        /// Name of the dataset from the Actor's dataset schema whose results are displayed. When<br/>
        /// `null`, the Actor's default dataset is used. That is, the only dataset the Actor declares,<br/>
        /// or the one named `default` when it declares several.
        /// </param>
        /// <param name="datasetView">
        /// Key of the dataset view from the Actor's dataset schema used to display results. Must be<br/>
        /// one of the views declared on the resolved dataset. You can't publish a task without it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskPublicConfig(
            global::System.DateTime? publishedAt,
            string? seoTitle,
            string? seoDescription,
            global::System.Collections.Generic.IList<string>? inputSchemaFields,
            string? datasetName,
            string? datasetView)
        {
            this.PublishedAt = publishedAt;
            this.SeoTitle = seoTitle;
            this.SeoDescription = seoDescription;
            this.InputSchemaFields = inputSchemaFields;
            this.DatasetName = datasetName;
            this.DatasetView = datasetView;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskPublicConfig" /> class.
        /// </summary>
        public TaskPublicConfig()
        {
        }

    }
}