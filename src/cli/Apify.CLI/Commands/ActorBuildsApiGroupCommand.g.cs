#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorBuildsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"actor-builds", @"Actor builds endpoint commands.");
                         command.Subcommands.Add(ActorBuildsActorBuildAbortPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorBuildsActorBuildDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ActorBuildsActorBuildGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorBuildsActorBuildLogGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorBuildsActorBuildOpenapiJsonGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorBuildsActorBuildsGetCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}