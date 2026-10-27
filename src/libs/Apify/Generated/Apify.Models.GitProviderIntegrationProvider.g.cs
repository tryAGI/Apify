
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum GitProviderIntegrationProvider
    {
        /// <summary>
        ///
        /// </summary>
        Bitbucket,
        /// <summary>
        ///
        /// </summary>
        Github,
        /// <summary>
        ///
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GitProviderIntegrationProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GitProviderIntegrationProvider value)
        {
            return value switch
            {
                GitProviderIntegrationProvider.Bitbucket => "bitbucket",
                GitProviderIntegrationProvider.Github => "github",
                GitProviderIntegrationProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GitProviderIntegrationProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GitProviderIntegrationProvider.Bitbucket,
                "github" => GitProviderIntegrationProvider.Github,
                "gitlab" => GitProviderIntegrationProvider.Gitlab,
                _ => null,
            };
        }
    }
}