#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorBuildsActorsBuildsPostCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or the username of the Actor owner and the Actor name, separated by a tilde (`~`).",
    };

    private static Option<string> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Actor version number to be built.",
        Required = true,
    };

    private static Option<bool?> UseCache { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--use-cache",
        description: @"If `true` or `1`, the system will use a cache to speed up the build
process. By default, cache is not used.
");

    private static Option<bool?> BetaPackages { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--beta-packages",
        description: @"If `true` or `1` then the Actor is built with beta versions of Apify NPM
packages. By default, the build uses `latest` packages.
");

    private static Option<string?> Tag { get; } = new(
        name: @"--tag")
    {
        Description = @"Tag to be applied to the build on success. By default, the tag is taken
from Actor version's `buildTag` property.
",
    };

    private static Option<double?> WaitForFinish { get; } = new(
        name: @"--wait-for-finish")
    {
        Description = @"The maximum number of seconds the server waits for the build to finish.
By default it is `0`, the maximum value is `60`. <!-- MAX_ACTOR_JOB_ASYNC_WAIT_SECS -->
If the build finishes in time then the returned build object will have a
terminal status (e.g. `SUCCEEDED`), otherwise it will have a transitional status (e.g. `RUNNING`).
",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.BuildResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.BuildResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"actors-builds-post", @"Build Actor
Builds an Actor.
The response is the build object as returned by the
[Get build](#/reference/actors/build-object/get-build) endpoint.
");
                        command.Arguments.Add(ActorId);
                        command.Options.Add(Version);
                        command.Options.Add(UseCache);
                        command.Options.Add(BetaPackages);
                        command.Options.Add(Tag);
                        command.Options.Add(WaitForFinish);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var version = parseResult.GetRequiredValue(Version);
                        var useCache = parseResult.GetValue(UseCache);
                        var betaPackages = parseResult.GetValue(BetaPackages);
                        var tag = parseResult.GetValue(Tag);
                        var waitForFinish = parseResult.GetValue(WaitForFinish);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorsActorBuilds.ActorsBuildsPostAsync(
                                    actorId: actorId,
                                    version: version,
                                    useCache: useCache,
                                    betaPackages: betaPackages,
                                    tag: tag,
                                    waitForFinish: waitForFinish,
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