#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify
{
    public partial interface IActorsClient
    {
        /// <summary>
        /// Update Actor<br/>
        /// Updates settings of an Actor using values specified by an Actor object<br/>
        /// passed as JSON in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The response is the full Actor object as returned by the<br/>
        /// [Get Actor](#/reference/actors/actor-object/get-actor) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).<br/>
        /// If you want to make your Actor<br/>
        /// [public](https://docs.apify.com/platform/actors/publishing) using `isPublic:<br/>
        /// true`, you will need to provide the Actor's `title` and the `categories`<br/>
        /// under which that Actor will be classified in Apify Store. For this, it's<br/>
        /// best to use the [constants from our `apify-shared-js`<br/>
        /// package](https://github.com/apify/apify-shared-js/blob/2d43ebc41ece9ad31cd6525bd523fb86939bf860/packages/consts/src/consts.ts#L452-L471).
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorResponse> ActPutAsync(
            string actorId,

            global::Apify.UpdateActorRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Actor<br/>
        /// Updates settings of an Actor using values specified by an Actor object<br/>
        /// passed as JSON in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The response is the full Actor object as returned by the<br/>
        /// [Get Actor](#/reference/actors/actor-object/get-actor) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).<br/>
        /// If you want to make your Actor<br/>
        /// [public](https://docs.apify.com/platform/actors/publishing) using `isPublic:<br/>
        /// true`, you will need to provide the Actor's `title` and the `categories`<br/>
        /// under which that Actor will be classified in Apify Store. For this, it's<br/>
        /// best to use the [constants from our `apify-shared-js`<br/>
        /// package](https://github.com/apify/apify-shared-js/blob/2d43ebc41ece9ad31cd6525bd523fb86939bf860/packages/consts/src/consts.ts#L452-L471).
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ActorResponse>> ActPutAsResponseAsync(
            string actorId,

            global::Apify.UpdateActorRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Actor<br/>
        /// Updates settings of an Actor using values specified by an Actor object<br/>
        /// passed as JSON in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The response is the full Actor object as returned by the<br/>
        /// [Get Actor](#/reference/actors/actor-object/get-actor) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).<br/>
        /// If you want to make your Actor<br/>
        /// [public](https://docs.apify.com/platform/actors/publishing) using `isPublic:<br/>
        /// true`, you will need to provide the Actor's `title` and the `categories`<br/>
        /// under which that Actor will be classified in Apify Store. For this, it's<br/>
        /// best to use the [constants from our `apify-shared-js`<br/>
        /// package](https://github.com/apify/apify-shared-js/blob/2d43ebc41ece9ad31cd6525bd523fb86939bf860/packages/consts/src/consts.ts#L452-L471).
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="isPublic"></param>
        /// <param name="actorPermissionLevel"></param>
        /// <param name="seoTitle"></param>
        /// <param name="seoDescription"></param>
        /// <param name="title"></param>
        /// <param name="versions"></param>
        /// <param name="pricingInfos"></param>
        /// <param name="categories"></param>
        /// <param name="defaultRunOptions"></param>
        /// <param name="taggedBuilds">
        /// An object to modify tags on the Actor's builds. The key is the tag name (e.g., _latest_), and the value is either an object with a `buildId` or `null`.<br/>
        /// This operation is a patch; any existing tags that you omit from this object will be preserved.<br/>
        /// - **To create or reassign a tag**, provide the tag name with a `buildId`. e.g., to assign the _latest_ tag:<br/>
        ///   &amp;nbsp;<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "latest": {<br/>
        ///       "buildId": "z2EryhbfhgSyqj6Hn"<br/>
        ///     }<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - **To remove a tag**, provide the tag name with a `null` value. e.g., to remove the _beta_ tag:<br/>
        ///   &amp;nbsp;<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "beta": null<br/>
        ///   }<br/>
        ///   ```<br/>
        /// - **To perform multiple operations**, combine them. The following reassigns _latest_ and removes _beta_, while preserving any other existing tags.<br/>
        ///   &amp;nbsp;<br/>
        ///   ```json<br/>
        ///   {<br/>
        ///     "latest": {<br/>
        ///       "buildId": "z2EryhbfhgSyqj6Hn"<br/>
        ///     },<br/>
        ///     "beta": null<br/>
        ///   }<br/>
        ///   ```<br/>
        /// Example: {"latest":{"buildId":"z2EryhbfhgSyqj6Hn"},"beta":null}
        /// </param>
        /// <param name="actorStandby"></param>
        /// <param name="exampleRunInput"></param>
        /// <param name="isDeprecated"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorResponse> ActPutAsync(
            string actorId,
            string? name = default,
            string? description = default,
            bool? isPublic = default,
            global::Apify.ActorPermissionLevel? actorPermissionLevel = default,
            string? seoTitle = default,
            string? seoDescription = default,
            string? title = default,
            global::System.Collections.Generic.IList<global::Apify.CreateOrUpdateVersionRequest>? versions = default,
            global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>? pricingInfos = default,
            global::System.Collections.Generic.IList<string>? categories = default,
            global::Apify.DefaultRunOptions? defaultRunOptions = default,
            global::System.Collections.Generic.Dictionary<string, global::Apify.BuildTag?>? taggedBuilds = default,
            global::Apify.ActorStandby? actorStandby = default,
            global::Apify.ExampleRunInput? exampleRunInput = default,
            bool? isDeprecated = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}