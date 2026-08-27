
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CommonActorPricingInfo
    {
        /// <summary>
        /// Apify's share of the revenue generated under this pricing info record, as a fraction between 0 and 1. Set by the Apify platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apifyMarginPercentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ApifyMarginPercentage { get; set; }

        /// <summary>
        /// When this pricing info record has been created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Since when is this pricing info record effective for a given Actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifiedAboutFutureChangeAt")]
        public global::System.DateTime? NotifiedAboutFutureChangeAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifiedAboutChangeAt")]
        public global::System.DateTime? NotifiedAboutChangeAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasonForChange")]
        public string? ReasonForChange { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPriceChangeNotificationSuppressed")]
        public bool? IsPriceChangeNotificationSuppressed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forceContainsSignificantPriceChange")]
        public bool? ForceContainsSignificantPriceChange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonActorPricingInfo" /> class.
        /// </summary>
        /// <param name="apifyMarginPercentage">
        /// Apify's share of the revenue generated under this pricing info record, as a fraction between 0 and 1. Set by the Apify platform.
        /// </param>
        /// <param name="createdAt">
        /// When this pricing info record has been created
        /// </param>
        /// <param name="startedAt">
        /// Since when is this pricing info record effective for a given Actor
        /// </param>
        /// <param name="notifiedAboutFutureChangeAt"></param>
        /// <param name="notifiedAboutChangeAt"></param>
        /// <param name="reasonForChange"></param>
        /// <param name="isPriceChangeNotificationSuppressed"></param>
        /// <param name="forceContainsSignificantPriceChange"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommonActorPricingInfo(
            double apifyMarginPercentage,
            global::System.DateTime createdAt,
            global::System.DateTime startedAt,
            global::System.DateTime? notifiedAboutFutureChangeAt,
            global::System.DateTime? notifiedAboutChangeAt,
            string? reasonForChange,
            bool? isPriceChangeNotificationSuppressed,
            bool? forceContainsSignificantPriceChange)
        {
            this.ApifyMarginPercentage = apifyMarginPercentage;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.NotifiedAboutFutureChangeAt = notifiedAboutFutureChangeAt;
            this.NotifiedAboutChangeAt = notifiedAboutChangeAt;
            this.ReasonForChange = reasonForChange;
            this.IsPriceChangeNotificationSuppressed = isPriceChangeNotificationSuppressed;
            this.ForceContainsSignificantPriceChange = forceContainsSignificantPriceChange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonActorPricingInfo" /> class.
        /// </summary>
        public CommonActorPricingInfo()
        {
        }

    }
}