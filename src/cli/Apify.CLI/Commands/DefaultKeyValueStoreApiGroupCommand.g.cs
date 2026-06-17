#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class DefaultKeyValueStoreApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default-key-value-store", @"Default key-value store endpoint commands.");
                         command.Subcommands.Add(DefaultKeyValueStoreActorRunKeyValueStoreDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultKeyValueStoreActorRunKeyValueStoreGetCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultKeyValueStoreActorRunKeyValueStoreKeysGetCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultKeyValueStoreActorRunKeyValueStorePutCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultKeyValueStoreActorRunKeyValueStoreRecordDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultKeyValueStoreActorRunKeyValueStoreRecordGetCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultKeyValueStoreActorRunKeyValueStoreRecordPostCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultKeyValueStoreActorRunKeyValueStoreRecordPutCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultKeyValueStoreActorRunKeyValueStoreRecordsGetCommandApiCommand.Create());
        return command;
    }
}