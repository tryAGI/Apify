#nullable enable

namespace Apify
{
    public partial interface ISchedulesClient
    {
        /// <summary>
        /// Create schedule<br/>
        /// Creates a new schedule with settings provided by the schedule object passed<br/>
        /// as JSON in the payload. The response is the created schedule object.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ScheduleResponse> SchedulesPostAsync(

            global::Apify.ScheduleCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create schedule<br/>
        /// Creates a new schedule with settings provided by the schedule object passed<br/>
        /// as JSON in the payload. The response is the created schedule object.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isEnabled"></param>
        /// <param name="isExclusive"></param>
        /// <param name="cronExpression"></param>
        /// <param name="timezone"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
        /// <param name="actions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ScheduleResponse> SchedulesPostAsync(
            string? name = default,
            bool? isEnabled = default,
            bool? isExclusive = default,
            string? cronExpression = default,
            string? timezone = default,
            string? description = default,
            string? title = default,
            global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>? actions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}