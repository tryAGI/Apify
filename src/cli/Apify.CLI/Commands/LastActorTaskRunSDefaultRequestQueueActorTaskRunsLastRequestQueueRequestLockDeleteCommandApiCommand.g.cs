#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueRequestLockDeleteCommandApiCommand
{
    private static Argument<string> ActorTaskId { get; } = new(
        name: @"actor-task-id")
    {
        Description = @"Task ID or a tilde-separated owner's username and task's name.",
    };

    private static Argument<string> RequestId { get; } = new(
        name: @"request-id")
    {
        Description = @"Request ID.",
    };

    private static Option<string?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter for the run status.",
    };

    private static Option<string?> ClientKey { get; } = new(
        name: @"--client-key")
    {
        Description = @"A unique identifier of the client accessing the request queue. It must
be a string between 1 and 32 characters long. This identifier is used to
determine whether the queue was accessed by multiple clients. If
`clientKey` is not provided,
the system considers this API call to come from a new client. For
details, see the `hadMultipleClients` field returned by the [Get
head](#/reference/request-queues/queue-head) operation.
",
    };

    private static Option<string?> Forefront { get; } = new(
        name: @"--forefront")
    {
        Description = @"Determines if request should be added to the head of the queue or to the
end after lock was removed.
",
    };

    public static Command Create()
    {
        var command = new Command(@"actor-task-runs-last-request-queue-request-lock-delete", @"Delete lock on request in last task run's default request queue
Deletes a request lock in the default request queue of the last Actor task run.

This endpoint is a shortcut for getting the last task run's `defaultRequestQueueId` and then using the
[Delete request lock](/api/v2/request-queue-request-lock-delete) endpoint.
");
                        command.Arguments.Add(ActorTaskId);
                        command.Arguments.Add(RequestId);
                        command.Options.Add(Status);
                        command.Options.Add(ClientKey);
                        command.Options.Add(Forefront);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorTaskId = parseResult.GetRequiredValue(ActorTaskId);
                        var requestId = parseResult.GetRequiredValue(RequestId);
                        var status = parseResult.GetValue(Status);
                        var clientKey = parseResult.GetValue(ClientKey);
                        var forefront = parseResult.GetValue(Forefront);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.LastActorTaskRunSDefaultRequestQueue.ActorTaskRunsLastRequestQueueRequestLockDeleteAsync(
                                    actorTaskId: actorTaskId,
                                    requestId: requestId,
                                    status: status,
                                    clientKey: clientKey,
                                    forefront: forefront,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}