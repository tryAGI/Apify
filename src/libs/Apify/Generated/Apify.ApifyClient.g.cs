
#nullable enable

namespace Apify
{
    /// <summary>
    /// The Apify API (version 2) provides programmatic access to the [Apify<br/>
    /// platform](https://docs.apify.com). The API is organized<br/>
    /// around [RESTful](https://en.wikipedia.org/wiki/Representational_state_transfer)<br/>
    /// HTTP endpoints.<br/>
    /// You can download the complete OpenAPI schema of Apify API in the [YAML](http://docs.apify.com/api/openapi.yaml) or [JSON](http://docs.apify.com/api/openapi.json) formats. The source code is also available on [GitHub](https://github.com/apify/apify-docs/tree/master/apify-api/openapi).<br/>
    /// All requests and responses (including errors) are encoded in<br/>
    /// [JSON](http://www.json.org/) format with UTF-8 encoding,<br/>
    /// with a few exceptions that are explicitly described in the reference.<br/>
    /// To access the API, we recommend using one of our API clients:<br/>
    /// Stable API clients:<br/>
    /// - For [Node.js](https://nodejs.org/en/), we recommend the [`apify-client`](https://docs.apify.com/api/client/js) [NPM<br/>
    /// package](https://www.npmjs.com/package/apify-client).<br/>
    /// - For [Python](https://www.python.org/), we recommend the [`apify-client`](https://docs.apify.com/api/client/python) [PyPI<br/>
    /// package](https://pypi.org/project/apify-client/).<br/>
    /// Experimental API clients:<br/>
    /// - For [Java](https://www.java.com/), we recommend the `apify-client` [Maven central component](https://central.sonatype.com/artifact/com.apify/apify-client).<br/>
    /// - For [Rust](https://rust-lang.org/), we recommend the `apify-client` [crate](https://crates.io/crates/apify-client).<br/>
    /// - For [.NET](https://dotnet.microsoft.com/), we recommend the `apify-client` [Nuget package](https://www.nuget.org/packages/Apify.Client).<br/>
    /// - For [PHP](https://www.php.net/), we recommend the `apify-client` [Packagist package](https://packagist.org/packages/apify/apify-client).<br/>
    /// - For [Go](https://go.dev/), we recommend the `apify-client` [package](https://github.com/apify/apify-client-go/releases).<br/>
    /// The clients' functions correspond to the API endpoints and have the same<br/>
    /// parameters. This simplifies development of apps that depend on the Apify<br/>
    /// platform.<br/>
    /// :::note Important Request Details<br/>
    /// - `Content-Type` header: For requests with a JSON body, you must include the `Content-Type: application/json` header.<br/>
    /// - Method override: You can override the HTTP method using the `method` query parameter. This is useful for clients that can only send `GET` requests. For example, to call a `POST` endpoint, append `?method=POST` to the URL of your `GET` request.<br/>
    /// :::<br/>
    /// ## Authentication<br/>
    /// &lt;span id="/introduction/authentication"&gt;&lt;/span&gt;<br/>
    /// **You can find your API token on the<br/>
    /// [Integrations](https://console.apify.com/settings/integrations) page in the<br/>
    /// Apify Console.**<br/>
    /// To use your token in a request, either:<br/>
    /// - Add the token to your request's `Authorization` header as `Bearer &lt;token&gt;`.<br/>
    /// E.g., `Authorization: Bearer xxxxxxx`.<br/>
    /// [More info](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Authorization).<br/>
    /// (Recommended).<br/>
    /// - Add it as the `token` parameter to your request URL. (Less secure).<br/>
    /// Using your token in the request header is more secure than using it as a URL<br/>
    /// parameter because URLs are often stored<br/>
    /// in browser history and server logs. This creates a chance for someone<br/>
    /// unauthorized to access your API token.<br/>
    /// **Never share your API token or password with untrusted parties!**<br/>
    /// For more information, see our<br/>
    /// [integrations](https://docs.apify.com/platform/integrations) documentation.<br/>
    /// ### Agentic payments<br/>
    /// AI agents can authenticate and pay for Actor runs without an Apify account<br/>
    /// using agentic payments. Instead of an API token, the request carries a<br/>
    /// payment credential that both authorizes and pays for the call. Apify supports<br/>
    /// the [x402 protocol](https://docs.apify.com/platform/integrations/x402)<br/>
    /// (`PAYMENT-SIGNATURE` header) and<br/>
    /// [Skyfire](https://docs.apify.com/platform/integrations/skyfire)<br/>
    /// (`skyfire-pay-id` header).<br/>
    /// ## Basic usage<br/>
    /// &lt;span id="/introduction/basic-usage"&gt;&lt;/span&gt;<br/>
    /// To run an Actor, send a POST request to the [Run<br/>
    /// Actor](#/reference/actors/run-collection/run-actor) endpoint using either the<br/>
    /// Actor ID code (e.g. `vKg4IjxZbEYTYeW8T`) or its name (e.g.<br/>
    /// `janedoe~my-actor`):<br/>
    /// `https://api.apify.com/v2/actors/[actor_id]/runs`<br/>
    /// If the Actor is not runnable anonymously, you will receive a 401 or 403<br/>
    /// [response code](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status).<br/>
    /// This means you need to add your [secret API<br/>
    /// token](https://console.apify.com/account#/integrations) to the request's<br/>
    /// `Authorization` header ([recommended](#/introduction/authentication)) or as a<br/>
    /// URL query parameter `?token=[your_token]` (less secure).<br/>
    /// Optionally, you can include the query parameters described in the [Run<br/>
    /// Actor](#/reference/actors/run-collection/run-actor) section to customize your<br/>
    /// run.<br/>
    /// If you're using Node.js, the best way to run an Actor is using the<br/>
    /// `Apify.call()` method from the [Apify<br/>
    /// SDK](https://sdk.apify.com/docs/api/apify#apifycallactid-input-options). It<br/>
    /// runs the Actor using the account you are currently logged into (determined<br/>
    /// by the [secret API token](https://console.apify.com/account#/integrations)).<br/>
    /// The result is an [Actor run<br/>
    /// object](https://sdk.apify.com/docs/typedefs/actor-run) and its output (if<br/>
    /// any).<br/>
    /// A typical workflow is as follows:<br/>
    /// 1. Run an Actor or task using the [Run<br/>
    /// Actor](#/reference/actors/run-collection/run-actor) or [Run<br/>
    /// task](#/reference/actor-tasks/run-collection/run-task) API endpoints.<br/>
    /// 2. Monitor the Actor run by periodically polling its progress using the [Get<br/>
    /// run](#/reference/actor-runs/run-object-and-its-storages/get-run) API<br/>
    /// endpoint.<br/>
    /// 3. Fetch the results from the [Get<br/>
    /// items](#/reference/datasets/item-collection/get-items) API endpoint using the<br/>
    /// `defaultDatasetId`, which you receive in the Run request response.<br/>
    /// Additional data may be stored in a key-value store. You can fetch them from<br/>
    /// the [Get record](#/reference/key-value-stores/record/get-record) API endpoint<br/>
    /// using the `defaultKeyValueStoreId` and the store's `key`.<br/>
    /// **Note**: Instead of periodic polling, you can also run your<br/>
    /// [Actor](#/reference/actors/run-actor-synchronously) or<br/>
    /// [task](#/reference/actor-tasks/runs-collection/run-task-synchronously)<br/>
    /// synchronously. This will ensure that the request waits for 300 seconds (5<br/>
    /// minutes) for the run to finish and returns its output. If the run takes<br/>
    /// longer, the request will time out and throw an error.<br/>
    /// ## Legacy `/v2/acts/` URL prefix<br/>
    /// &lt;span id="/introduction/legacy-acts-prefix"&gt;&lt;/span&gt;<br/>
    /// The `/v2/acts/` prefix is deprecated but still fully functional, and <br/>
    /// such endpoint routes to the same handler as its `/v2/actors/...` counterpart. <br/>
    /// New integrations should use the canonical /v2/actors/ prefix, <br/>
    /// but existing clients keep working without changes.<br/>
    /// ## Response structure<br/>
    /// &lt;span id="/introduction/response-structure"&gt;&lt;/span&gt;<br/>
    /// Most API endpoints return a JSON object with the `data` property:<br/>
    /// ```<br/>
    /// {<br/>
    ///     "data": {<br/>
    ///         ...<br/>
    ///     }<br/>
    /// }<br/>
    /// ```<br/>
    /// However, there are a few explicitly described exceptions, such as<br/>
    /// [Get dataset items](#/reference/datasets/item-collection/get-items) or<br/>
    /// Key-value store [Get record](#/reference/key-value-stores/record/get-record)<br/>
    /// API endpoints, which return data in other formats.<br/>
    /// In case of an error, the response has the HTTP status code in the range of<br/>
    /// 4xx or 5xx and the `data` property is replaced with `error`. For example:<br/>
    /// ```<br/>
    /// {<br/>
    ///     "error": {<br/>
    ///         "type": "record-not-found",<br/>
    ///         "message": "Store was not found."<br/>
    ///     }<br/>
    /// }<br/>
    /// ```<br/>
    /// See [Errors](#/introduction/errors) for more details.<br/>
    /// ## Pagination<br/>
    /// &lt;span id="/introduction/pagination"&gt;&lt;/span&gt;<br/>
    /// All API endpoints that return a list of records<br/>
    /// (e.g. [Get list of<br/>
    /// Actors](#/reference/actors/actor-collection/get-list-of-actors))<br/>
    /// enforce pagination in order to limit the size of their responses.<br/>
    /// Most of these API endpoints are paginated using the `offset` and `limit`<br/>
    /// query parameters.<br/>
    /// The only exception is [Get list of<br/>
    /// keys](#/reference/key-value-stores/key-collection/get-list-of-keys),<br/>
    /// which is paginated using the `exclusiveStartKey` query parameter.<br/>
    /// **IMPORTANT**: Each API endpoint that supports pagination enforces a certain<br/>
    /// maximum value for the `limit` parameter,<br/>
    /// in order to reduce the load on Apify servers.<br/>
    /// The maximum limit could change in future so you should never<br/>
    /// rely on a specific value and check the responses of these API endpoints.<br/>
    /// ### Using offset<br/>
    /// &lt;span id="/introduction/pagination/using-offset"&gt;&lt;/span&gt;<br/>
    /// Most API endpoints that return a list of records enable pagination using the<br/>
    /// following query parameters:<br/>
    /// &lt;table&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;limit&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Limits the response to contain a specific maximum number of items, e.g. &lt;code&gt;limit=20&lt;/code&gt;.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;offset&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Skips a number of items from the beginning of the list, e.g. &lt;code&gt;offset=100&lt;/code&gt;.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;desc&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;<br/>
    ///     By default, items are sorted in the order in which they were created or added to the list.<br/>
    ///     This feature is useful when fetching all the items, because it ensures that items<br/>
    ///     created after the client started the pagination will not be skipped.<br/>
    ///     If you specify the &lt;code&gt;desc=1&lt;/code&gt; parameter, the items will be returned in the reverse order,<br/>
    ///     i.e. from the newest to the oldest items.<br/>
    ///     &lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    /// &lt;/table&gt;<br/>
    /// The response of these API endpoints is always a JSON object with the<br/>
    /// following structure:<br/>
    /// ```<br/>
    /// {<br/>
    ///     "data": {<br/>
    ///         "total": 2560,<br/>
    ///         "offset": 250,<br/>
    ///         "limit": 1000,<br/>
    ///         "count": 1000,<br/>
    ///         "desc": false,<br/>
    ///         "items": [<br/>
    ///             { 1st object },<br/>
    ///             { 2nd object },<br/>
    ///             ...<br/>
    ///             { 1000th object }<br/>
    ///         ]<br/>
    ///     }<br/>
    /// }<br/>
    /// ```<br/>
    /// The following table describes the meaning of the response properties:<br/>
    /// &lt;table&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;th&gt;Property&lt;/th&gt;<br/>
    ///     &lt;th&gt;Description&lt;/th&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;total&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;The total number of items available in the list.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;offset&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;The number of items that were skipped at the start.<br/>
    ///     This is equal to the &lt;code&gt;offset&lt;/code&gt; query parameter if it was provided, otherwise it is &lt;code&gt;0&lt;/code&gt;.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;limit&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;The maximum number of items that can be returned in the HTTP response.<br/>
    ///     It equals to the &lt;code&gt;limit&lt;/code&gt; query parameter if it was provided or<br/>
    ///     the maximum limit enforced for the particular API endpoint, whichever is smaller.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;count&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;The actual number of items returned in the HTTP response.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;desc&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;true&lt;/code&gt; if data were requested in descending order and &lt;code&gt;false&lt;/code&gt; otherwise.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;items&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;An array of requested items.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    /// &lt;/table&gt;<br/>
    /// ### Using key<br/>
    /// &lt;span id="/introduction/pagination/using-key"&gt;&lt;/span&gt;<br/>
    /// The records in the [key-value<br/>
    /// store](https://docs.apify.com/platform/storage/key-value-store)<br/>
    /// are not ordered based on numerical indexes,<br/>
    /// but rather by their keys in the UTF-8 binary order.<br/>
    /// Therefore the [Get list of<br/>
    /// keys](#/reference/key-value-stores/key-collection/get-list-of-keys)<br/>
    /// API endpoint only supports pagination using the following query parameters:<br/>
    /// &lt;table&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;limit&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Limits the response to contain a specific maximum number items, e.g. &lt;code&gt;limit=20&lt;/code&gt;.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;exclusiveStartKey&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Skips all records with keys up to the given key including the given key,<br/>
    ///     in the UTF-8 binary order.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    /// &lt;/table&gt;<br/>
    /// The response of the API endpoint is always a JSON object with following<br/>
    /// structure:<br/>
    /// ```<br/>
    /// {<br/>
    ///     "data": {<br/>
    ///         "limit": 1000,<br/>
    ///         "isTruncated": true,<br/>
    ///         "exclusiveStartKey": "my-key",<br/>
    ///         "nextExclusiveStartKey": "some-other-key",<br/>
    ///         "items": [<br/>
    ///             { 1st object },<br/>
    ///             { 2nd object },<br/>
    ///             ...<br/>
    ///             { 1000th object }<br/>
    ///         ]<br/>
    ///     }<br/>
    /// }<br/>
    /// ```<br/>
    /// The following table describes the meaning of the response properties:<br/>
    /// &lt;table&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;th&gt;Property&lt;/th&gt;<br/>
    ///     &lt;th&gt;Description&lt;/th&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;limit&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;The maximum number of items that can be returned in the HTTP response.<br/>
    ///     It equals to the &lt;code&gt;limit&lt;/code&gt; query parameter if it was provided or<br/>
    ///     the maximum limit enforced for the particular endpoint, whichever is smaller.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;isTruncated&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;true&lt;/code&gt; if there are more items left to be queried. Otherwise &lt;code&gt;false&lt;/code&gt;.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;exclusiveStartKey&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;The last key that was skipped at the start. Is `null` for the first page.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;nextExclusiveStartKey&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;The value for the &lt;code&gt;exclusiveStartKey&lt;/code&gt; parameter to query the next page of items.&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    /// &lt;/table&gt;<br/>
    /// ## Errors<br/>
    /// &lt;span id="/introduction/errors"&gt;&lt;/span&gt;<br/>
    /// The Apify API uses common HTTP status codes: `2xx` range for success, `4xx`<br/>
    /// range for errors caused by the caller<br/>
    /// (invalid requests) and `5xx` range for server errors (these are rare).<br/>
    /// Each error response contains a JSON object defining the `error` property,<br/>
    /// which is an object with<br/>
    /// the `type` and `message` properties that contain the error code and a<br/>
    /// human-readable error description, respectively.<br/>
    /// For example:<br/>
    /// ```<br/>
    /// {<br/>
    ///     "error": {<br/>
    ///         "type": "record-not-found",<br/>
    ///         "message": "Store was not found."<br/>
    ///     }<br/>
    /// }<br/>
    /// ```<br/>
    /// Here is the table of the most common errors that can occur for many API<br/>
    /// endpoints:<br/>
    /// &lt;table&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;th&gt;status&lt;/th&gt;<br/>
    ///     &lt;th&gt;type&lt;/th&gt;<br/>
    ///     &lt;th&gt;message&lt;/th&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;400&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;invalid-request&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;POST data must be a JSON object&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;400&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;invalid-value&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Invalid value provided: Comments required&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;400&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;invalid-record-key&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Record key contains invalid character&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;401&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;token-not-provided&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Authentication token was not provided&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;404&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;record-not-found&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Store was not found&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;429&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;rate-limit-exceeded&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;You have exceeded the rate limit of ... requests per second&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;405&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;&lt;code&gt;method-not-allowed&lt;/code&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;This API endpoint can only be accessed using the following HTTP methods: OPTIONS, POST&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    /// &lt;/table&gt;<br/>
    /// ## Rate limiting<br/>
    /// &lt;span id="/introduction/rate-limiting"&gt;&lt;/span&gt;<br/>
    /// All API endpoints limit the rate of requests in order to prevent overloading of Apify servers by misbehaving clients.<br/>
    /// There are two kinds of rate limits - a global rate limit and a per-resource rate limit.<br/>
    /// ### Global rate limit<br/>
    /// &lt;span id="/introduction/rate-limiting/global-rate-limit"&gt;&lt;/span&gt;<br/>
    /// The global rate limit is set to _250 000 requests per minute_.<br/>
    /// For [authenticated](#/introduction/authentication) requests, it is counted per user,<br/>
    /// and for unauthenticated requests, it is counted per IP address.<br/>
    /// ### Per-resource rate limit<br/>
    /// &lt;span id="/introduction/rate-limiting/per-resource-rate-limit"&gt;&lt;/span&gt;<br/>
    /// The default per-resource rate limit is _60 requests per second per resource_, which in this context means a single Actor, a single Actor run, a single dataset, single key-value store etc.<br/>
    /// The default rate limit is applied to every API endpoint except a few select ones, which have higher rate limits.<br/>
    /// Each API endpoint returns its rate limit in `X-RateLimit-Limit` header.<br/>
    /// These endpoints have a rate limit of _200 requests per second per resource_:<br/>
    /// * CRUD ([get](#/reference/key-value-stores/record/get-record),<br/>
    ///   [put](#/reference/key-value-stores/record/put-record),<br/>
    ///   [delete](#/reference/key-value-stores/record/delete-record))<br/>
    ///   operations on key-value store records<br/>
    /// These endpoints have a rate limit of _400 requests per second per resource_:<br/>
    /// * [Run Actor](#/reference/actors/run-collection/run-actor)<br/>
    /// * [Run Actor task asynchronously](#/reference/actor-tasks/runs-collection/run-task-asynchronously)<br/>
    /// * [Run Actor task synchronously](#/reference/actor-tasks/runs-collection/run-task-synchronously)<br/>
    /// * [Metamorph Actor run](#/reference/actors/metamorph-run/metamorph-run)<br/>
    /// * [Push items](#/reference/datasets/item-collection/put-items) to dataset<br/>
    /// * CRUD<br/>
    ///   ([add](#/reference/request-queues/request-collection/add-request),<br/>
    ///   [get](#/reference/request-queues/request-collection/get-request),<br/>
    ///   [update](#/reference/request-queues/request-collection/update-request),<br/>
    ///   [delete](#/reference/request-queues/request-collection/delete-request))<br/>
    ///   operations on requests in request queues<br/>
    /// ### Rate limit exceeded errors<br/>
    /// &lt;span id="/introduction/rate-limiting/rate-limit-exceeded-errors"&gt;&lt;/span&gt;<br/>
    /// If the client is sending too many requests, the API endpoints respond with the HTTP status code `429 Too Many Requests`<br/>
    /// and the following body:<br/>
    /// ```<br/>
    /// {<br/>
    ///     "error": {<br/>
    ///         "type": "rate-limit-exceeded",<br/>
    ///         "message": "You have exceeded the rate limit of ... requests per second"<br/>
    ///     }<br/>
    /// }<br/>
    /// ```<br/>
    /// ### Retrying rate-limited requests with exponential backoff<br/>
    /// &lt;span id="/introduction/rate-limiting/retrying-rate-limited-requests-with-exponential-backoff"&gt;&lt;/span&gt;<br/>
    /// If the client receives the rate limit error, it should wait a certain period of time and then retry the request.<br/>
    /// If the error happens again, the client should double the wait period and retry the request,<br/>
    /// and so on. This algorithm is known as _exponential backoff_<br/>
    /// and it can be described using the following pseudo-code:<br/>
    /// 1. Define a variable `DELAY=500`<br/>
    /// 2. Send the HTTP request to the API endpoint<br/>
    /// 3. If the response has status code not equal to `429` then you are done. Otherwise:<br/>
    ///    * Wait for a period of time chosen randomly from the interval `DELAY` to `2*DELAY` milliseconds<br/>
    ///    * Double the future wait period by setting `DELAY = 2*DELAY`<br/>
    ///    * Continue with step 2<br/>
    /// If all requests sent by the client implement the above steps,<br/>
    /// the client will automatically use the maximum available bandwidth for its requests.<br/>
    /// Note that the Apify API clients [for JavaScript](https://docs.apify.com/api/client/js)<br/>
    /// and [for Python](https://docs.apify.com/api/client/python)<br/>
    /// use the exponential backoff algorithm transparently, so that you do not need to worry about it.<br/>
    /// ## Referring to resources<br/>
    /// &lt;span id="/introduction/referring-to-resources"&gt;&lt;/span&gt;<br/>
    /// There are three main ways to refer to a resource you're accessing via API.<br/>
    /// - the resource ID (e.g. `iKkPcIgVvwmztduf8`)<br/>
    /// - `username~resourcename` - when using this access method, you will need to<br/>
    /// use your API token, and access will only work if you have the correct<br/>
    /// permissions.<br/>
    /// - `~resourcename` - for this, you need to use an API token, and the<br/>
    /// `resourcename` refers to a resource in the API token owner's account.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class ApifyClient : global::Apify.IApifyClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.apify.com/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Apify.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::Apify.AutoSDKClientOptions Options { get; }


