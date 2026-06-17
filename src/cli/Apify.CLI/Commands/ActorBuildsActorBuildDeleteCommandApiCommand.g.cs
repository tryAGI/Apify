#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorBuildsActorBuildDeleteCommandApiCommand
{
    private static Argument<string> BuildId { get; } = new(
        name: @"build-id")
    {
        Description = @"ID of the build, found in the build's Info tab.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete", @"Delete build
Delete the build. The build that is the current default build for the Actor
cannot be deleted.

Only users with build permissions for the Actor can delete builds.
");
                        command.Arguments.Add(BuildId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var buildId = parseResult.GetRequiredValue(BuildId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.ActorBuilds.ActorBuildDeleteAsync(
                                    buildId: buildId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}