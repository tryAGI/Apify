
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"fieldStatistics":{"name":{"nullCount":122},"price":{"min":59,"max":89}}}
    /// </summary>
    public sealed partial class DatasetStatistics
    {
        /// <summary>
        /// When you configure the dataset [fields schema](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema/validation), we measure the statistics such as `min`, `max`, `nullCount` and `emptyCount` for each field. This property provides statistics for each field from dataset fields schema. &lt;br/&gt;&lt;/br&gt;See dataset field statistics [documentation](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema/validation#dataset-field-statistics) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldStatistics")]
        public global::System.Collections.Generic.Dictionary<string, global::Apify.DatasetFieldStatistics>? FieldStatistics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetStatistics" /> class.
        /// </summary>
        /// <param name="fieldStatistics">
        /// When you configure the dataset [fields schema](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema/validation), we measure the statistics such as `min`, `max`, `nullCount` and `emptyCount` for each field. This property provides statistics for each field from dataset fields schema. &lt;br/&gt;&lt;/br&gt;See dataset field statistics [documentation](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema/validation#dataset-field-statistics) for more information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetStatistics(
            global::System.Collections.Generic.Dictionary<string, global::Apify.DatasetFieldStatistics>? fieldStatistics)
        {
            this.FieldStatistics = fieldStatistics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetStatistics" /> class.
        /// </summary>
        public DatasetStatistics()
        {
        }

    }
}