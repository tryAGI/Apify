
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EffectivePlatformFeature
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledReason")]
        public string? DisabledReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledReasonType")]
        public string? DisabledReasonType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTrial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsTrial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trialExpirationAt")]
        public global::System.DateTime? TrialExpirationAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectivePlatformFeature" /> class.
        /// </summary>
        /// <param name="isEnabled"></param>
        /// <param name="isTrial"></param>
        /// <param name="disabledReason"></param>
        /// <param name="disabledReasonType"></param>
        /// <param name="trialExpirationAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectivePlatformFeature(
            bool isEnabled,
            bool isTrial,
            string? disabledReason,
            string? disabledReasonType,
            global::System.DateTime? trialExpirationAt)
        {
            this.IsEnabled = isEnabled;
            this.DisabledReason = disabledReason;
            this.DisabledReasonType = disabledReasonType;
            this.IsTrial = isTrial;
            this.TrialExpirationAt = trialExpirationAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectivePlatformFeature" /> class.
        /// </summary>
        public EffectivePlatformFeature()
        {
        }

    }
}