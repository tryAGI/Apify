#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorRunSDefaultDatasetActRunsLastDatasetDeleteCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or a tilde-separated owner's username and Actor name.",
    };

    private static Option<string?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter for the run status.",
    };

    public static Command Create()
    {
        var command = new Command(@"act-runs-last-dataset-delete", @"Delete last run's default dataset
Deletes the default dataset associated with the last Actor run.

This endpoint is a shortcut for getting the last run's `defaultDatasetId` and then using the
[Delete dataset](/api/v2/dataset-delete) endpoint.
");
                        command.Arguments.Add(ActorId);
                        command.Options.Add(Status);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var status = parseResult.GetValue(Status);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.LastActorRunSDefaultDataset.ActRunsLastDatasetDeleteAsync(
                                    actorId: actorId,
                                    status: status,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}