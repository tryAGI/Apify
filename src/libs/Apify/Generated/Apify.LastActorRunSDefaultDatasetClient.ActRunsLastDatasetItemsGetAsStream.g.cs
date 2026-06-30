
#nullable enable

namespace Apify
{
    public partial class LastActorRunSDefaultDatasetClient
    {


        private static readonly global::Apify.EndPointSecurityRequirement s_ActRunsLastDatasetItemsGetAsStreamSecurityRequirement0 =
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
        private static readonly global::Apify.EndPointSecurityRequirement[] s_ActRunsLastDatasetItemsGetAsStreamSecurityRequirements =
            new global::Apify.EndPointSecurityRequirement[]
            {                s_ActRunsLastDatasetItemsGetAsStreamSecurityRequirement0,
            };
        partial void PrepareActRunsLastDatasetItemsGetAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string actorId,
            ref string? status,
            ref global::Apify.RunOrigin? origin,
            ref string? format,
            ref bool? clean,
            ref double? offset,
            ref double? limit,
            ref string? fields,
            ref string? outputFields,
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
            ref string? view,
            ref bool? skipFailedPages,
            ref string? feedTitle,
            ref string? feedDescription,
            ref string? signature);
        partial void PrepareActRunsLastDatasetItemsGetAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string actorId,
            string? status,
            global::Apify.RunOrigin? origin,
            string? format,
            bool? clean,
            double? offset,
            double? limit,
            string? fields,
            string? outputFields,
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
            string? view,
            bool? skipFailedPages,
            string? feedTitle,
            string? feedDescription,
            string? signature);
        partial void ProcessActRunsLastDatasetItemsGetAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Get last run's dataset items<br/>
        /// Returns data stored in the default dataset of the last Actor run in the desired format.<br/>
        /// This endpoint is a shortcut that resolves the last run's `defaultDatasetId` and proxies to the<br/>
        /// [Get dataset items](/api/v2/dataset-items-get) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
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
        /// <param name="outputFields">
        /// Example: title,link
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
        /// <param name="view">
        /// Example: overview
        /// </param>
        /// <param name="skipFailedPages">
        /// Example: false
        /// </param>
        /// <param name="feedTitle">
        /// Example: Latest posts from r/pasta
        /// </param>
        /// <param name="feedDescription">
        /// Example: Scraped forum posts
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::System.Collections.Generic.IList<object>> ActRunsLastDatasetItemsGetAsStreamAsync(
            string actorId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? format = default,
            bool? clean = default,
            double? offset = default,
            double? limit = default,
            string? fields = default,
            string? outputFields = default,
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
            string? view = default,
            bool? skipFailedPages = default,
            string? feedTitle = default,
            string? feedDescription = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareActRunsLastDatasetItemsGetAsStreamArguments(
                httpClient: HttpClient,
                actorId: ref actorId,
                status: ref status,
                origin: ref origin,
                format: ref format,
                clean: ref clean,
                offset: ref offset,
                limit: ref limit,
                fields: ref fields,
                outputFields: ref outputFields,
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
                view: ref view,
                skipFailedPages: ref skipFailedPages,
                feedTitle: ref feedTitle,
                feedDescription: ref feedDescription,
                signature: ref signature);


            var __authorizations = global::Apify.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ActRunsLastDatasetItemsGetAsStreamSecurityRequirements,
                operationName: "ActRunsLastDatasetItemsGetAsStreamAsync");

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
                                path: $"/v2/actors/{actorId}/runs/last/dataset/items",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("status", status)
                                .AddOptionalParameter("origin", origin?.ToValueString())
                                .AddOptionalParameter("format", format)
                                .AddOptionalParameter("clean", clean?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("fields", fields)
                                .AddOptionalParameter("outputFields", outputFields)
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
                                .AddOptionalParameter("view", view)
                                .AddOptionalParameter("skipFailedPages", skipFailedPages?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("feedTitle", feedTitle)
                                .AddOptionalParameter("feedDescription", feedDescription)
                                .AddOptionalParameter("signature", signature)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Apify.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::Apify.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareActRunsLastDatasetItemsGetAsStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    actorId: actorId!,
                    status: status,
                    origin: origin,
                    format: format,
                    clean: clean,
                    offset: offset,
                    limit: limit,
                    fields: fields,
                    outputFields: outputFields,
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
                    view: view,
                    skipFailedPages: skipFailedPages,
                    feedTitle: feedTitle,
                    feedDescription: feedDescription,
                    signature: signature);

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
                                operationId: "ActRunsLastDatasetItemsGetAsStream",
                                methodName: "ActRunsLastDatasetItemsGetAsStreamAsync",
                                pathTemplate: "$\"/v2/actors/{actorId}/runs/last/dataset/items\"",
                                httpMethod: "GET",
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
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
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
                                operationId: "ActRunsLastDatasetItemsGetAsStream",
                                methodName: "ActRunsLastDatasetItemsGetAsStreamAsync",
                                pathTemplate: "$\"/v2/actors/{actorId}/runs/last/dataset/items\"",
                                httpMethod: "GET",
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
                                operationId: "ActRunsLastDatasetItemsGetAsStream",
                                methodName: "ActRunsLastDatasetItemsGetAsStreamAsync",
                                pathTemplate: "$\"/v2/actors/{actorId}/runs/last/dataset/items\"",
                                httpMethod: "GET",
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
                ProcessActRunsLastDatasetItemsGetAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Apify.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Apify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ActRunsLastDatasetItemsGetAsStream",
                                methodName: "ActRunsLastDatasetItemsGetAsStreamAsync",
                                pathTemplate: "$\"/v2/actors/{actorId}/runs/last/dataset/items\"",
                                httpMethod: "GET",
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
                                operationId: "ActRunsLastDatasetItemsGetAsStream",
                                methodName: "ActRunsLastDatasetItemsGetAsStreamAsync",
                                pathTemplate: "$\"/v2/actors/{actorId}/runs/last/dataset/items\"",
                                httpMethod: "GET",
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

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
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

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            using var __reader = new global::System.IO.StreamReader(__stream);

                            while (!__reader.EndOfStream && !__effectiveCancellationToken.IsCancellationRequested)
                            {
                                var __content = await __reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                                if (global::System.String.IsNullOrWhiteSpace(__content))
                                {
                                    continue;
                                }

                                var __streamedResponse = (global::System.Collections.Generic.IList<object>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<object>), JsonSerializerContext) ??
                                                       throw global::Apify.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}