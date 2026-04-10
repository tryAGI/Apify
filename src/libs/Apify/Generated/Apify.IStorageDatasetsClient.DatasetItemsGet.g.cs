#nullable enable

namespace Apify
{
    public partial interface IStorageDatasetsClient
    {
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> DatasetItemsGetAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::System.Collections.Generic.IList<object>>> DatasetItemsGetAsResponseAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}