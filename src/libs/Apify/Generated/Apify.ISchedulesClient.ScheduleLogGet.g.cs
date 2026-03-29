#nullable enable

namespace Apify
{
    public partial interface ISchedulesClient
    {
        /// <summary>
        /// Get schedule log<br/>
        /// Gets the schedule log as a JSON array containing information about up to a<br/>
        /// 1000 invocations of the schedule.
        /// </summary>
        /// <param name="scheduleId">
        /// Example: asdLZtadYvn4mBZmm
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ScheduleLogResponse> ScheduleLogGetAsync(
            string scheduleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}