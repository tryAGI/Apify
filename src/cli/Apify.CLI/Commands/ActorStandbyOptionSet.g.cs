#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal sealed record ActorStandbyOptionSet(
    Option<bool?> IsEnabled,
                     Option<int?> DesiredRequestsPerActorRun,
                     Option<int?> MaxRequestsPerActorRun,
                     Option<int?> IdleTimeoutSecs,
                     Option<string?> Build,
                     Option<long?> MemoryMbytes,
                     Option<bool?> DisableStandbyFieldsOverride,
                     Option<bool?> ShouldPassActorInput)
{
    public static ActorStandbyOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ActorStandbyOptionSet(
                        IsEnabled: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}is-enabled", description: @""),
                DesiredRequestsPerActorRun: new Option<int?>($"--{normalizedPrefix}desired-requests-per-actor-run")
                {
                    Description = @"",
                },
                MaxRequestsPerActorRun: new Option<int?>($"--{normalizedPrefix}max-requests-per-actor-run")
                {
                    Description = @"",
                },
                IdleTimeoutSecs: new Option<int?>($"--{normalizedPrefix}idle-timeout-secs")
                {
                    Description = @"",
                },
                Build: new Option<string?>($"--{normalizedPrefix}build")
                {
                    Description = @"",
                },
                MemoryMbytes: new Option<long?>($"--{normalizedPrefix}memory-mbytes")
                {
                    Description = @"",
                },
                DisableStandbyFieldsOverride: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}disable-standby-fields-override", description: @""),
                ShouldPassActorInput: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}should-pass-actor-input", description: @"")
        );
    }
}