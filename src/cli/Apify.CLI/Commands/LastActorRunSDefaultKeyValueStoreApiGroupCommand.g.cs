#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorRunSDefaultKeyValueStoreApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-default-key-value-store", @"Last Actor run's default key-value store endpoint commands.");
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActorRunsLastKeyValueStoreDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActorRunsLastKeyValueStoreGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActorRunsLastKeyValueStoreKeysGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActorRunsLastKeyValueStorePutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActorRunsLastKeyValueStoreRecordDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActorRunsLastKeyValueStoreRecordGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActorRunsLastKeyValueStoreRecordGetAsBytesCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActorRunsLastKeyValueStoreRecordPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActorRunsLastKeyValueStoreRecordPutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreActorRunsLastKeyValueStoreRecordsGetCommandApiCommand.Create());
        return command;
    }
}