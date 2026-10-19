#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorVersionsActorVersionsPostCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or the username of the Actor owner and the Actor name, separated by a tilde (`~`).",
    };

    private static Option<string> VersionNumber { get; } = new(
        name: @"--version-number")
    {
        Description = @"The version number of the Actor. Two numbers separated by a dot, that represent the `MAJOR.MINOR` part of the semantic versioning.",
        Required = true,
    };

    private static Option<global::Apify.WritableVersionSourceType> SourceType { get; } = new(
        name: @"--source-type")
    {
        Description = @"Where the source code of the version lives.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::Apify.EnvVarRequest>?> EnvVars { get; } = new(
        name: @"--env-vars")
    {
        Description = @"Environment variables for the version.",
    };

    private static Option<bool?> ApplyEnvVarsToBuild { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--apply-env-vars-to-build",
        description: @"Whether to inject the environment variables at build time.");

    private static Option<string?> BuildTag { get; } = new(
        name: @"--build-tag")
    {
        Description = @"The tag name to apply to a successful build of this version. Can be `null` when the version has no build tag.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>?> SourceFiles { get; } = new(
        name: @"--source-files")
    {
        Description = @"Applies when the `sourceType` is `SOURCE_FILES`. Represents the Actor's file structure as an array of files and folders.",
    };

    private static Option<string?> GitRepoUrl { get; } = new(
        name: @"--git-repo-url")
    {
        Description = @"URL of the Git repository to clone the source code from. Applies when the `sourceType` is `GIT_REPO`.",
    };

    private static Option<string?> TarballUrl { get; } = new(
        name: @"--tarball-url")
    {
        Description = @"URL of the tarball to download the source code from. Applies when the `sourceType` is `TARBALL`.",
    };

    private static Option<string?> GitHubGistUrl { get; } = new(
        name: @"--git-hub-gist-url")
    {
        Description = @"URL of the GitHub Gist to clone the source code from. Applies when the `sourceType` is `GITHUB_GIST`.",
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


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"actor-versions-post", @"Create version
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
                        command.Options.Add(VersionNumber);
                        command.Options.Add(SourceType);
                        command.Options.Add(EnvVars);
                        command.Options.Add(ApplyEnvVarsToBuild);
                        command.Options.Add(BuildTag);
                        command.Options.Add(SourceFiles);
                        command.Options.Add(GitRepoUrl);
                        command.Options.Add(TarballUrl);
                        command.Options.Add(GitHubGistUrl);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Apify.CreateVersionRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var versionNumber = parseResult.GetRequiredValue(VersionNumber);
                        var sourceType = parseResult.GetRequiredValue(SourceType);
                        var envVars = CliRuntime.WasSpecified(parseResult, EnvVars) ? parseResult.GetValue(EnvVars) : (__requestBase is { } __EnvVarsBaseValue ? __EnvVarsBaseValue.EnvVars : default);
                        var applyEnvVarsToBuild = CliRuntime.WasSpecified(parseResult, ApplyEnvVarsToBuild) ? parseResult.GetValue(ApplyEnvVarsToBuild) : (__requestBase is { } __ApplyEnvVarsToBuildBaseValue ? __ApplyEnvVarsToBuildBaseValue.ApplyEnvVarsToBuild : default);
                        var buildTag = CliRuntime.WasSpecified(parseResult, BuildTag) ? parseResult.GetValue(BuildTag) : (__requestBase is { } __BuildTagBaseValue ? __BuildTagBaseValue.BuildTag : default);
                        var sourceFiles = CliRuntime.WasSpecified(parseResult, SourceFiles) ? parseResult.GetValue(SourceFiles) : (__requestBase is { } __SourceFilesBaseValue ? __SourceFilesBaseValue.SourceFiles : default);
                        var gitRepoUrl = CliRuntime.WasSpecified(parseResult, GitRepoUrl) ? parseResult.GetValue(GitRepoUrl) : (__requestBase is { } __GitRepoUrlBaseValue ? __GitRepoUrlBaseValue.GitRepoUrl : default);
                        var tarballUrl = CliRuntime.WasSpecified(parseResult, TarballUrl) ? parseResult.GetValue(TarballUrl) : (__requestBase is { } __TarballUrlBaseValue ? __TarballUrlBaseValue.TarballUrl : default);
                        var gitHubGistUrl = CliRuntime.WasSpecified(parseResult, GitHubGistUrl) ? parseResult.GetValue(GitHubGistUrl) : (__requestBase is { } __GitHubGistUrlBaseValue ? __GitHubGistUrlBaseValue.GitHubGistUrl : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorsActorVersions.ActorVersionsPostAsync(
                                    actorId: actorId,
                                    versionNumber: versionNumber,
                                    sourceType: sourceType,
                                    envVars: envVars,
                                    applyEnvVarsToBuild: applyEnvVarsToBuild,
                                    buildTag: buildTag,
                                    sourceFiles: sourceFiles,
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
        CustomizeCommand(ref command);
        return command;
    }
}