#nullable enable

namespace Apify
{
    public partial interface IActorRunsClient
    {
        /// <summary>
        /// Update run<br/>
        /// This endpoint can be used to update both the run's status message and to configure its general resource access level.<br/>
        /// **Status message:**<br/>
        /// You can set a single status message on your run that will be displayed in<br/>
        /// the Apify Console UI. During an Actor run, you will typically do this in order<br/>
        /// to inform users of your Actor about the Actor's progress.<br/>
        /// The request body must contain `runId` and `statusMessage` properties. The<br/>
        /// `isStatusMessageTerminal` property is optional and it indicates if the<br/>
        /// status message is the very last one. In the absence of a status message, the<br/>
        /// platform will try to substitute sensible defaults.<br/>
        /// **General resource access:**<br/>
        /// You can also update the run's general resource access setting, which determines who can view the run and its related data.<br/>
        /// Allowed values:<br/>
        /// * `FOLLOW_USER_SETTING` - The run inherits the general access setting from the account level.<br/>
        /// * `ANYONE_WITH_ID_CAN_READ` - The run can be viewed anonymously by anyone who has its ID.<br/>
        /// * `RESTRICTED` - Only users with explicit access to the resource can access the run.<br/>
        /// When a run is accessible anonymously, all of the run's default storages and logs also become accessible anonymously.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> ActorRunPutAsync(
            string runId,

            global::Apify.AllOf<global::Apify.UpdateRunRequest, object> request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update run<br/>
        /// This endpoint can be used to update both the run's status message and to configure its general resource access level.<br/>
        /// **Status message:**<br/>
        /// You can set a single status message on your run that will be displayed in<br/>
        /// the Apify Console UI. During an Actor run, you will typically do this in order<br/>
        /// to inform users of your Actor about the Actor's progress.<br/>
        /// The request body must contain `runId` and `statusMessage` properties. The<br/>
        /// `isStatusMessageTerminal` property is optional and it indicates if the<br/>
        /// status message is the very last one. In the absence of a status message, the<br/>
        /// platform will try to substitute sensible defaults.<br/>
        /// **General resource access:**<br/>
        /// You can also update the run's general resource access setting, which determines who can view the run and its related data.<br/>
        /// Allowed values:<br/>
        /// * `FOLLOW_USER_SETTING` - The run inherits the general access setting from the account level.<br/>
        /// * `ANYONE_WITH_ID_CAN_READ` - The run can be viewed anonymously by anyone who has its ID.<br/>
        /// * `RESTRICTED` - Only users with explicit access to the resource can access the run.<br/>
        /// When a run is accessible anonymously, all of the run's default storages and logs also become accessible anonymously.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> ActorRunPutAsync(
            string runId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}