
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum ScheduleCreateActionDiscriminatorType
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
    public static class ScheduleCreateActionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduleCreateActionDiscriminatorType value)
        {
            return value switch
            {
                ScheduleCreateActionDiscriminatorType.RunActor => "RUN_ACTOR",
                ScheduleCreateActionDiscriminatorType.RunActorTask => "RUN_ACTOR_TASK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduleCreateActionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "RUN_ACTOR" => ScheduleCreateActionDiscriminatorType.RunActor,
                "RUN_ACTOR_TASK" => ScheduleCreateActionDiscriminatorType.RunActorTask,
                _ => null,
            };
        }
    }
}