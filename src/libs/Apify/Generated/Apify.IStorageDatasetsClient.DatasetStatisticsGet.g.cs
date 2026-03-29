#nullable enable

namespace Apify
{
    public partial interface IStorageDatasetsClient
    {
        /// <summary>
        /// Get dataset statistics<br/>
        /// Returns statistics for given dataset.<br/>
        /// Provides only [field statistics](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema/validation#dataset-field-statistics).
        /// </summary>
        /// <param name="datasetId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DatasetStatisticsResponse> DatasetStatisticsGetAsync(
            string datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}