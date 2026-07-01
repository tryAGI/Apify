
#nullable enable

namespace Apify
{
    /// <summary>
    /// Defines the schema of items in your dataset, the full specification can be found in [Apify docs](/platform/actors/development/actor-definition/dataset-schema)<br/>
    /// Example: {"actorSpecification":1,"title":"My dataset","views":{"overview":{"title":"Overview","transformation":{"fields":["linkUrl"]},"display":{"component":"table","properties":{"linkUrl":{"label":"Link URL","format":"link"}}}}}}
    /// </summary>
    public sealed partial class DatasetSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}