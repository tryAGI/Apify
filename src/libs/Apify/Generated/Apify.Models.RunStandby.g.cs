
#nullable enable

namespace Apify
{
    /// <summary>
    /// Standby configuration of the run. Present only on Actor Standby runs.
    /// </summary>
    public sealed partial class RunStandby
    {
        /// <summary>
        /// How the Standby run is deployed: `SINGLE_TENANT`, `MULTI_TENANT_FREE_USERS`, `MULTI_TENANT_PAYING_USERS` or `MULTI_TENANT_OWNER_PAID`. `SINGLE_TENANT` is a private instance in the user's account.<br/>
        /// The `MULTI_TENANT_*` values are runs in the Actor owner's account that serve requests from many users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStandby" /> class.
        /// </summary>
        /// <param name="deployment">
        /// How the Standby run is deployed: `SINGLE_TENANT`, `MULTI_TENANT_FREE_USERS`, `MULTI_TENANT_PAYING_USERS` or `MULTI_TENANT_OWNER_PAID`. `SINGLE_TENANT` is a private instance in the user's account.<br/>
        /// The `MULTI_TENANT_*` values are runs in the Actor owner's account that serve requests from many users.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStandby(
            string deployment)
        {
            this.Deployment = deployment ?? throw new global::System.ArgumentNullException(nameof(deployment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStandby" /> class.
        /// </summary>
        public RunStandby()
        {
        }

    }
}