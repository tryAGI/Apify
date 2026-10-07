
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum ScheduleListItemActionDiscriminatorType
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
    public static class ScheduleListItemActionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduleListItemActionDiscriminatorType value)
        {
            return value switch
            {
                ScheduleListItemActionDiscriminatorType.RunActor => "RUN_ACTOR",
                ScheduleListItemActionDiscriminatorType.RunActorTask => "RUN_ACTOR_TASK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduleListItemActionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "RUN_ACTOR" => ScheduleListItemActionDiscriminatorType.RunActor,
                "RUN_ACTOR_TASK" => ScheduleListItemActionDiscriminatorType.RunActorTask,
                _ => null,
            };
        }
    }
}