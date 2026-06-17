#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal sealed record DefaultRunOptionsOptionSet(
    Option<string?> Build,
                     Option<int?> TimeoutSecs,
                     Option<long?> MemoryMbytes,
                     Option<bool?> RestartOnError,
                     Option<int?> MaxItems)
{
    public static DefaultRunOptionsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new DefaultRunOptionsOptionSet(
                        Build: new Option<string?>($"--{normalizedPrefix}build")
                {
                    Description = @"",
                },
                TimeoutSecs: new Option<int?>($"--{normalizedPrefix}timeout-secs")
                {
                    Description = @"",
                },
                MemoryMbytes: new Option<long?>($"--{normalizedPrefix}memory-mbytes")
                {
                    Description = @"",
                },
                RestartOnError: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}restart-on-error", description: @""),
                MaxItems: new Option<int?>($"--{normalizedPrefix}max-items")
                {
                    Description = @"",
                }
        );
    }
}