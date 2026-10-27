#nullable enable

namespace Apify
{
    public partial interface ISchedulesClient
    {
        /// <summary>
        /// Invoke schedule<br/>
        /// Immediately runs all actions of the schedule, the same way as the **Run now** button in Apify Console.<br/>
        /// The invocation is recorded in the [schedule log](/api/v2/schedule-log-get). It doesn't change the schedule's<br/>
        /// `lastRunAt` or `nextRunAt`. The response doesn't contain the started runs.
        /// </summary>
        /// <param name="scheduleId">
        /// Example: asdLZtadYvn4mBZmm
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ScheduleInvokePostAsync(
            string scheduleId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invoke schedule<br/>
        /// Immediately runs all actions of the schedule, the same way as the **Run now** button in Apify Console.<br/>
        /// The invocation is recorded in the [schedule log](/api/v2/schedule-log-get). It doesn't change the schedule's<br/>
        /// `lastRunAt` or `nextRunAt`. The response doesn't contain the started runs.
        /// </summary>
        /// <param name="scheduleId">
        /// Example: asdLZtadYvn4mBZmm
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> ScheduleInvokePostAsResponseAsync(
            string scheduleId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}