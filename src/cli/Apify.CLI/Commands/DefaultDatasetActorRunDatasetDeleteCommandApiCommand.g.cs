#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class DefaultDatasetActorRunDatasetDeleteCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
    };

    public static Command Create()
    {
        var command = new Command(@"actor-run-dataset-delete", @"Delete default dataset
Deletes default dataset associated with an Actor run.

This endpoint is a shortcut for getting the last run's `defaultDatasetId` and then using the
[ Delete dataset ](/api/v2/dataset-delete) endpoint.
");
                        command.Arguments.Add(RunId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetRequiredValue(RunId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.DefaultDataset.ActorRunDatasetDeleteAsync(
                                    runId: runId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}