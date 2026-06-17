#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class DefaultKeyValueStoreActorRunKeyValueStoreDeleteCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
    };

    public static Command Create()
    {
        var command = new Command(@"actor-run-key-value-store-delete", @"Delete default store
Delete the default key-value store.

This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the
[Delete store](/api/v2/key-value-store-delete) endpoint.
");
                        command.Arguments.Add(RunId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetRequiredValue(RunId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.DefaultKeyValueStore.ActorRunKeyValueStoreDeleteAsync(
                                    runId: runId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}