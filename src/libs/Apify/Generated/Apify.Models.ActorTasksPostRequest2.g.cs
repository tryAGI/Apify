
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"actId":"asADASadYvn4mBZmm","name":"my-task","options":{"build":"latest","timeoutSecs":300,"memoryMbytes":128},"input":{"hello":"world"}}
    /// </summary>
    public sealed partial class ActorTasksPostRequest2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}