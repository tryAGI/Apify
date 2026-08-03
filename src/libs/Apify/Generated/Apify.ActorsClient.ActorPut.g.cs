
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify
{
    public partial class ActorsClient
    {


        private static readonly global::Apify.EndPointSecurityRequirement s_ActorPutSecurityRequirement0 =
            new global::Apify.EndPointSecurityRequirement
            {
                Authorizations = new global::Apify.EndPointAuthorizationRequirement[]
                {                    new global::Apify.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Apify.EndPointSecurityRequirement[] s_ActorPutSecurityRequirements =
            new global::Apify.EndPointSecurityRequirement[]
            {                s_ActorPutSecurityRequirement0,
            };
        partial void PrepareActorPutArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string actorId,
            global::Apify.UpdateActorRequest request);
        partial void PrepareActorPutRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string actorId,
            global::Apify.UpdateActorRequest request);
        partial void ProcessActorPutResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActorPutResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Actor<br/>
        /// Updates an Actor's settings with the values specified in an `Actor` object<br/>
        /// passed as JSON in the POST payload. Only the fields specified in the request body are updated.<br/>
        /// Returns the full `Actor` object, the same as the<br/>
        /// [Get Actor](/api/v2/actor-get) endpoint.<br/>
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
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Apify.ActorResponse> ActorPutAsync(
            string actorId,

            global::Apify.UpdateActorRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ActorPutAsResponseAsync(
                actorId: actorId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Update Actor<br/>
        /// Updates an Actor's settings with the values specified in an `Actor` object<br/>
        /// passed as JSON in the POST payload. Only the fields specified in the request body are updated.<br/>
        /// Returns the full `Actor` object, the same as the<br/>
        /// [Get Actor](/api/v2/actor-get) endpoint.<br/>
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
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ActorResponse>> ActorPutAsResponseAsync(
            string actorId,

            global::Apify.UpdateActorRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareActorPutArguments(
                httpClient: HttpClient,
                actorId: ref actorId,
                request: request);


            var __authorizations = global::Apify.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ActorPutSecurityRequirements,
                operationName: "ActorPutAsync");

            using var __timeoutCancellationTokenSource = global::Apify.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Apify.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Apify.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Apify.PathBuilder(
                                path: $"/v2/actors/{actorId}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Apify.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Put,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Apify.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareActorPutRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    actorId: actorId!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Apify.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Apify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ActorPut",
                                methodName: "ActorPutAsync",
                                pathTemplate: "$\"/v2/actors/{actorId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Apify.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Apify.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Apify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ActorPut",
                                methodName: "ActorPutAsync",
                                pathTemplate: "$\"/v2/actors/{actorId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Apify.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Apify.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Apify.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Apify.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Apify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ActorPut",
                                methodName: "ActorPutAsync",
                                pathTemplate: "$\"/v2/actors/{actorId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Apify.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessActorPutResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Apify.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Apify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ActorPut",
                                methodName: "ActorPutAsync",
                                pathTemplate: "$\"/v2/actors/{actorId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Apify.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Apify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ActorPut",
                                methodName: "ActorPutAsync",
                                pathTemplate: "$\"/v2/actors/{actorId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad request - invalid input parameters or request body.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Apify.ErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Apify.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Apify.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Apify.ApiException<global::Apify.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unauthorized - authentication required or invalid token.
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::Apify.ErrorResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Apify.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Apify.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Apify.ApiException<global::Apify.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Forbidden - insufficient permissions to perform this action.
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::Apify.ErrorResponse? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Apify.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::Apify.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Apify.ApiException<global::Apify.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Not found - the requested resource does not exist.
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::Apify.ErrorResponse? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Apify.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::Apify.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Apify.ApiException<global::Apify.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Method not allowed.
                            if ((int)__response.StatusCode == 405)
                            {
                                string? __content_405 = null;
                                global::System.Exception? __exception_405 = null;
                                global::Apify.ErrorResponse? __value_405 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_405 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_405 = global::Apify.ErrorResponse.FromJson(__content_405, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_405 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_405 = global::Apify.ErrorResponse.FromJson(__content_405, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_405 = __ex;
                                }


                                throw global::Apify.ApiException<global::Apify.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_405 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_405,
                                    responseBody: __content_405,
                                    responseObject: __value_405,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Payload too large - the request body exceeds the size limit.
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::Apify.ErrorResponse? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::Apify.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::Apify.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::Apify.ApiException<global::Apify.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseObject: __value_413,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unsupported media type - the Content-Encoding of the request is not supported.
                            if ((int)__response.StatusCode == 415)
                            {
                                string? __content_415 = null;
                                global::System.Exception? __exception_415 = null;
                                global::Apify.ErrorResponse? __value_415 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_415 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_415 = global::Apify.ErrorResponse.FromJson(__content_415, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_415 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_415 = global::Apify.ErrorResponse.FromJson(__content_415, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_415 = __ex;
                                }


                                throw global::Apify.ApiException<global::Apify.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_415 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_415,
                                    responseBody: __content_415,
                                    responseObject: __value_415,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Too many requests - rate limit exceeded.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::Apify.ErrorResponse? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Apify.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Apify.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::Apify.ApiException<global::Apify.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessActorPutResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Apify.ActorResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Apify.AutoSDKHttpResponse<global::Apify.ActorResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Apify.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Apify.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Apify.ActorResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Apify.AutoSDKHttpResponse<global::Apify.ActorResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Apify.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Apify.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Update Actor<br/>
        /// Updates an Actor's settings with the values specified in an `Actor` object<br/>
        /// passed as JSON in the POST payload. Only the fields specified in the request body are updated.<br/>
        /// Returns the full `Actor` object, the same as the<br/>
        /// [Get Actor](/api/v2/actor-get) endpoint.<br/>
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
        /// Example: compass~google-maps-extractor
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
        public async global::System.Threading.Tasks.Task<global::Apify.ActorResponse> ActorPutAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Apify.UpdateActorRequest
            {
                Name = name,
                Description = description,
                IsPublic = isPublic,
                ActorPermissionLevel = actorPermissionLevel,
                SeoTitle = seoTitle,
                SeoDescription = seoDescription,
                Title = title,
                Versions = versions,
                PricingInfos = pricingInfos,
                Categories = categories,
                DefaultRunOptions = defaultRunOptions,
                TaggedBuilds = taggedBuilds,
                ActorStandby = actorStandby,
                ExampleRunInput = exampleRunInput,
                IsDeprecated = isDeprecated,
            };

            return await ActorPutAsync(
                actorId: actorId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}