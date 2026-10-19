#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal sealed record EnvVarRequestOptionSet(
    Option<string> NameOption,
                     Option<string> Value,
                     Option<bool?> IsSecret)
{
    public static EnvVarRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new EnvVarRequestOptionSet(
                        NameOption: new Option<string>($"--{normalizedPrefix}name")
                {
                    Description = @"The name of the environment variable. Can't contain `=`.",
                    Required = true,
                },
                Value: new Option<string>($"--{normalizedPrefix}value")
                {
                    Description = @"The value of the environment variable.",
                    Required = true,
                },
                IsSecret: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}is-secret", description: @"Whether the environment variable is encrypted. Secret values aren't returned by the API.")
        );
    }
}