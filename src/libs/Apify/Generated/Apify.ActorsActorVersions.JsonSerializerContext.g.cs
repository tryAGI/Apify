
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorType), TypeInfoPropertyName = "ErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.VersionSourceType), TypeInfoPropertyName = "VersionSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EnvVar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.SourceCodeFileFormat), TypeInfoPropertyName = "SourceCodeFileFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.SourceCodeFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.SourceCodeFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>), TypeInfoPropertyName = "AnyOfSourceCodeFileSourceCodeFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.EnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.Version>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CreateOrUpdateVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.VersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfEnvVars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfEnvVarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EnvVarRequest), TypeInfoPropertyName = "EnvVarRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EnvVarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorType?), TypeInfoPropertyName = "NullableErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.VersionSourceType?), TypeInfoPropertyName = "NullableVersionSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.SourceCodeFileFormat?), TypeInfoPropertyName = "NullableSourceCodeFileFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>?), TypeInfoPropertyName = "NullableAnyOfSourceCodeFileSourceCodeFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EnvVarRequest?), TypeInfoPropertyName = "NullableEnvVarRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.EnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.Version>))]
    internal sealed partial class ActorsActorVersionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActorsActorVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ActorsActorVersionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ActorsActorVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Apify.JsonConverters.EnvVarRequestJsonConverter());
            options.Converters.Add(new global::Apify.JsonConverters.AnyOfJsonConverter<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>());
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

                    || typeToConvert == typeof(global::Apify.VersionSourceType)

                    || typeToConvert == typeof(global::Apify.VersionSourceType?)

                    || typeToConvert == typeof(global::Apify.SourceCodeFileFormat)

                    || typeToConvert == typeof(global::Apify.SourceCodeFileFormat?);
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

                if (typeToConvert == typeof(global::Apify.VersionSourceType))
                {
                    return new global::Apify.JsonConverters.VersionSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.VersionSourceType?))
                {
                    return new global::Apify.JsonConverters.VersionSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.SourceCodeFileFormat))
                {
                    return new global::Apify.JsonConverters.SourceCodeFileFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.SourceCodeFileFormat?))
                {
                    return new global::Apify.JsonConverters.SourceCodeFileFormatNullableJsonConverter();
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
                    0 => new ActorsActorVersionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}