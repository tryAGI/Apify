#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public class ListOfStoreActorsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ListOfStoreActors>
    {
        /// <inheritdoc />
        public override global::Apify.ListOfStoreActors Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Apify.PaginationResponse? paginationResponse = default;
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

            global::Apify.ListOfStoreActorsVariant2? listOfStoreActorsVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ListOfStoreActorsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ListOfStoreActorsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ListOfStoreActorsVariant2).Name}");
                listOfStoreActorsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Apify.ListOfStoreActors(
                paginationResponse,

                listOfStoreActorsVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ListOfStoreActors value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsPaginationResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.PaginationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.PaginationResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.PaginationResponse).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PaginationResponse!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsListOfStoreActorsVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ListOfStoreActorsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ListOfStoreActorsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ListOfStoreActorsVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.ListOfStoreActorsVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}