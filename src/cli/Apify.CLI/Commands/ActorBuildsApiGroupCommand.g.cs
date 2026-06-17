#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ActorBuildsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"actor-builds", @"Actor builds endpoint commands.");
                         command.Subcommands.Add(ActorBuildsActorBuildAbortPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorBuildsActorBuildDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ActorBuildsActorBuildGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorBuildsActorBuildLogGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorBuildsActorBuildOpenapiJsonGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorBuildsActorBuildsGetCommandApiCommand.Create());
        return command;
    }
}