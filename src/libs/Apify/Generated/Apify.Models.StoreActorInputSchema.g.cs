
#nullable enable

namespace Apify
{
    /// <summary>
    /// Compact input schema of the Actor's default build, with only property types and required properties. Returned only when `includeInputSchema=true` and the default build succeeded and defines input properties.
    /// </summary>
    public sealed partial class StoreActorInputSchema
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Apify.StoreActorInputSchemaProperties2> Properties { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreActorInputSchema" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="properties"></param>
        /// <param name="required"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreActorInputSchema(
            string type,
            global::System.Collections.Generic.Dictionary<string, global::Apify.StoreActorInputSchemaProperties2> properties,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreActorInputSchema" /> class.
        /// </summary>
        public StoreActorInputSchema()
        {
        }

    }
}