
#nullable enable

namespace Apify
{
    /// <summary>
    /// The input configuration for the Actor task. This is a user-defined JSON object<br/>
    /// that will be passed to the Actor when the task is run.<br/>
    /// Example: {"startUrls":[{"url":"https://example.com"}],"maxRequestsPerCrawl":100}
    /// </summary>
    public sealed partial class TaskInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}