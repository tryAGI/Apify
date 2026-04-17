#nullable enable

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public sealed class ActorRunKeyValueStoreRecordPutContentEncodingNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ActorRunKeyValueStoreRecordPutContentEncoding?>
    {
        /// <inheritdoc />
        public override global::Apify.ActorRunKeyValueStoreRecordPutContentEncoding? Read(
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
                        return global::Apify.ActorRunKeyValueStoreRecordPutContentEncodingExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Apify.ActorRunKeyValueStoreRecordPutContentEncoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Apify.ActorRunKeyValueStoreRecordPutContentEncoding?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ActorRunKeyValueStoreRecordPutContentEncoding? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Apify.ActorRunKeyValueStoreRecordPutContentEncodingExtensions.ToValueString(value.Value));
            }
        }
    }
}
