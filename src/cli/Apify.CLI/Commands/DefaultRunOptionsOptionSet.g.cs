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
                    Description = @"Which build to run. Either a build tag or a version number.",
                },
                TimeoutSecs: new Option<int?>($"--{normalizedPrefix}timeout-secs")
                {
                    Description = @"Timeout in seconds. 0 if no timeout.",
                },
                MemoryMbytes: new Option<long?>($"--{normalizedPrefix}memory-mbytes")
                {
                    Description = @"In MB, the amount of memory allocated to the run.",
                },
                RestartOnError: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}restart-on-error", description: @"Whether to automatically restart the run if it fails."),
                MaxItems: new Option<int?>($"--{normalizedPrefix}max-items")
                {
                    Description = @"Maximum number of items the run might produce.",
                }
        );
    }
}