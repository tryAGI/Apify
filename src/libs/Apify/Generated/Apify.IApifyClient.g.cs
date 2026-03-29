
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
    /// - To access the API using [Node.js](https://nodejs.org/en/), we recommend the [`apify-client`](https://docs.apify.com/api/client/js) [NPM<br/>
    /// package](https://www.npmjs.com/package/apify-client).<br/>
    /// - To access the API using [Python](https://www.python.org/), we recommend the [`apify-client`](https://docs.apify.com/api/client/python) [PyPI<br/>
    /// package](https://pypi.org/project/apify-client/).<br/>
    /// The clients' functions correspond to the API endpoints and have the same<br/>
    /// parameters. This simplifies development of apps that depend on the Apify<br/>
    /// platform.<br/>
    /// :::note Important Request Details<br/>
    /// - `Content-Type` header: For requests with a JSON body, you must include the `Content-Type: application/json` header.<br/>
    /// - Method override: You can override the HTTP method using the `method` query parameter. This is useful for clients that can only send `GET` requests. For example, to call a `POST` endpoint, append `?method=POST` to the URL of your `GET` request.<br/>
    /// :::<br/>
    /// ## Authentication<br/>
    /// &lt;span id="/introduction/authentication"&gt;&lt;/span&gt;<br/>
    /// You can find your API token on the<br/>
    /// [Integrations](https://console.apify.com/account#/integrations) page in the<br/>
    /// Apify Console.<br/>
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
    /// **Do not share your API token or password with untrusted parties.**<br/>
    /// For more information, see our<br/>
    /// [integrations](https://docs.apify.com/platform/integrations) documentation.<br/>
    /// ## Basic usage<br/>
    /// &lt;span id="/introduction/basic-usage"&gt;&lt;/span&gt;<br/>
    /// To run an Actor, send a POST request to the [Run<br/>
    /// Actor](#/reference/actors/run-collection/run-actor) endpoint using either the<br/>
    /// Actor ID code (e.g. `vKg4IjxZbEYTYeW8T`) or its name (e.g.<br/>
    /// `janedoe~my-actor`):<br/>
    /// `https://api.apify.com/v2/acts/[actor_id]/runs`<br/>
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
    public partial interface IApifyClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Actor builds - Introduction
        /// </summary>
        public ActorBuildsClient ActorBuilds { get; }

        /// <summary>
        /// Actor runs - Introduction
        /// </summary>
        public ActorRunsClient ActorRuns { get; }

        /// <summary>
        /// Actor tasks - Introduction
        /// </summary>
        public ActorTasksClient ActorTasks { get; }

        /// <summary>
        /// Actors - Introduction
        /// </summary>
        public ActorsClient Actors { get; }

        /// <summary>
        /// Actor builds - Introduction
        /// </summary>
        public ActorsActorBuildsClient ActorsActorBuilds { get; }

        /// <summary>
        /// Actor runs - Introduction
        /// </summary>
        public ActorsActorRunsClient ActorsActorRuns { get; }

        /// <summary>
        /// Actor versions - Introduction
        /// </summary>
        public ActorsActorVersionsClient ActorsActorVersions { get; }

        /// <summary>
        /// Webhook collection - Introduction
        /// </summary>
        public ActorsWebhookCollectionClient ActorsWebhookCollection { get; }

        /// <summary>
        /// Logs - Introduction
        /// </summary>
        public LogsClient Logs { get; }

        /// <summary>
        /// Schedules - Introduction
        /// </summary>
        public SchedulesClient Schedules { get; }

        /// <summary>
        /// Datasets - Introduction
        /// </summary>
        public StorageDatasetsClient StorageDatasets { get; }

        /// <summary>
        /// Key-value stores - Introduction
        /// </summary>
        public StorageKeyValueStoresClient StorageKeyValueStores { get; }

        /// <summary>
        /// Request queues - Introduction
        /// </summary>
        public StorageRequestQueuesClient StorageRequestQueues { get; }

        /// <summary>
        /// Requests - Introduction
        /// </summary>
        public StorageRequestQueuesRequestsClient StorageRequestQueuesRequests { get; }

        /// <summary>
        /// Requests locks - Introduction
        /// </summary>
        public StorageRequestQueuesRequestsLocksClient StorageRequestQueuesRequestsLocks { get; }

        /// <summary>
        /// Store - Introduction
        /// </summary>
        public StoreClient Store { get; }

        /// <summary>
        /// Tools - Introduction
        /// </summary>
        public ToolsClient Tools { get; }

        /// <summary>
        /// Users - Introduction
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// Webhook dispatches - Introduction
        /// </summary>
        public WebhooksWebhookDispatchesClient WebhooksWebhookDispatches { get; }

        /// <summary>
        /// Webhooks - Introduction
        /// </summary>
        public WebhooksWebhooksClient WebhooksWebhooks { get; }

    }
}