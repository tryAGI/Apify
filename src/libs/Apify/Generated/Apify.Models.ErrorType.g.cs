
#nullable enable

namespace Apify
{
    /// <summary>
    /// Machine-processable error type identifier.
    /// </summary>
    public enum ErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        ActorMemoryLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        ActorNotFound,
        /// <summary>
        /// 
        /// </summary>
        InvalidInput,
        /// <summary>
        /// 
        /// </summary>
        MethodNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        PermissionDenied,
        /// <summary>
        /// 
        /// </summary>
        RateLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        RecordNotFound,
        /// <summary>
        /// 
        /// </summary>
        RecordNotUnique,
        /// <summary>
        /// 
        /// </summary>
        RecordOrTokenNotFound,
        /// <summary>
        /// 
        /// </summary>
        RequestIdInvalid,
        /// <summary>
        /// 
        /// </summary>
        RequestTooLarge,
        /// <summary>
        /// 
        /// </summary>
        RunFailed,
        /// <summary>
        /// 
        /// </summary>
        RunTimeoutExceeded,
        /// <summary>
        /// 
        /// </summary>
        TokenNotValid,
        /// <summary>
        /// 
        /// </summary>
        UnknownBuildTag,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedContentEncoding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorType value)
        {
            return value switch
            {
                ErrorType.ActorMemoryLimitExceeded => "actor-memory-limit-exceeded",
                ErrorType.ActorNotFound => "actor-not-found",
                ErrorType.InvalidInput => "invalid-input",
                ErrorType.MethodNotAllowed => "method-not-allowed",
                ErrorType.PermissionDenied => "permission-denied",
                ErrorType.RateLimitExceeded => "rate-limit-exceeded",
                ErrorType.RecordNotFound => "record-not-found",
                ErrorType.RecordNotUnique => "record-not-unique",
                ErrorType.RecordOrTokenNotFound => "record-or-token-not-found",
                ErrorType.RequestIdInvalid => "request-id-invalid",
                ErrorType.RequestTooLarge => "request-too-large",
                ErrorType.RunFailed => "run-failed",
                ErrorType.RunTimeoutExceeded => "run-timeout-exceeded",
                ErrorType.TokenNotValid => "token-not-valid",
                ErrorType.UnknownBuildTag => "unknown-build-tag",
                ErrorType.UnsupportedContentEncoding => "unsupported-content-encoding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorType? ToEnum(string value)
        {
            return value switch
            {
                "actor-memory-limit-exceeded" => ErrorType.ActorMemoryLimitExceeded,
                "actor-not-found" => ErrorType.ActorNotFound,
                "invalid-input" => ErrorType.InvalidInput,
                "method-not-allowed" => ErrorType.MethodNotAllowed,
                "permission-denied" => ErrorType.PermissionDenied,
                "rate-limit-exceeded" => ErrorType.RateLimitExceeded,
                "record-not-found" => ErrorType.RecordNotFound,
                "record-not-unique" => ErrorType.RecordNotUnique,
                "record-or-token-not-found" => ErrorType.RecordOrTokenNotFound,
                "request-id-invalid" => ErrorType.RequestIdInvalid,
                "request-too-large" => ErrorType.RequestTooLarge,
                "run-failed" => ErrorType.RunFailed,
                "run-timeout-exceeded" => ErrorType.RunTimeoutExceeded,
                "token-not-valid" => ErrorType.TokenNotValid,
                "unknown-build-tag" => ErrorType.UnknownBuildTag,
                "unsupported-content-encoding" => ErrorType.UnsupportedContentEncoding,
                _ => null,
            };
        }
    }
}