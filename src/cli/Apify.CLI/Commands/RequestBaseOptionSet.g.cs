#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal sealed record RequestBaseOptionSet(
    Option<string?> UniqueKey,
                     Option<string?> Url,
                     Option<global::Apify.HttpMethod?> Method,
                     Option<int?> RetryCount,
                     Option<string?> LoadedUrl,
                     Option<string?> Payload,
                     Option<bool?> NoRetry,
                     Option<global::System.Collections.Generic.IList<string>?> ErrorMessages,
                     Option<global::System.DateTime?> HandledAt)
{
    public static RequestBaseOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new RequestBaseOptionSet(
                        UniqueKey: new Option<string?>($"--{normalizedPrefix}unique-key")
                {
                    Description = @"A unique key used for request de-duplication. Requests with the same unique key are considered identical.",
                },
                Url: new Option<string?>($"--{normalizedPrefix}url")
                {
                    Description = @"The URL of the request.",
                },
                Method: new Option<global::Apify.HttpMethod?>($"--{normalizedPrefix}method")
                {
                    Description = @"",
                },
                RetryCount: new Option<int?>($"--{normalizedPrefix}retry-count")
                {
                    Description = @"The number of times this request has been retried.",
                },
                LoadedUrl: new Option<string?>($"--{normalizedPrefix}loaded-url")
                {
                    Description = @"The final URL that was loaded, after redirects (if any).",
                },
                Payload: new Option<string?>($"--{normalizedPrefix}payload")
                {
                    Description = @"The request payload, typically used with POST or PUT requests.",
                },
                NoRetry: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}no-retry", description: @"Indicates whether the request should not be retried if processing fails."),
                ErrorMessages: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}error-messages")
                {
                    Description = @"Error messages recorded from failed processing attempts.",
                },
                HandledAt: new Option<global::System.DateTime?>($"--{normalizedPrefix}handled-at")
                {
                    Description = @"The timestamp when the request was marked as handled, if applicable.",
                }
        );
    }
}