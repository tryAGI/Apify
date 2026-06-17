#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class DefaultRequestQueueActorRunRequestQueueDeleteCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
    };

    public static Command Create()
    {
        var command = new Command(@"actor-run-request-queue-delete", @"Delete default request queue
Deletes the default request queue associated with an Actor run.

This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the
[Delete request queue](/api/v2/request-queue-delete) endpoint.
");
                        command.Arguments.Add(RunId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetRequiredValue(RunId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.DefaultRequestQueue.ActorRunRequestQueueDeleteAsync(
                                    runId: runId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}