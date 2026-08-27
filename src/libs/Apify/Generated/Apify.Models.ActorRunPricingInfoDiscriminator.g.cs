
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActorRunPricingInfoDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingModel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ActorRunPricingInfoDiscriminatorPricingModelJsonConverter))]
        public global::Apify.ActorRunPricingInfoDiscriminatorPricingModel? PricingModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorRunPricingInfoDiscriminator" /> class.
        /// </summary>
        /// <param name="pricingModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorRunPricingInfoDiscriminator(
            global::Apify.ActorRunPricingInfoDiscriminatorPricingModel? pricingModel)
        {
            this.PricingModel = pricingModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorRunPricingInfoDiscriminator" /> class.
        /// </summary>
        public ActorRunPricingInfoDiscriminator()
        {
        }

    }
}