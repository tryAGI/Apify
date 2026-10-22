#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorRunsPostChargeRunCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
    };

    private static Option<string?> IdempotencyKey { get; } = new(
        name: @"--idempotency-key")
    {
        Description = @"Always pass a unique idempotency key (any unique string) for each charge to avoid double charging in case of retries or network errors. The key expires 3 minutes after the charge, so a later request with the same key creates a new charge.",
    };

    private static Option<string> EventName { get; } = new(
        name: @"--event-name")
    {
        Description = @"",
        Required = true,
    };

    private static Option<int> Count { get; } = new(
        name: @"--count")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> RequestId { get; } = new(
        name: @"--request-id")
    {
        Description = @"ID of the Server Actor request being charged, from the `X-Actor-Request-ID` header of the incoming request. Required for multi-tenant Server Actor runs, where it identifies the request the charge belongs to.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.PostChargeRunResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.PostChargeRunResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"post-charge-run", @"Charge events in Actor run
Charge for events in the run of your [pay-per-event Actor](/actors/monetize/pay-per-event).
The event you are charging for must be one of the configured events in your Actor. If the Actor is not set up as pay per event, or if the event is not configured,
the endpoint will return an error. The endpoint must be called from the Actor run itself, with the same API token that the run was started with.
");
                        command.Arguments.Add(RunId);
                        command.Options.Add(IdempotencyKey);
                        command.Options.Add(EventName);
                        command.Options.Add(Count);
                        command.Options.Add(RequestId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Apify.ChargeRunRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var runId = parseResult.GetRequiredValue(RunId);
                        var idempotencyKey = parseResult.GetValue(IdempotencyKey);
                        var eventName = parseResult.GetRequiredValue(EventName);
                        var count = parseResult.GetRequiredValue(Count);
                        var requestId = CliRuntime.WasSpecified(parseResult, RequestId) ? parseResult.GetValue(RequestId) : (__requestBase is { } __RequestIdBaseValue ? __RequestIdBaseValue.RequestId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorRuns.PostChargeRunAsync(
                                    runId: runId,
                                    idempotencyKey: idempotencyKey,
                                    eventName: eventName,
                                    count: count,
                                    requestId: requestId,
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