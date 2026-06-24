#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal sealed record ExampleRunInputOptionSet(
    Option<string?> Body,
                     Option<string?> ContentType)
{
    public static ExampleRunInputOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ExampleRunInputOptionSet(
                        Body: new Option<string?>($"--{normalizedPrefix}body")
                {
                    Description = @"Sample input, serialized as a string.",
                },
                ContentType: new Option<string?>($"--{normalizedPrefix}content-type")
                {
                    Description = @"MIME type of `body`.",
                }
        );
    }
}