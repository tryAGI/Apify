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
                    Description = @"",
                },
                ApplyEnvVarsToBuild: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}apply-env-vars-to-build", description: @""),
                BuildTag: new Option<string?>($"--{normalizedPrefix}build-tag")
                {
                    Description = @"",
                },
                GitRepoUrl: new Option<string?>($"--{normalizedPrefix}git-repo-url")
                {
                    Description = @"URL of the Git repository when sourceType is GIT_REPO.",
                },
                TarballUrl: new Option<string?>($"--{normalizedPrefix}tarball-url")
                {
                    Description = @"URL of the tarball when sourceType is TARBALL.",
                },
                GitHubGistUrl: new Option<string?>($"--{normalizedPrefix}git-hub-gist-url")
                {
                    Description = @"URL of the GitHub Gist when sourceType is GITHUB_GIST.",
                }
        );
    }
}