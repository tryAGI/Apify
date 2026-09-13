
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GeneralAccess), TypeInfoPropertyName = "GeneralAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateRequestQueueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.HttpMethod), TypeInfoPropertyName = "HttpMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestUserData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestWithoutId), TypeInfoPropertyName = "RequestWithoutId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AddedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestDraft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BatchAddResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.AddedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BatchAddResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestDraftDeleteById))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestDraftDeleteByUniqueKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestDraftDelete), TypeInfoPropertyName = "RequestDraftDelete2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DeletedRequestById))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DeletedRequestByUniqueKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DeletedRequest), TypeInfoPropertyName = "DeletedRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BatchDeleteResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.DeletedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BatchDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.StorageOwnership), TypeInfoPropertyName = "StorageOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueShort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequestQueues), TypeInfoPropertyName = "ListOfRequestQueues2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequestQueuesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestQueueShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequestQueuesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AllOf<global::Apify.UpdateRequestQueueRequest, object>), TypeInfoPropertyName = "AllOfUpdateRequestQueueRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestWithoutId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestDraftDelete>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorType?), TypeInfoPropertyName = "NullableErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GeneralAccess?), TypeInfoPropertyName = "NullableGeneralAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.HttpMethod?), TypeInfoPropertyName = "NullableHttpMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestWithoutId?), TypeInfoPropertyName = "NullableRequestWithoutId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestDraftDelete?), TypeInfoPropertyName = "NullableRequestDraftDelete2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DeletedRequest?), TypeInfoPropertyName = "NullableDeletedRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.StorageOwnership?), TypeInfoPropertyName = "NullableStorageOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequestQueues?), TypeInfoPropertyName = "NullableListOfRequestQueues2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AllOf<global::Apify.UpdateRequestQueueRequest, object>?), TypeInfoPropertyName = "NullableAllOfUpdateRequestQueueRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.AddedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.DeletedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestQueueShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestWithoutId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestDraftDelete>))]
    internal sealed partial class StorageRequestQueuesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StorageRequestQueuesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static StorageRequestQueuesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private StorageRequestQueuesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Apify.JsonConverters.RequestWithoutIdJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.RequestDraftDeleteJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.DeletedRequestJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.ListOfRequestQueuesJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.OneOfJsonConverter<string, long?>());
            options.Converters.Add(new global::Apify.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.UpdateRequestQueueRequest, object>());
            options.Converters.Add(new global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.UpdateRequestQueueRequest, object>());
            options.Converters.Add(new global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.UpdateRequestQueueRequest, object>());
            options.Converters.Add(new global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.UpdateRequestQueueRequest, object>());
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

                    || typeToConvert == typeof(global::Apify.GeneralAccess)

                    || typeToConvert == typeof(global::Apify.GeneralAccess?)

                    || typeToConvert == typeof(global::Apify.HttpMethod)

                    || typeToConvert == typeof(global::Apify.HttpMethod?)

                    || typeToConvert == typeof(global::Apify.StorageOwnership)

                    || typeToConvert == typeof(global::Apify.StorageOwnership?);
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

                if (typeToConvert == typeof(global::Apify.GeneralAccess))
                {
                    return new global::Apify.JsonConverters.GeneralAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.GeneralAccess?))
                {
                    return new global::Apify.JsonConverters.GeneralAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.HttpMethod))
                {
                    return new global::Apify.JsonConverters.HttpMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.HttpMethod?))
                {
                    return new global::Apify.JsonConverters.HttpMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.StorageOwnership))
                {
                    return new global::Apify.JsonConverters.StorageOwnershipJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.StorageOwnership?))
                {
                    return new global::Apify.JsonConverters.StorageOwnershipNullableJsonConverter();
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
                    0 => new StorageRequestQueuesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}