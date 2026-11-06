#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal sealed record UpdateVersionRequestOptionSet(
    Option<string?> VersionNumber,
                     Option<global::Apify.WritableVersionSourceType?> SourceType,
                     Option<bool?> ApplyEnvVarsToBuild,
                     Option<string?> BuildTag,
                     Option<string?> GitRepoUrl,
                     Option<string?> TarballUrl,
                     Option<string?> GitHubGistUrl,
                     Option<string?> ActorPath)
{
    public static UpdateVersionRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new UpdateVersionRequestOptionSet(
                        VersionNumber: new Option<string?>($"--{normalizedPrefix}version-number")
                {
                    Description = @"The version number of the Actor. Two numbers separated by a dot, that represent the `MAJOR.MINOR` part of the semantic versioning.",
                },
                SourceType: new Option<global::Apify.WritableVersionSourceType?>($"--{normalizedPrefix}source-type")
                {
                    Description = @"Where the source code of the version lives.",
                },
                ApplyEnvVarsToBuild: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}apply-env-vars-to-build", description: @"Whether to inject the environment variables at build time."),
                BuildTag: new Option<string?>($"--{normalizedPrefix}build-tag")
                {
                    Description = @"The tag name to apply to a successful build of this version. Can be `null` when the version has no build tag.",
                },
                GitRepoUrl: new Option<string?>($"--{normalizedPrefix}git-repo-url")
                {
                    Description = @"URL of the Git repository to clone the source code from. Applies when the `sourceType` is `GIT_REPO`.",
                },
                TarballUrl: new Option<string?>($"--{normalizedPrefix}tarball-url")
                {
                    Description = @"URL of the zip archive to download the source code from. Applies when the `sourceType` is `TARBALL`.",
                },
                GitHubGistUrl: new Option<string?>($"--{normalizedPrefix}git-hub-gist-url")
                {
                    Description = @"URL of the GitHub Gist to clone the source code from. Applies when the `sourceType` is `GITHUB_GIST`.",
                },
                ActorPath: new Option<string?>($"--{normalizedPrefix}actor-path")
                {
                    Description = @"The Actor's directory inside the uploaded source, as a path relative to the upload root with `/` separators, for example `actors/typescript-actor`. Applies when the `sourceType` is `SOURCE_FILES` or `TARBALL`. The API rejects it when the `sourceType` is `GIT_REPO` or `GITHUB_GIST`. On an update without `sourceType`, the API checks it against the version's stored source type. When the version has no `actorPath`, the upload root is the Actor's directory. It has 1 to 255 characters, with no leading, trailing, or repeated `/` and no `.` or `..` segments. An update that sends `sourceType`, `sourceFiles`, or `tarballUrl` without `actorPath` removes the stored `actorPath`, so send it again with every upload. An update of other fields, such as `envVars` or `buildTag`, keeps it. Send `null` to remove it.",
                }
        );
    }
}