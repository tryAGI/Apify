#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorTaskRunSDefaultDatasetActorTaskRunsLastDatasetDeleteCommandApiCommand
{
    private static Argument<string> ActorTaskId { get; } = new(
        name: @"actor-task-id")
    {
        Description = @"Task ID or a tilde-separated owner's username and task's name.",
    };

    private static Option<string?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter for the run status.",
    };

    public static Command Create()
    {
        var command = new Command(@"actor-task-runs-last-dataset-delete", @"Delete last task run's default dataset
Deletes the default dataset associated with the last Actor task run.

This endpoint is a shortcut for getting the last task run's `defaultDatasetId` and then using the
[Delete dataset](/api/v2/dataset-delete) endpoint.
");
                        command.Arguments.Add(ActorTaskId);
                        command.Options.Add(Status);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorTaskId = parseResult.GetRequiredValue(ActorTaskId);
                        var status = parseResult.GetValue(Status);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.LastActorTaskRunSDefaultDataset.ActorTaskRunsLastDatasetDeleteAsync(
                                    actorTaskId: actorTaskId,
                                    status: status,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}