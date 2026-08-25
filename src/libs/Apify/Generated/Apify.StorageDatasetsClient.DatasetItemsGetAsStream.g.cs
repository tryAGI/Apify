
#nullable enable

namespace Apify
{
    public partial class StorageDatasetsClient
    {


        private static readonly global::Apify.EndPointSecurityRequirement s_DatasetItemsGetAsStreamSecurityRequirement0 =
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
        private static readonly global::Apify.EndPointSecurityRequirement[] s_DatasetItemsGetAsStreamSecurityRequirements =
            new global::Apify.EndPointSecurityRequirement[]
            {                s_DatasetItemsGetAsStreamSecurityRequirement0,
            };
        partial void PrepareDatasetItemsGetAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
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
        partial void PrepareDatasetItemsGetAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
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
        partial void ProcessDatasetItemsGetAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Get dataset items<br/>
        /// Returns data stored in the dataset in a desired format.<br/>
        /// ### Response format<br/>
        /// The format of the response depends on &lt;code&gt;format&lt;/code&gt; query parameter.<br/>
        /// The &lt;code&gt;format&lt;/code&gt; parameter can have one of the following values:<br/>
        /// &lt;code&gt;json&lt;/code&gt;, &lt;code&gt;jsonl&lt;/code&gt;, &lt;code&gt;xml&lt;/code&gt;, &lt;code&gt;html&lt;/code&gt;,<br/>
        /// &lt;code&gt;csv&lt;/code&gt;, &lt;code&gt;xlsx&lt;/code&gt; and &lt;code&gt;rss&lt;/code&gt;.<br/>
        /// The following table describes how each format is treated.<br/>
        /// &lt;table&gt;<br/>
        ///   &lt;tr&gt;<br/>
        ///     &lt;th&gt;Format&lt;/th&gt;<br/>
        ///     &lt;th&gt;Items&lt;/th&gt;<br/>
        ///   &lt;/tr&gt;<br/>
        ///   &lt;tr&gt;<br/>
        ///     &lt;td&gt;&lt;code&gt;json&lt;/code&gt;&lt;/td&gt;<br/>
        ///     &lt;td rowspan="3"&gt;The response is a JSON, JSONL or XML array of raw item objects.&lt;/td&gt;<br/>
        ///   &lt;/tr&gt;<br/>
        ///   &lt;tr&gt;<br/>
        ///     &lt;td&gt;&lt;code&gt;jsonl&lt;/code&gt;&lt;/td&gt;<br/>
        ///   &lt;/tr&gt;<br/>
        ///   &lt;tr&gt;<br/>
        ///     &lt;td&gt;&lt;code&gt;xml&lt;/code&gt;&lt;/td&gt;<br/>
        ///   &lt;/tr&gt;<br/>
        ///   &lt;tr&gt;<br/>
        ///     &lt;td&gt;&lt;code&gt;html&lt;/code&gt;&lt;/td&gt;<br/>
        ///     &lt;td rowspan="3"&gt;The response is a HTML, CSV or XLSX table, where columns correspond to the<br/>
        ///     properties of the item and rows correspond to each dataset item.&lt;/td&gt;<br/>
        ///   &lt;/tr&gt;<br/>
        ///   &lt;tr&gt;<br/>
        ///     &lt;td&gt;&lt;code&gt;csv&lt;/code&gt;&lt;/td&gt;<br/>
        ///   &lt;/tr&gt;<br/>
        ///   &lt;tr&gt;<br/>
        ///     &lt;td&gt;&lt;code&gt;xlsx&lt;/code&gt;&lt;/td&gt;<br/>
        ///   &lt;/tr&gt;<br/>
        ///   &lt;tr&gt;<br/>
        ///     &lt;td&gt;&lt;code&gt;rss&lt;/code&gt;&lt;/td&gt;<br/>
        ///     &lt;td colspan="2"&gt;The response is a RSS file. Each item is displayed as child elements of one<br/>
        ///     &lt;code&gt;&amp;lt;item&amp;gt;&lt;/code&gt;.&lt;/td&gt;<br/>
        ///   &lt;/tr&gt;<br/>
        /// &lt;/table&gt;<br/>
        /// Note that CSV, XLSX and HTML tables are limited to 2000 columns and the column names cannot be longer than 200 characters.<br/>
        /// JSON, XML and RSS formats do not have such restrictions.<br/>
        /// ### Hidden fields<br/>
        /// The top-level fields starting with the `#` character are considered hidden.<br/>
        /// These are useful to store debugging information and can be omitted from the output by providing the `skipHidden=1` or `clean=1` query parameters.<br/>
        /// For example, if you store the following object to the dataset:<br/>
        /// ```<br/>
        /// {<br/>
        ///     productName: "iPhone Xs",<br/>
        ///     description: "Welcome to the big screens."<br/>
        ///     #debug: {<br/>
        ///         url: "https://www.apple.com/lae/iphone-xs/",<br/>
        ///         crawledAt: "2019-01-21T16:06:03.683Z"<br/>
        ///     }<br/>
        /// }<br/>
        /// ```<br/>
        /// The `#debug` field will be considered as hidden and can be omitted from the<br/>
        /// results. This is useful to<br/>
        /// provide nice cleaned data to end users, while keeping debugging info<br/>
        /// available if needed. The Dataset object<br/>
        /// returned by the API contains the number of such clean items in the`dataset.cleanItemCount` property.<br/>
        /// ### XML format extension<br/>
        /// When exporting results to XML or RSS formats, the names of object properties become XML tags and the corresponding values become tag's children. For example, the following JavaScript object:<br/>
        /// ```<br/>
        /// {<br/>
        ///     name: "Paul Newman",<br/>
        ///     address: [<br/>
        ///         { type: "home", street: "21st", city: "Chicago" },<br/>
        ///         { type: "office", street: null, city: null }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```<br/>
        /// will be transformed to the following XML snippet:<br/>
        /// ```<br/>
        /// &lt;name&gt;Paul Newman&lt;/name&gt;<br/>
        /// &lt;address&gt;<br/>
        ///   &lt;type&gt;home&lt;/type&gt;<br/>
        ///   &lt;street&gt;21st&lt;/street&gt;<br/>
        ///   &lt;city&gt;Chicago&lt;/city&gt;<br/>
        /// &lt;/address&gt;<br/>
        /// &lt;address&gt;<br/>
        ///   &lt;type&gt;office&lt;/type&gt;<br/>
        ///   &lt;street/&gt;<br/>
        ///   &lt;city/&gt;<br/>
        /// &lt;/address&gt;<br/>
        /// ```<br/>
        /// If the JavaScript object contains a property named `@` then its sub-properties are exported as attributes of the parent XML<br/>
        /// element.<br/>
        /// If the parent XML element does not have any child elements then its value is taken from a JavaScript object property named `#`.<br/>
        /// For example, the following JavaScript object:<br/>
        /// ```<br/>
        /// {<br/>
        ///   "address": [{<br/>
        ///     "@": {<br/>
        ///       "type": "home"<br/>
        ///     },<br/>
        ///     "street": "21st",<br/>
        ///     "city": "Chicago"<br/>
        ///   },<br/>
        ///   {<br/>
        ///     "@": {<br/>
        ///       "type": "office"<br/>
        ///     },<br/>
        ///     "#": 'unknown'<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```<br/>
        /// will be transformed to the following XML snippet:<br/>
        /// ```<br/>
        /// &lt;address type="home"&gt;<br/>
        ///   &lt;street&gt;21st&lt;/street&gt;<br/>
        ///   &lt;city&gt;Chicago&lt;/city&gt;<br/>
        /// &lt;/address&gt;<br/>
        /// &lt;address type="office"&gt;unknown&lt;/address&gt;<br/>
        /// ```<br/>
        /// This feature is also useful to customize your RSS feeds generated for various websites.<br/>
        /// By default the whole result is wrapped in a `&lt;items&gt;` element and each page object is wrapped in a `&lt;item&gt;` element.<br/>
        /// You can change this using &lt;code&gt;xmlRoot&lt;/code&gt; and &lt;code&gt;xmlRow&lt;/code&gt; url parameters.<br/>
        /// ### Pagination<br/>
        /// The generated response supports [pagination](#/introduction/pagination).<br/>
        /// The pagination is always performed with the granularity of a single item, regardless whether &lt;code&gt;unwind&lt;/code&gt; parameter was provided.<br/>
        /// By default, the **Items** in the response are sorted by the time they were stored to the database, therefore you can use pagination to incrementally fetch the items as they are being added.<br/>
        /// No limit exists to how many items can be returned in one response.<br/>
        /// If you specify `desc=1` query parameter, the results are returned in the reverse order than they were stored (i.e. from newest to oldest items).<br/>
        /// Note that only the order of **Items** is reversed, but not the order of the `unwind` array elements.
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
        public async global::System.Collections.Generic.IAsyncEnumerable<string> DatasetItemsGetAsStreamAsync(
            string datasetId,
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
            PrepareDatasetItemsGetAsStreamArguments(
                httpClient: HttpClient,
                datasetId: ref datasetId,
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
                securityRequirements: s_DatasetItemsGetAsStreamSecurityRequirements,
                operationName: "DatasetItemsGetAsStreamAsync");

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

                __httpRequest.Headers.TryAddWithoutValidation(
                    "Accept",
                    "application/jsonl");

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
                PrepareDatasetItemsGetAsStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    datasetId: datasetId!,
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
                                operationId: "DatasetItemsGetAsStream",
                                methodName: "DatasetItemsGetAsStreamAsync",
                                pathTemplate: "$\"/v2/datasets/{datasetId}/items\"",
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
                                operationId: "DatasetItemsGetAsStream",
                                methodName: "DatasetItemsGetAsStreamAsync",
                                pathTemplate: "$\"/v2/datasets/{datasetId}/items\"",
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
                                operationId: "DatasetItemsGetAsStream",
                                methodName: "DatasetItemsGetAsStreamAsync",
                                pathTemplate: "$\"/v2/datasets/{datasetId}/items\"",
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
                ProcessDatasetItemsGetAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Apify.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Apify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DatasetItemsGetAsStream",
                                methodName: "DatasetItemsGetAsStreamAsync",
                                pathTemplate: "$\"/v2/datasets/{datasetId}/items\"",
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
                                operationId: "DatasetItemsGetAsStream",
                                methodName: "DatasetItemsGetAsStreamAsync",
                                pathTemplate: "$\"/v2/datasets/{datasetId}/items\"",
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

                                var __streamedResponse = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(string), JsonSerializerContext) ??
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