
#nullable enable

namespace Apify
{
    public partial class StorageKeyValueStoresClient
    {


        private static readonly global::Apify.EndPointSecurityRequirement s_KeyValueStoreRecordPostSecurityRequirement0 =
            new global::Apify.EndPointSecurityRequirement
            {
                Authorizations = new global::Apify.EndPointAuthorizationRequirement[]
                {                    new global::Apify.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Apify.EndPointSecurityRequirement[] s_KeyValueStoreRecordPostSecurityRequirements =
            new global::Apify.EndPointSecurityRequirement[]
            {                s_KeyValueStoreRecordPostSecurityRequirement0,
            };
        partial void PrepareKeyValueStoreRecordPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string storeId,
            ref string recordKey,
            ref global::Apify.KeyValueStoreRecordPostContentEncoding? contentEncoding,
            global::Apify.PutRecordRequest request);
        partial void PrepareKeyValueStoreRecordPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string storeId,
            string recordKey,
            global::Apify.KeyValueStoreRecordPostContentEncoding? contentEncoding,
            global::Apify.PutRecordRequest request);
        partial void ProcessKeyValueStoreRecordPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessKeyValueStoreRecordPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Store record (POST)<br/>
        /// Stores a value under a specific key to the key-value store.<br/>
        /// This endpoint is an alias for the [`PUT` record](#tag/Key-value-storesRecord/operation/keyValueStore_record_put) method and behaves identically.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> KeyValueStoreRecordPostAsync(
            string storeId,
            string recordKey,

            global::Apify.PutRecordRequest request,
            global::Apify.KeyValueStoreRecordPostContentEncoding? contentEncoding = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await KeyValueStoreRecordPostAsResponseAsync(
                storeId: storeId,
                recordKey: recordKey,

                request: request,
                contentEncoding: contentEncoding,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Store record (POST)<br/>
        /// Stores a value under a specific key to the key-value store.<br/>
        /// This endpoint is an alias for the [`PUT` record](#tag/Key-value-storesRecord/operation/keyValueStore_record_put) method and behaves identically.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> KeyValueStoreRecordPostAsResponseAsync(
            string storeId,
            string recordKey,

            global::Apify.PutRecordRequest request,
            global::Apify.KeyValueStoreRecordPostContentEncoding? contentEncoding = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareKeyValueStoreRecordPostArguments(
                httpClient: HttpClient,
                storeId: ref storeId,
                recordKey: ref recordKey,
                contentEncoding: ref contentEncoding,
                request: request);


            var __authorizations = global::Apify.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_KeyValueStoreRecordPostSecurityRequirements,
                operationName: "KeyValueStoreRecordPostAsync");

            var __pathBuilder = new global::Apify.PathBuilder(
                path: $"/v2/key-value-stores/{storeId}/records/{recordKey}",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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

            if (contentEncoding != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Content-Encoding", contentEncoding?.ToValueString() ?? string.Empty);
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareKeyValueStoreRecordPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                storeId: storeId,
                recordKey: recordKey,
                contentEncoding: contentEncoding,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessKeyValueStoreRecordPostResponse(
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
            // Unauthorized - authentication required or invalid token.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::Apify.ErrorResponse? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::Apify.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::Apify.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Forbidden - insufficient permissions to perform this action.
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::Apify.ErrorResponse? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::Apify.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::Apify.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
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
            // Payload too large - the request body exceeds the size limit.
            if ((int)__response.StatusCode == 413)
            {
                string? __content_413 = null;
                global::System.Exception? __exception_413 = null;
                global::Apify.ErrorResponse? __value_413 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_413 = global::Apify.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                    }
                    else
                    {
                        __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_413 = global::Apify.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_413 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_413,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_413,
                    ResponseObject = __value_413,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unsupported media type - the Content-Encoding of the request is not supported.
            if ((int)__response.StatusCode == 415)
            {
                string? __content_415 = null;
                global::System.Exception? __exception_415 = null;
                global::Apify.ErrorResponse? __value_415 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_415 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_415 = global::Apify.ErrorResponse.FromJson(__content_415, JsonSerializerContext);
                    }
                    else
                    {
                        __content_415 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_415 = global::Apify.ErrorResponse.FromJson(__content_415, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_415 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_415 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_415,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_415,
                    ResponseObject = __value_415,
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
                ProcessKeyValueStoreRecordPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return new global::Apify.AutoSDKHttpResponse<string>(
                        statusCode: __response.StatusCode,
                        headers: global::Apify.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __content);
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
                    var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return new global::Apify.AutoSDKHttpResponse<string>(
                        statusCode: __response.StatusCode,
                        headers: global::Apify.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __content);
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
        /// Store record (POST)<br/>
        /// Stores a value under a specific key to the key-value store.<br/>
        /// This endpoint is an alias for the [`PUT` record](#tag/Key-value-storesRecord/operation/keyValueStore_record_put) method and behaves identically.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> KeyValueStoreRecordPostAsync(
            string storeId,
            string recordKey,
            global::Apify.KeyValueStoreRecordPostContentEncoding? contentEncoding = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Apify.PutRecordRequest
            {
            };

            return await KeyValueStoreRecordPostAsync(
                storeId: storeId,
                recordKey: recordKey,
                contentEncoding: contentEncoding,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}