#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class StorageKeyValueStoresApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"storage-key-value-stores", @"Storage/Key-value stores endpoint commands.");
                         command.Subcommands.Add(StorageKeyValueStoresKeyValueStoreDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(StorageKeyValueStoresKeyValueStoreGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageKeyValueStoresKeyValueStoreKeysGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageKeyValueStoresKeyValueStorePutCommandApiCommand.Create());
                         command.Subcommands.Add(StorageKeyValueStoresKeyValueStoreRecordDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(StorageKeyValueStoresKeyValueStoreRecordGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageKeyValueStoresKeyValueStoreRecordGetAsBytesCommandApiCommand.Create());
                         command.Subcommands.Add(StorageKeyValueStoresKeyValueStoreRecordHeadCommandApiCommand.Create());
                         command.Subcommands.Add(StorageKeyValueStoresKeyValueStoreRecordPostCommandApiCommand.Create());
                         command.Subcommands.Add(StorageKeyValueStoresKeyValueStoreRecordPutCommandApiCommand.Create());
                         command.Subcommands.Add(StorageKeyValueStoresKeyValueStoreRecordsGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageKeyValueStoresKeyValueStoresGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageKeyValueStoresKeyValueStoresPostCommandApiCommand.Create());
        return command;
    }
}