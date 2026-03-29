#nullable enable

namespace Apify
{
    public partial interface IStorageDatasetsClient
    {
        /// <summary>
        /// Create dataset<br/>
        /// Creates a dataset and returns its object.<br/>
        /// Keep in mind that data stored under unnamed dataset follows [data retention period](https://docs.apify.com/platform/storage#data-retention).<br/>
        /// It creates a dataset with the given name if the parameter name is used.<br/>
        /// If a dataset with the given name already exists then returns its object.
        /// </summary>
        /// <param name="name">
        /// Example: eshop-items
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DatasetResponse> DatasetsPostAsync(
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}