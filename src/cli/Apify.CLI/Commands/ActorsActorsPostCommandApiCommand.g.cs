#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorsPostCommandApiCommand
{
    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"The identifier of the Actor. Use lowercase letters, numbers, and hyphens. Spaces or special characters aren't allowed. Must be unique across your account.",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"Short description of the Actor, displayed in Apify Store and Console.",
    };

    private static Option<string?> Title { get; } = new(
        name: @"--title")
    {
        Description = @"Human-readable name of the Actor, displayed in Apify Store and Console. Can contain spaces and capital letters. Recommended length is 40-50 characters. You can change this title without affecting the Actor's URL or SEO.",
    };

    private static Option<bool?> IsPublic { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--is-public",
        description: @"Whether the Actor is available to users in Apify Store. If `false`, the Actor is private and only visible to you.");

    private static Option<string?> SeoTitle { get; } = new(
        name: @"--seo-title")
    {
        Description = @"Name of the Actor to display by search engines such as Google. Can be different from the Actor's name displayed in Apify Store and Console. Recommended length is 40-50 characters.",
    };

    private static Option<string?> SeoDescription { get; } = new(
        name: @"--seo-description")
    {
        Description = @"Description of the Actor to display by search engines such as Google. Recommended length is 140-156 characters.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Apify.Version>?> Versions { get; } = new(
        name: @"--versions")
    {
        Description = @"An array of `Version` objects. Each object represents a specific version of the Actor's source code: its location, builds, and environment configuration.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>?> PricingInfos { get; } = new(
        name: @"--pricing-infos")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Categories { get; } = new(
        name: @"--categories")
    {
        Description = @"A list of categories that best define the Actor. Reflected in Apify Store's search and filtering options.",
    };

    private static Option<bool?> IsDeprecated { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--is-deprecated",
        description: @"Whether the Actor is deprecated.");
    private static readonly DefaultRunOptionsOptionSet DefaultRunOptionsOptions = DefaultRunOptionsOptionSet.Create(@"default-run");

    private static readonly ActorStandbyOptionSet ActorStandbyOptions = ActorStandbyOptionSet.Create(@"actor-standby");

    private static readonly ExampleRunInputOptionSet ExampleRunInputOptions = ExampleRunInputOptionSet.Create(@"example-run-input");
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ActorResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ActorResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post", @"Create Actor
Creates an Actor with the settings specified in an `Actor` object passed as
JSON in the POST payload.

Returns the full `Actor` object, the same as the
[Get Actor](/api/v2/actor-get) endpoint.

In the HTTP request, set the `Content-Type` header to `application/json`.

### Define a source code version

An Actor must specify at least one version of the source code.
For details, see [Actor versions](/api/v2/actors-actor-versions).

### Create a public Actor

