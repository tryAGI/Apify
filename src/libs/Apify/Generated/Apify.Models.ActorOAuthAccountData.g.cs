
#nullable enable

namespace Apify
{
    /// <summary>
    /// The OAuth tokens of the account, such as `access_token`, `refresh_token`, `scope` and `expiry_date`. The exact<br/>
    /// fields depend on the OAuth provider.
    /// </summary>
    public sealed partial class ActorOAuthAccountData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}