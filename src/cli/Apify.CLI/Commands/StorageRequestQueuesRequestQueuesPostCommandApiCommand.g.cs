#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageRequestQueuesRequestQueuesPostCommandApiCommand
{
    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Custom unique name to easily identify the queue in the future.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.RequestQueueResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.RequestQueueResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"request-queues-post", @"Create request queue
Creates a request queue and returns its object.
Keep in mind that requests stored under unnamed queue follows [data
retention period](https://docs.apify.com/platform/storage#data-retention).

It creates a queue of given name if the parameter name is used. If a queue
with the given name already exists then the endpoint returns
its object.
");
                        command.Options.Add(NameOption);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var name = parseResult.GetValue(NameOption);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.StorageRequestQueues.RequestQueuesPostAsync(
                                    name: name,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Apify.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}