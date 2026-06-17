#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal sealed record UpdateStoreRequestOptionSet(
    Option<string?> NameOption,
                     Option<global::Apify.GeneralAccess?> GeneralAccess)
{
    public static UpdateStoreRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new UpdateStoreRequestOptionSet(
                        NameOption: new Option<string?>($"--{normalizedPrefix}name")
                {
                    Description = @"",
                },
                GeneralAccess: new Option<global::Apify.GeneralAccess?>($"--{normalizedPrefix}general-access")
                {
                    Description = @"Defines the general access level for the resource.",
                }
        );
    }
}