#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public class ScheduleActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ScheduleAction>
    {
        /// <inheritdoc />
        public override global::Apify.ScheduleAction Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.ScheduleActionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Apify.ScheduleActionRunActor? runActor = default;
            if (discriminator?.Type == global::Apify.ScheduleActionDiscriminatorType.RunActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionRunActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionRunActor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.ScheduleActionRunActor)}");
                runActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Apify.ScheduleActionRunActorTask? runActorTask = default;
            if (discriminator?.Type == global::Apify.ScheduleActionDiscriminatorType.RunActorTask)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionRunActorTask), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionRunActorTask> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.ScheduleActionRunActorTask)}");
                runActorTask = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Apify.ScheduleAction(
                discriminator?.Type,
                runActor,

                runActorTask
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ScheduleAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionRunActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionRunActor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleActionRunActor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunActor!, typeInfo);
            }
            else if (value.IsRunActorTask)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleActionRunActorTask), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleActionRunActorTask?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleActionRunActorTask).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunActorTask!, typeInfo);
            }
        }
    }
}