#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public class ScheduleListItemActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ScheduleListItemAction>
    {
        /// <inheritdoc />
        public override global::Apify.ScheduleListItemAction Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleListItemActionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleListItemActionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.ScheduleListItemActionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Apify.ScheduleListItemActionRunActor? runActor = default;
            if (discriminator?.Type == global::Apify.ScheduleListItemActionDiscriminatorType.RunActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleListItemActionRunActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleListItemActionRunActor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.ScheduleListItemActionRunActor)}");
                runActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Apify.ScheduleListItemActionRunActorTask? runActorTask = default;
            if (discriminator?.Type == global::Apify.ScheduleListItemActionDiscriminatorType.RunActorTask)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleListItemActionRunActorTask), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleListItemActionRunActorTask> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.ScheduleListItemActionRunActorTask)}");
                runActorTask = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Apify.ScheduleListItemAction(
                discriminator?.Type,
                runActor,

                runActorTask
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ScheduleListItemAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleListItemActionRunActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleListItemActionRunActor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleListItemActionRunActor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRunActor(), typeInfo);
            }
            else if (value.IsRunActorTask)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ScheduleListItemActionRunActorTask), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ScheduleListItemActionRunActorTask?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.ScheduleListItemActionRunActorTask).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRunActorTask(), typeInfo);
            }
        }
    }
}