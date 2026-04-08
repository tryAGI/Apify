
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvVar
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The environment variable value. This field is absent in responses when `isSecret` is `true`, as secret values are never returned by the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSecret")]
        public bool? IsSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvVar" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value">
        /// The environment variable value. This field is absent in responses when `isSecret` is `true`, as secret values are never returned by the API.
        /// </param>
        /// <param name="isSecret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvVar(
            string name,
            string? value,
            bool? isSecret)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value;
            this.IsSecret = isSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvVar" /> class.
        /// </summary>
        public EnvVar()
        {
        }
    }
}