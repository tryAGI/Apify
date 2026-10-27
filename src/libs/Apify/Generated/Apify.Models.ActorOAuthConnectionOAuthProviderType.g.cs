
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum ActorOAuthConnectionOAuthProviderType
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorOAuthConnectionOAuthProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorOAuthConnectionOAuthProviderType value)
        {
            return value switch
            {
                ActorOAuthConnectionOAuthProviderType.Custom => "CUSTOM",
                ActorOAuthConnectionOAuthProviderType.Google => "GOOGLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorOAuthConnectionOAuthProviderType? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM" => ActorOAuthConnectionOAuthProviderType.Custom,
                "GOOGLE" => ActorOAuthConnectionOAuthProviderType.Google,
                _ => null,
            };
        }
    }
}