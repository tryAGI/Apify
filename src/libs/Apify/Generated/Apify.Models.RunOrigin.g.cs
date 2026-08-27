
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum RunOrigin
    {
        /// <summary>
        ///
        /// </summary>
        Actor,
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        Ci,
        /// <summary>
        ///
        /// </summary>
        Cli,
        /// <summary>
        ///
        /// </summary>
        Development,
        /// <summary>
        ///
        /// </summary>
        Mcp,
        /// <summary>
        ///
        /// </summary>
        Scheduler,
        /// <summary>
        ///
        /// </summary>
        Standby,
        /// <summary>
        ///
        /// </summary>
        Test,
        /// <summary>
        ///
        /// </summary>
        Web,
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunOrigin value)
        {
            return value switch
            {
                RunOrigin.Actor => "ACTOR",
                RunOrigin.Api => "API",
                RunOrigin.Ci => "CI",
                RunOrigin.Cli => "CLI",
                RunOrigin.Development => "DEVELOPMENT",
                RunOrigin.Mcp => "MCP",
                RunOrigin.Scheduler => "SCHEDULER",
                RunOrigin.Standby => "STANDBY",
                RunOrigin.Test => "TEST",
                RunOrigin.Web => "WEB",
                RunOrigin.Webhook => "WEBHOOK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunOrigin? ToEnum(string value)
        {
            return value switch
            {
                "ACTOR" => RunOrigin.Actor,
                "API" => RunOrigin.Api,
                "CI" => RunOrigin.Ci,
                "CLI" => RunOrigin.Cli,
                "DEVELOPMENT" => RunOrigin.Development,
                "MCP" => RunOrigin.Mcp,
                "SCHEDULER" => RunOrigin.Scheduler,
                "STANDBY" => RunOrigin.Standby,
                "TEST" => RunOrigin.Test,
                "WEB" => RunOrigin.Web,
                "WEBHOOK" => RunOrigin.Webhook,
                _ => null,
            };
        }
    }
}