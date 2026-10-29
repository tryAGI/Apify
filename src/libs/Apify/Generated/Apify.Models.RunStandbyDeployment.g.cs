
#nullable enable

namespace Apify
{
    /// <summary>
    /// Which pool the Server Actor run serves. `SINGLE_TENANT` is a private instance in the caller's account.<br/>
    /// The `MULTI_TENANT_*` pools run in the Actor owner's account and serve many callers;<br/>
    /// charges in them require a `requestId` (see the charge endpoint).
    /// </summary>
    public enum RunStandbyDeployment
    {
        /// <summary>
        ///
        /// </summary>
        MultiTenantFreeUsers,
        /// <summary>
        ///
        /// </summary>
        MultiTenantOwnerPaid,
        /// <summary>
        ///
        /// </summary>
        MultiTenantPayingUsers,
        /// <summary>
        ///
        /// </summary>
        SingleTenant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStandbyDeploymentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStandbyDeployment value)
        {
            return value switch
            {
                RunStandbyDeployment.MultiTenantFreeUsers => "MULTI_TENANT_FREE_USERS",
                RunStandbyDeployment.MultiTenantOwnerPaid => "MULTI_TENANT_OWNER_PAID",
                RunStandbyDeployment.MultiTenantPayingUsers => "MULTI_TENANT_PAYING_USERS",
                RunStandbyDeployment.SingleTenant => "SINGLE_TENANT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStandbyDeployment? ToEnum(string value)
        {
            return value switch
            {
                "MULTI_TENANT_FREE_USERS" => RunStandbyDeployment.MultiTenantFreeUsers,
                "MULTI_TENANT_OWNER_PAID" => RunStandbyDeployment.MultiTenantOwnerPaid,
                "MULTI_TENANT_PAYING_USERS" => RunStandbyDeployment.MultiTenantPayingUsers,
                "SINGLE_TENANT" => RunStandbyDeployment.SingleTenant,
                _ => null,
            };
        }
    }
}