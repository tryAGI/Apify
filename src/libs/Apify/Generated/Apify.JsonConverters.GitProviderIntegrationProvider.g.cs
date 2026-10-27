#nullable enable

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public sealed class GitProviderIntegrationProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.GitProviderIntegrationProvider>
    {
        /// <inheritdoc />
        public override global::Apify.GitProviderIntegrationProvider Read(
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
                        return global::Apify.GitProviderIntegrationProviderExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Apify.GitProviderIntegrationProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Apify.GitProviderIntegrationProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.GitProviderIntegrationProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Apify.GitProviderIntegrationProviderExtensions.ToValueString(value));
        }
    }
}
