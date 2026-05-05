#nullable enable

namespace Apify
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Encode and sign object<br/>
        /// Encodes and signs any JSON object. The encoded value includes a signature<br/>
        /// tied to the authenticated user's ID, which can later be verified using the<br/>
        /// decode-and-verify endpoint.<br/>
        /// **Important**: The request must specify the `Content-Type: application/json`<br/>
        /// HTTP header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.EncodeAndSignResponse> ToolsEncodeAndSignPostAsync(

            object request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Encode and sign object<br/>
        /// Encodes and signs any JSON object. The encoded value includes a signature<br/>
        /// tied to the authenticated user's ID, which can later be verified using the<br/>
        /// decode-and-verify endpoint.<br/>
        /// **Important**: The request must specify the `Content-Type: application/json`<br/>
        /// HTTP header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.EncodeAndSignResponse>> ToolsEncodeAndSignPostAsResponseAsync(

            object request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Encode and sign object<br/>
        /// Encodes and signs any JSON object. The encoded value includes a signature<br/>
        /// tied to the authenticated user's ID, which can later be verified using the<br/>
        /// decode-and-verify endpoint.<br/>
        /// **Important**: The request must specify the `Content-Type: application/json`<br/>
        /// HTTP header.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.EncodeAndSignResponse> ToolsEncodeAndSignPostAsync(
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}