
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PaginationResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaskOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionShortRunActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionShortRunActorTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionShort), TypeInfoPropertyName = "ScheduleActionShort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionShortDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionShortDiscriminatorType), TypeInfoPropertyName = "ScheduleActionShortDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleShort), TypeInfoPropertyName = "ScheduleShort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleShortVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleActionShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfSchedules), TypeInfoPropertyName = "ListOfSchedules2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfSchedulesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfSchedulesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionRunInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateActionRunActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateActionRunActorTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateAction), TypeInfoPropertyName = "ScheduleCreateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateActionDiscriminatorType), TypeInfoPropertyName = "ScheduleCreateActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionRunActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionRunActorTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleAction), TypeInfoPropertyName = "ScheduleAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionDiscriminatorType), TypeInfoPropertyName = "ScheduleActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Schedule), TypeInfoPropertyName = "Schedule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleVariant2Notifications))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleInvoked))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleLogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleInvoked>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorType?), TypeInfoPropertyName = "NullableErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionShort?), TypeInfoPropertyName = "NullableScheduleActionShort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionShortDiscriminatorType?), TypeInfoPropertyName = "NullableScheduleActionShortDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleShort?), TypeInfoPropertyName = "NullableScheduleShort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfSchedules?), TypeInfoPropertyName = "NullableListOfSchedules2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateAction?), TypeInfoPropertyName = "NullableScheduleCreateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateActionDiscriminatorType?), TypeInfoPropertyName = "NullableScheduleCreateActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleAction?), TypeInfoPropertyName = "NullableScheduleAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionDiscriminatorType?), TypeInfoPropertyName = "NullableScheduleActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Schedule?), TypeInfoPropertyName = "NullableSchedule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleActionShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleCreateAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleInvoked>))]
    internal sealed partial class SchedulesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SchedulesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SchedulesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SchedulesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Apify.JsonConverters.ScheduleActionShortJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.ScheduleShortJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.ListOfSchedulesJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.ScheduleCreateActionJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.ScheduleActionJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.ScheduleJsonConverter());
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

                    || typeToConvert == typeof(global::Apify.ScheduleActionShortDiscriminatorType)

                    || typeToConvert == typeof(global::Apify.ScheduleActionShortDiscriminatorType?)

                    || typeToConvert == typeof(global::Apify.ScheduleCreateActionDiscriminatorType)

                    || typeToConvert == typeof(global::Apify.ScheduleCreateActionDiscriminatorType?)

                    || typeToConvert == typeof(global::Apify.ScheduleActionDiscriminatorType)

                    || typeToConvert == typeof(global::Apify.ScheduleActionDiscriminatorType?);
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

                if (typeToConvert == typeof(global::Apify.ScheduleActionShortDiscriminatorType))
                {
                    return new global::Apify.JsonConverters.ScheduleActionShortDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.ScheduleActionShortDiscriminatorType?))
                {
                    return new global::Apify.JsonConverters.ScheduleActionShortDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.ScheduleCreateActionDiscriminatorType))
                {
                    return new global::Apify.JsonConverters.ScheduleCreateActionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.ScheduleCreateActionDiscriminatorType?))
                {
                    return new global::Apify.JsonConverters.ScheduleCreateActionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.ScheduleActionDiscriminatorType))
                {
                    return new global::Apify.JsonConverters.ScheduleActionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.ScheduleActionDiscriminatorType?))
                {
                    return new global::Apify.JsonConverters.ScheduleActionDiscriminatorTypeNullableJsonConverter();
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
                    0 => new SchedulesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}