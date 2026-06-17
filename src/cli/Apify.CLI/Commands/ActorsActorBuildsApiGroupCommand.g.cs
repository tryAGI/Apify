#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ActorsActorBuildsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"actors-actor-builds", @"Actors/Actor builds endpoint commands.");
                         command.Subcommands.Add(ActorsActorBuildsActBuildDefaultGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorBuildsActBuildsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorBuildsActBuildsPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorBuildsActOpenapiJsonGetCommandApiCommand.Create());
        return command;
    }
}