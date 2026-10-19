#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal sealed record ScheduleNotificationsOptionSet(
    Option<bool?> Email)
{
    public static ScheduleNotificationsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ScheduleNotificationsOptionSet(
                        Email: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}email", description: @"")
        );
    }
}