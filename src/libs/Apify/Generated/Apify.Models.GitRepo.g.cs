
#nullable enable

namespace Apify
{
    /// <summary>
    /// URLs of a newly created repository.
    /// </summary>
    public sealed partial class GitRepo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sshUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SshUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpsUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HttpsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("htmlUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitRepo" /> class.
        /// </summary>
        /// <param name="sshUrl"></param>
        /// <param name="httpsUrl"></param>
        /// <param name="htmlUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GitRepo(
            string sshUrl,
            string httpsUrl,
            string htmlUrl)
        {
            this.SshUrl = sshUrl ?? throw new global::System.ArgumentNullException(nameof(sshUrl));
            this.HttpsUrl = httpsUrl ?? throw new global::System.ArgumentNullException(nameof(httpsUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitRepo" /> class.
        /// </summary>
        public GitRepo()
        {
        }

    }
}