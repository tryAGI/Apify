#nullable enable

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public sealed class ActRunsLastKeyValueStoreRecordPutContentEncodingNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ActRunsLastKeyValueStoreRecordPutContentEncoding?>
    {
        /// <inheritdoc />
        public override global::Apify.ActRunsLastKeyValueStoreRecordPutContentEncoding? Read(
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
                        return global::Apify.ActRunsLastKeyValueStoreRecordPutContentEncodingExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Apify.ActRunsLastKeyValueStoreRecordPutContentEncoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Apify.ActRunsLastKeyValueStoreRecordPutContentEncoding?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ActRunsLastKeyValueStoreRecordPutContentEncoding? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Apify.ActRunsLastKeyValueStoreRecordPutContentEncodingExtensions.ToValueString(value.Value));
            }
        }
    }
}
