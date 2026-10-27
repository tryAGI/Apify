
#nullable enable

namespace Apify
{
    /// <summary>
    /// Level of monitoring services included in the plan. `null` or missing means the plan includes no monitoring service.
    /// </summary>
    public enum UserPlanMonitoringLevel
    {
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserPlanMonitoringLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserPlanMonitoringLevel value)
        {
            return value switch
            {
                UserPlanMonitoringLevel.Standard => "STANDARD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserPlanMonitoringLevel? ToEnum(string value)
        {
            return value switch
            {
                "STANDARD" => UserPlanMonitoringLevel.Standard,
                _ => null,
            };
        }
    }
}