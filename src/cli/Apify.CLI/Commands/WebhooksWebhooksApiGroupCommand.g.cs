#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class WebhooksWebhooksApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"webhooks-webhooks", @"Webhooks/Webhooks endpoint commands.");
                         command.Subcommands.Add(WebhooksWebhooksWebhookDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksWebhookGetCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksWebhookPutCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksWebhookTestPostCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksWebhookWebhookDispatchesGetCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksWebhooksGetCommandApiCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksWebhooksPostCommandApiCommand.Create());
        return command;
    }
}