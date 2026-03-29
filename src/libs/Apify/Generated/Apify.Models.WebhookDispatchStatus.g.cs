
#nullable enable

namespace Apify
{
    /// <summary>
    /// Status of the webhook dispatch indicating whether the HTTP request was successful.
    /// </summary>
    public enum WebhookDispatchStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDispatchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDispatchStatus value)
        {
            return value switch
            {
                WebhookDispatchStatus.Active => "ACTIVE",
                WebhookDispatchStatus.Failed => "FAILED",
                WebhookDispatchStatus.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDispatchStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => WebhookDispatchStatus.Active,
                "FAILED" => WebhookDispatchStatus.Failed,
                "SUCCEEDED" => WebhookDispatchStatus.Succeeded,
                _ => null,
            };
        }
    }
}