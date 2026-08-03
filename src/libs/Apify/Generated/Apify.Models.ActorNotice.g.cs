
#nullable enable

namespace Apify
{
    /// <summary>
    /// A warning displayed on the Actor's page in Apify Store and Console. Can be set by the Actor's developer or automatically by Apify's quality checks.
    /// </summary>
    public enum ActorNotice
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        ResidentialProxyRequired,
        /// <summary>
        /// 
        /// </summary>
        UnderMaintenance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorNoticeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorNotice value)
        {
            return value switch
            {
                ActorNotice.None => "NONE",
                ActorNotice.ResidentialProxyRequired => "RESIDENTIAL_PROXY_REQUIRED",
                ActorNotice.UnderMaintenance => "UNDER_MAINTENANCE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorNotice? ToEnum(string value)
        {
            return value switch
            {
                "NONE" => ActorNotice.None,
                "RESIDENTIAL_PROXY_REQUIRED" => ActorNotice.ResidentialProxyRequired,
                "UNDER_MAINTENANCE" => ActorNotice.UnderMaintenance,
                _ => null,
            };
        }
    }
}