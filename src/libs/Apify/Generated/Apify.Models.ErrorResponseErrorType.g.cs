
#nullable enable

namespace Apify
{
    /// <summary>
    /// Machine-processable error type identifier.
    /// </summary>
    public enum ErrorResponseErrorType
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
    public static class ErrorResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorResponseErrorType value)
        {
            return value switch
            {
                ErrorResponseErrorType.ActorMemoryLimitExceeded => "actor-memory-limit-exceeded",
                ErrorResponseErrorType.ActorNotFound => "actor-not-found",
                ErrorResponseErrorType.InvalidInput => "invalid-input",
                ErrorResponseErrorType.MethodNotAllowed => "method-not-allowed",
                ErrorResponseErrorType.PermissionDenied => "permission-denied",
                ErrorResponseErrorType.RateLimitExceeded => "rate-limit-exceeded",
                ErrorResponseErrorType.RecordNotFound => "record-not-found",
                ErrorResponseErrorType.RecordNotUnique => "record-not-unique",
                ErrorResponseErrorType.RecordOrTokenNotFound => "record-or-token-not-found",
                ErrorResponseErrorType.RequestIdInvalid => "request-id-invalid",
                ErrorResponseErrorType.RequestTooLarge => "request-too-large",
                ErrorResponseErrorType.RunFailed => "run-failed",
                ErrorResponseErrorType.RunTimeoutExceeded => "run-timeout-exceeded",
                ErrorResponseErrorType.TokenNotValid => "token-not-valid",
                ErrorResponseErrorType.UnknownBuildTag => "unknown-build-tag",
                ErrorResponseErrorType.UnsupportedContentEncoding => "unsupported-content-encoding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "actor-memory-limit-exceeded" => ErrorResponseErrorType.ActorMemoryLimitExceeded,
                "actor-not-found" => ErrorResponseErrorType.ActorNotFound,
                "invalid-input" => ErrorResponseErrorType.InvalidInput,
                "method-not-allowed" => ErrorResponseErrorType.MethodNotAllowed,
                "permission-denied" => ErrorResponseErrorType.PermissionDenied,
                "rate-limit-exceeded" => ErrorResponseErrorType.RateLimitExceeded,
                "record-not-found" => ErrorResponseErrorType.RecordNotFound,
                "record-not-unique" => ErrorResponseErrorType.RecordNotUnique,
                "record-or-token-not-found" => ErrorResponseErrorType.RecordOrTokenNotFound,
                "request-id-invalid" => ErrorResponseErrorType.RequestIdInvalid,
                "request-too-large" => ErrorResponseErrorType.RequestTooLarge,
                "run-failed" => ErrorResponseErrorType.RunFailed,
                "run-timeout-exceeded" => ErrorResponseErrorType.RunTimeoutExceeded,
                "token-not-valid" => ErrorResponseErrorType.TokenNotValid,
                "unknown-build-tag" => ErrorResponseErrorType.UnknownBuildTag,
                "unsupported-content-encoding" => ErrorResponseErrorType.UnsupportedContentEncoding,
                _ => null,
            };
        }
    }
}