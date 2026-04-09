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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionShortDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionShortDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.ScheduleActionShortDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Apify.ScheduleActionShortRunActor? runActor = default;
            if (discriminator?.Type == global::Apify.ScheduleActionShortDiscriminatorType.RunActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionShortRunActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionShortRunActor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.ScheduleActionShortRunActor)}");
                runActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Apify.ScheduleActionShortRunActorTask? runActorTask = default;
            if (discriminator?.Type == global::Apify.ScheduleActionShortDiscriminatorType.RunActorTask)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionShortRunActorTask), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionShortRunActorTask> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.ScheduleActionShortRunActorTask)}");
                runActorTask = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Apify.ScheduleActionShort(
                discriminator?.Type,
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionShortRunActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionShortRunActor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleActionShortRunActor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunActor!, typeInfo);
            }
            else if (value.IsRunActorTask)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionShortRunActorTask), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionShortRunActorTask?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleActionShortRunActorTask).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunActorTask!, typeInfo);
            }
        }
    }
}