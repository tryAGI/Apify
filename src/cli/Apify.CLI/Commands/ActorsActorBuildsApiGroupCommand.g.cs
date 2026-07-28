#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ActorsActorBuildsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"actors-actor-builds", @"Actors/Actor builds endpoint commands.");
                         command.Subcommands.Add(ActorsActorBuildsActorBuildDefaultGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorBuildsActorOpenapiJsonGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorBuildsActorsBuildsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorBuildsActorsBuildsPostCommandApiCommand.Create());
        return command;
    }
}