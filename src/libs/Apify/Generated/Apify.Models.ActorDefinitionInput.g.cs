
#nullable enable

namespace Apify
{
    /// <summary>
    /// The input schema object, the full specification can be found in [Apify docs](https://docs.apify.com/platform/actors/development/actor-definition/input-schema)
    /// </summary>
    public sealed partial class ActorDefinitionInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}