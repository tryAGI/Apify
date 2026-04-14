
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
        PageNotFound,
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
        ScheduleActorNotFound,
        /// <summary>
        /// 
        /// </summary>
        ScheduleActorTaskNotFound,
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
        /// <summary>
        /// 
        /// </summary>
        UserNotFound,
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
                ErrorType.PageNotFound => "page-not-found",
                ErrorType.PermissionDenied => "permission-denied",
                ErrorType.RateLimitExceeded => "rate-limit-exceeded",
                ErrorType.RecordNotFound => "record-not-found",
                ErrorType.RecordNotUnique => "record-not-unique",
                ErrorType.RecordOrTokenNotFound => "record-or-token-not-found",
                ErrorType.RequestIdInvalid => "request-id-invalid",
                ErrorType.RequestTooLarge => "request-too-large",
                ErrorType.RunFailed => "run-failed",
                ErrorType.RunTimeoutExceeded => "run-timeout-exceeded",
                ErrorType.ScheduleActorNotFound => "schedule-actor-not-found",
                ErrorType.ScheduleActorTaskNotFound => "schedule-actor-task-not-found",
                ErrorType.TokenNotValid => "token-not-valid",
                ErrorType.UnknownBuildTag => "unknown-build-tag",
                ErrorType.UnsupportedContentEncoding => "unsupported-content-encoding",
                ErrorType.UserNotFound => "user-not-found",
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
                "page-not-found" => ErrorType.PageNotFound,
                "permission-denied" => ErrorType.PermissionDenied,
                "rate-limit-exceeded" => ErrorType.RateLimitExceeded,
                "record-not-found" => ErrorType.RecordNotFound,
                "record-not-unique" => ErrorType.RecordNotUnique,
                "record-or-token-not-found" => ErrorType.RecordOrTokenNotFound,
                "request-id-invalid" => ErrorType.RequestIdInvalid,
                "request-too-large" => ErrorType.RequestTooLarge,
                "run-failed" => ErrorType.RunFailed,
                "run-timeout-exceeded" => ErrorType.RunTimeoutExceeded,
                "schedule-actor-not-found" => ErrorType.ScheduleActorNotFound,
                "schedule-actor-task-not-found" => ErrorType.ScheduleActorTaskNotFound,
                "token-not-valid" => ErrorType.TokenNotValid,
                "unknown-build-tag" => ErrorType.UnknownBuildTag,
                "unsupported-content-encoding" => ErrorType.UnsupportedContentEncoding,
                "user-not-found" => ErrorType.UserNotFound,
                _ => null,
            };
        }
    }
}