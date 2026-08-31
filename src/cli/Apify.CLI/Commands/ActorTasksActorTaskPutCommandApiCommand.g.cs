#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorTasksActorTaskPutCommandApiCommand
{
    private static Argument<string> ActorTaskId { get; } = new(
        name: @"actor-task-id")
    {
        Description = @"Task ID or a tilde-separated owner's username and task's name.",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"",
    };

    private static Option<global::Apify.TaskOptions?> OptionsOption { get; } = new(
        name: @"--options")
    {
        Description = @"",
    };

    private static Option<global::Apify.AnyOf<global::Apify.TaskInput, global::System.Collections.Generic.IList<global::Apify.TaskInput>, object>?> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"",
    };

    private static Option<string?> Title { get; } = new(
        name: @"--title")
    {
        Description = @"",
    };

    private static Option<global::Apify.TaskPublicConfig?> PublicConfig { get; } = new(
        name: @"--public-config")
    {
        Description = @"Configuration that controls how the published task appears on its public landing page.
Editing this object requires write permission to the Actor that the task belongs to.

The fields you send are merged into the stored configuration, so you only need to include
the ones you're changing. To clear a field, set it to `null`. Sending `publicConfig: null`
is rejected, so the object as a whole can't be cleared.
",
    };

    private static Option<bool?> IsPublic { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--is-public",
        description: @"Set to `true` to publish the task on its public landing page, or `false` to unpublish it.
Sending the value the task already has does nothing.
");
    private static readonly ActorStandbyOptionSet ActorStandbyOptions = ActorStandbyOptionSet.Create(@"actor-standby");
      private static Option<string?> RequestInput { get; } = new(@"--request-input")
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ActorTaskPutResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ActorTaskPutResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"put", @"Update task
Update settings of a task using values specified by an object passed as JSON
in the POST payload.

If the object does not define a specific property, its value is not updated.

The `publicConfig` field carries the display configuration of the task's public
landing page, and `isPublic` publishes or unpublishes the task itself. Both require
write permission to the task's Actor.

To publish a task, its Actor must be public, `publicConfig.inputSchemaFields` and
`publicConfig.datasetView` must be set, and the Actor must have fewer than 50 published
tasks. If the task isn't ready to be published, the whole update fails and none of it
is applied.

Publishing lists the task among the Actor's examples and makes its input public, so anyone
can view and copy it. The landing page itself is shown only while `publicConfig` still
validates against the Actor's current build, so a new build can stop the page from being
offered while the task stays published and copyable.

The response is the full task object as returned by the
[Get task](/api/v2/actor-task-get) endpoint.

The request needs to specify the `Content-Type: application/json` HTTP
header!

When providing your API authentication token, we recommend using the
request's `Authorization` header, rather than the URL.
");
                        command.Arguments.Add(ActorTaskId);
                        command.Options.Add(NameOption);
                        command.Options.Add(OptionsOption);
                        command.Options.Add(InputOption);
                        command.Options.Add(Title);
                        command.Options.Add(PublicConfig);
                        command.Options.Add(IsPublic);                        command.Options.Add(ActorStandbyOptions.IsEnabled);
                        command.Options.Add(ActorStandbyOptions.DesiredRequestsPerActorRun);
                        command.Options.Add(ActorStandbyOptions.MaxRequestsPerActorRun);
                        command.Options.Add(ActorStandbyOptions.IdleTimeoutSecs);
                        command.Options.Add(ActorStandbyOptions.Build);
                        command.Options.Add(ActorStandbyOptions.MemoryMbytes);
                        command.Options.Add(ActorStandbyOptions.DisableStandbyFieldsOverride);
                        command.Options.Add(ActorStandbyOptions.ShouldPassActorInput);
          command.Options.Add(RequestInput);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(RequestInput) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --request-input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Apify.UpdateTaskRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var actorTaskId = parseResult.GetRequiredValue(ActorTaskId);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var options = CliRuntime.WasSpecified(parseResult, OptionsOption) ? parseResult.GetValue(OptionsOption) : (__requestBase is { } __OptionsBaseValue ? __OptionsBaseValue.Options : default);
                        var input = CliRuntime.WasSpecified(parseResult, InputOption) ? parseResult.GetValue(InputOption) : (__requestBase is { } __InputBaseValue ? __InputBaseValue.Input : default);
                        var title = CliRuntime.WasSpecified(parseResult, Title) ? parseResult.GetValue(Title) : (__requestBase is { } __TitleBaseValue ? __TitleBaseValue.Title : default);
                        var publicConfig = CliRuntime.WasSpecified(parseResult, PublicConfig) ? parseResult.GetValue(PublicConfig) : (__requestBase is { } __PublicConfigBaseValue ? __PublicConfigBaseValue.PublicConfig : default);
                        var isPublic = CliRuntime.WasSpecified(parseResult, IsPublic) ? parseResult.GetValue(IsPublic) : (__requestBase is { } __IsPublicBaseValue ? __IsPublicBaseValue.IsPublic : default);

                        var __ActorStandbyBase = __requestBase is { } __ActorStandbyBaseValue ? __ActorStandbyBaseValue.ActorStandby : default;                        var actorStandbyIsEnabled = CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.IsEnabled) ? parseResult.GetValue(ActorStandbyOptions.IsEnabled) : (__ActorStandbyBase is { } __ActorStandbyisEnabledBaseValue ? __ActorStandbyisEnabledBaseValue.IsEnabled : default);
                        var actorStandbyDesiredRequestsPerActorRun = CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.DesiredRequestsPerActorRun) ? parseResult.GetValue(ActorStandbyOptions.DesiredRequestsPerActorRun) : (__ActorStandbyBase is { } __ActorStandbydesiredRequestsPerActorRunBaseValue ? __ActorStandbydesiredRequestsPerActorRunBaseValue.DesiredRequestsPerActorRun : default);
                        var actorStandbyMaxRequestsPerActorRun = CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.MaxRequestsPerActorRun) ? parseResult.GetValue(ActorStandbyOptions.MaxRequestsPerActorRun) : (__ActorStandbyBase is { } __ActorStandbymaxRequestsPerActorRunBaseValue ? __ActorStandbymaxRequestsPerActorRunBaseValue.MaxRequestsPerActorRun : default);
                        var actorStandbyIdleTimeoutSecs = CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.IdleTimeoutSecs) ? parseResult.GetValue(ActorStandbyOptions.IdleTimeoutSecs) : (__ActorStandbyBase is { } __ActorStandbyidleTimeoutSecsBaseValue ? __ActorStandbyidleTimeoutSecsBaseValue.IdleTimeoutSecs : default);
                        var actorStandbyBuild = CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.Build) ? parseResult.GetValue(ActorStandbyOptions.Build) : (__ActorStandbyBase is { } __ActorStandbybuildBaseValue ? __ActorStandbybuildBaseValue.Build : default);
                        var actorStandbyMemoryMbytes = CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.MemoryMbytes) ? parseResult.GetValue(ActorStandbyOptions.MemoryMbytes) : (__ActorStandbyBase is { } __ActorStandbymemoryMbytesBaseValue ? __ActorStandbymemoryMbytesBaseValue.MemoryMbytes : default);
                        var actorStandbyDisableStandbyFieldsOverride = CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.DisableStandbyFieldsOverride) ? parseResult.GetValue(ActorStandbyOptions.DisableStandbyFieldsOverride) : (__ActorStandbyBase is { } __ActorStandbydisableStandbyFieldsOverrideBaseValue ? __ActorStandbydisableStandbyFieldsOverrideBaseValue.DisableStandbyFieldsOverride : default);
                        var actorStandbyShouldPassActorInput = CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.ShouldPassActorInput) ? parseResult.GetValue(ActorStandbyOptions.ShouldPassActorInput) : (__ActorStandbyBase is { } __ActorStandbyshouldPassActorInputBaseValue ? __ActorStandbyshouldPassActorInputBaseValue.ShouldPassActorInput : default);
                        var __ActorStandbySpecified = CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.IsEnabled) || CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.DesiredRequestsPerActorRun) || CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.MaxRequestsPerActorRun) || CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.IdleTimeoutSecs) || CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.Build) || CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.MemoryMbytes) || CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.DisableStandbyFieldsOverride) || CliRuntime.WasSpecified(parseResult, ActorStandbyOptions.ShouldPassActorInput);
                        var actorStandby =
                            __ActorStandbySpecified || __ActorStandbyBase is not null
                                ? new global::Apify.ActorStandby
                                {
	                                IsEnabled = actorStandbyIsEnabled,
                                DesiredRequestsPerActorRun = actorStandbyDesiredRequestsPerActorRun,
                                MaxRequestsPerActorRun = actorStandbyMaxRequestsPerActorRun,
                                IdleTimeoutSecs = actorStandbyIdleTimeoutSecs,
                                Build = actorStandbyBuild,
                                MemoryMbytes = actorStandbyMemoryMbytes,
                                DisableStandbyFieldsOverride = actorStandbyDisableStandbyFieldsOverride,
                                ShouldPassActorInput = actorStandbyShouldPassActorInput,

                                }
                                : __ActorStandbyBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorTasks.ActorTaskPutAsync(
                                    actorTaskId: actorTaskId,
                                    name: name,
                                    options: options,
                                    input: input,
                                    title: title,
                                    publicConfig: publicConfig,
                                    isPublic: isPublic,
                                    actorStandby: actorStandby,
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