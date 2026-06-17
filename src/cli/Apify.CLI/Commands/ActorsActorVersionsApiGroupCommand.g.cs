#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ActorsActorVersionsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"actors-actor-versions", @"Actors/Actor versions endpoint commands.");
                         command.Subcommands.Add(ActorsActorVersionsActVersionDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActVersionEnvVarDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActVersionEnvVarGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActVersionEnvVarPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActVersionEnvVarPutCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActVersionEnvVarsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActVersionEnvVarsPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActVersionGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActVersionPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActVersionPutCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActVersionsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsActVersionsPostCommandApiCommand.Create());
        return command;
    }
}