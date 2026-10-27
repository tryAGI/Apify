#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorOAuthAccountGetCommandApiCommand
{
    private static Argument<string> AccountId { get; } = new(
        name: @"account-id")
    {
        Description = @"Actor OAuth account ID.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ActorOAuthAccountResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ActorOAuthAccountResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"oauth-account-get", @"Get Actor OAuth account
Gets an account connected through an Actor OAuth connection, including its OAuth tokens.

This endpoint only accepts the API token of an Actor run (the `APIFY_TOKEN` environment variable of the run).
The run must belong to the Actor that the account's OAuth connection is configured on, and the account must
belong to the user the run's token acts for. Any other token gets a `403` error.
");
                        command.Arguments.Add(AccountId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var accountId = parseResult.GetRequiredValue(AccountId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Actors.ActorOAuthAccountGetAsync(
                                    accountId: accountId,
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