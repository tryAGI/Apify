
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
        public global::Apify.Profile? Profile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy")]
        public global::Apify.Proxy? Proxy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.Plan Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effectivePlatformFeatures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.EffectivePlatformFeatures EffectivePlatformFeatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPaying")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPaying { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPrivateInfo" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="plan"></param>
        /// <param name="effectivePlatformFeatures"></param>
        /// <param name="isPaying"></param>
        /// <param name="id"></param>
        /// <param name="profile"></param>
        /// <param name="email"></param>
        /// <param name="proxy"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserPrivateInfo(
            string username,
            global::Apify.Plan plan,
            global::Apify.EffectivePlatformFeatures effectivePlatformFeatures,
            bool isPaying,
            string? id,
            global::Apify.Profile? profile,
            string? email,
            global::Apify.Proxy? proxy,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Profile = profile;
            this.Email = email;
            this.Proxy = proxy;
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
            this.EffectivePlatformFeatures = effectivePlatformFeatures ?? throw new global::System.ArgumentNullException(nameof(effectivePlatformFeatures));
            this.CreatedAt = createdAt;
            this.IsPaying = isPaying;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPrivateInfo" /> class.
        /// </summary>
        public UserPrivateInfo()
        {
        }

    }
}