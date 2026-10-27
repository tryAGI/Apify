#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal sealed record UpdateLimitsRequestOptionSet(
    Option<double?> MaxMonthlyUsageUsd,
                     Option<int?> DataRetentionDays)
{
    public static UpdateLimitsRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new UpdateLimitsRequestOptionSet(
                        MaxMonthlyUsageUsd: new Option<double?>($"--{normalizedPrefix}max-monthly-usage-usd")
                {
                    Description = @"If your platform usage in the billing period exceeds the prepaid usage, you will be charged extra. Setting this property you can update your hard limit on monthly platform usage to prevent accidental overage or to limit the extra charges.
",
                },
                DataRetentionDays: new Option<int?>($"--{normalizedPrefix}data-retention-days")
                {
                    Description = @"Apify securely stores your ten most recent Actor runs indefinitely, ensuring they are always accessible. Unnamed storages and other Actor runs are automatically deleted after the retention period. If you're subscribed, you can change it to keep data for longer or to limit your usage. [Lear more](https://docs.apify.com/storage#data-retention).
",
                }
        );
    }
}