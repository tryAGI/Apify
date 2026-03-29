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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ScheduleResponse> ScheduleGetAsync(
            string scheduleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}