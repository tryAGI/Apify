
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserPublicInfo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        public global::Apify.Profile? Profile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPublicInfo" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="profile"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserPublicInfo(
            string username,
            global::Apify.Profile? profile)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Profile = profile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPublicInfo" /> class.
        /// </summary>
        public UserPublicInfo()
        {
        }

    }
}