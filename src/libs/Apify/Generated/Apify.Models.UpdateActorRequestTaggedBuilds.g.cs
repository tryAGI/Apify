
#nullable enable

namespace Apify
{
    /// <summary>
    /// An object to modify tags on the Actor's builds. The key is the tag name (e.g., _latest_), and the value is either an object with a `buildId` or `null`.<br/>
    /// This operation is a patch; any existing tags that you omit from this object will be preserved.<br/>
    /// - **To create or reassign a tag**, provide the tag name with a `buildId`. e.g., to assign the _latest_ tag:<br/>
    ///   &amp;nbsp;<br/>
    ///   ```json<br/>
    ///   {<br/>
    ///     "latest": {<br/>
    ///       "buildId": "z2EryhbfhgSyqj6Hn"<br/>
    ///     }<br/>
    ///   }<br/>
    ///   ```<br/>
    /// - **To remove a tag**, provide the tag name with a `null` value. e.g., to remove the _beta_ tag:<br/>
    ///   &amp;nbsp;<br/>
    ///   ```json<br/>
    ///   {<br/>
    ///     "beta": null<br/>
    ///   }<br/>
    ///   ```<br/>
    /// - **To perform multiple operations**, combine them. The following reassigns _latest_ and removes _beta_, while preserving any other existing tags.<br/>
    ///   &amp;nbsp;<br/>
    ///   ```json<br/>
    ///   {<br/>
    ///     "latest": {<br/>
    ///       "buildId": "z2EryhbfhgSyqj6Hn"<br/>
    ///     },<br/>
    ///     "beta": null<br/>
    ///   }<br/>
    ///   ```<br/>
    /// Example: {"latest":{"buildId":"z2EryhbfhgSyqj6Hn"},"beta":null}
    /// </summary>
    public sealed partial class UpdateActorRequestTaggedBuilds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}