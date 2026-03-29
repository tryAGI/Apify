
#nullable enable

namespace Apify
{
    /// <summary>
    /// Status of an Actor job (run or build).
    /// </summary>
    public enum ActorJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Aborted,
        /// <summary>
        /// 
        /// </summary>
        Aborting,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        TimingOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorJobStatus value)
        {
            return value switch
            {
                ActorJobStatus.Aborted => "ABORTED",
                ActorJobStatus.Aborting => "ABORTING",
                ActorJobStatus.Failed => "FAILED",
                ActorJobStatus.Ready => "READY",
                ActorJobStatus.Running => "RUNNING",
                ActorJobStatus.Succeeded => "SUCCEEDED",
                ActorJobStatus.TimedOut => "TIMED-OUT",
                ActorJobStatus.TimingOut => "TIMING-OUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "ABORTED" => ActorJobStatus.Aborted,
                "ABORTING" => ActorJobStatus.Aborting,
                "FAILED" => ActorJobStatus.Failed,
                "READY" => ActorJobStatus.Ready,
                "RUNNING" => ActorJobStatus.Running,
                "SUCCEEDED" => ActorJobStatus.Succeeded,
                "TIMED-OUT" => ActorJobStatus.TimedOut,
                "TIMING-OUT" => ActorJobStatus.TimingOut,
                _ => null,
            };
        }
    }
}