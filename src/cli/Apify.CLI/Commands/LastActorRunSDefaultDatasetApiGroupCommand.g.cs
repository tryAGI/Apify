#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorRunSDefaultDatasetApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-default-dataset", @"Last Actor run's default dataset endpoint commands.");
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActRunsLastDatasetDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActRunsLastDatasetGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActRunsLastDatasetItemsGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActRunsLastDatasetItemsGetAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActRunsLastDatasetItemsPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActRunsLastDatasetPutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActRunsLastDatasetStatisticsGetCommandApiCommand.Create());
        return command;
    }
}