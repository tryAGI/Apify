#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorGetCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or the username of the Actor owner and the Actor name, separated by a tilde (`~`).",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ActorResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ActorResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get", @"Get Actor
Gets an object that contains all the details about the Actor with the specified ID.");
                        command.Arguments.Add(ActorId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Actors.ActorGetAsync(
                                    actorId: actorId,
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