
#nullable enable

namespace Apify
{
    /// <summary>
    /// The version source types accepted in request bodies. Same as `VersionSourceType`, without `SOURCE_CODE`.
    /// </summary>
    public enum WritableVersionSourceType
    {
        /// <summary>
        ///
        /// </summary>
        GithubGist,
        /// <summary>
        ///
        /// </summary>
        GitRepo,
        /// <summary>
        ///
        /// </summary>
        SourceFiles,
        /// <summary>
        ///
        /// </summary>
        Tarball,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WritableVersionSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WritableVersionSourceType value)
        {
            return value switch
            {
                WritableVersionSourceType.GithubGist => "GITHUB_GIST",
                WritableVersionSourceType.GitRepo => "GIT_REPO",
                WritableVersionSourceType.SourceFiles => "SOURCE_FILES",
                WritableVersionSourceType.Tarball => "TARBALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WritableVersionSourceType? ToEnum(string value)
        {
            return value switch
            {
                "GITHUB_GIST" => WritableVersionSourceType.GithubGist,
                "GIT_REPO" => WritableVersionSourceType.GitRepo,
                "SOURCE_FILES" => WritableVersionSourceType.SourceFiles,
                "TARBALL" => WritableVersionSourceType.Tarball,
                _ => null,
            };
        }
    }
}