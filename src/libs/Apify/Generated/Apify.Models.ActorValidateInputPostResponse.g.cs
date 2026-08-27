
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActorValidateInputPostResponse
    {
        /// <summary>
        /// Always `true`. The endpoint responds with `200` only when the input<br/>
        /// passes validation. Invalid input returns a `400` error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Valid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorValidateInputPostResponse" /> class.
        /// </summary>
        /// <param name="valid">
        /// Always `true`. The endpoint responds with `200` only when the input<br/>
        /// passes validation. Invalid input returns a `400` error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorValidateInputPostResponse(
            bool valid)
        {
            this.Valid = valid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorValidateInputPostResponse" /> class.
        /// </summary>
        public ActorValidateInputPostResponse()
        {
        }

    }
}