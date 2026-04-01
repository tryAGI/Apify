#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public class ActorRunPricingInfoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.ActorRunPricingInfo>
    {
        /// <inheritdoc />
        public override global::Apify.ActorRunPricingInfo Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.ActorRunPricingInfoDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.ActorRunPricingInfoDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.ActorRunPricingInfoDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Apify.PayPerEventActorPricingInfo? payPerEvent = default;
            if (discriminator?.PricingModel == global::Apify.ActorRunPricingInfoDiscriminatorPricingModel.PayPerEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.PayPerEventActorPricingInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.PayPerEventActorPricingInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.PayPerEventActorPricingInfo)}");
                payPerEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Apify.PricePerDatasetItemActorPricingInfo? pricePerDatasetItem = default;
            if (discriminator?.PricingModel == global::Apify.ActorRunPricingInfoDiscriminatorPricingModel.PricePerDatasetItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.PricePerDatasetItemActorPricingInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.PricePerDatasetItemActorPricingInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.PricePerDatasetItemActorPricingInfo)}");
                pricePerDatasetItem = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Apify.FlatPricePerMonthActorPricingInfo? flatPricePerMonth = default;
            if (discriminator?.PricingModel == global::Apify.ActorRunPricingInfoDiscriminatorPricingModel.FlatPricePerMonth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.FlatPricePerMonthActorPricingInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.FlatPricePerMonthActorPricingInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.FlatPricePerMonthActorPricingInfo)}");
                flatPricePerMonth = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Apify.FreeActorPricingInfo? free = default;
            if (discriminator?.PricingModel == global::Apify.ActorRunPricingInfoDiscriminatorPricingModel.Free)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.FreeActorPricingInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.FreeActorPricingInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Apify.FreeActorPricingInfo)}");
                free = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Apify.ActorRunPricingInfo(
                discriminator?.PricingModel,
                payPerEvent,

                pricePerDatasetItem,

                flatPricePerMonth,

                free
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.ActorRunPricingInfo value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPayPerEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.PayPerEventActorPricingInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.PayPerEventActorPricingInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.PayPerEventActorPricingInfo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PayPerEvent!.Value, typeInfo);
            }
            else if (value.IsPricePerDatasetItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.PricePerDatasetItemActorPricingInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.PricePerDatasetItemActorPricingInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.PricePerDatasetItemActorPricingInfo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PricePerDatasetItem!.Value, typeInfo);
            }
            else if (value.IsFlatPricePerMonth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.FlatPricePerMonthActorPricingInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.FlatPricePerMonthActorPricingInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.FlatPricePerMonthActorPricingInfo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FlatPricePerMonth!.Value, typeInfo);
            }
            else if (value.IsFree)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.FreeActorPricingInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.FreeActorPricingInfo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.FreeActorPricingInfo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Free!.Value, typeInfo);
            }
        }
    }
}