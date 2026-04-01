#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify.JsonConverters
{
    /// <inheritdoc />
    public class FlatPricePerMonthActorPricingInfoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Apify.FlatPricePerMonthActorPricingInfo>
    {
        /// <inheritdoc />
        public override global::Apify.FlatPricePerMonthActorPricingInfo Read(
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
            if (__jsonProps.Contains("apifyMarginPercentage")) __score0++;
            if (__jsonProps.Contains("createdAt")) __score0++;
            if (__jsonProps.Contains("notifiedAboutChangeAt")) __score0++;
            if (__jsonProps.Contains("notifiedAboutFutureChangeAt")) __score0++;
            if (__jsonProps.Contains("reasonForChange")) __score0++;
            if (__jsonProps.Contains("startedAt")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("pricePerUnitUsd")) __score1++;
            if (__jsonProps.Contains("pricingModel")) __score1++;
            if (__jsonProps.Contains("trialMinutes")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Apify.CommonActorPricingInfo? commonActorPricingInfo = default;
            global::Apify.FlatPricePerMonthActorPricingInfoVariant2? value2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.CommonActorPricingInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.CommonActorPricingInfo> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.CommonActorPricingInfo).Name}");
                        commonActorPricingInfo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.FlatPricePerMonthActorPricingInfoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.FlatPricePerMonthActorPricingInfoVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.FlatPricePerMonthActorPricingInfoVariant2).Name}");
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

            if (commonActorPricingInfo == null && value2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.CommonActorPricingInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.CommonActorPricingInfo> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.CommonActorPricingInfo).Name}");
                    commonActorPricingInfo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.FlatPricePerMonthActorPricingInfoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.FlatPricePerMonthActorPricingInfoVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.FlatPricePerMonthActorPricingInfoVariant2).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Apify.FlatPricePerMonthActorPricingInfo(
                commonActorPricingInfo,

                value2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Apify.FlatPricePerMonthActorPricingInfo value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCommonActorPricingInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.CommonActorPricingInfo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.CommonActorPricingInfo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.CommonActorPricingInfo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommonActorPricingInfo!, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Apify.FlatPricePerMonthActorPricingInfoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Apify.FlatPricePerMonthActorPricingInfoVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Apify.FlatPricePerMonthActorPricingInfoVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!, typeInfo);
            }
        }
    }
}