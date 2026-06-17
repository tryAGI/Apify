#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorTasksActorTaskRunsLastGetCommandApiCommand
{
    private static Argument<string> ActorTaskId { get; } = new(
        name: @"actor-task-id")
    {
        Description = @"Task ID or a tilde-separated owner's username and task's name.",
    };

    private static Option<string?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter for the run status.",
    };

    private static Option<double?> WaitForFinish { get; } = new(
        name: @"--wait-for-finish")
    {
        Description = @"The maximum number of seconds the server waits for the run to finish. By
default it is `0`, the maximum value is `60`. <!-- MAX_ACTOR_JOB_ASYNC_WAIT_SECS -->
If the run finishes in time then the returned run object will have a terminal status (e.g. `SUCCEEDED`),
otherwise it will have a transitional status (e.g. `RUNNING`).
",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ActorTaskRunsLastGetResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ActorTaskRunsLastGetResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"runs-last-get", @"Get last run
This is not a single endpoint, but an entire group of endpoints that lets you to
retrieve and manage the last run of given actor task or any of its default storages.
All the endpoints require an authentication token.

The base path represents the last actor task run object is:

`/v2/actor-tasks/{actorTaskId}/runs/last{?token,status}`

Using the `status` query parameter you can ensure to only get a run with a certain status
(e.g. `status=SUCCEEDED`). The output of this endpoint and other query parameters
are the same as in the [Run object](/api/v2/actor-run-get) endpoint.

##### Convenience endpoints for last Actor task run

* [Dataset](/api/v2/last-actor-task-runs-default-dataset)

* [Key-value store](/api/v2/last-actor-task-runs-default-key-value-store)

* [Request queue](/api/v2/last-actor-task-runs-default-request-queue)

* [Log](/api/v2/last-actor-task-runs-log)
");
                        command.Arguments.Add(ActorTaskId);
                        command.Options.Add(Status);
                        command.Options.Add(WaitForFinish);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorTaskId = parseResult.GetRequiredValue(ActorTaskId);
                        var status = parseResult.GetValue(Status);
                        var waitForFinish = parseResult.GetValue(WaitForFinish);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorTasks.ActorTaskRunsLastGetAsync(
                                    actorTaskId: actorTaskId,
                                    status: status,
                                    waitForFinish: waitForFinish,
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