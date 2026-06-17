#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorTaskRunSDefaultKeyValueStoreActorTaskRunsLastKeyValueStoreRecordsGetCommandApiCommand
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

    private static Option<string?> Collection { get; } = new(
        name: @"--collection")
    {
        Description = @"If specified, only records belonging to a specific collection from the key-value store schema. The key-value store need to have a schema defined for this parameter to work.
",
    };

    private static Option<string?> Prefix { get; } = new(
        name: @"--prefix")
    {
        Description = @"If specified, only records whose key starts with the given prefix are included in the archive.
",
    };

    private static Option<string?> Signature { get; } = new(
        name: @"--signature")
    {
        Description = @"Signature used for the access.",
    };

    public static Command Create()
    {
        var command = new Command(@"actor-task-runs-last-key-value-store-records-get", @"Download last task run's default store's records
Downloads all records from the default key-value store of the last Actor task run as a ZIP archive.

This endpoint is a shortcut for getting the last task run's `defaultKeyValueStoreId` and then using the
[Download records](/api/v2/key-value-store-records-get) endpoint.
");
                        command.Arguments.Add(ActorTaskId);
                        command.Options.Add(Status);
                        command.Options.Add(Collection);
                        command.Options.Add(Prefix);
                        command.Options.Add(Signature);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorTaskId = parseResult.GetRequiredValue(ActorTaskId);
                        var status = parseResult.GetValue(Status);
                        var collection = parseResult.GetValue(Collection);
                        var prefix = parseResult.GetValue(Prefix);
                        var signature = parseResult.GetValue(Signature);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LastActorTaskRunSDefaultKeyValueStore.ActorTaskRunsLastKeyValueStoreRecordsGetAsync(
                                    actorTaskId: actorTaskId,
                                    status: status,
                                    collection: collection,
                                    prefix: prefix,
                                    signature: signature,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}