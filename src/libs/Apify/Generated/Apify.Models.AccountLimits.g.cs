
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountLimits
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyUsageCycle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.UsageCycle MonthlyUsageCycle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.Limits Limits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.Current Current { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLimits" /> class.
        /// </summary>
        /// <param name="monthlyUsageCycle"></param>
        /// <param name="limits"></param>
        /// <param name="current"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountLimits(
            global::Apify.UsageCycle monthlyUsageCycle,
            global::Apify.Limits limits,
            global::Apify.Current current)
        {
            this.MonthlyUsageCycle = monthlyUsageCycle ?? throw new global::System.ArgumentNullException(nameof(monthlyUsageCycle));
            this.Limits = limits ?? throw new global::System.ArgumentNullException(nameof(limits));
            this.Current = current ?? throw new global::System.ArgumentNullException(nameof(current));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLimits" /> class.
        /// </summary>
        public AccountLimits()
        {
        }

    }
}