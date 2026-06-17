#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class DefaultKeyValueStoreActorRunKeyValueStorePutCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
    };
    private static readonly UpdateStoreRequestOptionSet UpdateStoreRequestOptionSetOptions = UpdateStoreRequestOptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.KeyValueStoreResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.KeyValueStoreResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"actor-run-key-value-store-put", @"Update default store
Updates the default key-value store's name and general resource access level using a value specified by a JSON object
passed in the PUT payload.

This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the
[Update store](/api/v2/key-value-store-put) endpoint.
");
                        command.Arguments.Add(RunId);                        command.Options.Add(UpdateStoreRequestOptionSetOptions.NameOption);
                        command.Options.Add(UpdateStoreRequestOptionSetOptions.GeneralAccess);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Apify.UpdateStoreRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var runId = parseResult.GetRequiredValue(RunId);                        var name = CliRuntime.WasSpecified(parseResult, UpdateStoreRequestOptionSetOptions.NameOption) ? parseResult.GetValue(UpdateStoreRequestOptionSetOptions.NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var generalAccess = CliRuntime.WasSpecified(parseResult, UpdateStoreRequestOptionSetOptions.GeneralAccess) ? parseResult.GetValue(UpdateStoreRequestOptionSetOptions.GeneralAccess) : (__requestBase is { } __GeneralAccessBaseValue ? __GeneralAccessBaseValue.GeneralAccess : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DefaultKeyValueStore.ActorRunKeyValueStorePutAsync(
                                    runId: runId,
                                    name: name,
                                    generalAccess: generalAccess,
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