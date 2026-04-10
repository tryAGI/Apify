#nullable enable

namespace Apify
{
    public partial interface ISchedulesClient
    {
        /// <summary>
        /// Update schedule<br/>
        /// Updates a schedule using values specified by a schedule object passed as<br/>
        /// JSON in the POST payload. If the object does not define a specific property,<br/>
        /// its value will not be updated.<br/>
        /// The response is the full schedule object as returned by the<br/>
        /// [Get schedule](#/reference/schedules/schedule-object/get-schedule) endpoint.<br/>
        /// **The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!**<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).
        /// </summary>
        /// <param name="scheduleId">
        /// Example: asdLZtadYvn4mBZmm
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ScheduleResponse> SchedulePutAsync(
            string scheduleId,

            global::Apify.ScheduleCreate request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update schedule<br/>
        /// Updates a schedule using values specified by a schedule object passed as<br/>
        /// JSON in the POST payload. If the object does not define a specific property,<br/>
        /// its value will not be updated.<br/>
        /// The response is the full schedule object as returned by the<br/>
        /// [Get schedule](#/reference/schedules/schedule-object/get-schedule) endpoint.<br/>
        /// **The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!**<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).
        /// </summary>
        /// <param name="scheduleId">
        /// Example: asdLZtadYvn4mBZmm
        /// </param>
        /// <param name="name"></param>
        /// <param name="isEnabled"></param>
        /// <param name="isExclusive"></param>
        /// <param name="cronExpression"></param>
        /// <param name="timezone"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
        /// <param name="actions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ScheduleResponse> SchedulePutAsync(
            string scheduleId,
            string? name = default,
            bool? isEnabled = default,
            bool? isExclusive = default,
            string? cronExpression = default,
            string? timezone = default,
            string? description = default,
            string? title = default,
            global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>? actions = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}