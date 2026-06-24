#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify
{
    public partial interface IActorsClient
    {
        /// <summary>
        /// Create Actor<br/>
        /// Creates an Actor with the settings specified in an `Actor` object passed as<br/>
        /// JSON in the POST payload.<br/>
        /// Returns the full `Actor` object, the same as the<br/>
        /// [Get Actor](/api/v2/act-get) endpoint.<br/>
        /// In the HTTP request, set the `Content-Type` header to `application/json`.<br/>
        /// ### Define a source code version<br/>
        /// An Actor must specify at least one version of the source code.<br/>
        /// For details, see [Actor versions](/api/v2/actors-actor-versions).<br/>
        /// ### Create a public Actor<br/>
        /// To make your Actor [public](https://docs.apify.com/platform/actors/publishing):<br/>
        /// - Set `isPublic` to `true`.<br/>
        /// - Provide `title` and `categories`. For reference, see [constants from the `apify-shared-js`<br/>
        /// package](https://github.com/apify/apify-shared-js/blob/2d43ebc41ece9ad31cd6525bd523fb86939bf860/packages/consts/src/consts.ts#L452-L471)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorResponse> ActsPostAsync(

            global::Apify.CreateActorRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Actor<br/>
        /// Creates an Actor with the settings specified in an `Actor` object passed as<br/>
        /// JSON in the POST payload.<br/>
        /// Returns the full `Actor` object, the same as the<br/>
        /// [Get Actor](/api/v2/act-get) endpoint.<br/>
        /// In the HTTP request, set the `Content-Type` header to `application/json`.<br/>
        /// ### Define a source code version<br/>
        /// An Actor must specify at least one version of the source code.<br/>
        /// For details, see [Actor versions](/api/v2/actors-actor-versions).<br/>
        /// ### Create a public Actor<br/>
        /// To make your Actor [public](https://docs.apify.com/platform/actors/publishing):<br/>
        /// - Set `isPublic` to `true`.<br/>
        /// - Provide `title` and `categories`. For reference, see [constants from the `apify-shared-js`<br/>
        /// package](https://github.com/apify/apify-shared-js/blob/2d43ebc41ece9ad31cd6525bd523fb86939bf860/packages/consts/src/consts.ts#L452-L471)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ActorResponse>> ActsPostAsResponseAsync(

            global::Apify.CreateActorRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Actor<br/>
        /// Creates an Actor with the settings specified in an `Actor` object passed as<br/>
        /// JSON in the POST payload.<br/>
        /// Returns the full `Actor` object, the same as the<br/>
        /// [Get Actor](/api/v2/act-get) endpoint.<br/>
        /// In the HTTP request, set the `Content-Type` header to `application/json`.<br/>
        /// ### Define a source code version<br/>
        /// An Actor must specify at least one version of the source code.<br/>
        /// For details, see [Actor versions](/api/v2/actors-actor-versions).<br/>
        /// ### Create a public Actor<br/>
        /// To make your Actor [public](https://docs.apify.com/platform/actors/publishing):<br/>
        /// - Set `isPublic` to `true`.<br/>
        /// - Provide `title` and `categories`. For reference, see [constants from the `apify-shared-js`<br/>
        /// package](https://github.com/apify/apify-shared-js/blob/2d43ebc41ece9ad31cd6525bd523fb86939bf860/packages/consts/src/consts.ts#L452-L471)
        /// </summary>
        /// <param name="name">
        /// The identifier of the Actor. Use lowercase letters, numbers, and hyphens. Spaces or special characters aren't allowed. Must be unique across your account.
        /// </param>
        /// <param name="description">
        /// Short description of the Actor, displayed in Apify Store and Console.
        /// </param>
        /// <param name="title">
        /// Human-readable name of the Actor, displayed in Apify Store and Console. Can contain spaces and capital letters. Recommended length is 40-50 characters. You can change this title without affecting the Actor's URL or SEO.
        /// </param>
        /// <param name="isPublic">
        /// Whether the Actor is available to users in Apify Store. If `false`, the Actor is private and only visible to you.
        /// </param>
        /// <param name="seoTitle">
        /// Name of the Actor to display by search engines such as Google. Can be different from the Actor's name displayed in Apify Store and Console. Recommended length is 40-50 characters.
        /// </param>
        /// <param name="seoDescription">
        /// Description of the Actor to display by search engines such as Google. Recommended length is 140-156 characters.
        /// </param>
        /// <param name="versions">
        /// An array of `Version` objects. Each object represents a specific version of the Actor's source code: its location, builds, and environment configuration.
        /// </param>
        /// <param name="pricingInfos"></param>
        /// <param name="categories">
        /// A list of categories that best define the Actor. Reflected in Apify Store's search and filtering options.
        /// </param>
        /// <param name="defaultRunOptions">
        /// The default settings applied to an Actor run. Can be overridden elsewhere.
        /// </param>
        /// <param name="actorStandby">
        /// The configuration of the Actor's standby mode. For details, see [Standby mode](https://docs.apify.com/platform/actors/development/programming-interface/standby).
        /// </param>
        /// <param name="exampleRunInput">
        /// Sample input payload that demonstrates what a typical run input for an Actor looks like. Used when no explicit input for a run is provided.
        /// </param>
        /// <param name="isDeprecated">
        /// Whether the Actor is deprecated.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
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
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}