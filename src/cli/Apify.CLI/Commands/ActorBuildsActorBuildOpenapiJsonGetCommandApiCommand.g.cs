#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorBuildsActorBuildOpenapiJsonGetCommandApiCommand
{
    private static Argument<string> BuildId { get; } = new(
        name: @"build-id")
    {
        Description = @"ID of the build, found in the build's Info tab.
Use the special value `default` to get the OpenAPI schema for the Actor's default build.
",
    };

                    private static string FormatResponse(ParseResult parseResult, string value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, string value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"openapi-json-get", @"Get OpenAPI definition
Get the OpenAPI definition for Actor builds. Two similar endpoints are available:

- [First endpoint](/api/v2/act-openapi-json-get): Requires both `actorId` and `buildId`. Use `default` as the `buildId` to get the OpenAPI schema for the default Actor build.
- [Second endpoint](/api/v2/actor-build-openapi-json-get): Requires only `buildId`.

Get the OpenAPI definition for a specific Actor build.
Authentication is based on the build's unique ID. No authentication token is required.

:::note

You can also use the [`/api/v2/act-openapi-json-get`](/api/v2/act-openapi-json-get) endpoint to get the OpenAPI definition for a build.

:::
");
                        command.Arguments.Add(BuildId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var buildId = parseResult.GetRequiredValue(BuildId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorBuilds.ActorBuildOpenapiJsonGetAsync(
                                    buildId: buildId,
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