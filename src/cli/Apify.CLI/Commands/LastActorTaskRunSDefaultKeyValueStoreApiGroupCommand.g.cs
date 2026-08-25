#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorTaskRunSDefaultKeyValueStoreApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-task-run-s-default-key-value-store", @"Last Actor task run's default key-value store endpoint commands.");
                         command.Subcommands.Add(LastActorTaskRunSDefaultKeyValueStoreActorTaskRunsLastKeyValueStoreDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultKeyValueStoreActorTaskRunsLastKeyValueStoreGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultKeyValueStoreActorTaskRunsLastKeyValueStoreKeysGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultKeyValueStoreActorTaskRunsLastKeyValueStorePutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultKeyValueStoreActorTaskRunsLastKeyValueStoreRecordDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultKeyValueStoreActorTaskRunsLastKeyValueStoreRecordGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultKeyValueStoreActorTaskRunsLastKeyValueStoreRecordGetAsBytesCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultKeyValueStoreActorTaskRunsLastKeyValueStoreRecordPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultKeyValueStoreActorTaskRunsLastKeyValueStoreRecordPutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultKeyValueStoreActorTaskRunsLastKeyValueStoreRecordsGetCommandApiCommand.Create());
        return command;
    }
}