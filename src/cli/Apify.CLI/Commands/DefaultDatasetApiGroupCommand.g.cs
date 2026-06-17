#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class DefaultDatasetApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default-dataset", @"Default dataset endpoint commands.");
                         command.Subcommands.Add(DefaultDatasetActorRunDatasetDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultDatasetActorRunDatasetGetCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultDatasetActorRunDatasetItemsGetCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultDatasetActorRunDatasetItemsGetAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultDatasetActorRunDatasetItemsPostCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultDatasetActorRunDatasetPutCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultDatasetActorRunDatasetStatisticsGetCommandApiCommand.Create());
        return command;
    }
}