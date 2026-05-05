#nullable enable

namespace Apify
{
    public partial interface ISchedulesClient
    {
        /// <summary>
        /// Get schedule<br/>
        /// Gets the schedule object with all details.
        /// </summary>
        /// <param name="scheduleId">
        /// Example: asdLZtadYvn4mBZmm
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ScheduleResponse> ScheduleGetAsync(
            string scheduleId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get schedule<br/>
        /// Gets the schedule object with all details.
        /// </summary>
        /// <param name="scheduleId">
        /// Example: asdLZtadYvn4mBZmm
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ScheduleResponse>> ScheduleGetAsResponseAsync(
            string scheduleId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}