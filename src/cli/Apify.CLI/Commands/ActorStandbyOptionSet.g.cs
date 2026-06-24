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
                        IsEnabled: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}is-enabled", description: @"Whether standby mode is enabled for the Actor."),
                DesiredRequestsPerActorRun: new Option<int?>($"--{normalizedPrefix}desired-requests-per-actor-run")
                {
                    Description = @"Target number of concurrent HTTP requests a single run is configured to handle.",
                },
                MaxRequestsPerActorRun: new Option<int?>($"--{normalizedPrefix}max-requests-per-actor-run")
                {
                    Description = @"Maximum number of concurrent HTTP requests that can be routed to a single run.",
                },
                IdleTimeoutSecs: new Option<int?>($"--{normalizedPrefix}idle-timeout-secs")
                {
                    Description = @"In seconds, how long a run can stay idle without incoming requests before it's terminated.",
                },
                Build: new Option<string?>($"--{normalizedPrefix}build")
                {
                    Description = @"Which build to run in standby mode. Either a build tag or a version number.",
                },
                MemoryMbytes: new Option<long?>($"--{normalizedPrefix}memory-mbytes")
                {
                    Description = @"In MB, the amount of memory allocated to the run.",
                },
                DisableStandbyFieldsOverride: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}disable-standby-fields-override", description: @"If `true`, prevents the standby mode configuration from being overridden elsewhere."),
                ShouldPassActorInput: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}should-pass-actor-input", description: @"Whether to pass the Actor's input to the standby run. If `false`, the standby runs start with no input.")
        );
    }
}