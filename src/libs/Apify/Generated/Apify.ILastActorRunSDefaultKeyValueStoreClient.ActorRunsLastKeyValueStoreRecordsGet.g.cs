#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSDefaultKeyValueStoreClient
    {
        /// <summary>
        /// Download records from the default key-value store of an Actor's last run<br/>
        /// Downloads all records from the default key-value store of the last Actor run as a ZIP archive.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Download key-value store records](/api/v2/key-value-store-records-get) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="collection">
        /// Example: my-collection
        /// </param>
        /// <param name="prefix">
        /// Example: my-prefix/
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ActorRunsLastKeyValueStoreRecordsGetAsync(
            string actorId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? collection = default,
            string? prefix = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download records from the default key-value store of an Actor's last run<br/>
        /// Downloads all records from the default key-value store of the last Actor run as a ZIP archive.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Download key-value store records](/api/v2/key-value-store-records-get) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="collection">
        /// Example: my-collection
        /// </param>
        /// <param name="prefix">
        /// Example: my-prefix/
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ActorRunsLastKeyValueStoreRecordsGetAsStreamAsync(
            string actorId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? collection = default,
            string? prefix = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download records from the default key-value store of an Actor's last run<br/>
        /// Downloads all records from the default key-value store of the last Actor run as a ZIP archive.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Download key-value store records](/api/v2/key-value-store-records-get) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="collection">
        /// Example: my-collection
        /// </param>
        /// <param name="prefix">
        /// Example: my-prefix/
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <returns>The response metadata and an unbuffered body stream. The caller must dispose Body to release the HTTP response.</returns>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::System.IO.Stream>> ActorRunsLastKeyValueStoreRecordsGetAsStreamAsResponseAsync(
            string actorId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? collection = default,
            string? prefix = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download records from the default key-value store of an Actor's last run<br/>
        /// Downloads all records from the default key-value store of the last Actor run as a ZIP archive.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Download key-value store records](/api/v2/key-value-store-records-get) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="collection">
        /// Example: my-collection
        /// </param>
        /// <param name="prefix">
        /// Example: my-prefix/
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<byte[]>> ActorRunsLastKeyValueStoreRecordsGetAsResponseAsync(
            string actorId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? collection = default,
            string? prefix = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}