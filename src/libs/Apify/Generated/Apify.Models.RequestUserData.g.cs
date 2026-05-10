
#nullable enable

namespace Apify
{
    /// <summary>
    /// Custom user data attached to the request. Can contain arbitrary fields.<br/>
    /// Example: {"label":"DETAIL","customField":"custom-value"}
    /// </summary>
    public sealed partial class RequestUserData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}