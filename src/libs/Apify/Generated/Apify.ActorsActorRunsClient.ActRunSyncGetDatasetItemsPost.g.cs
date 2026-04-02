
#nullable enable

namespace Apify
{
    public partial class ActorsActorRunsClient
    {
        partial void PrepareActRunSyncGetDatasetItemsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string actorId,
            ref double? timeout,
            ref double? memory,
            ref double? maxItems,
            ref double? maxTotalChargeUsd,
            ref bool? restartOnError,
            ref string? build,
            ref string? webhooks,
            ref string? format,
            ref bool? clean,
            ref double? offset,
            ref double? limit,
            ref string? fields,
            ref string? omit,
            ref string? unwind,
            ref string? flatten,
            ref bool? desc,
            ref bool? attachment,
            ref string? delimiter,
            ref bool? bom,
            ref string? xmlRoot,
            ref string? xmlRow,
            ref bool? skipHeaderRow,
            ref bool? skipHidden,
            ref bool? skipEmpty,
            ref bool? simplified,
            ref bool? skipFailedPages,
            object request);
        partial void PrepareActRunSyncGetDatasetItemsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string actorId,
            double? timeout,
            double? memory,
            double? maxItems,
            double? maxTotalChargeUsd,
            bool? restartOnError,
            string? build,
            string? webhooks,
            string? format,
            bool? clean,
            double? offset,
            double? limit,
            string? fields,
            string? omit,
            string? unwind,
            string? flatten,
            bool? desc,
            bool? attachment,
            string? delimiter,
            bool? bom,
            string? xmlRoot,
            string? xmlRow,
            bool? skipHeaderRow,
            bool? skipHidden,
            bool? skipEmpty,
            bool? simplified,
            bool? skipFailedPages,
            object request);
        partial void ProcessActRunSyncGetDatasetItemsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActRunSyncGetDatasetItemsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Run Actor synchronously with input and get dataset items<br/>
        /// Runs a specific Actor and returns its dataset items.<br/>
        /// The POST payload including its `Content-Type` header is passed as `INPUT` to<br/>
        /// the Actor (usually `application/json`).<br/>
        /// The HTTP response contains the Actors dataset items, while the format of<br/>
        /// items depends on specifying dataset items' `format` parameter.<br/>
        /// You can send all the same options in parameters as the [Get Dataset<br/>
        /// Items](#/reference/datasets/item-collection/get-items) API endpoint.<br/>
        /// The Actor is started with the default options; you can override them using<br/>
        /// URL query parameters.<br/>
        /// If the Actor run exceeds 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds,<br/>
        /// the HTTP response will return the 408 status code (Request Timeout).<br/>
        /// Beware that it might be impossible to maintain an idle HTTP connection for a<br/>
        /// long period of time,<br/>
        /// due to client timeout or network conditions. Make sure your HTTP client is<br/>
        /// configured to have a long enough connection timeout.<br/>
        /// If the connection breaks, you will not receive any information about the run<br/>
        /// and its status.<br/>
        /// To run the Actor asynchronously, use the [Run<br/>
        /// Actor](#/reference/actors/run-collection/run-actor) API endpoint instead.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="timeout">
        /// Example: 60
        /// </param>
        /// <param name="memory">
        /// Example: 256
        /// </param>
        /// <param name="maxItems">
        /// Example: 1000
        /// </param>
        /// <param name="maxTotalChargeUsd">
        /// Example: 5
        /// </param>
        /// <param name="restartOnError">
        /// Example: false
        /// </param>
        /// <param name="build">
        /// Example: 0.1.234
        /// </param>
        /// <param name="webhooks">
        /// Example: dGhpcyBpcyBqdXN0IGV4YW1wbGUK...
        /// </param>
        /// <param name="format">
        /// Example: json
        /// </param>
        /// <param name="clean">
        /// Example: false
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit"></param>
        /// <param name="fields">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="omit">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="unwind">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="flatten">
        /// Example: myValue
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="attachment">
        /// Example: true
        /// </param>
        /// <param name="delimiter">
        /// Example: ;
        /// </param>
        /// <param name="bom">
        /// Example: false
        /// </param>
        /// <param name="xmlRoot">
        /// Example: items
        /// </param>
        /// <param name="xmlRow">
        /// Example: item
        /// </param>
        /// <param name="skipHeaderRow">
        /// Example: true
        /// </param>
        /// <param name="skipHidden">
        /// Example: false
        /// </param>
        /// <param name="skipEmpty">
        /// Example: false
        /// </param>
        /// <param name="simplified">
        /// Example: false
        /// </param>
        /// <param name="skipFailedPages">
        /// Example: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> ActRunSyncGetDatasetItemsPostAsync(
            string actorId,

            object request,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            string? webhooks = default,
            string? format = default,
            bool? clean = default,
            double? offset = default,
            double? limit = default,
            string? fields = default,
            string? omit = default,
            string? unwind = default,
            string? flatten = default,
            bool? desc = default,
            bool? attachment = default,
            string? delimiter = default,
            bool? bom = default,
            string? xmlRoot = default,
            string? xmlRow = default,
            bool? skipHeaderRow = default,
            bool? skipHidden = default,
            bool? skipEmpty = default,
            bool? simplified = default,
            bool? skipFailedPages = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ActRunSyncGetDatasetItemsPostAsResponseAsync(
                actorId: actorId,

                request: request,
                timeout: timeout,
                memory: memory,
                maxItems: maxItems,
                maxTotalChargeUsd: maxTotalChargeUsd,
                restartOnError: restartOnError,
                build: build,
                webhooks: webhooks,
                format: format,
                clean: clean,
                offset: offset,
                limit: limit,
                fields: fields,
                omit: omit,
                unwind: unwind,
                flatten: flatten,
                desc: desc,
                attachment: attachment,
                delimiter: delimiter,
                bom: bom,
                xmlRoot: xmlRoot,
                xmlRow: xmlRow,
                skipHeaderRow: skipHeaderRow,
                skipHidden: skipHidden,
                skipEmpty: skipEmpty,
                simplified: simplified,
                skipFailedPages: skipFailedPages,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Run Actor synchronously with input and get dataset items<br/>
        /// Runs a specific Actor and returns its dataset items.<br/>
        /// The POST payload including its `Content-Type` header is passed as `INPUT` to<br/>
        /// the Actor (usually `application/json`).<br/>
        /// The HTTP response contains the Actors dataset items, while the format of<br/>
        /// items depends on specifying dataset items' `format` parameter.<br/>
        /// You can send all the same options in parameters as the [Get Dataset<br/>
        /// Items](#/reference/datasets/item-collection/get-items) API endpoint.<br/>
        /// The Actor is started with the default options; you can override them using<br/>
        /// URL query parameters.<br/>
        /// If the Actor run exceeds 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds,<br/>
        /// the HTTP response will return the 408 status code (Request Timeout).<br/>
        /// Beware that it might be impossible to maintain an idle HTTP connection for a<br/>
        /// long period of time,<br/>
        /// due to client timeout or network conditions. Make sure your HTTP client is<br/>
        /// configured to have a long enough connection timeout.<br/>
        /// If the connection breaks, you will not receive any information about the run<br/>
        /// and its status.<br/>
        /// To run the Actor asynchronously, use the [Run<br/>
        /// Actor](#/reference/actors/run-collection/run-actor) API endpoint instead.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="timeout">
        /// Example: 60
        /// </param>
        /// <param name="memory">
        /// Example: 256
        /// </param>
        /// <param name="maxItems">
        /// Example: 1000
        /// </param>
        /// <param name="maxTotalChargeUsd">
        /// Example: 5
        /// </param>
        /// <param name="restartOnError">
        /// Example: false
        /// </param>
        /// <param name="build">
        /// Example: 0.1.234
        /// </param>
        /// <param name="webhooks">
        /// Example: dGhpcyBpcyBqdXN0IGV4YW1wbGUK...
        /// </param>
        /// <param name="format">
        /// Example: json
        /// </param>
        /// <param name="clean">
        /// Example: false
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit"></param>
        /// <param name="fields">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="omit">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="unwind">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="flatten">
        /// Example: myValue
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="attachment">
        /// Example: true
        /// </param>
        /// <param name="delimiter">
        /// Example: ;
        /// </param>
        /// <param name="bom">
        /// Example: false
        /// </param>
        /// <param name="xmlRoot">
        /// Example: items
        /// </param>
        /// <param name="xmlRow">
        /// Example: item
        /// </param>
        /// <param name="skipHeaderRow">
        /// Example: true
        /// </param>
        /// <param name="skipHidden">
        /// Example: false
        /// </param>
        /// <param name="skipEmpty">
        /// Example: false
        /// </param>
        /// <param name="simplified">
        /// Example: false
        /// </param>
        /// <param name="skipFailedPages">
        /// Example: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::System.Collections.Generic.IList<object>>> ActRunSyncGetDatasetItemsPostAsResponseAsync(
            string actorId,

            object request,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            string? webhooks = default,
            string? format = default,
            bool? clean = default,
            double? offset = default,
            double? limit = default,
            string? fields = default,
            string? omit = default,
            string? unwind = default,
            string? flatten = default,
            bool? desc = default,
            bool? attachment = default,
            string? delimiter = default,
            bool? bom = default,
            string? xmlRoot = default,
            string? xmlRow = default,
            bool? skipHeaderRow = default,
            bool? skipHidden = default,
            bool? skipEmpty = default,
            bool? simplified = default,
            bool? skipFailedPages = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareActRunSyncGetDatasetItemsPostArguments(
                httpClient: HttpClient,
                actorId: ref actorId,
                timeout: ref timeout,
                memory: ref memory,
                maxItems: ref maxItems,
                maxTotalChargeUsd: ref maxTotalChargeUsd,
                restartOnError: ref restartOnError,
                build: ref build,
                webhooks: ref webhooks,
                format: ref format,
                clean: ref clean,
                offset: ref offset,
                limit: ref limit,
                fields: ref fields,
                omit: ref omit,
                unwind: ref unwind,
                flatten: ref flatten,
                desc: ref desc,
                attachment: ref attachment,
                delimiter: ref delimiter,
                bom: ref bom,
                xmlRoot: ref xmlRoot,
                xmlRow: ref xmlRow,
                skipHeaderRow: ref skipHeaderRow,
                skipHidden: ref skipHidden,
                skipEmpty: ref skipEmpty,
                simplified: ref simplified,
                skipFailedPages: ref skipFailedPages,
                request: request);

            var __pathBuilder = new global::Apify.PathBuilder(
                path: $"/v2/acts/{actorId}/run-sync-get-dataset-items",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("timeout", timeout?.ToString())
                .AddOptionalParameter("memory", memory?.ToString())
                .AddOptionalParameter("maxItems", maxItems?.ToString())
                .AddOptionalParameter("maxTotalChargeUsd", maxTotalChargeUsd?.ToString())
                .AddOptionalParameter("restartOnError", restartOnError?.ToString().ToLowerInvariant())
                .AddOptionalParameter("build", build)
                .AddOptionalParameter("webhooks", webhooks)
                .AddOptionalParameter("format", format)
                .AddOptionalParameter("clean", clean?.ToString().ToLowerInvariant())
                .AddOptionalParameter("offset", offset?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("fields", fields)
                .AddOptionalParameter("omit", omit)
                .AddOptionalParameter("unwind", unwind)
                .AddOptionalParameter("flatten", flatten)
                .AddOptionalParameter("desc", desc?.ToString().ToLowerInvariant())
                .AddOptionalParameter("attachment", attachment?.ToString().ToLowerInvariant())
                .AddOptionalParameter("delimiter", delimiter)
                .AddOptionalParameter("bom", bom?.ToString().ToLowerInvariant())
                .AddOptionalParameter("xmlRoot", xmlRoot)
                .AddOptionalParameter("xmlRow", xmlRow)
                .AddOptionalParameter("skipHeaderRow", skipHeaderRow?.ToString().ToLowerInvariant())
                .AddOptionalParameter("skipHidden", skipHidden?.ToString().ToLowerInvariant())
                .AddOptionalParameter("skipEmpty", skipEmpty?.ToString().ToLowerInvariant())
                .AddOptionalParameter("simplified", simplified?.ToString().ToLowerInvariant())
                .AddOptionalParameter("skipFailedPages", skipFailedPages?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActRunSyncGetDatasetItemsPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                actorId: actorId,
                timeout: timeout,
                memory: memory,
                maxItems: maxItems,
                maxTotalChargeUsd: maxTotalChargeUsd,
                restartOnError: restartOnError,
                build: build,
                webhooks: webhooks,
                format: format,
                clean: clean,
                offset: offset,
                limit: limit,
                fields: fields,
                omit: omit,
                unwind: unwind,
                flatten: flatten,
                desc: desc,
                attachment: attachment,
                delimiter: delimiter,
                bom: bom,
                xmlRoot: xmlRoot,
                xmlRow: xmlRow,
                skipHeaderRow: skipHeaderRow,
                skipHidden: skipHidden,
                skipEmpty: skipEmpty,
                simplified: simplified,
                skipFailedPages: skipFailedPages,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActRunSyncGetDatasetItemsPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Apify.ActorRunFailedError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Apify.ActorRunFailedError.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Apify.ActorRunFailedError.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ActorRunFailedError>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Not found - the requested resource was not found.
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::Apify.ActorNotFoundError? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::Apify.ActorNotFoundError.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::Apify.ActorNotFoundError.FromJson(__content_404, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ActorNotFoundError>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 408)
            {
                string? __content_408 = null;
                global::System.Exception? __exception_408 = null;
                global::Apify.ActorRunTimeoutExceededError? __value_408 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_408 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_408 = global::Apify.ActorRunTimeoutExceededError.FromJson(__content_408, JsonSerializerContext);
                    }
                    else
                    {
                        __content_408 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_408 = global::Apify.ActorRunTimeoutExceededError.FromJson(__content_408, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_408 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ActorRunTimeoutExceededError>(
                    message: __content_408 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_408,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_408,
                    ResponseObject = __value_408,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Too many requests - rate limit exceeded.
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::Apify.ErrorResponse? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::Apify.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::Apify.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessActRunSyncGetDatasetItemsPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __value = (global::System.Collections.Generic.IList<object>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<object>), JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                    return new global::Apify.AutoSDKHttpResponse<global::System.Collections.Generic.IList<object>>(
                        statusCode: __response.StatusCode,
                        headers: global::Apify.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __value);
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Apify.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    var __value = (global::System.Collections.Generic.IList<object>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<object>), JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                    return new global::Apify.AutoSDKHttpResponse<global::System.Collections.Generic.IList<object>>(
                        statusCode: __response.StatusCode,
                        headers: global::Apify.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __value);
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Apify.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Run Actor synchronously with input and get dataset items<br/>
        /// Runs a specific Actor and returns its dataset items.<br/>
        /// The POST payload including its `Content-Type` header is passed as `INPUT` to<br/>
        /// the Actor (usually `application/json`).<br/>
        /// The HTTP response contains the Actors dataset items, while the format of<br/>
        /// items depends on specifying dataset items' `format` parameter.<br/>
        /// You can send all the same options in parameters as the [Get Dataset<br/>
        /// Items](#/reference/datasets/item-collection/get-items) API endpoint.<br/>
        /// The Actor is started with the default options; you can override them using<br/>
        /// URL query parameters.<br/>
        /// If the Actor run exceeds 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds,<br/>
        /// the HTTP response will return the 408 status code (Request Timeout).<br/>
        /// Beware that it might be impossible to maintain an idle HTTP connection for a<br/>
        /// long period of time,<br/>
        /// due to client timeout or network conditions. Make sure your HTTP client is<br/>
        /// configured to have a long enough connection timeout.<br/>
        /// If the connection breaks, you will not receive any information about the run<br/>
        /// and its status.<br/>
        /// To run the Actor asynchronously, use the [Run<br/>
        /// Actor](#/reference/actors/run-collection/run-actor) API endpoint instead.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="timeout">
        /// Example: 60
        /// </param>
        /// <param name="memory">
        /// Example: 256
        /// </param>
        /// <param name="maxItems">
        /// Example: 1000
        /// </param>
        /// <param name="maxTotalChargeUsd">
        /// Example: 5
        /// </param>
        /// <param name="restartOnError">
        /// Example: false
        /// </param>
        /// <param name="build">
        /// Example: 0.1.234
        /// </param>
        /// <param name="webhooks">
        /// Example: dGhpcyBpcyBqdXN0IGV4YW1wbGUK...
        /// </param>
        /// <param name="format">
        /// Example: json
        /// </param>
        /// <param name="clean">
        /// Example: false
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit"></param>
        /// <param name="fields">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="omit">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="unwind">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="flatten">
        /// Example: myValue
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="attachment">
        /// Example: true
        /// </param>
        /// <param name="delimiter">
        /// Example: ;
        /// </param>
        /// <param name="bom">
        /// Example: false
        /// </param>
        /// <param name="xmlRoot">
        /// Example: items
        /// </param>
        /// <param name="xmlRow">
        /// Example: item
        /// </param>
        /// <param name="skipHeaderRow">
        /// Example: true
        /// </param>
        /// <param name="skipHidden">
        /// Example: false
        /// </param>
        /// <param name="skipEmpty">
        /// Example: false
        /// </param>
        /// <param name="simplified">
        /// Example: false
        /// </param>
        /// <param name="skipFailedPages">
        /// Example: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> ActRunSyncGetDatasetItemsPostAsync(
            string actorId,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            string? webhooks = default,
            string? format = default,
            bool? clean = default,
            double? offset = default,
            double? limit = default,
            string? fields = default,
            string? omit = default,
            string? unwind = default,
            string? flatten = default,
            bool? desc = default,
            bool? attachment = default,
            string? delimiter = default,
            bool? bom = default,
            string? xmlRoot = default,
            string? xmlRow = default,
            bool? skipHeaderRow = default,
            bool? skipHidden = default,
            bool? skipEmpty = default,
            bool? simplified = default,
            bool? skipFailedPages = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new object
            {
            };

            return await ActRunSyncGetDatasetItemsPostAsync(
                actorId: actorId,
                timeout: timeout,
                memory: memory,
                maxItems: maxItems,
                maxTotalChargeUsd: maxTotalChargeUsd,
                restartOnError: restartOnError,
                build: build,
                webhooks: webhooks,
                format: format,
                clean: clean,
                offset: offset,
                limit: limit,
                fields: fields,
                omit: omit,
                unwind: unwind,
                flatten: flatten,
                desc: desc,
                attachment: attachment,
                delimiter: delimiter,
                bom: bom,
                xmlRoot: xmlRoot,
                xmlRow: xmlRow,
                skipHeaderRow: skipHeaderRow,
                skipHidden: skipHidden,
                skipEmpty: skipEmpty,
                simplified: simplified,
                skipFailedPages: skipFailedPages,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}