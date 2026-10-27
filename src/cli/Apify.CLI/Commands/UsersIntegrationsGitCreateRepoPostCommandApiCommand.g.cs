#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class UsersIntegrationsGitCreateRepoPostCommandApiCommand
{
    private static Argument<string> ProviderId { get; } = new(
        name: @"provider-id")
    {
        Description = @"The connected git account to use: `github-app` for the GitHub App, or the ID of a connected GitLab or
Bitbucket integration, as returned by [Get git provider integrations](/api/v2/integrations-git-get).
",
    };

    private static Option<string> Workspace { get; } = new(
        name: @"--workspace")
    {
        Description = @"Where to create the repository, as the `id` of one of the provider's workspaces. On GitLab, this is the
numeric namespace ID.
",
        Required = true,
    };

    private static Option<string> RepoName { get; } = new(
        name: @"--repo-name")
    {
        Description = @"",
        Required = true,
    };

    private static Option<bool> IsPrivate { get; } = new(
        name: @"--is-private")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::Apify.GitRepoFile>?> Files { get; } = new(
        name: @"--files")
    {
        Description = @"Files to commit as the initial commit. Can't be combined with `templateArchiveUrl`.",
    };

    private static Option<string?> TemplateArchiveUrl { get; } = new(
        name: @"--template-archive-url")
    {
        Description = @"URL of an Actor template archive whose files are committed as the initial commit. Can't be combined with
`files`.
",
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.GitRepoResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.GitRepoResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"integrations-git-create-repo-post", @"Create git repository
Creates a repository through a connected git account and commits the initial files into it, either the given
`files` or the files of an Actor template archive (`templateArchiveUrl`).
");
                        command.Arguments.Add(ProviderId);
                        command.Options.Add(Workspace);
                        command.Options.Add(RepoName);
                        command.Options.Add(IsPrivate);
                        command.Options.Add(Files);
                        command.Options.Add(TemplateArchiveUrl);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Apify.CreateGitRepoRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var providerId = parseResult.GetRequiredValue(ProviderId);
                        var workspace = parseResult.GetRequiredValue(Workspace);
                        var repoName = parseResult.GetRequiredValue(RepoName);
                        var isPrivate = parseResult.GetRequiredValue(IsPrivate);
                        var files = CliRuntime.WasSpecified(parseResult, Files) ? parseResult.GetValue(Files) : (__requestBase is { } __FilesBaseValue ? __FilesBaseValue.Files : default);
                        var templateArchiveUrl = CliRuntime.WasSpecified(parseResult, TemplateArchiveUrl) ? parseResult.GetValue(TemplateArchiveUrl) : (__requestBase is { } __TemplateArchiveUrlBaseValue ? __TemplateArchiveUrlBaseValue.TemplateArchiveUrl : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Users.IntegrationsGitCreateRepoPostAsync(
                                    providerId: providerId,
                                    workspace: workspace,
                                    repoName: repoName,
                                    isPrivate: isPrivate,
                                    files: files,
                                    templateArchiveUrl: templateArchiveUrl,
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