
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActorOAuthAccountResponse
    {
        /// <summary>
        /// An account a user connected through an Actor OAuth connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.ActorOAuthAccount Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorOAuthAccountResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// An account a user connected through an Actor OAuth connection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorOAuthAccountResponse(
            global::Apify.ActorOAuthAccount data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorOAuthAccountResponse" /> class.
        /// </summary>
        public ActorOAuthAccountResponse()
        {
        }

    }
}