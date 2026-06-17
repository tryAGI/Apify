#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActsGetCommandApiCommand
{
    private static Option<bool?> My { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--my",
        description: @"If `true` or `1` then the returned list only contains Actors owned by the user. The default value is `false`.
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
        Description = @"Maximum number of items to return. The default value as well as the maximum is `1000`.
",
    };

    private static Option<bool?> Desc { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--desc",
        description: @"If `true` or `1` then the objects are sorted by the `createdAt` field in
descending order. By default, they are sorted in ascending order.
");

    private static Option<global::Apify.ActsGetSortBy?> SortBy { get; } = new(
        name: @"--sort-by")
    {
        Description = @"Field to sort the records by. The default is `createdAt`. You can also use `stats.lastRunStartedAt` to sort
by the most recently ran Actors.
",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ListOfActorsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ListOfActorsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"acts-get", @"Get list of Actors
Gets the list of all Actors that the user created or used. The response is a
list of objects, where each object contains a basic information about a single Actor.

To only get Actors created by the user, add the `my=1` query parameter.

The endpoint supports pagination using the `limit` and `offset` parameters
and it will not return more than 1000 records.

By default, the records are sorted by the `createdAt` field in ascending
order, therefore you can use pagination to incrementally fetch all Actors while new
ones are still being created. To sort the records in descending order, use the `desc=1` parameter.

You can also sort by your last run by using the `sortBy=stats.lastRunStartedAt` query parameter.
In this case, descending order means the most recently run Actor appears first.
");
                        command.Options.Add(My);
                        command.Options.Add(Offset);
                        command.Options.Add(Limit);
                        command.Options.Add(Desc);
                        command.Options.Add(SortBy);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var my = parseResult.GetValue(My);
                        var offset = parseResult.GetValue(Offset);
                        var limit = parseResult.GetValue(Limit);
                        var desc = parseResult.GetValue(Desc);
                        var sortBy = parseResult.GetValue(SortBy);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Actors.ActsGetAsync(
                                    my: my,
                                    offset: offset,
                                    limit: limit,
                                    desc: desc,
                                    sortBy: sortBy,
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