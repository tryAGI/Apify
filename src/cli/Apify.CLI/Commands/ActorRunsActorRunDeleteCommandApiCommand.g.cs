#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorRunsActorRunDeleteCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete", @"Delete run
Delete the run. Only finished runs can be deleted. Only the person or
organization that initiated the run can delete it.
");
                        command.Arguments.Add(RunId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetRequiredValue(RunId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.ActorRuns.ActorRunDeleteAsync(
                                    runId: runId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}