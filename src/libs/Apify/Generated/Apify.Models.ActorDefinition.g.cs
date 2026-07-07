
#nullable enable

namespace Apify
{
    /// <summary>
    /// The definition of the Actor, the full specification of this field can be found in [Apify docs](https://docs.apify.com/platform/actors/development/actor-definition/actor-json)
    /// </summary>
    public sealed partial class ActorDefinition
    {
        /// <summary>
        /// The Actor specification version that this Actor follows. This property must be set to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorSpecification")]
        public int? ActorSpecification { get; set; }

        /// <summary>
        /// The name of the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The version of the Actor, typically a dot-separated sequence of numbers (e.g., `0.1`, `1.0`, or `0.0.1`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The tag name to be applied to a successful build of the Actor. Defaults to 'latest' if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildTag")]
        public string? BuildTag { get; set; }

        /// <summary>
        /// A map of environment variables to be used during local development and deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentVariables")]
        public global::System.Collections.Generic.Dictionary<string, string>? EnvironmentVariables { get; set; }

        /// <summary>
        /// The path to the Dockerfile used for building the Actor on the platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dockerfile")]
        public string? Dockerfile { get; set; }

        /// <summary>
        /// The path to the directory used as the Docker context when building the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dockerContextDir")]
        public string? DockerContextDir { get; set; }

        /// <summary>
        /// The path to the README file for the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// The input schema object, the full specification can be found in [Apify docs](https://docs.apify.com/platform/actors/development/actor-definition/input-schema)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// The path to the CHANGELOG file displayed in the Actor's information tab.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changelog")]
        public string? Changelog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storages")]
        public global::Apify.ActorDefinitionStorages? Storages { get; set; }

        /// <summary>
        /// Specifies the default amount of memory in megabytes to be used when the Actor is started. Can be an integer or a [dynamic memory expression](/actors/development/actor-definition/dynamic-actor-memory).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultMemoryMbytes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.OneOfJsonConverter<string, long?>))]
        public global::Apify.OneOf<string, long?>? DefaultMemoryMbytes { get; set; }

        /// <summary>
        /// Specifies the minimum amount of memory in megabytes required by the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minMemoryMbytes")]
        public long? MinMemoryMbytes { get; set; }

        /// <summary>
        /// Specifies the maximum amount of memory in megabytes required by the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMemoryMbytes")]
        public long? MaxMemoryMbytes { get; set; }

        /// <summary>
        /// Specifies whether Standby mode is enabled for the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usesStandbyMode")]
        public bool? UsesStandbyMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorDefinition" /> class.
        /// </summary>
        /// <param name="actorSpecification">
        /// The Actor specification version that this Actor follows. This property must be set to 1.
        /// </param>
        /// <param name="name">
        /// The name of the Actor.
        /// </param>
        /// <param name="version">
        /// The version of the Actor, typically a dot-separated sequence of numbers (e.g., `0.1`, `1.0`, or `0.0.1`).
        /// </param>
        /// <param name="buildTag">
        /// The tag name to be applied to a successful build of the Actor. Defaults to 'latest' if not specified.
        /// </param>
        /// <param name="environmentVariables">
        /// A map of environment variables to be used during local development and deployment.
        /// </param>
        /// <param name="dockerfile">
        /// The path to the Dockerfile used for building the Actor on the platform.
        /// </param>
        /// <param name="dockerContextDir">
        /// The path to the directory used as the Docker context when building the Actor.
        /// </param>
        /// <param name="readme">
        /// The path to the README file for the Actor.
        /// </param>
        /// <param name="input">
        /// The input schema object, the full specification can be found in [Apify docs](https://docs.apify.com/platform/actors/development/actor-definition/input-schema)
        /// </param>
        /// <param name="changelog">
        /// The path to the CHANGELOG file displayed in the Actor's information tab.
        /// </param>
        /// <param name="storages"></param>
        /// <param name="defaultMemoryMbytes">
        /// Specifies the default amount of memory in megabytes to be used when the Actor is started. Can be an integer or a [dynamic memory expression](/actors/development/actor-definition/dynamic-actor-memory).
        /// </param>
        /// <param name="minMemoryMbytes">
        /// Specifies the minimum amount of memory in megabytes required by the Actor.
        /// </param>
        /// <param name="maxMemoryMbytes">
        /// Specifies the maximum amount of memory in megabytes required by the Actor.
        /// </param>
        /// <param name="usesStandbyMode">
        /// Specifies whether Standby mode is enabled for the Actor.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorDefinition(
            int? actorSpecification,
            string? name,
            string? version,
            string? buildTag,
            global::System.Collections.Generic.Dictionary<string, string>? environmentVariables,
            string? dockerfile,
            string? dockerContextDir,
            string? readme,
            object? input,
            string? changelog,
            global::Apify.ActorDefinitionStorages? storages,
            global::Apify.OneOf<string, long?>? defaultMemoryMbytes,
            long? minMemoryMbytes,
            long? maxMemoryMbytes,
            bool? usesStandbyMode)
        {
            this.ActorSpecification = actorSpecification;
            this.Name = name;
            this.Version = version;
            this.BuildTag = buildTag;
            this.EnvironmentVariables = environmentVariables;
            this.Dockerfile = dockerfile;
            this.DockerContextDir = dockerContextDir;
            this.Readme = readme;
            this.Input = input;
            this.Changelog = changelog;
            this.Storages = storages;
            this.DefaultMemoryMbytes = defaultMemoryMbytes;
            this.MinMemoryMbytes = minMemoryMbytes;
            this.MaxMemoryMbytes = maxMemoryMbytes;
            this.UsesStandbyMode = usesStandbyMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorDefinition" /> class.
        /// </summary>
        public ActorDefinition()
        {
        }

    }
}