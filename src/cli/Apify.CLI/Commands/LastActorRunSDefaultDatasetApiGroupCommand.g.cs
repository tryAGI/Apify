#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorRunSDefaultDatasetApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-default-dataset", @"Last Actor run's default dataset endpoint commands.");
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActorRunsLastDatasetDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActorRunsLastDatasetGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActorRunsLastDatasetItemsGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActorRunsLastDatasetItemsGetAsBytesCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActorRunsLastDatasetItemsGetAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActorRunsLastDatasetItemsGetAsTextCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActorRunsLastDatasetItemsPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActorRunsLastDatasetPutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetActorRunsLastDatasetStatisticsGetCommandApiCommand.Create());
        return command;
    }
}