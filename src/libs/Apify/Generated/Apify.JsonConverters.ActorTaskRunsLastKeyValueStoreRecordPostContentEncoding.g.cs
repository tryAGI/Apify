#nullable enable

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public sealed class ActorTaskRunsLastKeyValueStoreRecordPostContentEncodingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding>
    {
        /// <inheritdoc />
        public override global::Apify.ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding Read(
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
                        return global::Apify.ActorTaskRunsLastKeyValueStoreRecordPostContentEncodingExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Apify.ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Apify.ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Apify.ActorTaskRunsLastKeyValueStoreRecordPostContentEncodingExtensions.ToValueString(value));
        }
    }
}
