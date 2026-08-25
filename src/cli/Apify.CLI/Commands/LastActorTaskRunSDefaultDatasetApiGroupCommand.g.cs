#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorTaskRunSDefaultDatasetApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-task-run-s-default-dataset", @"Last Actor task run's default dataset endpoint commands.");
                         command.Subcommands.Add(LastActorTaskRunSDefaultDatasetActorTaskRunsLastDatasetDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultDatasetActorTaskRunsLastDatasetGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultDatasetActorTaskRunsLastDatasetItemsGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultDatasetActorTaskRunsLastDatasetItemsGetAsBytesCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultDatasetActorTaskRunsLastDatasetItemsGetAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultDatasetActorTaskRunsLastDatasetItemsGetAsTextCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultDatasetActorTaskRunsLastDatasetItemsPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultDatasetActorTaskRunsLastDatasetPutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultDatasetActorTaskRunsLastDatasetStatisticsGetCommandApiCommand.Create());
        return command;
    }
}