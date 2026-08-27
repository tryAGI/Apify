
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum ScheduleActionDiscriminatorType
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
    public static class ScheduleActionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduleActionDiscriminatorType value)
        {
            return value switch
            {
                ScheduleActionDiscriminatorType.RunActor => "RUN_ACTOR",
                ScheduleActionDiscriminatorType.RunActorTask => "RUN_ACTOR_TASK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduleActionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "RUN_ACTOR" => ScheduleActionDiscriminatorType.RunActor,
                "RUN_ACTOR_TASK" => ScheduleActionDiscriminatorType.RunActorTask,
                _ => null,
            };
        }
    }
}