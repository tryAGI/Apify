#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class SchedulesSchedulePutCommandApiCommand
{
    private static Argument<string> ScheduleId { get; } = new(
        name: @"schedule-id")
    {
        Description = @"Schedule ID.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>?> Actions { get; } = new(
        name: @"--actions")
    {
        Description = @"",
    };
    private static readonly CreateOrUpdateScheduleRequestOptionSet CreateOrUpdateScheduleRequestOptionSetOptions = CreateOrUpdateScheduleRequestOptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ScheduleResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ScheduleResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"put", @"Update schedule
Updates a schedule using values specified by a schedule object passed as
JSON in the POST payload. If the object does not define a specific property,
its value will not be updated.

The response is the full schedule object as returned by the
[Get schedule](#/reference/schedules/schedule-object/get-schedule) endpoint.

**The request needs to specify the `Content-Type: application/json` HTTP
header!**

When providing your API authentication token, we recommend using the
request's `Authorization` header, rather than the URL. ([More
info](#/introduction/authentication)).
");
                        command.Arguments.Add(ScheduleId);
                        command.Options.Add(Actions);                        command.Options.Add(CreateOrUpdateScheduleRequestOptionSetOptions.NameOption);
                        command.Options.Add(CreateOrUpdateScheduleRequestOptionSetOptions.IsEnabled);
                        command.Options.Add(CreateOrUpdateScheduleRequestOptionSetOptions.IsExclusive);
                        command.Options.Add(CreateOrUpdateScheduleRequestOptionSetOptions.CronExpression);
                        command.Options.Add(CreateOrUpdateScheduleRequestOptionSetOptions.Timezone);
                        command.Options.Add(CreateOrUpdateScheduleRequestOptionSetOptions.DescriptionOption);
                        command.Options.Add(CreateOrUpdateScheduleRequestOptionSetOptions.Title);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Apify.CreateOrUpdateScheduleRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var scheduleId = parseResult.GetRequiredValue(ScheduleId);
                        var actions = CliRuntime.WasSpecified(parseResult, Actions) ? parseResult.GetValue(Actions) : (__requestBase is { } __ActionsBaseValue ? __ActionsBaseValue.Actions : default);                        var name = CliRuntime.WasSpecified(parseResult, CreateOrUpdateScheduleRequestOptionSetOptions.NameOption) ? parseResult.GetValue(CreateOrUpdateScheduleRequestOptionSetOptions.NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var isEnabled = CliRuntime.WasSpecified(parseResult, CreateOrUpdateScheduleRequestOptionSetOptions.IsEnabled) ? parseResult.GetValue(CreateOrUpdateScheduleRequestOptionSetOptions.IsEnabled) : (__requestBase is { } __IsEnabledBaseValue ? __IsEnabledBaseValue.IsEnabled : default);
                        var isExclusive = CliRuntime.WasSpecified(parseResult, CreateOrUpdateScheduleRequestOptionSetOptions.IsExclusive) ? parseResult.GetValue(CreateOrUpdateScheduleRequestOptionSetOptions.IsExclusive) : (__requestBase is { } __IsExclusiveBaseValue ? __IsExclusiveBaseValue.IsExclusive : default);
                        var cronExpression = CliRuntime.WasSpecified(parseResult, CreateOrUpdateScheduleRequestOptionSetOptions.CronExpression) ? parseResult.GetValue(CreateOrUpdateScheduleRequestOptionSetOptions.CronExpression) : (__requestBase is { } __CronExpressionBaseValue ? __CronExpressionBaseValue.CronExpression : default);
                        var timezone = CliRuntime.WasSpecified(parseResult, CreateOrUpdateScheduleRequestOptionSetOptions.Timezone) ? parseResult.GetValue(CreateOrUpdateScheduleRequestOptionSetOptions.Timezone) : (__requestBase is { } __TimezoneBaseValue ? __TimezoneBaseValue.Timezone : default);
                        var description = CliRuntime.WasSpecified(parseResult, CreateOrUpdateScheduleRequestOptionSetOptions.DescriptionOption) ? parseResult.GetValue(CreateOrUpdateScheduleRequestOptionSetOptions.DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var title = CliRuntime.WasSpecified(parseResult, CreateOrUpdateScheduleRequestOptionSetOptions.Title) ? parseResult.GetValue(CreateOrUpdateScheduleRequestOptionSetOptions.Title) : (__requestBase is { } __TitleBaseValue ? __TitleBaseValue.Title : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Schedules.SchedulePutAsync(
                                    scheduleId: scheduleId,
                                    actions: actions,
                                    name: name,
                                    isEnabled: isEnabled,
                                    isExclusive: isExclusive,
                                    cronExpression: cronExpression,
                                    timezone: timezone,
                                    description: description,
                                    title: title,
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