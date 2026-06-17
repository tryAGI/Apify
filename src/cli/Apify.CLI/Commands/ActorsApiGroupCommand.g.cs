#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ActorsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"actors", @"Actors endpoint commands.");
                         command.Subcommands.Add(ActorsActDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActPutCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActValidateInputPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActsPostCommandApiCommand.Create());
        return command;
    }
}