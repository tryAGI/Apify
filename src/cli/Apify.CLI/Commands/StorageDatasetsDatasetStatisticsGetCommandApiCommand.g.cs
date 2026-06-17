#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageDatasetsDatasetStatisticsGetCommandApiCommand
{
    private static Argument<string> DatasetId { get; } = new(
        name: @"dataset-id")
    {
        Description = @"Dataset ID or `username~dataset-name`.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.DatasetStatisticsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.DatasetStatisticsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"dataset-statistics-get", @"Get dataset statistics
Returns statistics for given dataset.

Provides only [field statistics](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema/validation#dataset-field-statistics).
");
                        command.Arguments.Add(DatasetId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var datasetId = parseResult.GetRequiredValue(DatasetId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.StorageDatasets.DatasetStatisticsGetAsync(
                                    datasetId: datasetId,
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