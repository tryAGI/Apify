#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsWebhookCollectionApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"actors-webhook-collection", @"Actors/Webhook collection endpoint commands.");
                         command.Subcommands.Add(ActorsWebhookCollectionActorWebhooksGetCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}