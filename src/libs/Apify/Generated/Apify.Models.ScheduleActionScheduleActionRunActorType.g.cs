
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduleActionScheduleActionRunActorType
    {
        /// <summary>
        /// 
        /// </summary>
        RunActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduleActionScheduleActionRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduleActionScheduleActionRunActorType value)
        {
            return value switch
            {
                ScheduleActionScheduleActionRunActorType.RunActor => "RUN_ACTOR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduleActionScheduleActionRunActorType? ToEnum(string value)
        {
            return value switch
            {
                "RUN_ACTOR" => ScheduleActionScheduleActionRunActorType.RunActor,
                _ => null,
            };
        }
    }
}