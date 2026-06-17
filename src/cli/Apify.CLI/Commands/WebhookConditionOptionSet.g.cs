#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal sealed record WebhookConditionOptionSet(
    Option<string?> ActorId,
                     Option<string?> ActorTaskId,
                     Option<string?> ActorRunId)
{
    public static WebhookConditionOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new WebhookConditionOptionSet(
                        ActorId: new Option<string?>($"--{normalizedPrefix}actor-id")
                {
                    Description = @"",
                },
                ActorTaskId: new Option<string?>($"--{normalizedPrefix}actor-task-id")
                {
                    Description = @"",
                },
                ActorRunId: new Option<string?>($"--{normalizedPrefix}actor-run-id")
                {
                    Description = @"",
                }
        );
    }
}