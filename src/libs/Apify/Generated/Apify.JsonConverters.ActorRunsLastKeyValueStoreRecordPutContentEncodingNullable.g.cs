#nullable enable

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public sealed class ActorRunsLastKeyValueStoreRecordPutContentEncodingNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ActorRunsLastKeyValueStoreRecordPutContentEncoding?>
    {
        /// <inheritdoc />
        public override global::Apify.ActorRunsLastKeyValueStoreRecordPutContentEncoding? Read(
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
                        return global::Apify.ActorRunsLastKeyValueStoreRecordPutContentEncodingExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Apify.ActorRunsLastKeyValueStoreRecordPutContentEncoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Apify.ActorRunsLastKeyValueStoreRecordPutContentEncoding?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ActorRunsLastKeyValueStoreRecordPutContentEncoding? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Apify.ActorRunsLastKeyValueStoreRecordPutContentEncodingExtensions.ToValueString(value.Value));
            }
        }
    }
}
