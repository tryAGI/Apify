
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EffectivePlatformFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ACTORS")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.EffectivePlatformFeature Actors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("STORAGE")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.EffectivePlatformFeature Storage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("SCHEDULER")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.EffectivePlatformFeature Scheduler { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PROXY")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.EffectivePlatformFeature Proxy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PROXY_EXTERNAL_ACCESS")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.EffectivePlatformFeature ProxyExternalAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PROXY_RESIDENTIAL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.EffectivePlatformFeature ProxyResidential { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PROXY_SERPS")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.EffectivePlatformFeature ProxySerps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("WEBHOOKS")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.EffectivePlatformFeature Webhooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ACTORS_PUBLIC_ALL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.EffectivePlatformFeature ActorsPublicAll { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ACTORS_PUBLIC_DEVELOPER")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.EffectivePlatformFeature ActorsPublicDeveloper { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectivePlatformFeatures" /> class.
        /// </summary>
        /// <param name="actors"></param>
        /// <param name="storage"></param>
        /// <param name="scheduler"></param>
        /// <param name="proxy"></param>
        /// <param name="proxyExternalAccess"></param>
        /// <param name="proxyResidential"></param>
        /// <param name="proxySerps"></param>
        /// <param name="webhooks"></param>
        /// <param name="actorsPublicAll"></param>
        /// <param name="actorsPublicDeveloper"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectivePlatformFeatures(
            global::Apify.EffectivePlatformFeature actors,
            global::Apify.EffectivePlatformFeature storage,
            global::Apify.EffectivePlatformFeature scheduler,
            global::Apify.EffectivePlatformFeature proxy,
            global::Apify.EffectivePlatformFeature proxyExternalAccess,
            global::Apify.EffectivePlatformFeature proxyResidential,
            global::Apify.EffectivePlatformFeature proxySerps,
            global::Apify.EffectivePlatformFeature webhooks,
            global::Apify.EffectivePlatformFeature actorsPublicAll,
            global::Apify.EffectivePlatformFeature actorsPublicDeveloper)
        {
            this.Actors = actors ?? throw new global::System.ArgumentNullException(nameof(actors));
            this.Storage = storage ?? throw new global::System.ArgumentNullException(nameof(storage));
            this.Scheduler = scheduler ?? throw new global::System.ArgumentNullException(nameof(scheduler));
            this.Proxy = proxy ?? throw new global::System.ArgumentNullException(nameof(proxy));
            this.ProxyExternalAccess = proxyExternalAccess ?? throw new global::System.ArgumentNullException(nameof(proxyExternalAccess));
            this.ProxyResidential = proxyResidential ?? throw new global::System.ArgumentNullException(nameof(proxyResidential));
            this.ProxySerps = proxySerps ?? throw new global::System.ArgumentNullException(nameof(proxySerps));
            this.Webhooks = webhooks ?? throw new global::System.ArgumentNullException(nameof(webhooks));
            this.ActorsPublicAll = actorsPublicAll ?? throw new global::System.ArgumentNullException(nameof(actorsPublicAll));
            this.ActorsPublicDeveloper = actorsPublicDeveloper ?? throw new global::System.ArgumentNullException(nameof(actorsPublicDeveloper));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectivePlatformFeatures" /> class.
        /// </summary>
        public EffectivePlatformFeatures()
        {
        }
    }
}