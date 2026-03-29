#nullable enable

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public sealed class ScheduleCreateActionScheduleCreateActionRunActorTaskTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTaskType?>
    {
        /// <inheritdoc />
        public override global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTaskType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTaskTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTaskType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTaskType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTaskType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTaskTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
