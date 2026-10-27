
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPublicInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPublicInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ProxyGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ProxyResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ProxyGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPlanMonitoringLevel), TypeInfoPropertyName = "UserPlanMonitoringLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EffectivePlatformFeature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EffectivePlatformFeatures))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPrivateInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPrivateInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GitProviderWorkspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GitProviderIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GitProviderIntegrationProvider), TypeInfoPropertyName = "GitProviderIntegrationProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.GitProviderWorkspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfGitProviderIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.GitProviderIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GitRepoFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GitRepoFileEncoding), TypeInfoPropertyName = "GitRepoFileEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CreateGitRepoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.GitRepoFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GitRepo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GitRepoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RegisterDeploymentKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RegisterDeploymentKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RegisterDeploymentKeyResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AnyOf<global::Apify.UserPublicInfoResponse, global::Apify.UserPrivateInfoResponse>), TypeInfoPropertyName = "AnyOfUserPublicInfoResponseUserPrivateInfoResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorType?), TypeInfoPropertyName = "NullableErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPlanMonitoringLevel?), TypeInfoPropertyName = "NullableUserPlanMonitoringLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GitProviderIntegrationProvider?), TypeInfoPropertyName = "NullableGitProviderIntegrationProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GitRepoFileEncoding?), TypeInfoPropertyName = "NullableGitRepoFileEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AnyOf<global::Apify.UserPublicInfoResponse, global::Apify.UserPrivateInfoResponse>?), TypeInfoPropertyName = "NullableAnyOfUserPublicInfoResponseUserPrivateInfoResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ProxyGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.GitProviderWorkspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.GitProviderIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.GitRepoFile>))]
    internal sealed partial class UsersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UsersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UsersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Apify.JsonConverters.OneOfJsonConverter<string, long?>());
            options.Converters.Add(new global::Apify.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Apify.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Apify.JsonConverters.AnyOfJsonConverter<global::Apify.UserPublicInfoResponse, global::Apify.UserPrivateInfoResponse>());
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

                    || typeToConvert == typeof(global::Apify.UserPlanMonitoringLevel)

                    || typeToConvert == typeof(global::Apify.UserPlanMonitoringLevel?)

                    || typeToConvert == typeof(global::Apify.GitProviderIntegrationProvider)

                    || typeToConvert == typeof(global::Apify.GitProviderIntegrationProvider?)

                    || typeToConvert == typeof(global::Apify.GitRepoFileEncoding)

                    || typeToConvert == typeof(global::Apify.GitRepoFileEncoding?);
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

                if (typeToConvert == typeof(global::Apify.UserPlanMonitoringLevel))
                {
                    return new global::Apify.JsonConverters.UserPlanMonitoringLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.UserPlanMonitoringLevel?))
                {
                    return new global::Apify.JsonConverters.UserPlanMonitoringLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.GitProviderIntegrationProvider))
                {
                    return new global::Apify.JsonConverters.GitProviderIntegrationProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.GitProviderIntegrationProvider?))
                {
                    return new global::Apify.JsonConverters.GitProviderIntegrationProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.GitRepoFileEncoding))
                {
                    return new global::Apify.JsonConverters.GitRepoFileEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Apify.GitRepoFileEncoding?))
                {
                    return new global::Apify.JsonConverters.GitRepoFileEncodingNullableJsonConverter();
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
                    0 => new UsersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}