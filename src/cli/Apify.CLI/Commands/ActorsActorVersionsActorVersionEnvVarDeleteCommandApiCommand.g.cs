#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorVersionsActorVersionEnvVarDeleteCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or the username of the Actor owner and the Actor name, separated by a tilde (`~`).",
    };

    private static Argument<string> VersionNumber { get; } = new(
        name: @"version-number")
    {
        Description = @"Actor version.",
    };

    private static Argument<string> EnvVarName { get; } = new(
        name: @"env-var-name")
    {
        Description = @"The name of the environment variable",
    };

                    private static string FormatResponse(ParseResult parseResult, string value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, string value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"actor-version-env-var-delete", @"Delete environment variable
Deletes a specific environment variable.");
                        command.Arguments.Add(ActorId);
                        command.Arguments.Add(VersionNumber);
                        command.Arguments.Add(EnvVarName);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var versionNumber = parseResult.GetRequiredValue(VersionNumber);
                        var envVarName = parseResult.GetRequiredValue(EnvVarName);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorsActorVersions.ActorVersionEnvVarDeleteAsync(
                                    actorId: actorId,
                                    versionNumber: versionNumber,
                                    envVarName: envVarName,
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