        /// <inheritdoc/>
        public global::System.Func<string> CreateIdempotencyKey { get; set; } = () => global::System.Guid.NewGuid().ToString("D");
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Apify.SourceGenerationContext.Default;


        /// <summary>
        /// Actor builds - Introduction. The API endpoints described in this section enable you to manage, and delete Apify Actor builds.<br/>
        /// Note that if any returned build object contains usage in dollars, your effective<br/>
        /// unit pricing at the time of query has been used for computation of this dollar equivalent, and hence it should be<br/>
        /// used only for informative purposes.<br/>
        /// You can learn more about platform usage in the [documentation](https://docs.apify.com/platform/actors/running/usage-and-resources#usage).
        /// </summary>
        public ActorBuildsClient ActorBuilds => new ActorBuildsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Actor runs - Introduction. The API endpoints described in this section enable you to manage, and delete Apify Actor runs.<br/>
        /// If any returned run object contains usage in dollars, your effective unit pricing at the time of query<br/>
        /// has been used for computation of this dollar equivalent, and hence it should be used only for informative purposes.<br/>
        /// For completed runs, aggregated fields such as `stats` or dollar usage totals are eventually consistent and update within a few seconds. For values that must match finalized totals, wait about 10 seconds after the run completed, then fetch the run again.<br/>
        /// You can learn more about platform usage in the [documentation](https://docs.apify.com/platform/actors/running/usage-and-resources#usage).
        /// </summary>
        public ActorRunsClient ActorRuns => new ActorRunsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Actor tasks - Introduction. The API endpoints described in this section enable you to create, manage, delete, and run Apify Actor tasks.<br/>
        /// For more information, see the [Actor tasts documentation](https://docs.apify.com/platform/actors/running/tasks).<br/>
        /// :::note<br/>
        /// For all the API endpoints that accept the `actorTaskId` parameter to<br/>
        /// specify a task, you can pass either the task ID (e.g. `HG7ML7M8z78YcAPEB`) or a tilde-separated<br/>
        /// username of the task's owner and the task's name (e.g. `janedoe~my-task`).<br/>
        /// :::<br/>
        /// Some of the API endpoints return run objects. If any such run object<br/>
        /// contains usage in dollars, your effective unit pricing at the time of query<br/>
        /// has been used for computation of this dollar equivalent, and hence it should be<br/>
        /// used only for informative purposes.<br/>
        /// You can learn more about platform usage in the [documentation](https://docs.apify.com/platform/actors/running/usage-and-resources#usage).
        /// </summary>
        public ActorTasksClient ActorTasks => new ActorTasksClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Actors - Introduction. The API endpoints in this section allow you to manage Apify Actors. For more details about Actors, refer to the [Actor documentation](https://docs.apify.com/platform/actors).<br/>
        /// For API endpoints that require the `actorId` parameter to identify an Actor, you can provide either:<br/>
        /// - The Actor ID (e.g., `HG7ML7M8z78YcAPEB`), or<br/>
        /// - A tilde-separated combination of the Actor owner's username and the Actor name (e.g., `janedoe~my-actor`).
        /// </summary>
        public ActorsClient Actors => new ActorsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Actor builds - Introduction. The API endpoints in this section allow you to manage your Apify Actors builds.
        /// </summary>
        public ActorsActorBuildsClient ActorsActorBuilds => new ActorsActorBuildsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Actor runs - Introduction. The API endpoints in this section allow you to manage your Apify Actors runs.<br/>
        /// Some API endpoints return run objects. If a run object includes usage costs in dollars, note that these values are calculated based on your effective unit pricing at the time of the query. As a result, the dollar amounts should be treated as informational only and not as exact figures.<br/>
        /// For completed runs, aggregated fields such as `stats` or dollar usage totals are eventually consistent and update within a few seconds. For values that must match finalized totals, wait about 10 seconds after the run completed, then fetch the run again.<br/>
        /// For more information about platform usage and resource calculations, see the [Usage and Resources documentation](https://docs.apify.com/platform/actors/running/usage-and-resources#usage).
        /// </summary>
        public ActorsActorRunsClient ActorsActorRuns => new ActorsActorRunsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Actor versions - Introduction. The API endpoints in this section allow you to manage your Apify Actors versions.<br/>
        /// - The version object contains the source code of a specific version of an Actor.<br/>
        /// - The `sourceType` property indicates where the source code is hosted, and based<br/>
        /// on its value the Version object has the following additional property:<br/>
        /// | **Value** | **Description**  |<br/>
        /// |---|---|<br/>
        /// | `"SOURCE_FILES"`   | Source code is comprised of multiple files specified in the `sourceFiles` array. Each item of the array is an object with the following fields:&lt;br/&gt; - `name`: File path and name&lt;br/&gt; - `format`: Format of the content, can be either `"TEXT"` or `"BASE64"`&lt;br/&gt; - `content`: File content&lt;br/&gt;&lt;br/&gt;Source files can be shown and edited in the Apify Console's Web IDE. |<br/>
        /// | `"GIT_REPO"` | Source code is cloned from a Git repository, whose URL is specified in the `gitRepoUrl` field. |<br/>
        /// | `"TARBALL"` | Source code is downloaded using a tarball or Zip file from a URL specified in the `tarballUrl` field.  |<br/>
        /// |`"GITHUB_GIST"`| Source code is taken from a GitHub Gist, whose URL is specified in the `gitHubGistUrl` field. |<br/>
        /// For more information about source code and Actor versions, check out [Source code](https://docs.apify.com/platform/actors/development/actor-definition/source-code)<br/>
        /// in Actors documentation.
        /// </summary>
        public ActorsActorVersionsClient ActorsActorVersions => new ActorsActorVersionsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Webhook collection - Introduction. The API endpoint in this section allows you to get a list of webhooks of a specific Actor.
        /// </summary>
        public ActorsWebhookCollectionClient ActorsWebhookCollection => new ActorsWebhookCollectionClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Default dataset - Introduction. The API endpoints described in this section are convenience endpoints that provide access to Actor run's default dataset without the need to resolve the dataset ID first.<br/>
        /// Subset of functionality described in: [Datasets](/api/v2/storage-datasets).
        /// </summary>
        public DefaultDatasetClient DefaultDataset => new DefaultDatasetClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Default key-value store - Introduction. The API endpoints described in this section are convenience endpoints that provide access to Actor run's default key-value store without the need to resolve the key-value store ID first.<br/>
        /// Subset of functionality described in: [Key-value stores](/api/v2/storage-key-value-stores).
        /// </summary>
        public DefaultKeyValueStoreClient DefaultKeyValueStore => new DefaultKeyValueStoreClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Default request queue - Introduction. The API endpoints described in this section are convenience endpoints that provide access to Actor run's default request queue without the need to resolve the request queue ID first.<br/>
        /// Subset of functionality described in: [Request queues](/api/v2/storage-request-queues).
        /// </summary>
        public DefaultRequestQueueClient DefaultRequestQueue => new DefaultRequestQueueClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor run's abort - Introduction. The API endpoint described in this section is a convenience endpoint that aborts the Actor's last run.<br/>
        /// Same as of functionality described in: [Abort run](/api/v2/actor-run-abort-post).
        /// </summary>
        public LastActorRunSAbortClient LastActorRunSAbort => new LastActorRunSAbortClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor run's default dataset - Introduction. The API endpoints described in this section are convenience endpoints that provide access to Actor's last run's default dataset without the need to resolve the dataset ID first.<br/>
        /// Subset of functionality described in: [Datasets](/api/v2/storage-datasets).
        /// </summary>
        public LastActorRunSDefaultDatasetClient LastActorRunSDefaultDataset => new LastActorRunSDefaultDatasetClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor run's default key-value store - Introduction. The API endpoints described in this section are convenience endpoints that provide access to Actor's last run's default key-value store without the need to resolve the key-value store ID first.<br/>
        /// Subset of functionality described in: [Key-value stores](/api/v2/storage-key-value-stores).
        /// </summary>
        public LastActorRunSDefaultKeyValueStoreClient LastActorRunSDefaultKeyValueStore => new LastActorRunSDefaultKeyValueStoreClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor run's default request queue - Introduction. The API endpoints described in this section are convenience endpoints that provide access to Actor's last run's default request queue without the need to resolve the request queue ID first.<br/>
        /// Subset of functionality described in: [Request queues](/api/v2/storage-request-queues).
        /// </summary>
        public LastActorRunSDefaultRequestQueueClient LastActorRunSDefaultRequestQueue => new LastActorRunSDefaultRequestQueueClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor run's log - Introduction. The API endpoint described in this section is convenience endpoint that provides access to last Actor run's log.<br/>
        /// Same as of functionality described in: [Logs](/api/v2/logs).
        /// </summary>
        public LastActorRunSLogClient LastActorRunSLog => new LastActorRunSLogClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor run's metamorph - Introduction. The API endpoint described in this section is a convenience endpoint that metamorphs the Actor's last run into a run of another Actor.<br/>
        /// Same as of functionality described in: [Metamorph run](/api/v2/actor-run-metamorph-post).
        /// </summary>
        public LastActorRunSMetamorphClient LastActorRunSMetamorph => new LastActorRunSMetamorphClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor run's reboot - Introduction. The API endpoint described in this section is a convenience endpoint that reboots the Actor's last run.<br/>
        /// Same as of functionality described in: [Reboot run](/api/v2/actor-run-reboot-post).
        /// </summary>
        public LastActorRunSRebootClient LastActorRunSReboot => new LastActorRunSRebootClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor task run's abort - Introduction. The API endpoint described in this section is a convenience endpoint that aborts the Actor task's last run.<br/>
        /// Same as of functionality described in: [Abort run](/api/v2/actor-run-abort-post).
        /// </summary>
        public LastActorTaskRunSAbortClient LastActorTaskRunSAbort => new LastActorTaskRunSAbortClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor task run's default dataset - Introduction. The API endpoints described in this section are convenience endpoints that provide access to Actor task's last run's default dataset without the need to resolve the dataset ID first.<br/>
        /// Subset of functionality described in: [Datasets](/api/v2/storage-datasets).
        /// </summary>
        public LastActorTaskRunSDefaultDatasetClient LastActorTaskRunSDefaultDataset => new LastActorTaskRunSDefaultDatasetClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor task run's default key-value store - Introduction. The API endpoints described in this section are convenience endpoints that provide access to Actor task's last run's default key-value store without the need to resolve the key-value store ID first.<br/>
        /// Subset of functionality described in: [Key-value stores](/api/v2/storage-key-value-stores).
        /// </summary>
        public LastActorTaskRunSDefaultKeyValueStoreClient LastActorTaskRunSDefaultKeyValueStore => new LastActorTaskRunSDefaultKeyValueStoreClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor task run's default request queue - Introduction. The API endpoints described in this section are convenience endpoints that provide access to Actor task's last run's default request queue without the need to resolve the request queue ID first.<br/>
        /// Subset of functionality described in: [Request queues](/api/v2/storage-request-queues).
        /// </summary>
        public LastActorTaskRunSDefaultRequestQueueClient LastActorTaskRunSDefaultRequestQueue => new LastActorTaskRunSDefaultRequestQueueClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor task run's log - Introduction. The API endpoint described in this section is convenience endpoint that provides access to last Actor task run's log.<br/>
        /// Same as of functionality described in: [Logs](/api/v2/logs).
        /// </summary>
        public LastActorTaskRunSLogClient LastActorTaskRunSLog => new LastActorTaskRunSLogClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor task run's metamorph - Introduction. The API endpoint described in this section is a convenience endpoint that metamorphs the Actor task's last run into a run of another Actor.<br/>
        /// Same as of functionality described in: [Metamorph run](/api/v2/actor-run-metamorph-post).
        /// </summary>
        public LastActorTaskRunSMetamorphClient LastActorTaskRunSMetamorph => new LastActorTaskRunSMetamorphClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Last Actor task run's reboot - Introduction. The API endpoint described in this section is a convenience endpoint that reboots the Actor task's last run.<br/>
        /// Same as of functionality described in: [Reboot run](/api/v2/actor-run-reboot-post).
        /// </summary>
        public LastActorTaskRunSRebootClient LastActorTaskRunSReboot => new LastActorTaskRunSRebootClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Logs - Introduction. The API endpoints described in this section are used the download the logs<br/>
        /// generated by Actor builds and runs. Note that only the trailing 5M characters<br/>
        /// of the log are stored, the rest is discarded.<br/>
        /// :::note<br/>
        /// Note that the endpoints do not require the authentication token, the calls<br/>
        /// are authenticated using a hard-to-guess ID of the Actor build or run.<br/>
        /// :::.
        /// </summary>
        public LogsClient Logs => new LogsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Schedules - Introduction. This section describes API endpoints for managing schedules.<br/>
        /// Schedules are used to automatically start your Actors at certain times. Each schedule<br/>
        /// can be associated with a number of Actors and Actor tasks. It is also possible<br/>
        /// to override the settings of each Actor (task) similarly to when invoking the Actor<br/>
        /// (task) using the API.<br/>
        /// For more information, see [Schedules documentation](https://docs.apify.com/platform/schedules).<br/>
        /// Each schedule is assigned actions for it to perform. Actions can be of two types<br/>
        /// - `RUN_ACTOR` and `RUN_ACTOR_TASK`.<br/>
        /// For details, see the documentation of the [Get schedule](#/reference/schedules/schedule-object/get-schedule) endpoint.
        /// </summary>
        public SchedulesClient Schedules => new SchedulesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Datasets - Introduction. This section describes API endpoints to manage Datasets.<br/>
        /// Dataset is a storage for structured data, where each record stored has the same attributes,<br/>
        /// such as online store products or real estate offers. You can imagine it as a table,<br/>
        /// where each object is a row and its attributes are columns. Dataset is an append-only<br/>
        /// storage - you can only add new records to it but you cannot modify or remove existing<br/>
        /// records. Typically it is used to store crawling results.<br/>
        /// For more information, see the [Datasets documentation](https://docs.apify.com/platform/storage/dataset).<br/>
        /// :::note<br/>
        /// Some of the endpoints do not require the authentication token, the calls<br/>
        /// are authenticated using the hard-to-guess ID of the dataset.<br/>
        /// :::.
        /// </summary>
        public StorageDatasetsClient StorageDatasets => new StorageDatasetsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Key-value stores - Introduction. This section describes API endpoints to manage Key-value stores.<br/>
        /// Key-value store is a simple storage for saving and reading data records or files.<br/>
        /// Each data record is represented by a unique key and associated with a MIME content type.<br/>
        /// Key-value stores are ideal for saving screenshots, Actor inputs and outputs, web pages,<br/>
        /// PDFs or to persist the state of crawlers.<br/>
        /// For more information, see the [Key-value store documentation](https://docs.apify.com/platform/storage/key-value-store).<br/>
        /// :::note<br/>
        /// Some of the endpoints do not require the authentication token, the calls<br/>
        /// are authenticated using a hard-to-guess ID of the key-value store.<br/>
        /// :::.
        /// </summary>
        public StorageKeyValueStoresClient StorageKeyValueStores => new StorageKeyValueStoresClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Request queues - Introduction. This section describes API endpoints to create, manage, and delete request queues.<br/>
        /// Request queue is a storage for a queue of HTTP URLs to crawl, which is typically<br/>
        /// used for deep crawling of websites where you<br/>
        /// start with several URLs and then recursively follow links to other pages.<br/>
        /// The storage supports both breadth-first and depth-first crawling orders.<br/>
        /// For more information, see the [Request queue documentation](https://docs.apify.com/platform/storage/request-queue).<br/>
        /// :::note<br/>
        /// Some of the endpoints do not require the authentication token, the calls<br/>
        /// are authenticated using the hard-to-guess ID of the queue.<br/>
        /// :::.
        /// </summary>
        public StorageRequestQueuesClient StorageRequestQueues => new StorageRequestQueuesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Requests - Introduction. This section describes API endpoints to create, manage, and delete requests within request queues.<br/>
        /// Request queue is a storage for a queue of HTTP URLs to crawl, which is typically<br/>
        /// used for deep crawling of websites where you<br/>
        /// start with several URLs and then recursively follow links to other pages.<br/>
        /// The storage supports both breadth-first and depth-first crawling orders.<br/>
        /// For more information, see the [Request queue documentation](https://docs.apify.com/platform/storage/request-queue).<br/>
        /// :::note<br/>
        /// Some of the endpoints do not require the authentication token, the calls<br/>
        /// are authenticated using the hard-to-guess ID of the queue.<br/>
        /// :::.
        /// </summary>
        public StorageRequestQueuesRequestsClient StorageRequestQueuesRequests => new StorageRequestQueuesRequestsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Requests locks - Introduction. This section describes API endpoints to create, manage, and delete request locks within request queues.<br/>
        /// Request queue is a storage for a queue of HTTP URLs to crawl, which is typically<br/>
        /// used for deep crawling of websites where you<br/>
        /// start with several URLs and then recursively follow links to other pages.<br/>
        /// The storage supports both breadth-first and depth-first crawling orders.<br/>
        /// For more information, see the [Request queue documentation](https://docs.apify.com/platform/storage/request-queue).<br/>
        /// :::note<br/>
        /// Some of the endpoints do not require the authentication token, the calls<br/>
        /// are authenticated using the hard-to-guess ID of the queue.<br/>
        /// :::.
        /// </summary>
        public StorageRequestQueuesRequestsLocksClient StorageRequestQueuesRequestsLocks => new StorageRequestQueuesRequestsLocksClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Store - Introduction. [Apify Store](https://apify.com/store) is home to thousands of public Actors available<br/>
        /// to the Apify community.<br/>
        /// The API endpoints described in this section are used to retrieve these Actors.<br/>
        /// :::note<br/>
        /// These endpoints do not require the authentication token.<br/>
        /// :::.
        /// </summary>
        public StoreClient Store => new StoreClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Tools - Introduction. The API endpoints described in this section provide utility tools for encoding,<br/>
        /// signing, and verifying data, as well as inspecting HTTP request details.
        /// </summary>
        public ToolsClient Tools => new ToolsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Users - Introduction. The API endpoints described in this section return information about user accounts.
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Webhook dispatches - Introduction. This section describes API endpoints to get webhook dispatches.
        /// </summary>
        public WebhooksWebhookDispatchesClient WebhooksWebhookDispatches => new WebhooksWebhookDispatchesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Webhooks - Introduction. This section describes API endpoints to manage webhooks.<br/>
        /// Webhooks provide an easy and reliable way to configure the Apify platform<br/>
        /// to carry out an action (e.g. a HTTP request to another service) when a certain<br/>
        /// system event occurs.<br/>
        /// For example, you can use webhooks to start another Actor when an Actor run finishes<br/>
        /// or fails.<br/>
        /// For more information see [Webhooks documentation](https://docs.apify.com/platform/integrations/webhooks).
        /// </summary>
        public WebhooksWebhooksClient WebhooksWebhooks => new WebhooksWebhooksClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the ApifyClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public ApifyClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Apify.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the ApifyClient with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public ApifyClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::Apify.EndPointAuthorization>? authorizations,
            global::Apify.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the ApifyClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public ApifyClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::Apify.EndPointAuthorization>? authorizations,
            global::Apify.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Apify.EndPointAuthorization>();
            Options = options ?? new global::Apify.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}