
#nullable enable

namespace Apify
{
    /// <summary>
    /// Standby configuration of the run. Present only on Actor Standby runs.
    /// </summary>
    public sealed partial class RunStandby
    {
        /// <summary>
        /// Which pool the Server Actor run serves. `SINGLE_TENANT` is a private instance in the caller's account.<br/>
        /// The `MULTI_TENANT_*` pools run in the Actor owner's account and serve many callers;<br/>
        /// charges in them require a `requestId` (see the charge endpoint).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.RunStandbyDeploymentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.RunStandbyDeployment Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStandby" /> class.
        /// </summary>
        /// <param name="deployment">
        /// Which pool the Server Actor run serves. `SINGLE_TENANT` is a private instance in the caller's account.<br/>
        /// The `MULTI_TENANT_*` pools run in the Actor owner's account and serve many callers;<br/>
        /// charges in them require a `requestId` (see the charge endpoint).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStandby(
            global::Apify.RunStandbyDeployment deployment)
        {
            this.Deployment = deployment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStandby" /> class.
        /// </summary>
        public RunStandby()
        {
        }

    }
}