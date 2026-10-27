#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class UsersUsageUsersMeLimitsPutCommandApiCommand
{
    private static readonly UpdateLimitsRequestOptionSet UpdateLimitsRequestOptionSetOptions = UpdateLimitsRequestOptionSet.Create();
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


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"users-me-limits-put", @"Update user's limits
Updates the account's limits manageable on your account's [Limits page](https://console.apify.com/billing#/limits).
Specifically the: `maxMonthlyUsageUsd` and `dataRetentionDays` limits (see request body schema for more details).
");
                        command.Options.Add(UpdateLimitsRequestOptionSetOptions.MaxMonthlyUsageUsd);
                        command.Options.Add(UpdateLimitsRequestOptionSetOptions.DataRetentionDays);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Apify.UpdateLimitsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);                        var maxMonthlyUsageUsd = CliRuntime.WasSpecified(parseResult, UpdateLimitsRequestOptionSetOptions.MaxMonthlyUsageUsd) ? parseResult.GetValue(UpdateLimitsRequestOptionSetOptions.MaxMonthlyUsageUsd) : (__requestBase is { } __MaxMonthlyUsageUsdBaseValue ? __MaxMonthlyUsageUsdBaseValue.MaxMonthlyUsageUsd : default);
                        var dataRetentionDays = CliRuntime.WasSpecified(parseResult, UpdateLimitsRequestOptionSetOptions.DataRetentionDays) ? parseResult.GetValue(UpdateLimitsRequestOptionSetOptions.DataRetentionDays) : (__requestBase is { } __DataRetentionDaysBaseValue ? __DataRetentionDaysBaseValue.DataRetentionDays : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UsersUsage.UsersMeLimitsPutAsync(
                                    maxMonthlyUsageUsd: maxMonthlyUsageUsd,
                                    dataRetentionDays: dataRetentionDays,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Apify.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}