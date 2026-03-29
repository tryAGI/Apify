#nullable enable

namespace Apify
{
    public partial interface IActorRunsClient
    {
        /// <summary>
        /// Metamorph run<br/>
        /// Transforms an Actor run into a run of another Actor with a new input.<br/>
        /// This is useful if you want to use another Actor to finish the work<br/>
        /// of your current Actor run, without the need to create a completely new run<br/>
        /// and waiting for its finish.<br/>
        /// For the users of your Actors, the metamorph operation is transparent, they<br/>
        /// will just see your Actor got the work done.<br/>
        /// Internally, the system stops the Docker container corresponding to the Actor<br/>
        /// run and starts a new container using a different Docker image.<br/>
        /// All the default storages are preserved and the new input is stored under the<br/>
        /// `INPUT-METAMORPH-1` key in the same default key-value store.<br/>
        /// For more information, see the [Actor docs](https://docs.apify.com/platform/actors/development/programming-interface/metamorph).
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="targetActorId">
        /// Example: HDSasDasz78YcAPEB
        /// </param>
        /// <param name="build">
        /// Example: beta
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> ActorRunMetamorphPostAsync(
            string runId,
            string targetActorId,
            string? build = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}