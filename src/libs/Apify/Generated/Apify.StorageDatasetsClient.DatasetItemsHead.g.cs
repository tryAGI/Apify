
#nullable enable

namespace Apify
{
    public partial class StorageDatasetsClient
    {


        private static readonly global::Apify.EndPointSecurityRequirement s_DatasetItemsHeadSecurityRequirement0 =
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
        private static readonly global::Apify.EndPointSecurityRequirement[] s_DatasetItemsHeadSecurityRequirements =
            new global::Apify.EndPointSecurityRequirement[]
            {                s_DatasetItemsHeadSecurityRequirement0,
            };
        partial void PrepareDatasetItemsHeadArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
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
            ref string? view,
            ref bool? skipFailedPages,
            ref string? signature);
        partial void PrepareDatasetItemsHeadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
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
            string? view,
            bool? skipFailedPages,
            string? signature);
        partial void ProcessDatasetItemsHeadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Get dataset items headers<br/>
        /// Returns only the HTTP headers for the dataset items endpoint, without the response body.<br/>
        /// This is useful to check pagination metadata or verify access without downloading the full dataset.
        /// </summary>
        /// <param name="datasetId">
        /// Example: WkzbQMuFYuamGv3YF
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
        /// <param name="view">
        /// Example: overview
        /// </param>
        /// <param name="skipFailedPages">
        /// Example: false
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task DatasetItemsHeadAsync(
            string datasetId,
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
            string? view = default,
            bool? skipFailedPages = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDatasetItemsHeadArguments(
                httpClient: HttpClient,
                datasetId: ref datasetId,
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
                view: ref view,
                skipFailedPages: ref skipFailedPages,
                signature: ref signature);


            var __authorizations = global::Apify.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_DatasetItemsHeadSecurityRequirements,
                operationName: "DatasetItemsHeadAsync");

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
                                path: $"/v2/datasets/{datasetId}/items",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
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
                                .AddOptionalParameter("view", view)
                                .AddOptionalParameter("skipFailedPages", skipFailedPages?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("signature", signature) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Apify.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Head,
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
                PrepareDatasetItemsHeadRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    datasetId: datasetId,
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
                    view: view,
                    skipFailedPages: skipFailedPages,
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
                                operationId: "DatasetItemsHead",
                                methodName: "DatasetItemsHeadAsync",
                                pathTemplate: "$\"/v2/datasets/{datasetId}/items\"",
                                httpMethod: "HEAD",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Apify.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Apify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DatasetItemsHead",
                                methodName: "DatasetItemsHeadAsync",
                                pathTemplate: "$\"/v2/datasets/{datasetId}/items\"",
                                httpMethod: "HEAD",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Apify.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Apify.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Apify.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Apify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DatasetItemsHead",
                                methodName: "DatasetItemsHeadAsync",
                                pathTemplate: "$\"/v2/datasets/{datasetId}/items\"",
                                httpMethod: "HEAD",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Apify.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessDatasetItemsHeadResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Apify.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Apify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DatasetItemsHead",
                                methodName: "DatasetItemsHeadAsync",
                                pathTemplate: "$\"/v2/datasets/{datasetId}/items\"",
                                httpMethod: "HEAD",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Apify.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Apify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DatasetItemsHead",
                                methodName: "DatasetItemsHeadAsync",
                                pathTemplate: "$\"/v2/datasets/{datasetId}/items\"",
                                httpMethod: "HEAD",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
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

                                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
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

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}