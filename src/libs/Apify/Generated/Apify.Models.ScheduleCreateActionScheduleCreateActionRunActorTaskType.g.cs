
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduleCreateActionScheduleCreateActionRunActorTaskType
    {
        /// <summary>
        /// 
        /// </summary>
        RunActorTask,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduleCreateActionScheduleCreateActionRunActorTaskTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduleCreateActionScheduleCreateActionRunActorTaskType value)
        {
            return value switch
            {
                ScheduleCreateActionScheduleCreateActionRunActorTaskType.RunActorTask => "RUN_ACTOR_TASK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduleCreateActionScheduleCreateActionRunActorTaskType? ToEnum(string value)
        {
            return value switch
            {
                "RUN_ACTOR_TASK" => ScheduleCreateActionScheduleCreateActionRunActorTaskType.RunActorTask,
                _ => null,
            };
        }
    }
}