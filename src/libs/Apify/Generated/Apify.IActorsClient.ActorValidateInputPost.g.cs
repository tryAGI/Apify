#nullable enable

namespace Apify
{
    public partial interface IActorsClient
    {
        /// <summary>
        /// Validate Actor input<br/>
        /// Validates the JSON payload against the Actor's<br/>
        /// [input schema](https://docs.apify.com/actors/development/actor-definition/input-schema)<br/>
        /// defined in the specified build.<br/>
        /// If the specified build has no input schema, any input is considered valid.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="build">
        /// Example: 0.1.234
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
        /// Validates the JSON payload against the Actor's<br/>
        /// [input schema](https://docs.apify.com/actors/development/actor-definition/input-schema)<br/>
        /// defined in the specified build.<br/>
        /// If the specified build has no input schema, any input is considered valid.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="build">
        /// Example: 0.1.234
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
        /// Validates the JSON payload against the Actor's<br/>
        /// [input schema](https://docs.apify.com/actors/development/actor-definition/input-schema)<br/>
        /// defined in the specified build.<br/>
        /// If the specified build has no input schema, any input is considered valid.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="build">
        /// Example: 0.1.234
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