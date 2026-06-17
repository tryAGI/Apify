#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorRunSDefaultKeyValueStoreApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-default-key-value-store", @"Last Actor run's default key-value store endpoint commands.");
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActRunsLastKeyValueStoreDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActRunsLastKeyValueStoreGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActRunsLastKeyValueStoreKeysGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActRunsLastKeyValueStorePutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActRunsLastKeyValueStoreRecordDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActRunsLastKeyValueStoreRecordGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActRunsLastKeyValueStoreRecordPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActRunsLastKeyValueStoreRecordPutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActRunsLastKeyValueStoreRecordsGetCommandApiCommand.Create());
        return command;
    }
}