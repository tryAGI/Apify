#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageDatasetsDatasetItemsPostCommandApiCommand
{
    private static Argument<string> DatasetId { get; } = new(
        name: @"dataset-id")
    {
        Description = @"Dataset ID or `username~dataset-name`.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, string value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, string value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"dataset-items-post", @"Store items
Appends an item or an array of items to the end of the dataset.
The POST payload is a JSON object or a JSON array of objects to save into the dataset.

If the data you attempt to store in the dataset is invalid (meaning any of the items received by the API fails the validation), the whole request is discarded and the API will return a response with status code 400.
For more information about dataset schema validation, see [Dataset schema](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema/validation).

**IMPORTANT:** The limit of request payload size for the dataset is 5 MB. If the array exceeds the size, you'll need to split it into a number of smaller arrays.
");
                        command.Arguments.Add(DatasetId);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount != 1)
              {
                  result.AddError(@"Specify exactly one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var datasetId = parseResult.GetRequiredValue(DatasetId);
                        var request = await CliRuntime.ReadRequestAsync<global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.StorageDatasets.DatasetItemsPostAsync(
                                    datasetId: datasetId,
                                    request: request,
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