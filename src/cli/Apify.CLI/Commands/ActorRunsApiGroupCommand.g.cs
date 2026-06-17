#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ActorRunsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"actor-runs", @"Actor runs endpoint commands.");
                         command.Subcommands.Add(ActorRunsActorRunAbortPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorRunsActorRunDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ActorRunsActorRunGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorRunsActorRunLogGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorRunsActorRunMetamorphPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorRunsActorRunPutCommandApiCommand.Create());
                         command.Subcommands.Add(ActorRunsActorRunRebootPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorRunsActorRunsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorRunsPostChargeRunCommandApiCommand.Create());
                         command.Subcommands.Add(ActorRunsPostResurrectRunCommandApiCommand.Create());
        return command;
    }
}