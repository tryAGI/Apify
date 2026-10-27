
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserPrivateInfo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        public global::Apify.UserProfile? Profile { get; set; }

        /// <summary>
        /// Primary email of the user. It is `null` when the email is not verified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Proxy access info. Omitted when the user has no access to Apify Proxy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy")]
        public global::Apify.ProxyResource? Proxy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public global::Apify.UserPlan? Plan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effectivePlatformFeatures")]
        public global::Apify.EffectivePlatformFeatures? EffectivePlatformFeatures { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPaying")]
        public bool? IsPaying { get; set; }

        /// <summary>
        /// ID of the user who owns the organization. Present only for organization accounts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationOwnerUserId")]
        public string? OrganizationOwnerUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPrivateInfo" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="id"></param>
        /// <param name="profile"></param>
        /// <param name="email">
        /// Primary email of the user. It is `null` when the email is not verified.
        /// </param>
        /// <param name="proxy">
        /// Proxy access info. Omitted when the user has no access to Apify Proxy.
        /// </param>
        /// <param name="plan"></param>
        /// <param name="effectivePlatformFeatures"></param>
        /// <param name="createdAt"></param>
        /// <param name="isPaying"></param>
        /// <param name="organizationOwnerUserId">
        /// ID of the user who owns the organization. Present only for organization accounts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserPrivateInfo(
            string username,
            string? id,
            global::Apify.UserProfile? profile,
            string? email,
            global::Apify.ProxyResource? proxy,
            global::Apify.UserPlan? plan,
            global::Apify.EffectivePlatformFeatures? effectivePlatformFeatures,
            global::System.DateTime? createdAt,
            bool? isPaying,
            string? organizationOwnerUserId)
        {
            this.Id = id;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Profile = profile;
            this.Email = email;
            this.Proxy = proxy;
            this.Plan = plan;
            this.EffectivePlatformFeatures = effectivePlatformFeatures;
            this.CreatedAt = createdAt;
            this.IsPaying = isPaying;
            this.OrganizationOwnerUserId = organizationOwnerUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPrivateInfo" /> class.
        /// </summary>
        public UserPrivateInfo()
        {
        }

    }
}