#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ActorsWebhookCollectionApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"actors-webhook-collection", @"Actors/Webhook collection endpoint commands.");
                         command.Subcommands.Add(ActorsWebhookCollectionActWebhooksGetCommandApiCommand.Create());
        return command;
    }
}