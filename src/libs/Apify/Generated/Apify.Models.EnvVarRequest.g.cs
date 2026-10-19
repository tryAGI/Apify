
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnvVarRequest
    {
        /// <summary>
        /// The name of the environment variable. Can't contain `=`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The value of the environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Whether the environment variable is encrypted. Secret values aren't returned by the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSecret")]
        public bool? IsSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvVarRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the environment variable. Can't contain `=`.
        /// </param>
        /// <param name="value">
        /// The value of the environment variable.
        /// </param>
        /// <param name="isSecret">
        /// Whether the environment variable is encrypted. Secret values aren't returned by the API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvVarRequest(
            string name,
            string value,
            bool? isSecret)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.IsSecret = isSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvVarRequest" /> class.
        /// </summary>
        public EnvVarRequest()
        {
        }

    }
}