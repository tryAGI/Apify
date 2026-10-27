
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegisterDeploymentKeyResponseData
    {
        /// <summary>
        /// The normalized URL of the repository the key is registered on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterDeploymentKeyResponseData" /> class.
        /// </summary>
        /// <param name="repoName">
        /// The normalized URL of the repository the key is registered on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterDeploymentKeyResponseData(
            string repoName)
        {
            this.RepoName = repoName ?? throw new global::System.ArgumentNullException(nameof(repoName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterDeploymentKeyResponseData" /> class.
        /// </summary>
        public RegisterDeploymentKeyResponseData()
        {
        }

    }
}