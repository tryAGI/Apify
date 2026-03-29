
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: createdAt
    /// </summary>
    public enum ActsGetSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        StatsLastRunStartedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActsGetSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActsGetSortBy value)
        {
            return value switch
            {
                ActsGetSortBy.CreatedAt => "createdAt",
                ActsGetSortBy.StatsLastRunStartedAt => "stats.lastRunStartedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActsGetSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => ActsGetSortBy.CreatedAt,
                "stats.lastRunStartedAt" => ActsGetSortBy.StatsLastRunStartedAt,
                _ => null,
            };
        }
    }
}