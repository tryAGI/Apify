/*
order: 10
title: Web Scraping
slug: web-scraping
*/

namespace Apify.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async System.Threading.Tasks.Task Example_RunActorAndGetResults()
    {
        using var client = GetAuthenticatedClient();

        //// Run the Web Scraper Actor to scrape a single page
        var runResponse = await client.ActorsActorRuns.ActRunsPostAsync(
            actorId: "apify~web-scraper",
            request: new
            {
                startUrls = new[] { new { url = "https://www.example.com" } },
                maxPagesPerCrawl = 1,
            },
            waitForFinish: 120);

        //// The run response contains the run status and default dataset ID
        runResponse.Data.Id.Should().NotBeNullOrEmpty();
        runResponse.Data.DefaultDatasetId.Should().NotBeNullOrEmpty();

        //// Fetch the scraped data from the default dataset
        var items = await client.StorageDatasets.DatasetItemsGetAsync(
            datasetId: runResponse.Data.DefaultDatasetId,
            clean: true);

        items.Should().NotBeNull();
    }

    [TestMethod]
    public async System.Threading.Tasks.Task Example_GetRunStatus()
    {
        using var client = GetAuthenticatedClient();

        //// List recent runs to find a run ID
        var runsResponse = await client.ActorRuns.ActorRunsGetAsync(
            limit: 1,
            desc: true);

        //// The response Data is a union type containing pagination and items
        runsResponse.Data.Should().NotBeNull();
    }

    [TestMethod]
    public async System.Threading.Tasks.Task Example_ListActors()
    {
        using var client = GetAuthenticatedClient();

        //// List Actors owned by the user
        var response = await client.Actors.ActsGetAsync(
            my: true,
            limit: 10);

        response.Data.Should().NotBeNull();
    }
}
