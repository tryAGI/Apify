#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueRequestsPostCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or the username of the Actor owner and the Actor name, separated by a tilde (`~`).",
    };

    private static Option<string?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter for the run status.",
    };

    private static Option<global::Apify.RunOrigin?> Origin { get; } = new(
        name: @"--origin")
    {
        Description = @"Filter for the run origin, i.e. the means by which the run was started.",
    };

    private static Option<string?> ClientKey { get; } = new(
        name: @"--client-key")
    {
        Description = @"A unique identifier of the client accessing the request queue. It must
be a string between 1 and 32 characters long. This identifier is used to
determine whether the queue was accessed by multiple clients. If
`clientKey` is not provided,
the system considers this API call to come from a new client. For
details, see the `hadMultipleClients` field returned by the [Get
head](#/reference/request-queues/queue-head) operation.
",
    };

    private static Option<string?> Forefront { get; } = new(
        name: @"--forefront")
    {
        Description = @"Determines if request should be added to the head of the queue or to the
end. Default value is `false` (end of queue).
",
    };

    private static Option<object?> Headers { get; } = new(
        name: @"--headers")
    {
        Description = @"HTTP headers sent with the request.",
    };

    private static Option<global::Apify.RequestUserData?> UserData { get; } = new(
        name: @"--user-data")
    {
        Description = @"Custom user data attached to the request. Can contain arbitrary fields.",
    };
    private static readonly RequestBaseOptionSet RequestBaseOptionSetOptions = RequestBaseOptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.AddRequestResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.AddRequestResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"actor-runs-last-request-queue-requests-post", @"Add request to last run's default request queue
Adds a request to the default request queue of the last Actor run.

This endpoint is a shortcut for getting the last run's `defaultRequestQueueId` and then using the
[Add request](/api/v2/request-queue-requests-post) endpoint.
");
                        command.Arguments.Add(ActorId);
                        command.Options.Add(Status);
                        command.Options.Add(Origin);
                        command.Options.Add(ClientKey);
                        command.Options.Add(Forefront);
                        command.Options.Add(Headers);
                        command.Options.Add(UserData);                        command.Options.Add(RequestBaseOptionSetOptions.UniqueKey);
                        command.Options.Add(RequestBaseOptionSetOptions.Url);
                        command.Options.Add(RequestBaseOptionSetOptions.Method);
                        command.Options.Add(RequestBaseOptionSetOptions.RetryCount);
                        command.Options.Add(RequestBaseOptionSetOptions.LoadedUrl);
                        command.Options.Add(RequestBaseOptionSetOptions.Payload);
                        command.Options.Add(RequestBaseOptionSetOptions.NoRetry);
                        command.Options.Add(RequestBaseOptionSetOptions.ErrorMessages);
                        command.Options.Add(RequestBaseOptionSetOptions.HandledAt);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Apify.RequestBase>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var status = parseResult.GetValue(Status);
                        var origin = parseResult.GetValue(Origin);
                        var clientKey = parseResult.GetValue(ClientKey);
                        var forefront = parseResult.GetValue(Forefront);
                        var headers = CliRuntime.WasSpecified(parseResult, Headers) ? parseResult.GetValue(Headers) : (__requestBase is { } __HeadersBaseValue ? __HeadersBaseValue.Headers : default);
                        var userData = CliRuntime.WasSpecified(parseResult, UserData) ? parseResult.GetValue(UserData) : (__requestBase is { } __UserDataBaseValue ? __UserDataBaseValue.UserData : default);                        var uniqueKey = CliRuntime.WasSpecified(parseResult, RequestBaseOptionSetOptions.UniqueKey) ? parseResult.GetValue(RequestBaseOptionSetOptions.UniqueKey) : (__requestBase is { } __UniqueKeyBaseValue ? __UniqueKeyBaseValue.UniqueKey : default);
                        var url = CliRuntime.WasSpecified(parseResult, RequestBaseOptionSetOptions.Url) ? parseResult.GetValue(RequestBaseOptionSetOptions.Url) : (__requestBase is { } __UrlBaseValue ? __UrlBaseValue.Url : default);
                        var method = CliRuntime.WasSpecified(parseResult, RequestBaseOptionSetOptions.Method) ? parseResult.GetValue(RequestBaseOptionSetOptions.Method) : (__requestBase is { } __MethodBaseValue ? __MethodBaseValue.Method : default);
                        var retryCount = CliRuntime.WasSpecified(parseResult, RequestBaseOptionSetOptions.RetryCount) ? parseResult.GetValue(RequestBaseOptionSetOptions.RetryCount) : (__requestBase is { } __RetryCountBaseValue ? __RetryCountBaseValue.RetryCount : default);
                        var loadedUrl = CliRuntime.WasSpecified(parseResult, RequestBaseOptionSetOptions.LoadedUrl) ? parseResult.GetValue(RequestBaseOptionSetOptions.LoadedUrl) : (__requestBase is { } __LoadedUrlBaseValue ? __LoadedUrlBaseValue.LoadedUrl : default);
                        var payload = CliRuntime.WasSpecified(parseResult, RequestBaseOptionSetOptions.Payload) ? parseResult.GetValue(RequestBaseOptionSetOptions.Payload) : (__requestBase is { } __PayloadBaseValue ? __PayloadBaseValue.Payload : default);
                        var noRetry = CliRuntime.WasSpecified(parseResult, RequestBaseOptionSetOptions.NoRetry) ? parseResult.GetValue(RequestBaseOptionSetOptions.NoRetry) : (__requestBase is { } __NoRetryBaseValue ? __NoRetryBaseValue.NoRetry : default);
                        var errorMessages = CliRuntime.WasSpecified(parseResult, RequestBaseOptionSetOptions.ErrorMessages) ? parseResult.GetValue(RequestBaseOptionSetOptions.ErrorMessages) : (__requestBase is { } __ErrorMessagesBaseValue ? __ErrorMessagesBaseValue.ErrorMessages : default);
                        var handledAt = CliRuntime.WasSpecified(parseResult, RequestBaseOptionSetOptions.HandledAt) ? parseResult.GetValue(RequestBaseOptionSetOptions.HandledAt) : (__requestBase is { } __HandledAtBaseValue ? __HandledAtBaseValue.HandledAt : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LastActorRunSDefaultRequestQueue.ActorRunsLastRequestQueueRequestsPostAsync(
                                    actorId: actorId,
                                    status: status,
                                    origin: origin,
                                    clientKey: clientKey,
                                    forefront: forefront,
                                    headers: headers,
                                    userData: userData,
                                    uniqueKey: uniqueKey,
                                    url: url,
                                    method: method,
                                    retryCount: retryCount,
                                    loadedUrl: loadedUrl,
                                    payload: payload,
                                    noRetry: noRetry,
                                    errorMessages: errorMessages,
                                    handledAt: handledAt,
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