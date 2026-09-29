#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class DefaultKeyValueStoreActorRunKeyValueStoreRecordDeleteCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
    };

    private static Argument<string> RecordKey { get; } = new(
        name: @"record-key")
    {
        Description = @"Key of the record.",
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"actor-run-key-value-store-record-delete", @"Delete default store's record
Removes a record specified by a key from the default key-value store of the Actor run.

This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the
[Delete record](/api/v2/key-value-store-record-delete) endpoint.
");
                        command.Arguments.Add(RunId);
                        command.Arguments.Add(RecordKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetRequiredValue(RunId);
                        var recordKey = parseResult.GetRequiredValue(RecordKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.DefaultKeyValueStore.ActorRunKeyValueStoreRecordDeleteAsync(
                                    runId: runId,
                                    recordKey: recordKey,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}