To make your Actor [public](https://docs.apify.com/platform/actors/publishing):
- Set `isPublic` to `true`.
- Provide `title` and `categories`. For reference, see [constants from the `apify-shared-js`
package](https://github.com/apify/apify-shared-js/blob/2d43ebc41ece9ad31cd6525bd523fb86939bf860/packages/consts/src/consts.ts#L452-L471)
");
                        command.Options.Add(NameOption);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Title);
                        command.Options.Add(IsPublic);
                        command.Options.Add(SeoTitle);
                        command.Options.Add(SeoDescription);
                        command.Options.Add(Versions);
                        command.Options.Add(PricingInfos);
                        command.Options.Add(Categories);
                        command.Options.Add(IsDeprecated);                        command.Options.Add(DefaultRunOptionsOptions.Build);
                        command.Options.Add(DefaultRunOptionsOptions.TimeoutSecs);
                        command.Options.Add(DefaultRunOptionsOptions.MemoryMbytes);
                        command.Options.Add(DefaultRunOptionsOptions.RestartOnError);
                        command.Options.Add(DefaultRunOptionsOptions.MaxItems);                        command.Options.Add(ActorStandbyOptions.IsEnabled);
                        command.Options.Add(ActorStandbyOptions.DesiredRequestsPerActorRun);
                        command.Options.Add(ActorStandbyOptions.MaxRequestsPerActorRun);
                        command.Options.Add(ActorStandbyOptions.IdleTimeoutSecs);
                        command.Options.Add(ActorStandbyOptions.Build);
                        command.Options.Add(ActorStandbyOptions.MemoryMbytes);
                        command.Options.Add(ActorStandbyOptions.DisableStandbyFieldsOverride);
                        command.Options.Add(ActorStandbyOptions.ShouldPassActorInput);                        command.Options.Add(ExampleRunInputOptions.Body);
                        command.Options.Add(ExampleRunInputOptions.ContentType);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Apify.CreateActorRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var title = CliRuntime.WasSpecified(parseResult, Title) ? parseResult.GetValue(Title) : (__requestBase is { } __TitleBaseValue ? __TitleBaseValue.Title : default);
                        var isPublic = CliRuntime.WasSpecified(parseResult, IsPublic) ? parseResult.GetValue(IsPublic) : (__requestBase is { } __IsPublicBaseValue ? __IsPublicBaseValue.IsPublic : default);
                        var seoTitle = CliRuntime.WasSpecified(parseResult, SeoTitle) ? parseResult.GetValue(SeoTitle) : (__requestBase is { } __SeoTitleBaseValue ? __SeoTitleBaseValue.SeoTitle : default);
                        var seoDescription = CliRuntime.WasSpecified(parseResult, SeoDescription) ? parseResult.GetValue(SeoDescription) : (__requestBase is { } __SeoDescriptionBaseValue ? __SeoDescriptionBaseValue.SeoDescription : default);
                        var versions = CliRuntime.WasSpecified(parseResult, Versions) ? parseResult.GetValue(Versions) : (__requestBase is { } __VersionsBaseValue ? __VersionsBaseValue.Versions : default);
                        var pricingInfos = CliRuntime.WasSpecified(parseResult, PricingInfos) ? parseResult.GetValue(PricingInfos) : (__requestBase is { } __PricingInfosBaseValue ? __PricingInfosBaseValue.PricingInfos : default);
                        var categories = CliRuntime.WasSpecified(parseResult, Categories) ? parseResult.GetValue(Categories) : (__requestBase is { } __CategoriesBaseValue ? __CategoriesBaseValue.Categories : default);
                        var isDeprecated = CliRuntime.WasSpecified(parseResult, IsDeprecated) ? parseResult.GetValue(IsDeprecated) : (__requestBase is { } __IsDeprecatedBaseValue ? __IsDeprecatedBaseValue.IsDeprecated : default);

                        var __DefaultRunOptionsBase = __requestBase is { } __DefaultRunOptionsBaseValue ? __DefaultRunOptionsBaseValue.DefaultRunOptions : default;                        var defaultRunOptionsBuild = CliRuntime.WasSpecified(parseResult, DefaultRunOptionsOptions.Build) ? parseResult.GetValue(DefaultRunOptionsOptions.Build) : (__DefaultRunOptionsBase is { } __DefaultRunOptionsbuildBaseValue ? __DefaultRunOptionsbuildBaseValue.Build : default);
                        var defaultRunOptionsTimeoutSecs = CliRuntime.WasSpecified(parseResult, DefaultRunOptionsOptions.TimeoutSecs) ? parseResult.GetValue(DefaultRunOptionsOptions.TimeoutSecs) : (__DefaultRunOptionsBase is { } __DefaultRunOptionstimeoutSecsBaseValue ? __DefaultRunOptionstimeoutSecsBaseValue.TimeoutSecs : default);
                        var defaultRunOptionsMemoryMbytes = CliRuntime.WasSpecified(parseResult, DefaultRunOptionsOptions.MemoryMbytes) ? parseResult.GetValue(DefaultRunOptionsOptions.MemoryMbytes) : (__DefaultRunOptionsBase is { } __DefaultRunOptionsmemoryMbytesBaseValue ? __DefaultRunOptionsmemoryMbytesBaseValue.MemoryMbytes : default);
                        var defaultRunOptionsRestartOnError = CliRuntime.WasSpecified(parseResult, DefaultRunOptionsOptions.RestartOnError) ? parseResult.GetValue(DefaultRunOptionsOptions.RestartOnError) : (__DefaultRunOptionsBase is { } __DefaultRunOptionsrestartOnErrorBaseValue ? __DefaultRunOptionsrestartOnErrorBaseValue.RestartOnError : default);
                        var defaultRunOptionsMaxItems = CliRuntime.WasSpecified(parseResult, DefaultRunOptionsOptions.MaxItems) ? parseResult.GetValue(DefaultRunOptionsOptions.MaxItems) : (__DefaultRunOptionsBase is { } __DefaultRunOptionsmaxItemsBaseValue ? __DefaultRunOptionsmaxItemsBaseValue.MaxItems : default);
                        var __DefaultRunOptionsSpecified = CliRuntime.WasSpecified(parseResult, DefaultRunOptionsOptions.Build) || CliRuntime.WasSpecified(parseResult, DefaultRunOptionsOptions.TimeoutSecs) || CliRuntime.WasSpecified(parseResult, DefaultRunOptionsOptions.MemoryMbytes) || CliRuntime.WasSpecified(parseResult, DefaultRunOptionsOptions.RestartOnError) || CliRuntime.WasSpecified(parseResult, DefaultRunOptionsOptions.MaxItems);
                        var defaultRunOptions =
                            __DefaultRunOptionsSpecified || __DefaultRunOptionsBase is not null
                                ? new global::Apify.DefaultRunOptions
                                {
	                                Build = defaultRunOptionsBuild,
                                TimeoutSecs = defaultRunOptionsTimeoutSecs,
                                MemoryMbytes = defaultRunOptionsMemoryMbytes,
                                RestartOnError = defaultRunOptionsRestartOnError,
                                MaxItems = defaultRunOptionsMaxItems,

                                }
                                : __DefaultRunOptionsBase;

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

                        var __ExampleRunInputBase = __requestBase is { } __ExampleRunInputBaseValue ? __ExampleRunInputBaseValue.ExampleRunInput : default;                        var exampleRunInputBody = CliRuntime.WasSpecified(parseResult, ExampleRunInputOptions.Body) ? parseResult.GetValue(ExampleRunInputOptions.Body) : (__ExampleRunInputBase is { } __ExampleRunInputbodyBaseValue ? __ExampleRunInputbodyBaseValue.Body : default);
                        var exampleRunInputContentType = CliRuntime.WasSpecified(parseResult, ExampleRunInputOptions.ContentType) ? parseResult.GetValue(ExampleRunInputOptions.ContentType) : (__ExampleRunInputBase is { } __ExampleRunInputcontentTypeBaseValue ? __ExampleRunInputcontentTypeBaseValue.ContentType : default);
                        var __ExampleRunInputSpecified = CliRuntime.WasSpecified(parseResult, ExampleRunInputOptions.Body) || CliRuntime.WasSpecified(parseResult, ExampleRunInputOptions.ContentType);
                        var exampleRunInput =
                            __ExampleRunInputSpecified || __ExampleRunInputBase is not null
                                ? new global::Apify.ExampleRunInput
                                {
	                                Body = exampleRunInputBody,
                                ContentType = exampleRunInputContentType,

                                }
                                : __ExampleRunInputBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Actors.ActorsPostAsync(
                                    name: name,
                                    description: description,
                                    title: title,
                                    isPublic: isPublic,
                                    seoTitle: seoTitle,
                                    seoDescription: seoDescription,
                                    versions: versions,
                                    pricingInfos: pricingInfos,
                                    categories: categories,
                                    isDeprecated: isDeprecated,
                                    defaultRunOptions: defaultRunOptions,
                                    actorStandby: actorStandby,
                                    exampleRunInput: exampleRunInput,
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