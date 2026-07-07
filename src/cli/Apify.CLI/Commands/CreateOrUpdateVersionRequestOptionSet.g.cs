#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal sealed record CreateOrUpdateVersionRequestOptionSet(
    Option<string?> VersionNumber,
                     Option<bool?> ApplyEnvVarsToBuild,
                     Option<string?> BuildTag,
                     Option<string?> GitRepoUrl,
                     Option<string?> TarballUrl,
                     Option<string?> GitHubGistUrl)
{
    public static CreateOrUpdateVersionRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateOrUpdateVersionRequestOptionSet(
                        VersionNumber: new Option<string?>($"--{normalizedPrefix}version-number")
                {
                    Description = @"The version number of the Actor. Two numbers separated by a dot, that represent the `MAJOR.MINOR` part of the semantic versioning.",
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
                    Description = @"URL of the tarball to download the source code from. Applies when the `sourceType` is `TARBALL`.",
                },
                GitHubGistUrl: new Option<string?>($"--{normalizedPrefix}git-hub-gist-url")
                {
                    Description = @"URL of the GitHub Gist to clone the source code from. Applies when the `sourceType` is `GITHUB_GIST`.",
                }
        );
    }
}