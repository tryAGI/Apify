#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageDatasetsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"storage-datasets", @"Storage/Datasets endpoint commands.");
                         command.Subcommands.Add(StorageDatasetsDatasetDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetItemsGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetItemsGetAsBytesCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetItemsGetAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetItemsGetAsTextCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetItemsHeadCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetItemsPostCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetPutCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetStatisticsGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetsGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageDatasetsDatasetsPostCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}