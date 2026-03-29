
#nullable enable

namespace Apify
{
    /// <summary>
    /// A map of service usage item names to their usage details.<br/>
    /// Example: {"ACTOR_COMPUTE_UNITS":{"quantity":60,"baseAmountUsd":0.00030000000000000003,"baseUnitPriceUsd":0.000005,"amountAfterVolumeDiscountUsd":0.00030000000000000003,"priceTiers":[]}}
    /// </summary>
    public sealed partial class ServiceUsage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}