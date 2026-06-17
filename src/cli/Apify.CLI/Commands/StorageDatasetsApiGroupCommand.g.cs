#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class StorageDatasetsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"storage-datasets", @"Storage/Datasets endpoint commands.");
                         command.Subcommands.Add(StorageDatasetsDatasetDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetItemsGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetItemsGetAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetItemsHeadCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetItemsPostCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetPutCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetStatisticsGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetsGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetsPostCommandApiCommand.Create());
        return command;
    }
}