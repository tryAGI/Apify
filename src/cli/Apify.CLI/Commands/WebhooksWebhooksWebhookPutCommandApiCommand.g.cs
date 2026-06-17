#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class WebhooksWebhooksWebhookPutCommandApiCommand
{
    private static Argument<string> WebhookId { get; } = new(
        name: @"webhook-id")
    {
        Description = @"Webhook ID.",
    };

    private static Option<bool?> IsAdHoc { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--is-ad-hoc",
        description: @"");

    private static Option<global::System.Collections.Generic.IList<global::Apify.WebhookEventType>?> EventTypes { get; } = new(
        name: @"--event-types")
    {
        Description = @"",
    };

    private static Option<bool?> IgnoreSslErrors { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--ignore-ssl-errors",
        description: @"");

    private static Option<bool?> DoNotRetry { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--do-not-retry",
        description: @"");

    private static Option<string?> RequestUrl { get; } = new(
        name: @"--request-url")
    {
        Description = @"",
    };

    private static Option<string?> PayloadTemplate { get; } = new(
        name: @"--payload-template")
    {
        Description = @"",
    };

    private static Option<string?> HeadersTemplate { get; } = new(
        name: @"--headers-template")
    {
        Description = @"",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"",
    };

    private static Option<bool?> ShouldInterpolateStrings { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--should-interpolate-strings",
        description: @"");
    private static readonly WebhookConditionOptionSet ConditionOptions = WebhookConditionOptionSet.Create(@"condition");
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.WebhookResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.WebhookResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"webhook-put", @"Update webhook
Updates a webhook using values specified by a webhook object passed as JSON
in the POST payload.
If the object does not define a specific property, its value will not be
updated.

The response is the full webhook object as returned by the
[Get webhook](#/reference/webhooks/webhook-object/get-webhook) endpoint.

The request needs to specify the `Content-Type: application/json` HTTP
header!

When providing your API authentication token, we recommend using the
request's `Authorization` header, rather than the URL. ([More
info](#/introduction/authentication)).
");
                        command.Arguments.Add(WebhookId);
                        command.Options.Add(IsAdHoc);
                        command.Options.Add(EventTypes);
                        command.Options.Add(IgnoreSslErrors);
                        command.Options.Add(DoNotRetry);
                        command.Options.Add(RequestUrl);
                        command.Options.Add(PayloadTemplate);
                        command.Options.Add(HeadersTemplate);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(ShouldInterpolateStrings);                        command.Options.Add(ConditionOptions.ActorId);
                        command.Options.Add(ConditionOptions.ActorTaskId);
                        command.Options.Add(ConditionOptions.ActorRunId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Apify.WebhookUpdate>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var webhookId = parseResult.GetRequiredValue(WebhookId);
                        var isAdHoc = CliRuntime.WasSpecified(parseResult, IsAdHoc) ? parseResult.GetValue(IsAdHoc) : (__requestBase is { } __IsAdHocBaseValue ? __IsAdHocBaseValue.IsAdHoc : default);
                        var eventTypes = CliRuntime.WasSpecified(parseResult, EventTypes) ? parseResult.GetValue(EventTypes) : (__requestBase is { } __EventTypesBaseValue ? __EventTypesBaseValue.EventTypes : default);
                        var ignoreSslErrors = CliRuntime.WasSpecified(parseResult, IgnoreSslErrors) ? parseResult.GetValue(IgnoreSslErrors) : (__requestBase is { } __IgnoreSslErrorsBaseValue ? __IgnoreSslErrorsBaseValue.IgnoreSslErrors : default);
                        var doNotRetry = CliRuntime.WasSpecified(parseResult, DoNotRetry) ? parseResult.GetValue(DoNotRetry) : (__requestBase is { } __DoNotRetryBaseValue ? __DoNotRetryBaseValue.DoNotRetry : default);
                        var requestUrl = CliRuntime.WasSpecified(parseResult, RequestUrl) ? parseResult.GetValue(RequestUrl) : (__requestBase is { } __RequestUrlBaseValue ? __RequestUrlBaseValue.RequestUrl : default);
                        var payloadTemplate = CliRuntime.WasSpecified(parseResult, PayloadTemplate) ? parseResult.GetValue(PayloadTemplate) : (__requestBase is { } __PayloadTemplateBaseValue ? __PayloadTemplateBaseValue.PayloadTemplate : default);
                        var headersTemplate = CliRuntime.WasSpecified(parseResult, HeadersTemplate) ? parseResult.GetValue(HeadersTemplate) : (__requestBase is { } __HeadersTemplateBaseValue ? __HeadersTemplateBaseValue.HeadersTemplate : default);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var shouldInterpolateStrings = CliRuntime.WasSpecified(parseResult, ShouldInterpolateStrings) ? parseResult.GetValue(ShouldInterpolateStrings) : (__requestBase is { } __ShouldInterpolateStringsBaseValue ? __ShouldInterpolateStringsBaseValue.ShouldInterpolateStrings : default);

                        var __ConditionBase = __requestBase is { } __ConditionBaseValue ? __ConditionBaseValue.Condition : default;                        var conditionActorId = CliRuntime.WasSpecified(parseResult, ConditionOptions.ActorId) ? parseResult.GetValue(ConditionOptions.ActorId) : (__ConditionBase is { } __ConditionactorIdBaseValue ? __ConditionactorIdBaseValue.ActorId : default);
                        var conditionActorTaskId = CliRuntime.WasSpecified(parseResult, ConditionOptions.ActorTaskId) ? parseResult.GetValue(ConditionOptions.ActorTaskId) : (__ConditionBase is { } __ConditionactorTaskIdBaseValue ? __ConditionactorTaskIdBaseValue.ActorTaskId : default);
                        var conditionActorRunId = CliRuntime.WasSpecified(parseResult, ConditionOptions.ActorRunId) ? parseResult.GetValue(ConditionOptions.ActorRunId) : (__ConditionBase is { } __ConditionactorRunIdBaseValue ? __ConditionactorRunIdBaseValue.ActorRunId : default);
                        var __ConditionSpecified = CliRuntime.WasSpecified(parseResult, ConditionOptions.ActorId) || CliRuntime.WasSpecified(parseResult, ConditionOptions.ActorTaskId) || CliRuntime.WasSpecified(parseResult, ConditionOptions.ActorRunId);
                        var condition =
                            __ConditionSpecified || __ConditionBase is not null
                                ? new global::Apify.WebhookCondition
                                {
	                                ActorId = conditionActorId,
                                ActorTaskId = conditionActorTaskId,
                                ActorRunId = conditionActorRunId,

                                }
                                : __ConditionBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.WebhooksWebhooks.WebhookPutAsync(
                                    webhookId: webhookId,
                                    isAdHoc: isAdHoc,
                                    eventTypes: eventTypes,
                                    ignoreSslErrors: ignoreSslErrors,
                                    doNotRetry: doNotRetry,
                                    requestUrl: requestUrl,
                                    payloadTemplate: payloadTemplate,
                                    headersTemplate: headersTemplate,
                                    description: description,
                                    shouldInterpolateStrings: shouldInterpolateStrings,
                                    condition: condition,
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