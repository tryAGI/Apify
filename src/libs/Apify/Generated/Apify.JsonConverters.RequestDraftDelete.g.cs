#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public class RequestDraftDeleteJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.RequestDraftDelete>
    {
        /// <inheritdoc />
        public override global::Apify.RequestDraftDelete Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("uniqueKey")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("uniqueKey")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Apify.RequestDraftDeleteById? requestDraftDeleteById = default;
            global::Apify.RequestDraftDeleteByUniqueKey? requestDraftDeleteByUniqueKey = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.RequestDraftDeleteById), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.RequestDraftDeleteById> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.RequestDraftDeleteById).Name}");
                        requestDraftDeleteById = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.RequestDraftDeleteByUniqueKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.RequestDraftDeleteByUniqueKey> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.RequestDraftDeleteByUniqueKey).Name}");
                        requestDraftDeleteByUniqueKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (requestDraftDeleteById == null && requestDraftDeleteByUniqueKey == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.RequestDraftDeleteById), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.RequestDraftDeleteById> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.RequestDraftDeleteById).Name}");
                    requestDraftDeleteById = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.RequestDraftDeleteByUniqueKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.RequestDraftDeleteByUniqueKey> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.RequestDraftDeleteByUniqueKey).Name}");
                    requestDraftDeleteByUniqueKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Apify.RequestDraftDelete(
                requestDraftDeleteById,

                requestDraftDeleteByUniqueKey
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.RequestDraftDelete value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRequestDraftDeleteById)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.RequestDraftDeleteById), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.RequestDraftDeleteById?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.RequestDraftDeleteById).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequestDraftDeleteById!, typeInfo);
            }
            else if (value.IsRequestDraftDeleteByUniqueKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.RequestDraftDeleteByUniqueKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.RequestDraftDeleteByUniqueKey?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.RequestDraftDeleteByUniqueKey).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequestDraftDeleteByUniqueKey!, typeInfo);
            }
        }
    }
}