#nullable enable

namespace Apify
{
    public partial interface IToolsEncodingClient
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DecodeAndVerifyResponse> ToolsDecodeAndVerifyPostAsync(

            global::Apify.DecodeAndVerifyRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Decode and verify object<br/>
        /// Decodes and verifies an encoded value previously created by the<br/>
        /// encode-and-sign endpoint. Returns the original decoded object along with<br/>
        /// information about the user who encoded it and whether that user is verified.<br/>
        /// **Important**: The request must specify the `Content-Type: application/json`<br/>
        /// HTTP header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.DecodeAndVerifyResponse>> ToolsDecodeAndVerifyPostAsResponseAsync(

            global::Apify.DecodeAndVerifyRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DecodeAndVerifyResponse> ToolsDecodeAndVerifyPostAsync(
            string encoded,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}