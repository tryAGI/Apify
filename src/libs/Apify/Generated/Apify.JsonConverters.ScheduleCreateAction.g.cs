#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public class ScheduleCreateActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ScheduleCreateAction>
    {
        /// <inheritdoc />
        public override global::Apify.ScheduleCreateAction Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleCreateActionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleCreateActionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.ScheduleCreateActionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Apify.ScheduleCreateActionRunActor? runActor = default;
            if (discriminator?.Type == global::Apify.ScheduleCreateActionDiscriminatorType.RunActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleCreateActionRunActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleCreateActionRunActor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.ScheduleCreateActionRunActor)}");
                runActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Apify.ScheduleCreateActionRunActorTask? runActorTask = default;
            if (discriminator?.Type == global::Apify.ScheduleCreateActionDiscriminatorType.RunActorTask)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleCreateActionRunActorTask), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleCreateActionRunActorTask> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.ScheduleCreateActionRunActorTask)}");
                runActorTask = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Apify.ScheduleCreateAction(
                discriminator?.Type,
                runActor,

                runActorTask
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ScheduleCreateAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleCreateActionRunActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleCreateActionRunActor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleCreateActionRunActor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunActor!, typeInfo);
            }
            else if (value.IsRunActorTask)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleCreateActionRunActorTask), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleCreateActionRunActorTask?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleCreateActionRunActorTask).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunActorTask!, typeInfo);
            }
        }
    }
}