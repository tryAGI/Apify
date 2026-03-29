
#nullable enable

namespace Apify
{
    /// <summary>
    /// Type of event that triggers the webhook.
    /// </summary>
    public enum WebhookEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ActorBuildAborted,
        /// <summary>
        /// 
        /// </summary>
        ActorBuildCreated,
        /// <summary>
        /// 
        /// </summary>
        ActorBuildFailed,
        /// <summary>
        /// 
        /// </summary>
        ActorBuildSucceeded,
        /// <summary>
        /// 
        /// </summary>
        ActorBuildTimedOut,
        /// <summary>
        /// 
        /// </summary>
        ActorRunAborted,
        /// <summary>
        /// 
        /// </summary>
        ActorRunCreated,
        /// <summary>
        /// 
        /// </summary>
        ActorRunFailed,
        /// <summary>
        /// 
        /// </summary>
        ActorRunResurrected,
        /// <summary>
        /// 
        /// </summary>
        ActorRunSucceeded,
        /// <summary>
        /// 
        /// </summary>
        ActorRunTimedOut,
        /// <summary>
        /// 
        /// </summary>
        Test,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEventType value)
        {
            return value switch
            {
                WebhookEventType.ActorBuildAborted => "ACTOR.BUILD.ABORTED",
                WebhookEventType.ActorBuildCreated => "ACTOR.BUILD.CREATED",
                WebhookEventType.ActorBuildFailed => "ACTOR.BUILD.FAILED",
                WebhookEventType.ActorBuildSucceeded => "ACTOR.BUILD.SUCCEEDED",
                WebhookEventType.ActorBuildTimedOut => "ACTOR.BUILD.TIMED_OUT",
                WebhookEventType.ActorRunAborted => "ACTOR.RUN.ABORTED",
                WebhookEventType.ActorRunCreated => "ACTOR.RUN.CREATED",
                WebhookEventType.ActorRunFailed => "ACTOR.RUN.FAILED",
                WebhookEventType.ActorRunResurrected => "ACTOR.RUN.RESURRECTED",
                WebhookEventType.ActorRunSucceeded => "ACTOR.RUN.SUCCEEDED",
                WebhookEventType.ActorRunTimedOut => "ACTOR.RUN.TIMED_OUT",
                WebhookEventType.Test => "TEST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEventType? ToEnum(string value)
        {
            return value switch
            {
                "ACTOR.BUILD.ABORTED" => WebhookEventType.ActorBuildAborted,
                "ACTOR.BUILD.CREATED" => WebhookEventType.ActorBuildCreated,
                "ACTOR.BUILD.FAILED" => WebhookEventType.ActorBuildFailed,
                "ACTOR.BUILD.SUCCEEDED" => WebhookEventType.ActorBuildSucceeded,
                "ACTOR.BUILD.TIMED_OUT" => WebhookEventType.ActorBuildTimedOut,
                "ACTOR.RUN.ABORTED" => WebhookEventType.ActorRunAborted,
                "ACTOR.RUN.CREATED" => WebhookEventType.ActorRunCreated,
                "ACTOR.RUN.FAILED" => WebhookEventType.ActorRunFailed,
                "ACTOR.RUN.RESURRECTED" => WebhookEventType.ActorRunResurrected,
                "ACTOR.RUN.SUCCEEDED" => WebhookEventType.ActorRunSucceeded,
                "ACTOR.RUN.TIMED_OUT" => WebhookEventType.ActorRunTimedOut,
                "TEST" => WebhookEventType.Test,
                _ => null,
            };
        }
    }
}