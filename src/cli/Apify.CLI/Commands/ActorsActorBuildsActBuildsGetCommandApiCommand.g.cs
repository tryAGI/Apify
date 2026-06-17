#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorBuildsActBuildsGetCommandApiCommand
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ListOfBuildsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ListOfBuildsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"act-builds-get", @"Get list of builds
Gets the list of builds of a specific Actor. The response is a JSON with the
list of objects, where each object contains basic information about a single build.

The endpoint supports pagination using the `limit` and `offset` parameters
and it will not return more than 1000 records.

By default, the records are sorted by the `startedAt` field in ascending order,
therefore you can use pagination to incrementally fetch all builds while new
ones are still being started. To sort the records in descending order, use
the `desc=1` parameter.
");
                        command.Arguments.Add(ActorId);
                        command.Options.Add(Offset);
                        command.Options.Add(Limit);
                        command.Options.Add(Desc);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var offset = parseResult.GetValue(Offset);
                        var limit = parseResult.GetValue(Limit);
                        var desc = parseResult.GetValue(Desc);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorsActorBuilds.ActBuildsGetAsync(
                                    actorId: actorId,
                                    offset: offset,
                                    limit: limit,
                                    desc: desc,
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