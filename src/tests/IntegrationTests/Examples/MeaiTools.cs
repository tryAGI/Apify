/*
order: 20
title: MEAI Tools
slug: meai-tools
*/

namespace Apify.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_CreateTools()
    {
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools for use with any IChatClient
        var runActorTool = client.AsRunActorTool();
        var getRunStatusTool = client.AsGetRunStatusTool();
        var listActorsTool = client.AsListActorsTool();
        var getDatasetItemsTool = client.AsGetDatasetItemsTool();
        var listRunsTool = client.AsListRunsTool();

        //// All tools are created with descriptive names and descriptions
        runActorTool.Name.Should().Be("Apify_RunActor");
        getRunStatusTool.Name.Should().Be("Apify_GetRunStatus");
        listActorsTool.Name.Should().Be("Apify_ListActors");
        getDatasetItemsTool.Name.Should().Be("Apify_GetDatasetItems");
        listRunsTool.Name.Should().Be("Apify_ListRuns");
    }
}
