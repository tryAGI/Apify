#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StoreStoreGetCommandApiCommand
{
    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of items to return. The default value as well as the
maximum is `1000`. When `search` is used, the default and maximum are
`100`, and larger values are reduced to `100`.
",
    };

    private static Option<double?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"Number of items that should be skipped at the start. The default value
is `0`. Ignored when `search` is used.
",
    };

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"String to search by. Results are ranked by relevance and returned as a
single page of at most 100 items.
",
    };

    private static Option<string?> SortBy { get; } = new(
        name: @"--sort-by")
    {
        Description = @"Deprecated and ignored. The value is accepted for backward
compatibility but has no effect. Results are ordered by relevance when
`search` is used, and by Store position otherwise. Sort the results
on the client if you need a different order.
",
    };

    private static Option<string?> Category { get; } = new(
        name: @"--category")
    {
        Description = @"Filters the results by category. Accepts one or more category IDs,
separated by commas and case-insensitive. An Actor must match all of
the listed categories. See the
[list of category IDs](https://github.com/apify/apify-shared-js/blob/master/packages/actor-categories/src/actor_categories.ts).
Legacy keys such as `social_media` are still accepted. An unknown
category returns a `400` error.
",
    };

    private static Option<string?> Username { get; } = new(
        name: @"--username")
    {
        Description = @"Filters the results by the specified username.",
    };

    private static Option<global::Apify.StoreGetPricingModel?> PricingModel { get; } = new(
        name: @"--pricing-model")
    {
        Description = @"Only return Actors with the specified pricing model.
",
    };

    private static Option<bool?> AllowsAgenticUsers { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--allows-agentic-users",
        description: @"If true, only return Actors that allow agentic users. If false, only
return Actors that do not allow agentic users.
");

    private static Option<global::Apify.StoreGetResponseFormat?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"Controls the shape of the response. Use `full` (default) for the
complete response including image URLs and all fields. Use `agent`
for a reduced field set optimized for LLM consumers, which only
includes `id`, `title`, `name`, `username`, `description`, `notice`,
`badge`, `categories`, and minimal `stats`.
",
    };

    private static Option<bool?> IncludeUnrunnableActors { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-unrunnable-actors",
        description: @"By default, search results exclude Actors that are not safe to run
automatically (e.g. Actors from developers who haven't passed KYC, or
full-permission Actors without a large user base). Set to `true` to
bypass this safety filtering and include all Actors in the results.
");

    private static Option<bool?> IncludeInputSchema { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-input-schema",
        description: @"If `true`, each Actor in the results includes an `inputSchema` field with a compact version of the input
schema of its default build (property types and required properties only). With this parameter, `limit`
defaults to and can't exceed `10`.
");

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ListOfStoreActorsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ListOfStoreActorsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get", @"Get list of Actors in Store
Gets the list of public Actors in Apify Store. You can use `search`
parameter to search Actors by string in title, name, description, username
and readme.
If you need detailed info about a specific Actor, use the [Get Actor](/api/v2/actor-get) endpoint.

Without `search`, the endpoint supports pagination using the `limit` and
`offset` parameters. It will not return more than 1,000 records per page.

With `search`, results are ranked by relevance and returned as a single
page of at most 100 records. `offset` is ignored and there is no second
page. `total` and `count` equal the number of returned items. To narrow
the results, use `category`, `username` or `pricingModel`.
");
                        command.Options.Add(Limit);
                        command.Options.Add(Offset);
                        command.Options.Add(Search);
                        command.Options.Add(SortBy);
                        command.Options.Add(Category);
                        command.Options.Add(Username);
                        command.Options.Add(PricingModel);
                        command.Options.Add(AllowsAgenticUsers);
                        command.Options.Add(ResponseFormat);
                        command.Options.Add(IncludeUnrunnableActors);
                        command.Options.Add(IncludeInputSchema);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var limit = parseResult.GetValue(Limit);
                        var offset = parseResult.GetValue(Offset);
                        var search = parseResult.GetValue(Search);
                        var sortBy = parseResult.GetValue(SortBy);
                        var category = parseResult.GetValue(Category);
                        var username = parseResult.GetValue(Username);
                        var pricingModel = parseResult.GetValue(PricingModel);
                        var allowsAgenticUsers = parseResult.GetValue(AllowsAgenticUsers);
                        var responseFormat = parseResult.GetValue(ResponseFormat);
                        var includeUnrunnableActors = parseResult.GetValue(IncludeUnrunnableActors);
                        var includeInputSchema = parseResult.GetValue(IncludeInputSchema);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Store.StoreGetAsync(
                                    limit: limit,
                                    offset: offset,
                                    search: search,
                                    sortBy: sortBy,
                                    category: category,
                                    username: username,
                                    pricingModel: pricingModel,
                                    allowsAgenticUsers: allowsAgenticUsers,
                                    responseFormat: responseFormat,
                                    includeUnrunnableActors: includeUnrunnableActors,
                                    includeInputSchema: includeInputSchema,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Apify.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}