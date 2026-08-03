#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorRunSDefaultKeyValueStoreActorRunsLastKeyValueStoreDeleteCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or the username of the Actor owner and the Actor name, separated by a tilde (`~`).",
    };

    private static Option<string?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter for the run status.",
    };

    private static Option<global::Apify.RunOrigin?> Origin { get; } = new(
        name: @"--origin")
    {
        Description = @"Filter for the run origin, i.e. the means by which the run was started.",
    };

    public static Command Create()
    {
        var command = new Command(@"actor-runs-last-key-value-store-delete", @"Delete last run's default store
Deletes the last Actor run key-value store.

This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the
[Delete store](/api/v2/key-value-store-delete) endpoint.
");
                        command.Arguments.Add(ActorId);
                        command.Options.Add(Status);
                        command.Options.Add(Origin);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var status = parseResult.GetValue(Status);
                        var origin = parseResult.GetValue(Origin);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.LastActorRunSDefaultKeyValueStore.ActorRunsLastKeyValueStoreDeleteAsync(
                                    actorId: actorId,
                                    status: status,
                                    origin: origin,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}