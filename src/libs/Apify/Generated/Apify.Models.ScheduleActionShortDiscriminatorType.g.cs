
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum ScheduleActionShortDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        RunActor,
        /// <summary>
        ///
        /// </summary>
        RunActorTask,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduleActionShortDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduleActionShortDiscriminatorType value)
        {
            return value switch
            {
                ScheduleActionShortDiscriminatorType.RunActor => "RUN_ACTOR",
                ScheduleActionShortDiscriminatorType.RunActorTask => "RUN_ACTOR_TASK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduleActionShortDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "RUN_ACTOR" => ScheduleActionShortDiscriminatorType.RunActor,
                "RUN_ACTOR_TASK" => ScheduleActionShortDiscriminatorType.RunActorTask,
                _ => null,
            };
        }
    }
}