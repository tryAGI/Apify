
#nullable enable

namespace Apify
{
    public partial class StoreClient
    {
        partial void PrepareStoreGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref double? limit,
            ref double? offset,
            ref string? search,
            ref string? sortBy,
            ref string? category,
            ref string? username,
            ref global::Apify.StoreGetPricingModel? pricingModel,
            ref bool? allowsAgenticUsers);
        partial void PrepareStoreGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            double? limit,
            double? offset,
            string? search,
            string? sortBy,
            string? category,
            string? username,
            global::Apify.StoreGetPricingModel? pricingModel,
            bool? allowsAgenticUsers);
        partial void ProcessStoreGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStoreGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get list of Actors in store<br/>
        /// Gets the list of public Actors in Apify Store. You can use `search`<br/>
        /// parameter to search Actors by string in title, name, description, username<br/>
        /// and readme.<br/>
        /// If you need detailed info about a specific Actor, use the [Get<br/>
        /// Actor](#/reference/actors/actor-object/get-actor) endpoint.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters.<br/>
        /// It will not return more than 1,000 records.
        /// </summary>
        /// <param name="limit">
        /// Example: 1000
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="search">
        /// Example: web scraper
        /// </param>
        /// <param name="sortBy">
        /// Example: 'popularity'
        /// </param>
        /// <param name="category">
        /// Example: 'AI'
        /// </param>
        /// <param name="username">
        /// Example: 'apify'
        /// </param>
        /// <param name="pricingModel">
        /// Example: FREE
        /// </param>
        /// <param name="allowsAgenticUsers">
        /// Example: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Apify.ListOfActorsInStoreResponse> StoreGetAsync(
            double? limit = default,
            double? offset = default,
            string? search = default,
            string? sortBy = default,
            string? category = default,
            string? username = default,
            global::Apify.StoreGetPricingModel? pricingModel = default,
            bool? allowsAgenticUsers = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareStoreGetArguments(
                httpClient: HttpClient,
                limit: ref limit,
                offset: ref offset,
                search: ref search,
                sortBy: ref sortBy,
                category: ref category,
                username: ref username,
                pricingModel: ref pricingModel,
                allowsAgenticUsers: ref allowsAgenticUsers);

            var __pathBuilder = new global::Apify.PathBuilder(
                path: "/v2/store",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("offset", offset?.ToString())
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("sortBy", sortBy)
                .AddOptionalParameter("category", category)
                .AddOptionalParameter("username", username)
                .AddOptionalParameter("pricingModel", pricingModel?.ToValueString())
                .AddOptionalParameter("allowsAgenticUsers", allowsAgenticUsers?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareStoreGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                limit: limit,
                offset: offset,
                search: search,
                sortBy: sortBy,
                category: category,
                username: username,
                pricingModel: pricingModel,
                allowsAgenticUsers: allowsAgenticUsers);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessStoreGetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request - invalid input parameters or request body.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Apify.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Apify.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

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
            // Method not allowed.
            if ((int)__response.StatusCode == 405)
            {
                string? __content_405 = null;
                global::System.Exception? __exception_405 = null;
                global::Apify.ErrorResponse? __value_405 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_405 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_405 = global::Apify.ErrorResponse.FromJson(__content_405, JsonSerializerContext);
                    }
                    else
                    {
                        __content_405 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_405 = global::Apify.ErrorResponse.FromJson(__content_405, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_405 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_405 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_405,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_405,
                    ResponseObject = __value_405,
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
                ProcessStoreGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Apify.ListOfActorsInStoreResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                    return
                        await global::Apify.ListOfActorsInStoreResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
    }
}