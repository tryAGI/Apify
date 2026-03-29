#nullable enable

namespace Apify
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Decode and verify object<br/>
        /// Decodes and verifies an encoded value previously created by the<br/>
        /// encode-and-sign endpoint. Returns the original decoded object along with<br/>
        /// information about the user who encoded it and whether that user is verified.<br/>
        /// **Important**: The request must specify the `Content-Type: application/json`<br/>
        /// HTTP header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DecodeAndVerifyResponse> ToolsDecodeAndVerifyPostAsync(

            global::Apify.DecodeAndVerifyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Decode and verify object<br/>
        /// Decodes and verifies an encoded value previously created by the<br/>
        /// encode-and-sign endpoint. Returns the original decoded object along with<br/>
        /// information about the user who encoded it and whether that user is verified.<br/>
        /// **Important**: The request must specify the `Content-Type: application/json`<br/>
        /// HTTP header.
        /// </summary>
        /// <param name="encoded"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DecodeAndVerifyResponse> ToolsDecodeAndVerifyPostAsync(
            string encoded,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}