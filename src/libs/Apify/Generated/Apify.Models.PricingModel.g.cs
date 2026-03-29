
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum PricingModel
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
    public static class PricingModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PricingModel value)
        {
            return value switch
            {
                PricingModel.FlatPricePerMonth => "FLAT_PRICE_PER_MONTH",
                PricingModel.Free => "FREE",
                PricingModel.PayPerEvent => "PAY_PER_EVENT",
                PricingModel.PricePerDatasetItem => "PRICE_PER_DATASET_ITEM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PricingModel? ToEnum(string value)
        {
            return value switch
            {
                "FLAT_PRICE_PER_MONTH" => PricingModel.FlatPricePerMonth,
                "FREE" => PricingModel.Free,
                "PAY_PER_EVENT" => PricingModel.PayPerEvent,
                "PRICE_PER_DATASET_ITEM" => PricingModel.PricePerDatasetItem,
                _ => null,
            };
        }
    }
}