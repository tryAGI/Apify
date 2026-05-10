
#nullable enable

namespace Apify
{
    /// <summary>
    /// Response containing Actor task data.<br/>
    /// Example: {"data":{"id":"zdc3Pyhyz3m8vjDeM","userId":"wRsJZtadYvn4mBZmm","actId":"asADASadYvn4mBZmm","name":"my-task","username":"janedoe","createdAt":"2018-10-26T07:23:14.855Z","modifiedAt":"2018-10-26T13:30:49.578Z","removedAt":null,"stats":{"totalRuns":15},"options":{"build":"latest","timeoutSecs":300,"memoryMbytes":128},"input":{"hello":"world"}}}
    /// </summary>
    public sealed partial class TaskResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.Task Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskResponse(
            global::Apify.Task data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponse" /> class.
        /// </summary>
        public TaskResponse()
        {
        }

    }
}