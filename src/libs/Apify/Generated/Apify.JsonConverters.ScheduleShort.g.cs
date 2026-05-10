#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public class ScheduleShortJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ScheduleShort>
    {
        /// <inheritdoc />
        public override global::Apify.ScheduleShort Read(
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
            if (__jsonProps.Contains("createdAt")) __score0++;
            if (__jsonProps.Contains("cronExpression")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("isEnabled")) __score0++;
            if (__jsonProps.Contains("isExclusive")) __score0++;
            if (__jsonProps.Contains("lastRunAt")) __score0++;
            if (__jsonProps.Contains("modifiedAt")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("nextRunAt")) __score0++;
            if (__jsonProps.Contains("timezone")) __score0++;
            if (__jsonProps.Contains("userId")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("actions")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Apify.ScheduleBase? scheduleBase = default;
            global::Apify.ScheduleShortVariant2? scheduleShortVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleBase).Name}");
                        scheduleBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleShortVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleShortVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleShortVariant2).Name}");
                        scheduleShortVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (scheduleBase == null && scheduleShortVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleBase).Name}");
                    scheduleBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (scheduleBase == null && scheduleShortVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleShortVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleShortVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleShortVariant2).Name}");
                    scheduleShortVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Apify.ScheduleShort(
                scheduleBase,

                scheduleShortVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ScheduleShort value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsScheduleBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScheduleBase!, typeInfo);
            }
            else if (value.IsScheduleShortVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleShortVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleShortVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleShortVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScheduleShortVariant2!, typeInfo);
            }
        }
    }
}