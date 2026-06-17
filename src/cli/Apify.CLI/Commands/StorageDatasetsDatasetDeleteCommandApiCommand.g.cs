#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageDatasetsDatasetDeleteCommandApiCommand
{
    private static Argument<string> DatasetId { get; } = new(
        name: @"dataset-id")
    {
        Description = @"Dataset ID or `username~dataset-name`.",
    };

    public static Command Create()
    {
        var command = new Command(@"dataset-delete", @"Delete dataset
Deletes a specific dataset.");
                        command.Arguments.Add(DatasetId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var datasetId = parseResult.GetRequiredValue(DatasetId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.StorageDatasets.DatasetDeleteAsync(
                                    datasetId: datasetId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}