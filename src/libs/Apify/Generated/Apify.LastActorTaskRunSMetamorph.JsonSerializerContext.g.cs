
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorType), TypeInfoPropertyName = "ErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CommonActorPricingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TieredPricingPerEventEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Apify.TieredPricingPerEventEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorChargeEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PayPerEventActorPricingInfo), TypeInfoPropertyName = "PayPerEventActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PayPerEventActorPricingInfoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PayPerEventActorPricingInfoVariant2PricingPerEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Apify.ActorChargeEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TieredPricingPerDatasetItemEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Apify.TieredPricingPerDatasetItemEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PricePerDatasetItemActorPricingInfo), TypeInfoPropertyName = "PricePerDatasetItemActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PricePerDatasetItemActorPricingInfoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FlatPricePerMonthActorPricingInfo), TypeInfoPropertyName = "FlatPricePerMonthActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FlatPricePerMonthActorPricingInfoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FreeActorPricingInfo), TypeInfoPropertyName = "FreeActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FreeActorPricingInfoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunPricingInfo), TypeInfoPropertyName = "ActorRunPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunPricingInfoDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunPricingInfoDiscriminatorPricingModel), TypeInfoPropertyName = "ActorRunPricingInfoDiscriminatorPricingModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorJobStatus), TypeInfoPropertyName = "ActorJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunOrigin), TypeInfoPropertyName = "RunOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GeneralAccess), TypeInfoPropertyName = "GeneralAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunUsageUsd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Metamorph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Run))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStorageIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStorageIdsDatasets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStorageIdsKeyValueStores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStorageIdsRequestQueues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.Metamorph>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorType?), TypeInfoPropertyName = "NullableErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PayPerEventActorPricingInfo?), TypeInfoPropertyName = "NullablePayPerEventActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PricePerDatasetItemActorPricingInfo?), TypeInfoPropertyName = "NullablePricePerDatasetItemActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FlatPricePerMonthActorPricingInfo?), TypeInfoPropertyName = "NullableFlatPricePerMonthActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FreeActorPricingInfo?), TypeInfoPropertyName = "NullableFreeActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunPricingInfo?), TypeInfoPropertyName = "NullableActorRunPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunPricingInfoDiscriminatorPricingModel?), TypeInfoPropertyName = "NullableActorRunPricingInfoDiscriminatorPricingModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorJobStatus?), TypeInfoPropertyName = "NullableActorJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunOrigin?), TypeInfoPropertyName = "NullableRunOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GeneralAccess?), TypeInfoPropertyName = "NullableGeneralAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.Metamorph>))]
    internal sealed partial class LastActorTaskRunSMetamorphSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LastActorTaskRunSMetamorphSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static LastActorTaskRunSMetamorphSourceGenerationContext Default { get; } = new(DefaultOptions);

        private LastActorTaskRunSMetamorphSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Apify.JsonConverters.PayPerEventActorPricingInfoJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.PricePerDatasetItemActorPricingInfoJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.FlatPricePerMonthActorPricingInfoJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.FreeActorPricingInfoJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.ActorRunPricingInfoJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.OneOfJsonConverter<string, long?>());
            options.Converters.Add(new global::Apify.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Apify.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Apify.ErrorType)

                    || typeToConvert == typeof(global::Apify.ErrorType?)

                    || typeToConvert == typeof(global::Apify.ActorRunPricingInfoDiscriminatorPricingModel)

                    || typeToConvert == typeof(global::Apify.ActorRunPricingInfoDiscriminatorPricingModel?)

                    || typeToConvert == typeof(global::Apify.ActorJobStatus)

                    || typeToConvert == typeof(global::Apify.ActorJobStatus?)

                    || typeToConvert == typeof(global::Apify.RunOrigin)

                    || typeToConvert == typeof(global::Apify.RunOrigin?)

                    || typeToConvert == typeof(global::Apify.GeneralAccess)

                    || typeToConvert == typeof(global::Apify.GeneralAccess?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Apify.ErrorType))
                {
                    return new global::Apify.JsonConverters.ErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.ErrorType?))
                {
                    return new global::Apify.JsonConverters.ErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.ActorRunPricingInfoDiscriminatorPricingModel))
                {
                    return new global::Apify.JsonConverters.ActorRunPricingInfoDiscriminatorPricingModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.ActorRunPricingInfoDiscriminatorPricingModel?))
                {
                    return new global::Apify.JsonConverters.ActorRunPricingInfoDiscriminatorPricingModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.ActorJobStatus))
                {
                    return new global::Apify.JsonConverters.ActorJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.ActorJobStatus?))
                {
                    return new global::Apify.JsonConverters.ActorJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.RunOrigin))
                {
                    return new global::Apify.JsonConverters.RunOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.RunOrigin?))
                {
                    return new global::Apify.JsonConverters.RunOriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.GeneralAccess))
                {
                    return new global::Apify.JsonConverters.GeneralAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.GeneralAccess?))
                {
                    return new global::Apify.JsonConverters.GeneralAccessNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new LastActorTaskRunSMetamorphSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}