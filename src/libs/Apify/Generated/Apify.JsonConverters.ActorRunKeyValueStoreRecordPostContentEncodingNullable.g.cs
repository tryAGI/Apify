#nullable enable

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public sealed class ActorRunKeyValueStoreRecordPostContentEncodingNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ActorRunKeyValueStoreRecordPostContentEncoding?>
    {
        /// <inheritdoc />
        public override global::Apify.ActorRunKeyValueStoreRecordPostContentEncoding? Read(
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
                        return global::Apify.ActorRunKeyValueStoreRecordPostContentEncodingExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Apify.ActorRunKeyValueStoreRecordPostContentEncoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Apify.ActorRunKeyValueStoreRecordPostContentEncoding?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ActorRunKeyValueStoreRecordPostContentEncoding? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Apify.ActorRunKeyValueStoreRecordPostContentEncodingExtensions.ToValueString(value.Value));
            }
        }
    }
}
