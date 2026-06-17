#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorRunsActRunsGetCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or a tilde-separated owner's username and Actor name.",
    };

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
        description: @"If `true` or `1` then the objects are sorted by the `startedAt` field in
descending order. By default, they are sorted in ascending order.
");

    private static Option<global::System.Collections.Generic.IList<string>?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Single status or comma-separated list of statuses, see ([available
statuses](https://docs.apify.com/platform/actors/running/runs-and-builds#lifecycle)). Used to filter runs by the specified statuses only.
",
    };

    private static Option<global::System.DateTime?> StartedAfter { get; } = new(
        name: @"--started-after")
    {
        Description = @"Filter runs that started after the specified date and time (inclusive).
The value must be a valid ISO 8601 datetime string (UTC).
",
    };

    private static Option<global::System.DateTime?> StartedBefore { get; } = new(
        name: @"--started-before")
    {
        Description = @"Filter runs that started before the specified date and time (inclusive).
The value must be a valid ISO 8601 datetime string (UTC).
",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ListOfRunsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ListOfRunsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"act-runs-get", @"Get list of runs
Gets the list of runs of a specific Actor. The response is a list of
objects, where each object contains basic information about a single Actor run.

The endpoint supports pagination using the `limit` and `offset` parameters
and it will not return more than 1000 array elements.

By default, the records are sorted by the `startedAt` field in ascending
order, therefore you can use pagination to incrementally fetch all records while
new ones are still being created. To sort the records in descending order, use
`desc=1` parameter. You can also filter runs by status ([available
statuses](https://docs.apify.com/platform/actors/running/runs-and-builds#lifecycle)).
");
                        command.Arguments.Add(ActorId);
                        command.Options.Add(Offset);
                        command.Options.Add(Limit);
                        command.Options.Add(Desc);
                        command.Options.Add(Status);
                        command.Options.Add(StartedAfter);
                        command.Options.Add(StartedBefore);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var offset = parseResult.GetValue(Offset);
                        var limit = parseResult.GetValue(Limit);
                        var desc = parseResult.GetValue(Desc);
                        var status = parseResult.GetValue(Status);
                        var startedAfter = parseResult.GetValue(StartedAfter);
                        var startedBefore = parseResult.GetValue(StartedBefore);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorsActorRuns.ActRunsGetAsync(
                                    actorId: actorId,
                                    offset: offset,
                                    limit: limit,
                                    desc: desc,
                                    status: status,
                                    startedAfter: startedAfter,
                                    startedBefore: startedBefore,
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