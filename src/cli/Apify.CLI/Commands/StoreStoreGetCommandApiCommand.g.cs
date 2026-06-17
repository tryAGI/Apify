#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StoreStoreGetCommandApiCommand
{
    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of items to return. The default value as well as the maximum is `1000`.
",
    };

    private static Option<double?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"Number of items that should be skipped at the start. The default value is `0`.
",
    };

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"String to search by. The search runs on the following fields: `title`,
`name`, `description`, `username`, `readme`.
",
    };

    private static Option<string?> SortBy { get; } = new(
        name: @"--sort-by")
    {
        Description = @"Specifies the field by which to sort the results. The supported values
are `relevance` (default), `popularity`, `newest` and `lastUpdate`.
",
    };

    private static Option<string?> Category { get; } = new(
        name: @"--category")
    {
        Description = @"Filters the results by the specified category.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ListOfActorsInStoreResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ListOfActorsInStoreResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get", @"Get list of Actors in Store
Gets the list of public Actors in Apify Store. You can use `search`
parameter to search Actors by string in title, name, description, username
and readme.
If you need detailed info about a specific Actor, use the [Get
Actor](#/reference/actors/actor-object/get-actor) endpoint.

The endpoint supports pagination using the `limit` and `offset` parameters.
It will not return more than 1,000 records.
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
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Apify.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}