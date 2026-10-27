#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class UsersUsageUsersUsageMonthlyGetCommandApiCommand
{
    private static Argument<string> UserId { get; } = new(
        name: @"user-id")
    {
        Description = @"User ID or username of your account, or of the organization your API token belongs to.",
    };

    private static Option<string?> Date { get; } = new(
        name: @"--date")
    {
        Description = @"Date in the YYYY-MM-DD format.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.MonthlyUsageResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.MonthlyUsageResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"monthly-get", @"Get user's monthly usage by ID
Returns the same summary of monthly usage as [Get user's monthly usage](/api/v2/users-me-usage-monthly-get),
for an account given by its ID or username.

You can only access your own account, or the organization your API token belongs to. API tokens with
limited permissions can't use this endpoint.

Using the `date` parameter will show the usage in the monthly usage cycle that
includes that date.
");
                        command.Arguments.Add(UserId);
                        command.Options.Add(Date);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var userId = parseResult.GetRequiredValue(UserId);
                        var date = parseResult.GetValue(Date);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UsersUsage.UsersUsageMonthlyGetAsync(
                                    userId: userId,
                                    date: date,
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