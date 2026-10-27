#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorVersionsActorVersionBuildOnPushPutCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or the username of the Actor owner and the Actor name, separated by a tilde (`~`).",
    };

    private static Argument<string> VersionNumber { get; } = new(
        name: @"version-number")
    {
        Description = @"Actor version.",
    };

    private static Option<string> ProviderId { get; } = new(
        name: @"--provider-id")
    {
        Description = @"The connected git account to register the push webhook through: `github-app` for the GitHub App, or the ID
of a connected GitLab or Bitbucket integration, as returned by the [Get git provider integrations](/api/v2/integrations-git-get) endpoint.
",
        Required = true,
    };

    private static Option<bool> Enabled { get; } = new(
        name: @"--enabled")
    {
        Description = @"`true` registers the push webhook so that pushes to the repository build the version; `false` turns it off.",
        Required = true,
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"actor-version-build-on-push-put", @"Update Actor version build on push
Turns automatic builds on push on or off for an Actor version whose source is a git repository.

Enabling registers a push webhook on the repository through the connected git account given by `providerId`, so
that every push to the repository builds the version. Disabling turns the webhook off on GitHub, or removes it
on GitLab and Bitbucket.

You need write access to the Actor. The version must have its source type set to a git repository, and the
connected account must have permission to manage the repository's webhooks.
");
                        command.Arguments.Add(ActorId);
                        command.Arguments.Add(VersionNumber);
                        command.Options.Add(ProviderId);
                        command.Options.Add(Enabled);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var versionNumber = parseResult.GetRequiredValue(VersionNumber);
                        var providerId = parseResult.GetRequiredValue(ProviderId);
                        var enabled = parseResult.GetRequiredValue(Enabled);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.ActorsActorVersions.ActorVersionBuildOnPushPutAsync(
                                    actorId: actorId,
                                    versionNumber: versionNumber,
                                    providerId: providerId,
                                    enabled: enabled,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}