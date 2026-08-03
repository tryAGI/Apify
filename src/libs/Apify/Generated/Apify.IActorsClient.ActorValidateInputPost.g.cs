#nullable enable

namespace Apify
{
    public partial interface IActorsClient
    {
        /// <summary>
        /// Validate Actor input<br/>
        /// Validates the provided input against the Actor's input schema for the specified build.<br/>
        /// The endpoint checks whether the JSON payload conforms to the input schema<br/>
        /// defined in the Actor's build. If no `build` query parameter is provided,<br/>
        /// the `latest` build tag is used by default.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="build">
        /// Example: latest
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorValidateInputPostResponse> ActorValidateInputPostAsync(
            string actorId,

            object request,
            string? build = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Actor input<br/>
        /// Validates the provided input against the Actor's input schema for the specified build.<br/>
        /// The endpoint checks whether the JSON payload conforms to the input schema<br/>
        /// defined in the Actor's build. If no `build` query parameter is provided,<br/>
        /// the `latest` build tag is used by default.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="build">
        /// Example: latest
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ActorValidateInputPostResponse>> ActorValidateInputPostAsResponseAsync(
            string actorId,

            object request,
            string? build = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Actor input<br/>
        /// Validates the provided input against the Actor's input schema for the specified build.<br/>
        /// The endpoint checks whether the JSON payload conforms to the input schema<br/>
        /// defined in the Actor's build. If no `build` query parameter is provided,<br/>
        /// the `latest` build tag is used by default.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="build">
        /// Example: latest
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorValidateInputPostResponse> ActorValidateInputPostAsync(
            string actorId,
            string? build = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}