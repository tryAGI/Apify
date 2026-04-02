#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify
{
    public partial interface IActorsClient
    {
        /// <summary>
        /// Create Actor<br/>
        /// Creates a new Actor with settings specified in an Actor object passed as<br/>
        /// JSON in the POST payload.<br/>
        /// The response is the full Actor object as returned by the<br/>
        /// [Get Actor](#/reference/actors/actor-object/get-actor) endpoint.<br/>
        /// The HTTP request must have the `Content-Type: application/json` HTTP header!<br/>
        /// The Actor needs to define at least one version of the source code.<br/>
        /// For more information, see [Version object](#/reference/actors/version-object).<br/>
        /// If you want to make your Actor<br/>
        /// [public](https://docs.apify.com/platform/actors/publishing) using `isPublic:<br/>
        /// true`, you will need to provide the Actor's `title` and the `categories`<br/>
        /// under which that Actor will be classified in Apify Store. For this, it's<br/>
        /// best to use the [constants from our `apify-shared-js`<br/>
        /// package](https://github.com/apify/apify-shared-js/blob/2d43ebc41ece9ad31cd6525bd523fb86939bf860/packages/consts/src/consts.ts#L452-L471).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorResponse> ActsPostAsync(

            global::Apify.CreateActorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Actor<br/>
        /// Creates a new Actor with settings specified in an Actor object passed as<br/>
        /// JSON in the POST payload.<br/>
        /// The response is the full Actor object as returned by the<br/>
        /// [Get Actor](#/reference/actors/actor-object/get-actor) endpoint.<br/>
        /// The HTTP request must have the `Content-Type: application/json` HTTP header!<br/>
        /// The Actor needs to define at least one version of the source code.<br/>
        /// For more information, see [Version object](#/reference/actors/version-object).<br/>
        /// If you want to make your Actor<br/>
        /// [public](https://docs.apify.com/platform/actors/publishing) using `isPublic:<br/>
        /// true`, you will need to provide the Actor's `title` and the `categories`<br/>
        /// under which that Actor will be classified in Apify Store. For this, it's<br/>
        /// best to use the [constants from our `apify-shared-js`<br/>
        /// package](https://github.com/apify/apify-shared-js/blob/2d43ebc41ece9ad31cd6525bd523fb86939bf860/packages/consts/src/consts.ts#L452-L471).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ActorResponse>> ActsPostAsResponseAsync(

            global::Apify.CreateActorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Actor<br/>
        /// Creates a new Actor with settings specified in an Actor object passed as<br/>
        /// JSON in the POST payload.<br/>
        /// The response is the full Actor object as returned by the<br/>
        /// [Get Actor](#/reference/actors/actor-object/get-actor) endpoint.<br/>
        /// The HTTP request must have the `Content-Type: application/json` HTTP header!<br/>
        /// The Actor needs to define at least one version of the source code.<br/>
        /// For more information, see [Version object](#/reference/actors/version-object).<br/>
        /// If you want to make your Actor<br/>
        /// [public](https://docs.apify.com/platform/actors/publishing) using `isPublic:<br/>
        /// true`, you will need to provide the Actor's `title` and the `categories`<br/>
        /// under which that Actor will be classified in Apify Store. For this, it's<br/>
        /// best to use the [constants from our `apify-shared-js`<br/>
        /// package](https://github.com/apify/apify-shared-js/blob/2d43ebc41ece9ad31cd6525bd523fb86939bf860/packages/consts/src/consts.ts#L452-L471).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
        /// <param name="isPublic"></param>
        /// <param name="seoTitle"></param>
        /// <param name="seoDescription"></param>
        /// <param name="versions"></param>
        /// <param name="pricingInfos"></param>
        /// <param name="categories"></param>
        /// <param name="defaultRunOptions"></param>
        /// <param name="actorStandby"></param>
        /// <param name="exampleRunInput"></param>
        /// <param name="isDeprecated"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorResponse> ActsPostAsync(
            string? name = default,
            string? description = default,
            string? title = default,
            bool? isPublic = default,
            string? seoTitle = default,
            string? seoDescription = default,
            global::System.Collections.Generic.IList<global::Apify.Version>? versions = default,
            global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>? pricingInfos = default,
            global::System.Collections.Generic.IList<string>? categories = default,
            global::Apify.DefaultRunOptions? defaultRunOptions = default,
            global::Apify.ActorStandby? actorStandby = default,
            global::Apify.ExampleRunInput? exampleRunInput = default,
            bool? isDeprecated = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}