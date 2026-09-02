#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageRequestQueuesRequestsRequestQueueRequestPutCommandApiCommand
{
    private static Argument<string> QueueId { get; } = new(
        name: @"queue-id")
    {
        Description = @"Queue ID or `username~queue-name`.",
    };

    private static Argument<string> RequestId { get; } = new(
        name: @"request-id")
    {
        Description = @"Request ID.",
    };

    private static Option<string?> Forefront { get; } = new(
        name: @"--forefront")
    {
        Description = @"Determines if request should be added to the head of the queue or to the
end. Default value is `false` (end of queue).
",
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

    private static Option<string> UniqueKey { get; } = new(
        name: @"--unique-key")
    {
        Description = @"A unique key used for request de-duplication. Requests with the same unique key are considered identical.",
        Required = true,
    };

    private static Option<string> Url { get; } = new(
        name: @"--url")
    {
        Description = @"The URL of the request.",
        Required = true,
    };

    private static Option<global::Apify.HttpMethod?> Method { get; } = new(
        name: @"--method")
    {
        Description = @"The HTTP method of the request.",
    };

    private static Option<int?> RetryCount { get; } = new(
        name: @"--retry-count")
    {
        Description = @"The number of times this request has been retried.",
    };

    private static Option<string?> LoadedUrl { get; } = new(
        name: @"--loaded-url")
    {
        Description = @"The final URL that was loaded, after redirects (if any).",
    };

    private static Option<string?> Payload { get; } = new(
        name: @"--payload")
    {
        Description = @"The request payload, typically used with POST or PUT requests.",
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

    private static Option<bool?> NoRetry { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--no-retry",
        description: @"Indicates whether the request should not be retried if processing fails.");

    private static Option<global::System.Collections.Generic.IList<string>?> ErrorMessages { get; } = new(
        name: @"--error-messages")
    {
        Description = @"Error messages recorded from failed processing attempts.",
    };

    private static Option<global::System.DateTime?> HandledAt { get; } = new(
        name: @"--handled-at")
    {
        Description = @"The timestamp when the request was marked as handled, if applicable.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.UpdateRequestResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.UpdateRequestResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"request-queue-request-put", @"Update request
Updates a request in a queue. Mark request as handled by setting
`request.handledAt = new Date()`.
If `handledAt` is set, the request will be removed from head of the queue (and unlocked, if applicable).
");
                        command.Arguments.Add(QueueId);
                        command.Arguments.Add(RequestId);
                        command.Options.Add(Forefront);
                        command.Options.Add(ClientKey);
                        command.Options.Add(UniqueKey);
                        command.Options.Add(Url);
                        command.Options.Add(Method);
                        command.Options.Add(RetryCount);
                        command.Options.Add(LoadedUrl);
                        command.Options.Add(Payload);
                        command.Options.Add(Headers);
                        command.Options.Add(UserData);
                        command.Options.Add(NoRetry);
                        command.Options.Add(ErrorMessages);
                        command.Options.Add(HandledAt);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var queueId = parseResult.GetRequiredValue(QueueId);
                        var requestId = parseResult.GetRequiredValue(RequestId);
                        var forefront = parseResult.GetValue(Forefront);
                        var clientKey = parseResult.GetValue(ClientKey);
                        var uniqueKey = parseResult.GetRequiredValue(UniqueKey);
                        var url = parseResult.GetRequiredValue(Url);
                        var method = parseResult.GetValue(Method);
                        var retryCount = parseResult.GetValue(RetryCount);
                        var loadedUrl = parseResult.GetValue(LoadedUrl);
                        var payload = parseResult.GetValue(Payload);
                        var headers = parseResult.GetValue(Headers);
                        var userData = parseResult.GetValue(UserData);
                        var noRetry = parseResult.GetValue(NoRetry);
                        var errorMessages = parseResult.GetValue(ErrorMessages);
                        var handledAt = parseResult.GetValue(HandledAt);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.StorageRequestQueuesRequests.RequestQueueRequestPutAsync(
                                    queueId: queueId,
                                    requestId: requestId,
                                    forefront: forefront,
                                    clientKey: clientKey,
                                    uniqueKey: uniqueKey,
                                    url: url,
                                    method: method,
                                    retryCount: retryCount,
                                    loadedUrl: loadedUrl,
                                    payload: payload,
                                    headers: headers,
                                    userData: userData,
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