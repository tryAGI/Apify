#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class UsersIntegrationsGitRegisterDeploymentKeyPostCommandApiCommand
{
    private static Argument<string> ProviderId { get; } = new(
        name: @"provider-id")
    {
        Description = @"The connected git account to use: `github-app` for the GitHub App, or the ID of a connected GitLab or
Bitbucket integration, as returned by [Get git provider integrations](/api/v2/integrations-git-get).
",
    };

    private static Option<string> ActorId { get; } = new(
        name: @"--actor-id")
    {
        Description = @"ID or `username~name` of the Actor whose deployment key to register.",
        Required = true,
    };

    private static Option<string> RepoName { get; } = new(
        name: @"--repo-name")
    {
        Description = @"URL of the repository to register the key on. Its host must match the provider.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.RegisterDeploymentKeyResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.RegisterDeploymentKeyResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"integrations-git-register-deployment-key-post", @"Register deployment key
Registers the Actor's deployment key (a read-only SSH key generated for every Actor) on a repository through a
connected git account, so that Apify can clone the repository when building the Actor.

You need write access to the Actor. The repository's host must match the provider of the connected account.
If the key is already registered on the repository, nothing changes. On GitHub, registering the key on another
repository removes it from the previously linked one.
");
                        command.Arguments.Add(ProviderId);
                        command.Options.Add(ActorId);
                        command.Options.Add(RepoName);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var providerId = parseResult.GetRequiredValue(ProviderId);
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var repoName = parseResult.GetRequiredValue(RepoName);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Users.IntegrationsGitRegisterDeploymentKeyPostAsync(
                                    providerId: providerId,
                                    actorId: actorId,
                                    repoName: repoName,
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