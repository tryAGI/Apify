#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorVersionsActVersionsPostCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or a tilde-separated owner's username and Actor name.",
    };

    private static Option<global::Apify.VersionSourceType?> SourceType { get; } = new(
        name: @"--source-type")
    {
        Description = @"Where the source code of the version lives.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Apify.EnvVar>?> EnvVars { get; } = new(
        name: @"--env-vars")
    {
        Description = @"Environment variables for the version.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>?> SourceFiles { get; } = new(
        name: @"--source-files")
    {
        Description = @"Applies when the `sourceType` is `SOURCE_FILES`. Represents the Actor's file structure as an array of files and folders.",
    };
    private static readonly CreateOrUpdateVersionRequestOptionSet CreateOrUpdateVersionRequestOptionSetOptions = CreateOrUpdateVersionRequestOptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.VersionResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.VersionResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"act-versions-post", @"Create version
Creates a version of an Actor using values specified in a [Version
object](#/reference/actors/version-object) passed as JSON in the POST
payload.

The request must specify `versionNumber` and `sourceType` parameters (as
strings) in the JSON payload and a `Content-Type: application/json` HTTP
header.

Each `sourceType` requires its own additional properties to be passed to the
JSON payload object. These are outlined in the [Version
object](#/reference/actors/version-object) table below and in more detail in
the [Apify
documentation](https://docs.apify.com/platform/actors/development/deployment/source-types).

For example, if an Actor's source code is stored in a [GitHub
repository](https://docs.apify.com/platform/actors/development/deployment/source-types#git-repository),
you will set the `sourceType` to `GIT_REPO` and pass the repository's URL in
the `gitRepoUrl` property.

```
{
    ""versionNumber"": ""0.1"",
    ""sourceType"": ""GIT_REPO"",
    ""gitRepoUrl"": ""https://github.com/my-github-account/actor-repo""
}
```

The response is the [Version object](#/reference/actors/version-object) as
returned by the [Get version](#/reference/actors/version-object/get-version) endpoint.
");
                        command.Arguments.Add(ActorId);
                        command.Options.Add(SourceType);
                        command.Options.Add(EnvVars);
                        command.Options.Add(SourceFiles);                        command.Options.Add(CreateOrUpdateVersionRequestOptionSetOptions.VersionNumber);
                        command.Options.Add(CreateOrUpdateVersionRequestOptionSetOptions.ApplyEnvVarsToBuild);
                        command.Options.Add(CreateOrUpdateVersionRequestOptionSetOptions.BuildTag);
                        command.Options.Add(CreateOrUpdateVersionRequestOptionSetOptions.GitRepoUrl);
                        command.Options.Add(CreateOrUpdateVersionRequestOptionSetOptions.TarballUrl);
                        command.Options.Add(CreateOrUpdateVersionRequestOptionSetOptions.GitHubGistUrl);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Apify.CreateOrUpdateVersionRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var sourceType = CliRuntime.WasSpecified(parseResult, SourceType) ? parseResult.GetValue(SourceType) : (__requestBase is { } __SourceTypeBaseValue ? __SourceTypeBaseValue.SourceType : default);
                        var envVars = CliRuntime.WasSpecified(parseResult, EnvVars) ? parseResult.GetValue(EnvVars) : (__requestBase is { } __EnvVarsBaseValue ? __EnvVarsBaseValue.EnvVars : default);
                        var sourceFiles = CliRuntime.WasSpecified(parseResult, SourceFiles) ? parseResult.GetValue(SourceFiles) : (__requestBase is { } __SourceFilesBaseValue ? __SourceFilesBaseValue.SourceFiles : default);                        var versionNumber = CliRuntime.WasSpecified(parseResult, CreateOrUpdateVersionRequestOptionSetOptions.VersionNumber) ? parseResult.GetValue(CreateOrUpdateVersionRequestOptionSetOptions.VersionNumber) : (__requestBase is { } __VersionNumberBaseValue ? __VersionNumberBaseValue.VersionNumber : default);
                        var applyEnvVarsToBuild = CliRuntime.WasSpecified(parseResult, CreateOrUpdateVersionRequestOptionSetOptions.ApplyEnvVarsToBuild) ? parseResult.GetValue(CreateOrUpdateVersionRequestOptionSetOptions.ApplyEnvVarsToBuild) : (__requestBase is { } __ApplyEnvVarsToBuildBaseValue ? __ApplyEnvVarsToBuildBaseValue.ApplyEnvVarsToBuild : default);
                        var buildTag = CliRuntime.WasSpecified(parseResult, CreateOrUpdateVersionRequestOptionSetOptions.BuildTag) ? parseResult.GetValue(CreateOrUpdateVersionRequestOptionSetOptions.BuildTag) : (__requestBase is { } __BuildTagBaseValue ? __BuildTagBaseValue.BuildTag : default);
                        var gitRepoUrl = CliRuntime.WasSpecified(parseResult, CreateOrUpdateVersionRequestOptionSetOptions.GitRepoUrl) ? parseResult.GetValue(CreateOrUpdateVersionRequestOptionSetOptions.GitRepoUrl) : (__requestBase is { } __GitRepoUrlBaseValue ? __GitRepoUrlBaseValue.GitRepoUrl : default);
                        var tarballUrl = CliRuntime.WasSpecified(parseResult, CreateOrUpdateVersionRequestOptionSetOptions.TarballUrl) ? parseResult.GetValue(CreateOrUpdateVersionRequestOptionSetOptions.TarballUrl) : (__requestBase is { } __TarballUrlBaseValue ? __TarballUrlBaseValue.TarballUrl : default);
                        var gitHubGistUrl = CliRuntime.WasSpecified(parseResult, CreateOrUpdateVersionRequestOptionSetOptions.GitHubGistUrl) ? parseResult.GetValue(CreateOrUpdateVersionRequestOptionSetOptions.GitHubGistUrl) : (__requestBase is { } __GitHubGistUrlBaseValue ? __GitHubGistUrlBaseValue.GitHubGistUrl : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorsActorVersions.ActVersionsPostAsync(
                                    actorId: actorId,
                                    sourceType: sourceType,
                                    envVars: envVars,
                                    sourceFiles: sourceFiles,
                                    versionNumber: versionNumber,
                                    applyEnvVarsToBuild: applyEnvVarsToBuild,
                                    buildTag: buildTag,
                                    gitRepoUrl: gitRepoUrl,
                                    tarballUrl: tarballUrl,
                                    gitHubGistUrl: gitHubGistUrl,
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