#nullable enable

namespace Apify
{
    public partial interface IStorageKeyValueStoresClient
    {
        /// <summary>
        /// Update store<br/>
        /// Updates a key-value store's name and general resource access level using a value specified by a JSON object<br/>
        /// passed in the PUT payload.<br/>
        /// The response is the updated key-value store object, as returned by the [Get<br/>
        /// store](#/reference/key-value-stores/store-object/get-store) API endpoint.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.KeyValueStoreResponse> KeyValueStorePutAsync(
            string storeId,

            global::Apify.UpdateStoreRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update store<br/>
        /// Updates a key-value store's name and general resource access level using a value specified by a JSON object<br/>
        /// passed in the PUT payload.<br/>
        /// The response is the updated key-value store object, as returned by the [Get<br/>
        /// store](#/reference/key-value-stores/store-object/get-store) API endpoint.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="name"></param>
        /// <param name="generalAccess">
        /// Defines the general access level for the resource.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.KeyValueStoreResponse> KeyValueStorePutAsync(
            string storeId,
            string? name = default,
            global::Apify.GeneralAccess? generalAccess = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}