
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: FREE
    /// </summary>
    public enum StoreGetPricingModel
    {
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
    public static class StoreGetPricingModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreGetPricingModel value)
        {
            return value switch
            {
                StoreGetPricingModel.Free => "FREE",
                StoreGetPricingModel.PayPerEvent => "PAY_PER_EVENT",
                StoreGetPricingModel.PricePerDatasetItem => "PRICE_PER_DATASET_ITEM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreGetPricingModel? ToEnum(string value)
        {
            return value switch
            {
                "FREE" => StoreGetPricingModel.Free,
                "PAY_PER_EVENT" => StoreGetPricingModel.PayPerEvent,
                "PRICE_PER_DATASET_ITEM" => StoreGetPricingModel.PricePerDatasetItem,
                _ => null,
            };
        }
    }
}