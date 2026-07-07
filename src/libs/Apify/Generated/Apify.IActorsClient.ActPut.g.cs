#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify
{
    public partial interface IActorsClient
    {
        /// <summary>
        /// Update Actor<br/>
        /// Updates an Actor's settings with the values specified in an `Actor` object<br/>
        /// passed as JSON in the POST payload. Only the fields specified in the request body are updated.<br/>
        /// Returns the full `Actor` object, the same as the<br/>
        /// [Get Actor](/api/v2/act-get) endpoint.<br/>
        /// In the HTTP request, set the `Content-Type` header to `application/json`.<br/>
        /// ### Authentication<br/>
        /// To provide the authentication token, we recommend using the request's<br/>
        /// `Authorization` header, rather than the URL. For details,<br/>
        /// see [Authentication](/api/v2/getting-started#authentication).<br/>
        /// ### Make an Actor public<br/>
        /// To make your Actor [public](https://docs.apify.com/platform/actors/publishing):<br/>
        /// - Set `isPublic` to `true`.<br/>
        /// - Provide `title` and `categories`. For reference, see [constants from the `apify-shared-js`<br/>
        /// package](https://github.com/apify/apify-shared-js/blob/2d43ebc41ece9ad31cd6525bd523fb86939bf860/packages/consts/src/consts.ts#L452-L471)<br/>
        /// ### Update build tags<br/>
        /// To change tags assigned to Actor builds, use the `taggedBuilds` object. It's a dictionary that maps tag names<br/>
        /// to specific builds, where:<br/>
        /// - the key is the tag name, for example `latest` or `beta`<br/>
        /// - the value is either `null` or an object with a build ID<br/>
        /// Changing tags is a patch operation. Only the tags that you provide in this object are updated.<br/>
        /// Note that you can assign multiple tags to a single build, but you can't assign the same tag to multiple builds.<br/>
        /// - To create or reassign a tag, provide the tag name with a build ID. For example, to assign<br/>
        /// the `latest` tag to a build, use:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "latest": { "buildId": "z2EryhbfhgSyqj6Hn" }<br/>
        /// }<br/>
        /// ```<br/>
        /// - To remove a tag from a build, provide the tag name with a `null` value. For example, to remove the `beta` tag, use:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "beta": null<br/>
        /// }<br/>
        /// ```<br/>
        /// - You can perform multiple actions at once. The following example reassigns `latest`<br/>
        /// and removes `beta`, while preserving other existing tags:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "latest": { "buildId": "z2EryhbfhgSyqj6Hn" },<br/>
        ///   "beta": null<br/>
        /// }<br/>
        /// ```
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
        /// Updates an Actor's settings with the values specified in an `Actor` object<br/>
        /// passed as JSON in the POST payload. Only the fields specified in the request body are updated.<br/>
        /// Returns the full `Actor` object, the same as the<br/>
        /// [Get Actor](/api/v2/act-get) endpoint.<br/>
        /// In the HTTP request, set the `Content-Type` header to `application/json`.<br/>
        /// ### Authentication<br/>
        /// To provide the authentication token, we recommend using the request's<br/>
        /// `Authorization` header, rather than the URL. For details,<br/>
        /// see [Authentication](/api/v2/getting-started#authentication).<br/>
        /// ### Make an Actor public<br/>
        /// To make your Actor [public](https://docs.apify.com/platform/actors/publishing):<br/>
        /// - Set `isPublic` to `true`.<br/>
        /// - Provide `title` and `categories`. For reference, see [constants from the `apify-shared-js`<br/>
        /// package](https://github.com/apify/apify-shared-js/blob/2d43ebc41ece9ad31cd6525bd523fb86939bf860/packages/consts/src/consts.ts#L452-L471)<br/>
        /// ### Update build tags<br/>
        /// To change tags assigned to Actor builds, use the `taggedBuilds` object. It's a dictionary that maps tag names<br/>
        /// to specific builds, where:<br/>
        /// - the key is the tag name, for example `latest` or `beta`<br/>
        /// - the value is either `null` or an object with a build ID<br/>
        /// Changing tags is a patch operation. Only the tags that you provide in this object are updated.<br/>
        /// Note that you can assign multiple tags to a single build, but you can't assign the same tag to multiple builds.<br/>
        /// - To create or reassign a tag, provide the tag name with a build ID. For example, to assign<br/>
        /// the `latest` tag to a build, use:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "latest": { "buildId": "z2EryhbfhgSyqj6Hn" }<br/>
        /// }<br/>
        /// ```<br/>
        /// - To remove a tag from a build, provide the tag name with a `null` value. For example, to remove the `beta` tag, use:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "beta": null<br/>
        /// }<br/>
        /// ```<br/>
        /// - You can perform multiple actions at once. The following example reassigns `latest`<br/>
        /// and removes `beta`, while preserving other existing tags:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "latest": { "buildId": "z2EryhbfhgSyqj6Hn" },<br/>
        ///   "beta": null<br/>
        /// }<br/>
        /// ```
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
        /// Updates an Actor's settings with the values specified in an `Actor` object<br/>
        /// passed as JSON in the POST payload. Only the fields specified in the request body are updated.<br/>
        /// Returns the full `Actor` object, the same as the<br/>
        /// [Get Actor](/api/v2/act-get) endpoint.<br/>
        /// In the HTTP request, set the `Content-Type` header to `application/json`.<br/>
        /// ### Authentication<br/>
        /// To provide the authentication token, we recommend using the request's<br/>
        /// `Authorization` header, rather than the URL. For details,<br/>
        /// see [Authentication](/api/v2/getting-started#authentication).<br/>
        /// ### Make an Actor public<br/>
        /// To make your Actor [public](https://docs.apify.com/platform/actors/publishing):<br/>
        /// - Set `isPublic` to `true`.<br/>
        /// - Provide `title` and `categories`. For reference, see [constants from the `apify-shared-js`<br/>
        /// package](https://github.com/apify/apify-shared-js/blob/2d43ebc41ece9ad31cd6525bd523fb86939bf860/packages/consts/src/consts.ts#L452-L471)<br/>
        /// ### Update build tags<br/>
        /// To change tags assigned to Actor builds, use the `taggedBuilds` object. It's a dictionary that maps tag names<br/>
        /// to specific builds, where:<br/>
        /// - the key is the tag name, for example `latest` or `beta`<br/>
        /// - the value is either `null` or an object with a build ID<br/>
        /// Changing tags is a patch operation. Only the tags that you provide in this object are updated.<br/>
        /// Note that you can assign multiple tags to a single build, but you can't assign the same tag to multiple builds.<br/>
        /// - To create or reassign a tag, provide the tag name with a build ID. For example, to assign<br/>
        /// the `latest` tag to a build, use:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "latest": { "buildId": "z2EryhbfhgSyqj6Hn" }<br/>
        /// }<br/>
        /// ```<br/>
        /// - To remove a tag from a build, provide the tag name with a `null` value. For example, to remove the `beta` tag, use:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "beta": null<br/>
        /// }<br/>
        /// ```<br/>
        /// - You can perform multiple actions at once. The following example reassigns `latest`<br/>
        /// and removes `beta`, while preserving other existing tags:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "latest": { "buildId": "z2EryhbfhgSyqj6Hn" },<br/>
        ///   "beta": null<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="name">
        /// The identifier of the Actor. Use lowercase letters, numbers, and hyphens. Spaces or special characters aren't allowed. Must be unique across your account.
        /// </param>
        /// <param name="description">
        /// Short description of the Actor, displayed in Apify Store and Console.
        /// </param>
        /// <param name="isPublic">
        /// Whether the Actor is available to users in Apify Store. If `false`, the Actor is private and only visible to you.
        /// </param>
        /// <param name="actorPermissionLevel"></param>
        /// <param name="seoTitle">
        /// Name of the Actor to display by search engines such as Google. Can be different from the Actor's name displayed in Apify Store and Console. Recommended length is 40-50 characters.
        /// </param>
        /// <param name="seoDescription">
        /// Description of the Actor to display by search engines such as Google. Recommended length is 140-156 characters.
        /// </param>
        /// <param name="title">
        /// Human-readable name of the Actor, displayed in Apify Store and Console. Can contain spaces and capital letters. Recommended length is 40-50 characters. You can change this title without affecting the Actor's URL or SEO.
        /// </param>
        /// <param name="versions">
        /// An array of `Version` objects. Each object represents a specific version of the Actor's source code: its location, builds, and environment configuration.
        /// </param>
        /// <param name="pricingInfos"></param>
        /// <param name="categories">
        /// A list of categories that best define the Actor. Reflected in Apify Store's search and filtering options.
        /// </param>
        /// <param name="defaultRunOptions">
        /// The default settings applied to an Actor run. Can be overridden by the user.
        /// </param>
        /// <param name="taggedBuilds">
        /// A dictionary that maps tag names to specific builds. For details, see [Update build tags](#update-build-tags).<br/>
        /// Example: {"latest":{"buildId":"z2EryhbfhgSyqj6Hn"},"beta":null}
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