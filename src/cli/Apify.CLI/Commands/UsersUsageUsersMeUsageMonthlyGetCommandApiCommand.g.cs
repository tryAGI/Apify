#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class UsersUsageUsersMeUsageMonthlyGetCommandApiCommand
{
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


    public static Command Create()
    {
        var command = new Command(@"users-me-usage-monthly-get", @"Get monthly usage
Returns a complete summary of your usage for the current monthly usage cycle,
an overall sum, as well as a daily breakdown of usage. It is the same
information you will see on your account's [Billing &gt; Historical usage page](https://console.apify.com/billing/historical-usage). The information
includes your use of Actors, compute, data transfer, and storage.

Using the `date` parameter will show your usage in the monthly usage cycle that
includes that date.
");
                        command.Options.Add(Date);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var date = parseResult.GetValue(Date);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UsersUsage.UsersMeUsageMonthlyGetAsync(
                                    date: date,
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