#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal sealed record ScheduleCreateOptionSet(
    Option<string?> NameOption,
                     Option<bool?> IsEnabled,
                     Option<bool?> IsExclusive,
                     Option<string?> CronExpression,
                     Option<string?> Timezone,
                     Option<string?> DescriptionOption,
                     Option<string?> Title)
{
    public static ScheduleCreateOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ScheduleCreateOptionSet(
                        NameOption: new Option<string?>($"--{normalizedPrefix}name")
                {
                    Description = @"",
                },
                IsEnabled: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}is-enabled", description: @""),
                IsExclusive: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}is-exclusive", description: @""),
                CronExpression: new Option<string?>($"--{normalizedPrefix}cron-expression")
                {
                    Description = @"",
                },
                Timezone: new Option<string?>($"--{normalizedPrefix}timezone")
                {
                    Description = @"",
                },
                DescriptionOption: new Option<string?>($"--{normalizedPrefix}description")
                {
                    Description = @"",
                },
                Title: new Option<string?>($"--{normalizedPrefix}title")
                {
                    Description = @"",
                }
        );
    }
}