#nullable enable

namespace Apify
{
    public partial interface IStorageKeyValueStoresClient
    {
        /// <summary>
        /// Download records<br/>
        /// Downloads all records from the key-value store as a ZIP archive.<br/>
        /// Each record is stored as a separate file in the archive, with the filename equal to the record key.<br/>
        /// You can optionally filter the records by `collection` or `prefix` to download only a subset of the store.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="collection">
        /// Example: my-collection
        /// </param>
        /// <param name="prefix">
        /// Example: my-prefix/
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> KeyValueStoreRecordsGetAsync(
            string storeId,
            string? collection = default,
            string? prefix = default,
            string? signature = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}