#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorTaskRunSDefaultKeyValueStoreActorTaskRunsLastKeyValueStoreDeleteCommandApiCommand
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
        var command = new Command(@"actor-task-runs-last-key-value-store-delete", @"Delete last task run's default store
Deletes the default key-value store of the last Actor task run.

This endpoint is a shortcut for getting the last task run's `defaultKeyValueStoreId` and then using the
[Delete store](/api/v2/key-value-store-delete) endpoint.
");
                        command.Arguments.Add(ActorTaskId);
                        command.Options.Add(Status);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorTaskId = parseResult.GetRequiredValue(ActorTaskId);
                        var status = parseResult.GetValue(Status);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.LastActorTaskRunSDefaultKeyValueStore.ActorTaskRunsLastKeyValueStoreDeleteAsync(
                                    actorTaskId: actorTaskId,
                                    status: status,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}