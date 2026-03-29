
#nullable enable

namespace Apify
{
    /// <summary>
    /// When you configure the dataset [fields schema](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema/validation), we measure the statistics such as `min`, `max`, `nullCount` and `emptyCount` for each field. This property provides statistics for each field from dataset fields schema. &lt;br/&gt;&lt;/br&gt;See dataset field statistics [documentation](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema/validation#dataset-field-statistics) for more information.
    /// </summary>
    public sealed partial class DatasetStatisticsFieldStatistics
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}