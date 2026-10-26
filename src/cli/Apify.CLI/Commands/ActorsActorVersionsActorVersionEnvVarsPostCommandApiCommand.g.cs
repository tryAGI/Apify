#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorVersionsActorVersionEnvVarsPostCommandApiCommand
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
    private static readonly EnvVarRequestOptionSet EnvVarRequestOptionSetOptions = EnvVarRequestOptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.EnvVarResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.EnvVarResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"actor-version-env-vars-post", @"Create environment variable in Actor version
Creates an environment variable of an Actor using values specified in an
`EnvVar` object passed as
JSON in the POST payload.

The request must specify `name` and `value` parameters (as strings) in the
JSON payload and a `Content-Type: application/json` HTTP header.

```
{
    ""name"": ""ENV_VAR_NAME"",
    ""value"": ""my-env-var""
}
```

The response is the `EnvVar`
object as returned by the [Get environment variable of Actor version](/api/v2/actor-version-env-var-get)
endpoint.
");
                        command.Arguments.Add(ActorId);
                        command.Arguments.Add(VersionNumber);                        command.Options.Add(EnvVarRequestOptionSetOptions.NameOption);
                        command.Options.Add(EnvVarRequestOptionSetOptions.Value);
                        command.Options.Add(EnvVarRequestOptionSetOptions.IsSecret);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Apify.EnvVarRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Apify.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var versionNumber = parseResult.GetRequiredValue(VersionNumber);                        var name = parseResult.GetRequiredValue(EnvVarRequestOptionSetOptions.NameOption);
                        var value = parseResult.GetRequiredValue(EnvVarRequestOptionSetOptions.Value);
                        var isSecret = CliRuntime.WasSpecified(parseResult, EnvVarRequestOptionSetOptions.IsSecret) ? parseResult.GetValue(EnvVarRequestOptionSetOptions.IsSecret) : (__requestBase is { } __IsSecretBaseValue ? __IsSecretBaseValue.IsSecret : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorsActorVersions.ActorVersionEnvVarsPostAsync(
                                    actorId: actorId,
                                    versionNumber: versionNumber,
                                    name: name,
                                    value: value,
                                    isSecret: isSecret,
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