
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TaskPublicConfigFaqItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Question { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Answer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskPublicConfigFaqItem" /> class.
        /// </summary>
        /// <param name="question"></param>
        /// <param name="answer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskPublicConfigFaqItem(
            string question,
            string answer)
        {
            this.Question = question ?? throw new global::System.ArgumentNullException(nameof(question));
            this.Answer = answer ?? throw new global::System.ArgumentNullException(nameof(answer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskPublicConfigFaqItem" /> class.
        /// </summary>
        public TaskPublicConfigFaqItem()
        {
        }

    }
}