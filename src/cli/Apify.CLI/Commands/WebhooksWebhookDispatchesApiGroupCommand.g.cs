#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class WebhooksWebhookDispatchesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"webhooks-webhook-dispatches", @"Webhooks/Webhook dispatches endpoint commands.");
                         command.Subcommands.Add(WebhooksWebhookDispatchesWebhookDispatchGetCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhookDispatchesWebhookDispatchesGetCommandApiCommand.Create());
        return command;
    }
}