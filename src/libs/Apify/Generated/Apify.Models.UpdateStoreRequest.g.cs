
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"name":"new-store-name","generalAccess":"RESTRICTED"}
    /// </summary>
    public sealed partial class UpdateStoreRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Defines the general access level for the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generalAccess")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.GeneralAccessJsonConverter))]
        public global::Apify.GeneralAccess? GeneralAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStoreRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="generalAccess">
        /// Defines the general access level for the resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateStoreRequest(
            string? name,
            global::Apify.GeneralAccess? generalAccess)
        {
            this.Name = name;
            this.GeneralAccess = generalAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStoreRequest" /> class.
        /// </summary>
        public UpdateStoreRequest()
        {
        }

    }
}