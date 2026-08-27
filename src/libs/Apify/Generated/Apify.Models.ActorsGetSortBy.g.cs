
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: createdAt
    /// </summary>
    public enum ActorsGetSortBy
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
    public static class ActorsGetSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorsGetSortBy value)
        {
            return value switch
            {
                ActorsGetSortBy.CreatedAt => "createdAt",
                ActorsGetSortBy.StatsLastRunStartedAt => "stats.lastRunStartedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorsGetSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => ActorsGetSortBy.CreatedAt,
                "stats.lastRunStartedAt" => ActorsGetSortBy.StatsLastRunStartedAt,
                _ => null,
            };
        }
    }
}