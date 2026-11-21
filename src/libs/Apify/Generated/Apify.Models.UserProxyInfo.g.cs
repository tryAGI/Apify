
#nullable enable

namespace Apify
{
    /// <summary>
    /// Reduced user data with only the fields Apify Proxy reads.
    /// </summary>
    public sealed partial class UserProxyInfo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.UserProxyInfoPlan Plan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effectivePlatformFeatures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.EffectivePlatformFeatures EffectivePlatformFeatures { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPaying")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPaying { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProxyInfo" /> class.
        /// </summary>
        /// <param name="plan"></param>
        /// <param name="effectivePlatformFeatures"></param>
        /// <param name="isPaying"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProxyInfo(
            global::Apify.UserProxyInfoPlan plan,
            global::Apify.EffectivePlatformFeatures effectivePlatformFeatures,
            bool isPaying)
        {
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
            this.EffectivePlatformFeatures = effectivePlatformFeatures ?? throw new global::System.ArgumentNullException(nameof(effectivePlatformFeatures));
            this.IsPaying = isPaying;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProxyInfo" /> class.
        /// </summary>
        public UserProxyInfo()
        {
        }

    }
}