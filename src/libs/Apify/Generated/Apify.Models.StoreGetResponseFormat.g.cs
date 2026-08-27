
#nullable enable

namespace Apify
{
    /// <summary>
    /// Default Value: full<br/>
    /// Example: agent
    /// </summary>
    public enum StoreGetResponseFormat
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Full,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreGetResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreGetResponseFormat value)
        {
            return value switch
            {
                StoreGetResponseFormat.Agent => "agent",
                StoreGetResponseFormat.Full => "full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreGetResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "agent" => StoreGetResponseFormat.Agent,
                "full" => StoreGetResponseFormat.Full,
                _ => null,
            };
        }
    }
}