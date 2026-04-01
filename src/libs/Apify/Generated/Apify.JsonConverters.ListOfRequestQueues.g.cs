#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public class ListOfRequestQueuesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ListOfRequestQueues>
    {
        /// <inheritdoc />
        public override global::Apify.ListOfRequestQueues Read(
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
            if (__jsonProps.Contains("count")) __score0++;
            if (__jsonProps.Contains("desc")) __score0++;
            if (__jsonProps.Contains("limit")) __score0++;
            if (__jsonProps.Contains("offset")) __score0++;
            if (__jsonProps.Contains("total")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("items")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Apify.PaginationResponse? paginationResponse = default;
            global::Apify.ListOfRequestQueuesVariant2? value2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.PaginationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.PaginationResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.PaginationResponse).Name}");
                        paginationResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ListOfRequestQueuesVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ListOfRequestQueuesVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ListOfRequestQueuesVariant2).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (paginationResponse == null && value2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.PaginationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.PaginationResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.PaginationResponse).Name}");
                    paginationResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ListOfRequestQueuesVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ListOfRequestQueuesVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ListOfRequestQueuesVariant2).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Apify.ListOfRequestQueues(
                paginationResponse,

                value2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ListOfRequestQueues value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPaginationResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.PaginationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.PaginationResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.PaginationResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PaginationResponse!, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ListOfRequestQueuesVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ListOfRequestQueuesVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ListOfRequestQueuesVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!, typeInfo);
            }
        }
    }
}