#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorTasksActorTaskRunSyncGetCommandApiCommand
{
    private static Argument<string> ActorTaskId { get; } = new(
        name: @"actor-task-id")
    {
        Description = @"Task ID or a tilde-separated owner's username and task's name.",
    };

    private static Option<double?> Timeout { get; } = new(
        name: @"--timeout")
    {
        Description = @"Optional timeout for the run, in seconds. By default, the run uses the timeout from its configuration.
",
    };

    private static Option<double?> Memory { get; } = new(
        name: @"--memory")
    {
        Description = @"Memory limit for the run, in megabytes. The amount of memory can be set to a power of 2 with a minimum of 128.
By default, the run uses the memory limit from its configuration.
",
    };

    private static Option<double?> MaxItems { get; } = new(
        name: @"--max-items")
    {
        Description = @"Specifies the maximum number of dataset items that will be charged for pay-per-result Actors.
This does NOT guarantee that the Actor will return only this many items.
It only ensures you won't be charged for more than this number of items.
Only works for pay-per-result Actors.
Value can be accessed in the actor run using `ACTOR_MAX_PAID_DATASET_ITEMS` environment variable.
",
    };

    private static Option<string?> Build { get; } = new(
        name: @"--build")
    {
        Description = @"Specifies the Actor build to run. It can be either a build tag or build number.
By default, the run uses the build from its configuration (typically `latest`).
",
    };

    private static Option<string?> OutputRecordKey { get; } = new(
        name: @"--output-record-key")
    {
        Description = @"Key of the record from run's default key-value store to be returned
in the response. By default, it is `OUTPUT`.
",
    };

    private static Option<byte[]?> Webhooks { get; } = new(
        name: @"--webhooks")
    {
        Description = @"Specifies optional webhooks associated with the Actor run, which can be used to receive a notification
e.g. when the Actor finished or failed. The value is a Base64-encoded JSON array whose items follow
the WebhookRepresentation schema. For more information, see
[Webhooks documentation](https://docs.apify.com/platform/integrations/webhooks).
",
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
        var command = new Command(@"run-sync-get", @"Run task synchronously
Run a specific task and return its output.

The run must finish in 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds
otherwise the HTTP request fails with a timeout error (this won't abort
the run itself).

Beware that it might be impossible to maintain an idle HTTP connection for
an extended period, due to client timeout or network conditions. Make sure your HTTP client is
configured to have a long enough connection timeout.

If the connection breaks, you will not receive any information about the run
and its status.

To run the Task asynchronously, use the
[Run task asynchronously](#/reference/actor-tasks/run-collection/run-task)
endpoint instead.
");
                        command.Arguments.Add(ActorTaskId);
                        command.Options.Add(Timeout);
                        command.Options.Add(Memory);
                        command.Options.Add(MaxItems);
                        command.Options.Add(Build);
                        command.Options.Add(OutputRecordKey);
                        command.Options.Add(Webhooks);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorTaskId = parseResult.GetRequiredValue(ActorTaskId);
                        var timeout = parseResult.GetValue(Timeout);
                        var memory = parseResult.GetValue(Memory);
                        var maxItems = parseResult.GetValue(MaxItems);
                        var build = parseResult.GetValue(Build);
                        var outputRecordKey = parseResult.GetValue(OutputRecordKey);
                        var webhooks = parseResult.GetValue(Webhooks);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorTasks.ActorTaskRunSyncGetAsync(
                                    actorTaskId: actorTaskId,
                                    timeout: timeout,
                                    memory: memory,
                                    maxItems: maxItems,
                                    build: build,
                                    outputRecordKey: outputRecordKey,
                                    webhooks: webhooks,
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