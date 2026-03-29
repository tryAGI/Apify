
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduleActionShortScheduleActionShortRunActorTaskType
    {
        /// <summary>
        /// 
        /// </summary>
        RunActorTask,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduleActionShortScheduleActionShortRunActorTaskTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduleActionShortScheduleActionShortRunActorTaskType value)
        {
            return value switch
            {
                ScheduleActionShortScheduleActionShortRunActorTaskType.RunActorTask => "RUN_ACTOR_TASK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduleActionShortScheduleActionShortRunActorTaskType? ToEnum(string value)
        {
            return value switch
            {
                "RUN_ACTOR_TASK" => ScheduleActionShortScheduleActionShortRunActorTaskType.RunActorTask,
                _ => null,
            };
        }
    }
}