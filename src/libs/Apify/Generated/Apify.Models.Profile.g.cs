
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Profile
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bio")]
        public string? Bio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        public string? PictureUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("githubUsername")]
        public string? GithubUsername { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("websiteUrl")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitterUsername")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile" /> class.
        /// </summary>
        /// <param name="bio"></param>
        /// <param name="name"></param>
        /// <param name="pictureUrl"></param>
        /// <param name="githubUsername"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="twitterUsername"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Profile(
            string? bio,
            string? name,
            string? pictureUrl,
            string? githubUsername,
            string? websiteUrl,
            string? twitterUsername)
        {
            this.Bio = bio;
            this.Name = name;
            this.PictureUrl = pictureUrl;
            this.GithubUsername = githubUsername;
            this.WebsiteUrl = websiteUrl;
            this.TwitterUsername = twitterUsername;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile" /> class.
        /// </summary>
        public Profile()
        {
        }

    }
}