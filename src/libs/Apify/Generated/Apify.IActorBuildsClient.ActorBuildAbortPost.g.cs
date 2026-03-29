#nullable enable

namespace Apify
{
    public partial interface IActorBuildsClient
    {
        /// <summary>
        /// Abort build<br/>
        /// Aborts an Actor build and returns an object that contains all the details<br/>
        /// about the build.<br/>
        /// Only builds that are starting or running are aborted. For builds with status<br/>
        /// `FINISHED`, `FAILED`, `ABORTING` and `TIMED-OUT` this call does nothing.
        /// </summary>
        /// <param name="buildId">
        /// Example: soSkq9ekdmfOslopH
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.BuildResponse> ActorBuildAbortPostAsync(
            string buildId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}