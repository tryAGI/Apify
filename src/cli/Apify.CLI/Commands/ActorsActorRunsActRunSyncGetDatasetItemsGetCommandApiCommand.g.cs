#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorRunsActRunSyncGetDatasetItemsGetCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or a tilde-separated owner's username and Actor name.",
    };

    private static Option<double?> Timeout { get; } = new(
        name: @"--timeout")
    {
        Description = @"Optional timeout for the run, in seconds. By default, the run uses the timeout from its configuration.
",
    };

    private static Option<double?> Memory { get; } = new(
        name: @"--memory")
    {
        Description = @"Memory limit for the run, in megabytes. The amount of memory can be set to a power of 2 with a minimum of 128.
By default, the run uses the memory limit from its configuration.
",
    };

    private static Option<double?> MaxItems { get; } = new(
        name: @"--max-items")
    {
        Description = @"Specifies the maximum number of dataset items that will be charged for pay-per-result Actors.
This does NOT guarantee that the Actor will return only this many items.
It only ensures you won't be charged for more than this number of items.
Only works for pay-per-result Actors.
Value can be accessed in the actor run using `ACTOR_MAX_PAID_DATASET_ITEMS` environment variable.
",
    };

    private static Option<double?> MaxTotalChargeUsd { get; } = new(
        name: @"--max-total-charge-usd")
    {
        Description = @"Specifies the maximum total cost of the run.
Use it to cap the total amount charged for all pricing models.
You can access the maximum cost in your Actor
by using the `ACTOR_MAX_TOTAL_CHARGE_USD` environment variable.
",
    };

    private static Option<bool?> RestartOnError { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--restart-on-error",
        description: @"Determines whether the run will be restarted if it fails.
");

    private static Option<string?> Build { get; } = new(
        name: @"--build")
    {
        Description = @"Specifies the Actor build to run. It can be either a build tag or build number.
By default, the run uses the build from its configuration (typically `latest`).
",
    };

    private static Option<byte[]?> Webhooks { get; } = new(
        name: @"--webhooks")
    {
        Description = @"Specifies optional webhooks associated with the Actor run, which can be used to receive a notification
e.g. when the Actor finished or failed. The value is a Base64-encoded JSON array whose items follow
the WebhookRepresentation schema. For more information, see
[Webhooks documentation](https://docs.apify.com/platform/integrations/webhooks).
",
    };

    private static Option<string?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"Format of the results, possible values are: `json`, `jsonl`, `csv`, `html`, `xlsx`, `xml` and `rss`. The default value is `json`.
",
    };

    private static Option<bool?> Clean { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--clean",
        description: @"If `true` or `1` then the API endpoint returns only non-empty items and skips hidden fields (i.e. fields starting with the # character).
The `clean` parameter is just a shortcut for `skipHidden=true` and `skipEmpty=true` parameters.
Note that since some objects might be skipped from the output, that the result might contain less items than the `limit` value.
");

    private static Option<double?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"Number of items that should be skipped at the start. The default value is `0`.
",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of items to return. By default there is no limit.",
    };

    private static Option<string?> Fields { get; } = new(
        name: @"--fields")
    {
        Description = @"A comma-separated list of fields which should be picked from the items, only these fields will remain in the resulting record objects.
Note that the fields in the outputted items are sorted the same way as they are specified in the `fields` query parameter.
You can use this feature to effectively fix the output format.
",
    };

    private static Option<string?> OutputFields { get; } = new(
        name: @"--output-fields")
    {
        Description = @"A comma-separated list of output field names that positionally rename the fields specified in the `fields` parameter.
For example, `?fields=headline,url&outputFields=title,link` renames `headline` to `title` and `url` to `link` in the output.
The number of names in `outputFields` must match the number of names in `fields`.
Requires the `fields` parameter to be specified as well.
",
    };

    private static Option<string?> Omit { get; } = new(
        name: @"--omit")
    {
        Description = @"A comma-separated list of fields which should be omitted from the items.",
    };

    private static Option<string?> Unwind { get; } = new(
        name: @"--unwind")
    {
        Description = @"A comma-separated list of fields which should be unwound, in order which they should be processed. Each field should be either an array or an object.
If the field is an array then every element of the array will become a separate record and merged with parent object.
If the unwound field is an object then it is merged with the parent object.
If the unwound field is missing or its value is neither an array nor an object and therefore cannot be merged with a parent object then the item gets preserved as it is.
Note that the unwound items ignore the `desc` parameter.
",
    };

    private static Option<string?> Flatten { get; } = new(
        name: @"--flatten")
    {
        Description = @"A comma-separated list of fields which should transform nested objects into flat structures.

For example, with `flatten=""foo""` the object `{""foo"":{""bar"": ""hello""}}` is turned into `{""foo.bar"": ""hello""}`.

The original object with properties is replaced with the flattened object.
",
    };

    private static Option<bool?> Desc { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--desc",
        description: @"By default, results are returned in the same order as they were stored.
To reverse the order, set this parameter to `true` or `1`.
");

    private static Option<bool?> Attachment { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--attachment",
        description: @"If `true` or `1` then the response will define the `Content-Disposition:
attachment` header, forcing a web browser to download the file rather
than to display it. By default this header is not present.
");

    private static Option<string?> Delimiter { get; } = new(
        name: @"--delimiter")
    {
        Description = @"A delimiter character for CSV files, only used if `format=csv`. You
might need to URL-encode the character (e.g. use `%09` for tab or `%3B`
for semicolon). The default delimiter is a simple comma (`,`).
",
    };

    private static Option<bool?> Bom { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--bom",
        description: @"All text responses are encoded in UTF-8 encoding. By default, the
`format=csv` files are prefixed with the UTF-8 Byte Order Mark (BOM), while `json`, `jsonl`, `xml`, `html` and `rss` files are not.

If you want to override this default behavior, specify `bom=1` query parameter to include the BOM or `bom=0` to skip it.
");

    private static Option<string?> XmlRoot { get; } = new(
        name: @"--xml-root")
    {
        Description = @"Overrides default root element name of `xml` output. By default the root element is `items`.
",
    };

    private static Option<string?> XmlRow { get; } = new(
        name: @"--xml-row")
    {
        Description = @"Overrides default element name that wraps each page or page function result object in `xml` output. By default the element name is `item`.
",
    };

    private static Option<bool?> SkipHeaderRow { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--skip-header-row",
        description: @"If `true` or `1` then header row in the `csv` format is skipped.");

    private static Option<bool?> SkipHidden { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--skip-hidden",
        description: @"If `true` or `1` then hidden fields are skipped from the output, i.e. fields starting with the `#` character.
");

    private static Option<bool?> SkipEmpty { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--skip-empty",
        description: @"If `true` or `1` then empty items are skipped from the output.

Note that if used, the results might contain less items than the limit value.
");

    private static Option<bool?> Simplified { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--simplified",
        description: @"If `true` or `1` then, the endpoint applies the `fields=url,pageFunctionResult,errorInfo`
and `unwind=pageFunctionResult` query parameters. This feature is used to emulate simplified results provided by the
legacy Apify Crawler product and it's not recommended to use it in new integrations.
");

    private static Option<string?> View { get; } = new(
        name: @"--view")
    {
        Description = @"Defines the view configuration for dataset items based on the schema definition.
This parameter determines how the data will be filtered and presented.
For complete specification details, see the [dataset schema documentation](/actors/development/actor-definition/dataset-schema).
",
    };

    private static Option<bool?> SkipFailedPages { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--skip-failed-pages",
        description: @"If `true` or `1` then, the all the items with errorInfo property will be skipped from the output.

This feature is here to emulate functionality of API version 1 used for the legacy Apify Crawler product and it's not recommended to use it in new integrations.
");

    private static Option<string?> FeedTitle { get; } = new(
        name: @"--feed-title")
    {
        Description = @"Overrides the auto-generated RSS channel `<title>` element.
Only used when `format=rss`. If not provided, the title defaults to `Dataset <label>`.
",
    };

    private static Option<string?> FeedDescription { get; } = new(
        name: @"--feed-description")
    {
        Description = @"Overrides the auto-generated RSS channel `<description>` element.
Only used when `format=rss`. If not provided, the description defaults to `Items in dataset with id ""<datasetId>"".`
",
    };

                    private static string FormatResponse(ParseResult parseResult, global::System.Collections.Generic.IList<object> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::System.Collections.Generic.IList<object> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"act-run-sync-get-dataset-items-get", @"Run Actor synchronously without input and get dataset items
Runs a specific Actor and returns its dataset items.
The run must finish in 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds
otherwise the API endpoint returns a timeout error.
The Actor is not passed any input.

It allows to send all possible options in parameters from [Get Dataset
Items](#/reference/datasets/item-collection/get-items) API endpoint.

Beware that it might be impossible to maintain an idle HTTP connection for a
long period of time,
due to client timeout or network conditions. Make sure your HTTP client is
configured to have a long enough connection timeout.
If the connection breaks, you will not receive any information about the run
and its status.

To run the Actor asynchronously, use the [Run
Actor](#/reference/actors/run-collection/run-actor) API endpoint instead.
");
                        command.Arguments.Add(ActorId);
                        command.Options.Add(Timeout);
                        command.Options.Add(Memory);
                        command.Options.Add(MaxItems);
                        command.Options.Add(MaxTotalChargeUsd);
                        command.Options.Add(RestartOnError);
                        command.Options.Add(Build);
                        command.Options.Add(Webhooks);
                        command.Options.Add(Format);
                        command.Options.Add(Clean);
                        command.Options.Add(Offset);
                        command.Options.Add(Limit);
                        command.Options.Add(Fields);
                        command.Options.Add(OutputFields);
                        command.Options.Add(Omit);
                        command.Options.Add(Unwind);
                        command.Options.Add(Flatten);
                        command.Options.Add(Desc);
                        command.Options.Add(Attachment);
                        command.Options.Add(Delimiter);
                        command.Options.Add(Bom);
                        command.Options.Add(XmlRoot);
                        command.Options.Add(XmlRow);
                        command.Options.Add(SkipHeaderRow);
                        command.Options.Add(SkipHidden);
                        command.Options.Add(SkipEmpty);
                        command.Options.Add(Simplified);
                        command.Options.Add(View);
                        command.Options.Add(SkipFailedPages);
                        command.Options.Add(FeedTitle);
                        command.Options.Add(FeedDescription);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var timeout = parseResult.GetValue(Timeout);
                        var memory = parseResult.GetValue(Memory);
                        var maxItems = parseResult.GetValue(MaxItems);
                        var maxTotalChargeUsd = parseResult.GetValue(MaxTotalChargeUsd);
                        var restartOnError = parseResult.GetValue(RestartOnError);
                        var build = parseResult.GetValue(Build);
                        var webhooks = parseResult.GetValue(Webhooks);
                        var format = parseResult.GetValue(Format);
                        var clean = parseResult.GetValue(Clean);
                        var offset = parseResult.GetValue(Offset);
                        var limit = parseResult.GetValue(Limit);
                        var fields = parseResult.GetValue(Fields);
                        var outputFields = parseResult.GetValue(OutputFields);
                        var omit = parseResult.GetValue(Omit);
                        var unwind = parseResult.GetValue(Unwind);
                        var flatten = parseResult.GetValue(Flatten);
                        var desc = parseResult.GetValue(Desc);
                        var attachment = parseResult.GetValue(Attachment);
                        var delimiter = parseResult.GetValue(Delimiter);
                        var bom = parseResult.GetValue(Bom);
                        var xmlRoot = parseResult.GetValue(XmlRoot);
                        var xmlRow = parseResult.GetValue(XmlRow);
                        var skipHeaderRow = parseResult.GetValue(SkipHeaderRow);
                        var skipHidden = parseResult.GetValue(SkipHidden);
                        var skipEmpty = parseResult.GetValue(SkipEmpty);
                        var simplified = parseResult.GetValue(Simplified);
                        var view = parseResult.GetValue(View);
                        var skipFailedPages = parseResult.GetValue(SkipFailedPages);
                        var feedTitle = parseResult.GetValue(FeedTitle);
                        var feedDescription = parseResult.GetValue(FeedDescription);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorsActorRuns.ActRunSyncGetDatasetItemsGetAsync(
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
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Apify.SourceGenerationContext.Default,
                                        @"$self",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Apify.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}