#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ActorsActorVersionsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"actors-actor-versions", @"Actors/Actor versions endpoint commands.");
                         command.Subcommands.Add(ActorsActorVersionsActorVersionDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActorVersionEnvVarDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActorVersionEnvVarGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActorVersionEnvVarPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActorVersionEnvVarPutCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActorVersionEnvVarsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActorVersionEnvVarsPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActorVersionGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActorVersionPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActorVersionPutCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActorVersionsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActorVersionsPostCommandApiCommand.Create());
        return command;
    }
}