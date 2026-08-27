
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum VersionSourceType
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
        SourceCode,
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
    public static class VersionSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VersionSourceType value)
        {
            return value switch
            {
                VersionSourceType.GithubGist => "GITHUB_GIST",
                VersionSourceType.GitRepo => "GIT_REPO",
                VersionSourceType.SourceCode => "SOURCE_CODE",
                VersionSourceType.SourceFiles => "SOURCE_FILES",
                VersionSourceType.Tarball => "TARBALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VersionSourceType? ToEnum(string value)
        {
            return value switch
            {
                "GITHUB_GIST" => VersionSourceType.GithubGist,
                "GIT_REPO" => VersionSourceType.GitRepo,
                "SOURCE_CODE" => VersionSourceType.SourceCode,
                "SOURCE_FILES" => VersionSourceType.SourceFiles,
                "TARBALL" => VersionSourceType.Tarball,
                _ => null,
            };
        }
    }
}