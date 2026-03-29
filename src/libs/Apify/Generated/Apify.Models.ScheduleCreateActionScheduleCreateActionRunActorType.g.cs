
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduleCreateActionScheduleCreateActionRunActorType
    {
        /// <summary>
        /// 
        /// </summary>
        RunActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduleCreateActionScheduleCreateActionRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduleCreateActionScheduleCreateActionRunActorType value)
        {
            return value switch
            {
                ScheduleCreateActionScheduleCreateActionRunActorType.RunActor => "RUN_ACTOR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduleCreateActionScheduleCreateActionRunActorType? ToEnum(string value)
        {
            return value switch
            {
                "RUN_ACTOR" => ScheduleCreateActionScheduleCreateActionRunActorType.RunActor,
                _ => null,
            };
        }
    }
}