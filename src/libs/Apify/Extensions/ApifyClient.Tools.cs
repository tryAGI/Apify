#nullable enable

using System.ComponentModel;
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Apify;

public static class ApifyClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that runs an Apify Actor (web scraper) with specified input.
    /// </summary>
    public static AIFunction AsRunActorTool(this ApifyClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The Actor ID (e.g. 'apify~web-scraper') or unique name (e.g. 'janedoe~my-actor')")] string actorId,
                   [Description("JSON string of the Actor input (varies per Actor)")] string? input,
                   [Description("Timeout in seconds for the Actor run (default: no limit)")] double? timeout,
                   [Description("Memory in megabytes allocated for the Actor run (e.g. 256, 512, 1024)")] double? memory,
                   [Description("Maximum number of items the Actor should return")] double? maxItems,
                   [Description("Maximum time in seconds to wait for the run to finish (0 = don't wait)")] double? waitForFinish,
                   CancellationToken cancellationToken) =>
            {
                object requestBody = input is { Length: > 0 }
                    ? JsonDocument.Parse(input).RootElement.Clone()
                    : JsonDocument.Parse("{}").RootElement.Clone();

                var response = await client.ActorsActorRuns.ActorsRunsPostAsync(
                    actorId: actorId,
                    request: requestBody!,
                    timeout: timeout,
                    memory: memory,
                    maxItems: maxItems,
                    waitForFinish: waitForFinish,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Data.Id,
                    response.Data.ActId,
                    Status = response.Data.Status.ToString(),
                    response.Data.StatusMessage,
                    response.Data.DefaultDatasetId,
                    response.Data.DefaultKeyValueStoreId,
                    response.Data.DefaultRequestQueueId,
                    response.Data.StartedAt,
                    response.Data.FinishedAt,
                };
            },
            name: "Apify_RunActor",
            description: "Run an Apify Actor (web scraper/automation) with specified input. Returns the run ID and default dataset ID for fetching results.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the status and details of an Actor run.
    /// </summary>
    public static AIFunction AsGetRunStatusTool(this ApifyClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The ID of the Actor run to check")] string runId,
                   [Description("Maximum time in seconds to wait for the run to finish (0 = return immediately)")] double? waitForFinish,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.ActorRuns.ActorRunGetAsync(
                    runId: runId,
                    waitForFinish: waitForFinish,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Data.Id,
                    response.Data.ActId,
                    Status = response.Data.Status.ToString(),
                    response.Data.StatusMessage,
                    response.Data.DefaultDatasetId,
                    response.Data.DefaultKeyValueStoreId,
                    response.Data.StartedAt,
                    response.Data.FinishedAt,
                    response.Data.ExitCode,
                };
            },
            name: "Apify_GetRunStatus",
            description: "Get the status and details of an Apify Actor run. Use waitForFinish to poll until completion.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists the user's Actors.
    /// </summary>
    public static AIFunction AsListActorsTool(this ApifyClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("If true, only return Actors created by the user (not used ones)")] bool? my,
                   [Description("Maximum number of Actors to return (default: 100, max: 1000)")] double? limit,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Actors.ActorsGetAsync(
                    my: my,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Apify_ListActors",
            description: "List Actors (web scrapers/automations) available to the user on Apify platform.");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves items from an Apify dataset.
    /// </summary>
    public static AIFunction AsGetDatasetItemsTool(this ApifyClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The ID of the dataset to fetch items from (obtained from a run's defaultDatasetId)")] string datasetId,
                   [Description("Maximum number of items to return")] double? limit,
                   [Description("Number of items to skip from the beginning")] double? offset,
                   [Description("Comma-separated list of fields to include in the response")] string? fields,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.StorageDatasets.DatasetItemsGetAsync(
                    datasetId: datasetId,
                    limit: limit,
                    offset: offset,
                    fields: fields,
                    clean: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Apify_GetDatasetItems",
            description: "Retrieve scraped data items from an Apify dataset. Use the defaultDatasetId from a run to fetch its results.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists Actor runs.
    /// </summary>
    public static AIFunction AsListRunsTool(this ApifyClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Maximum number of runs to return")] double? limit,
                   [Description("Filter by run status (e.g. 'SUCCEEDED', 'FAILED', 'RUNNING')")] string? status,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.ActorRuns.ActorRunsGetAsync(
                    limit: limit,
                    status: status is { Length: > 0 } ? [status] : null,
                    desc: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Apify_ListRuns",
            description: "List recent Actor runs on the Apify platform, optionally filtered by status.");
    }
}
