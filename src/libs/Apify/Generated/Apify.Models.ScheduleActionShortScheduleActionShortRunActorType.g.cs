
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduleActionShortScheduleActionShortRunActorType
    {
        /// <summary>
        /// 
        /// </summary>
        RunActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduleActionShortScheduleActionShortRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduleActionShortScheduleActionShortRunActorType value)
        {
            return value switch
            {
                ScheduleActionShortScheduleActionShortRunActorType.RunActor => "RUN_ACTOR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduleActionShortScheduleActionShortRunActorType? ToEnum(string value)
        {
            return value switch
            {
                "RUN_ACTOR" => ScheduleActionShortScheduleActionShortRunActorType.RunActor,
                _ => null,
            };
        }
    }
}