#nullable enable

namespace Apify
{
    public partial interface IStorageKeyValueStoresClient
    {
        /// <summary>
        /// Create key-value store<br/>
        /// Creates a key-value store and returns its object. The response is the same<br/>
        /// object as returned by the [Get store](#/reference/key-value-stores/store-object/get-store)<br/>
        /// endpoint.<br/>
        /// Keep in mind that data stored under unnamed store follows [data retention<br/>
        /// period](https://docs.apify.com/platform/storage#data-retention).<br/>
        /// It creates a store with the given name if the parameter name is used.<br/>
        /// If there is another store with the same name, the endpoint does not create a<br/>
        /// new one and returns the existing object instead.
        /// </summary>
        /// <param name="name">
        /// Example: eshop-values
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.KeyValueStoreResponse> KeyValueStoresPostAsync(
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create key-value store<br/>
        /// Creates a key-value store and returns its object. The response is the same<br/>
        /// object as returned by the [Get store](#/reference/key-value-stores/store-object/get-store)<br/>
        /// endpoint.<br/>
        /// Keep in mind that data stored under unnamed store follows [data retention<br/>
        /// period](https://docs.apify.com/platform/storage#data-retention).<br/>
        /// It creates a store with the given name if the parameter name is used.<br/>
        /// If there is another store with the same name, the endpoint does not create a<br/>
        /// new one and returns the existing object instead.
        /// </summary>
        /// <param name="name">
        /// Example: eshop-values
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.KeyValueStoreResponse>> KeyValueStoresPostAsResponseAsync(
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}