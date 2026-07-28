#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ActorsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"actors", @"Actors endpoint commands.");
                         command.Subcommands.Add(ActorsActorDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorPutCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorValidateInputPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorsPostCommandApiCommand.Create());
        return command;
    }
}