#nullable enable

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public sealed class ActorRunsLastKeyValueStoreRecordPostContentEncodingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ActorRunsLastKeyValueStoreRecordPostContentEncoding>
    {
        /// <inheritdoc />
        public override global::Apify.ActorRunsLastKeyValueStoreRecordPostContentEncoding Read(
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
                        return global::Apify.ActorRunsLastKeyValueStoreRecordPostContentEncodingExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Apify.ActorRunsLastKeyValueStoreRecordPostContentEncoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Apify.ActorRunsLastKeyValueStoreRecordPostContentEncoding);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ActorRunsLastKeyValueStoreRecordPostContentEncoding value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Apify.ActorRunsLastKeyValueStoreRecordPostContentEncodingExtensions.ToValueString(value));
        }
    }
}
