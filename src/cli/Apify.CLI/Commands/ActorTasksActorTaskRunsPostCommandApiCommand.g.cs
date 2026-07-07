#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorTasksActorTaskRunsPostCommandApiCommand
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

    private static Option<double?> MaxTotalChargeUsd { get; } = new(
        name: @"--max-total-charge-usd")
    {
        Description = @"Specifies the maximum total cost of the run.
Use it to cap the total amount charged for all pricing models.
You can access the maximum cost in your Actor
by using the `ACTOR_MAX_TOTAL_CHARGE_USD` environment variable.
",
    };

    private static Option<bool?> RestartOnError { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--restart-on-error",
        description: @"Determines whether the run will be restarted if it fails.
");

    private static Option<string?> Build { get; } = new(
        name: @"--build")
    {
        Description = @"Specifies the Actor build to run. It can be either a build tag or build number.
By default, the run uses the build from its configuration (typically `latest`).
",
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

    private static Option<byte[]?> Webhooks { get; } = new(
        name: @"--webhooks")
    {
        Description = @"Specifies optional webhooks associated with the Actor run, which can be used to receive a notification
e.g. when the Actor finished or failed. The value is a Base64-encoded JSON array whose items follow
the WebhookRepresentation schema. For more information, see
[Webhooks documentation](https://docs.apify.com/platform/integrations/webhooks).
",
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ActorTaskRunsPostResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ActorTaskRunsPostResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"runs-post", @"Run task
Runs an Actor task and immediately returns without waiting for the run to
finish.

Optionally, you can override the Actor input configuration by passing a JSON
object as the POST payload and setting the `Content-Type: application/json` HTTP header.

Note that if the object in the POST payload does not define a particular
input property, the Actor run uses the default value defined by the task (or Actor's input
schema if not defined by the task).

The response is the Actor Run object as returned by the [Get
run](#/reference/actor-runs/run-object-and-its-storages/get-run) endpoint.

If you want to wait for the run to finish and receive the actual output of
the Actor run as the response, use one of the [Run task
synchronously](#/reference/actor-tasks/run-task-synchronously) API endpoints
instead.

To fetch the Actor run results that are typically stored in the default
dataset, you'll need to pass the ID received in the `defaultDatasetId` field
received in the response JSON to the
[Get dataset items](#/reference/datasets/item-collection/get-items) API endpoint.
");
                        command.Arguments.Add(ActorTaskId);
                        command.Options.Add(Timeout);
                        command.Options.Add(Memory);
                        command.Options.Add(MaxItems);
                        command.Options.Add(MaxTotalChargeUsd);
                        command.Options.Add(RestartOnError);
                        command.Options.Add(Build);
                        command.Options.Add(WaitForFinish);
                        command.Options.Add(Webhooks);
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
                        var actorTaskId = parseResult.GetRequiredValue(ActorTaskId);
                        var timeout = parseResult.GetValue(Timeout);
                        var memory = parseResult.GetValue(Memory);
                        var maxItems = parseResult.GetValue(MaxItems);
                        var maxTotalChargeUsd = parseResult.GetValue(MaxTotalChargeUsd);
                        var restartOnError = parseResult.GetValue(RestartOnError);
                        var build = parseResult.GetValue(Build);
                        var waitForFinish = parseResult.GetValue(WaitForFinish);
                        var webhooks = parseResult.GetValue(Webhooks);
                        var request = await CliRuntime.ReadRequestAsync<object>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorTasks.ActorTaskRunsPostAsync(
                                    actorTaskId: actorTaskId,
                                    timeout: timeout,
                                    memory: memory,
                                    maxItems: maxItems,
                                    maxTotalChargeUsd: maxTotalChargeUsd,
                                    restartOnError: restartOnError,
                                    build: build,
                                    waitForFinish: waitForFinish,
                                    webhooks: webhooks,
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