
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum ActorRunPricingInfoDiscriminatorPricingModel
    {
        /// <summary>
        ///
        /// </summary>
        FlatPricePerMonth,
        /// <summary>
        ///
        /// </summary>
        Free,
        /// <summary>
        ///
        /// </summary>
        PayPerEvent,
        /// <summary>
        ///
        /// </summary>
        PricePerDatasetItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorRunPricingInfoDiscriminatorPricingModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorRunPricingInfoDiscriminatorPricingModel value)
        {
            return value switch
            {
                ActorRunPricingInfoDiscriminatorPricingModel.FlatPricePerMonth => "FLAT_PRICE_PER_MONTH",
                ActorRunPricingInfoDiscriminatorPricingModel.Free => "FREE",
                ActorRunPricingInfoDiscriminatorPricingModel.PayPerEvent => "PAY_PER_EVENT",
                ActorRunPricingInfoDiscriminatorPricingModel.PricePerDatasetItem => "PRICE_PER_DATASET_ITEM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorRunPricingInfoDiscriminatorPricingModel? ToEnum(string value)
        {
            return value switch
            {
                "FLAT_PRICE_PER_MONTH" => ActorRunPricingInfoDiscriminatorPricingModel.FlatPricePerMonth,
                "FREE" => ActorRunPricingInfoDiscriminatorPricingModel.Free,
                "PAY_PER_EVENT" => ActorRunPricingInfoDiscriminatorPricingModel.PayPerEvent,
                "PRICE_PER_DATASET_ITEM" => ActorRunPricingInfoDiscriminatorPricingModel.PricePerDatasetItem,
                _ => null,
            };
        }
    }
}