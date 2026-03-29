#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public class ScheduleActionShortJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ScheduleActionShort>
    {
        /// <inheritdoc />
        public override global::Apify.ScheduleActionShort Read(
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
            if (__jsonProps.Contains("actorId")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("actorTaskId")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Apify.ScheduleActionShortScheduleActionShortRunActor? runActor = default;
            global::Apify.ScheduleActionShortScheduleActionShortRunActorTask? runActorTask = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionShortScheduleActionShortRunActor> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActor).Name}");
                        runActor = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActorTask), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionShortScheduleActionShortRunActorTask> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActorTask).Name}");
                        runActorTask = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (runActor == null && runActorTask == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionShortScheduleActionShortRunActor> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActor).Name}");
                    runActor = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActorTask), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionShortScheduleActionShortRunActorTask> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActorTask).Name}");
                    runActorTask = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Apify.ScheduleActionShort(
                runActor,

                runActorTask
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ScheduleActionShort value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionShortScheduleActionShortRunActor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunActor, typeInfo);
            }
            else if (value.IsRunActorTask)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActorTask), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionShortScheduleActionShortRunActorTask?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleActionShortScheduleActionShortRunActorTask).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunActorTask, typeInfo);
            }
        }
    }
}