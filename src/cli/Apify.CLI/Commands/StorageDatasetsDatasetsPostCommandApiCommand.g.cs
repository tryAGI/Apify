#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageDatasetsDatasetsPostCommandApiCommand
{
    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Custom unique name to easily identify the dataset in the future.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.DatasetResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.DatasetResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"datasets-post", @"Create dataset
Creates a dataset and returns its object.
Keep in mind that data stored under unnamed dataset follows [data retention period](https://docs.apify.com/platform/storage#data-retention).
It creates a dataset with the given name if the parameter name is used.
If a dataset with the given name already exists then returns its object.
");
                        command.Options.Add(NameOption);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var name = parseResult.GetValue(NameOption);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.StorageDatasets.DatasetsPostAsync(
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