
#nullable enable

namespace Apify
{
    /// <summary>
    /// Whether each user gets their own standby runs (`SINGLE_TENANT`) or runs are shared across users (`MULTI_TENANT`).
    /// </summary>
    public enum ActorStandbyTenancy
    {
        /// <summary>
        ///
        /// </summary>
        MultiTenant,
        /// <summary>
        ///
        /// </summary>
        SingleTenant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorStandbyTenancyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorStandbyTenancy value)
        {
            return value switch
            {
                ActorStandbyTenancy.MultiTenant => "MULTI_TENANT",
                ActorStandbyTenancy.SingleTenant => "SINGLE_TENANT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorStandbyTenancy? ToEnum(string value)
        {
            return value switch
            {
                "MULTI_TENANT" => ActorStandbyTenancy.MultiTenant,
                "SINGLE_TENANT" => ActorStandbyTenancy.SingleTenant,
                _ => null,
            };
        }
    }
}