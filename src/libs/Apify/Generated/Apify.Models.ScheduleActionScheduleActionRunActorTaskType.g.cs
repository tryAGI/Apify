
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduleActionScheduleActionRunActorTaskType
    {
        /// <summary>
        /// 
        /// </summary>
        RunActorTask,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduleActionScheduleActionRunActorTaskTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduleActionScheduleActionRunActorTaskType value)
        {
            return value switch
            {
                ScheduleActionScheduleActionRunActorTaskType.RunActorTask => "RUN_ACTOR_TASK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduleActionScheduleActionRunActorTaskType? ToEnum(string value)
        {
            return value switch
            {
                "RUN_ACTOR_TASK" => ScheduleActionScheduleActionRunActorTaskType.RunActorTask,
                _ => null,
            };
        }
    }
}