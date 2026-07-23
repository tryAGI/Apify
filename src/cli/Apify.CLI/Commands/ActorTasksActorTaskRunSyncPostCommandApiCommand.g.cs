#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorTasksActorTaskRunSyncPostCommandApiCommand
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
        Description = @"Memory limit for the run, in megabytes. You can set the amount of memory to a power of 2 with a minimum of 128.
By default, the run uses the memory limit from its configuration. Don't change this value unless the Actor's
documentation recommends it or you're aware of the consequences.
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

    private static Option<string?> OutputRecordKey { get; } = new(
        name: @"--output-record-key")
    {
        Description = @"Key of the record from the run's default key-value store to return in the
response. Defaults to `OUTPUT`. Actors aren't required to store a record
under this key, so if it doesn't exist the response contains no data.
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
        var command = new Command(@"run-sync-post", @"Run task synchronously
Runs an Actor task and synchronously returns a key-value store record.

The response contains the record stored under the `OUTPUT` key in the run's
default key-value store. This is a legacy approach that has been replaced by
the Actor [output object](https://docs.apify.com/platform/actors/development/actor-definition/output-schema#output-object-definition);
Actors aren't required to store a record under this key, so the response may
not contain any data. Use the `outputRecordKey` query parameter to return a
different record.

The run must finish in 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds
otherwise the HTTP request fails with a timeout error (this won't abort
the run itself).

Optionally, you can override the Actor input configuration by passing a JSON
object as the POST payload and setting the `Content-Type: application/json` HTTP header.

Note that if the object in the POST payload does not define a particular
input property, the Actor run uses the default value defined by the task (or Actor's input
schema if not defined by the task).

Beware that it might be impossible to maintain an idle HTTP connection for
an extended period, due to client timeout or network conditions. Make sure your HTTP client is
configured to have a long enough connection timeout.

If the connection breaks, you will not receive any information about the run
and its status.

Input fields from Actor task configuration can be overloaded with values
passed as the POST payload.

Just make sure to specify `Content-Type` header to be `application/json` and
input to be an object.

To run the task asynchronously, use the [Run
task](#/reference/actor-tasks/run-collection/run-task) API endpoint instead.
");
                        command.Arguments.Add(ActorTaskId);
                        command.Options.Add(Timeout);
                        command.Options.Add(Memory);
                        command.Options.Add(MaxItems);
                        command.Options.Add(MaxTotalChargeUsd);
                        command.Options.Add(RestartOnError);
                        command.Options.Add(Build);
                        command.Options.Add(OutputRecordKey);
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
                        var outputRecordKey = parseResult.GetValue(OutputRecordKey);
                        var webhooks = parseResult.GetValue(Webhooks);
                        var request = await CliRuntime.ReadRequestAsync<object>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorTasks.ActorTaskRunSyncPostAsync(
                                    actorTaskId: actorTaskId,
                                    timeout: timeout,
                                    memory: memory,
                                    maxItems: maxItems,
                                    maxTotalChargeUsd: maxTotalChargeUsd,
                                    restartOnError: restartOnError,
                                    build: build,
                                    outputRecordKey: outputRecordKey,
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