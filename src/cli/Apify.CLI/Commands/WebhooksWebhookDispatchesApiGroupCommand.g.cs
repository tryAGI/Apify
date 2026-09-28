#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class WebhooksWebhookDispatchesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"webhooks-webhook-dispatches", @"Webhooks/Webhook dispatches endpoint commands.");
                         command.Subcommands.Add(WebhooksWebhookDispatchesWebhookDispatchGetCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhookDispatchesWebhookDispatchesGetCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}