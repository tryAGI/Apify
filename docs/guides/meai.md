# Microsoft.Extensions.AI Integration

The Apify SDK provides `AIFunction` tool wrappers that integrate with any `IChatClient` from the Microsoft.Extensions.AI ecosystem.

## Available Tools

| Tool | Method | Description |
|------|--------|-------------|
| Run Actor | `AsRunActorTool()` | Run an Apify Actor (web scraper/automation) with specified input |
| Get Run Status | `AsGetRunStatusTool()` | Get the status and details of an Actor run |
| List Actors | `AsListActorsTool()` | List Actors available to the user |
| Get Dataset Items | `AsGetDatasetItemsTool()` | Retrieve scraped data from a dataset |
| List Runs | `AsListRunsTool()` | List recent Actor runs |

## Usage Example

```csharp
using Apify;
using Microsoft.Extensions.AI;

// Create the Apify client
var apifyClient = new ApifyClient(apiKey);

// Create tools for use with any IChatClient
var tools = new[]
{
    apifyClient.AsRunActorTool(),
    apifyClient.AsGetRunStatusTool(),
    apifyClient.AsListActorsTool(),
    apifyClient.AsGetDatasetItemsTool(),
    apifyClient.AsListRunsTool(),
};

// Use with any IChatClient (e.g., OpenAI, Anthropic, Ollama)
var response = await chatClient.GetResponseAsync(
    "Scrape the homepage of example.com using the web scraper actor",
    new ChatOptions { Tools = tools });
```

## Typical AI Agent Workflow

1. The AI agent calls `AsListActorsTool()` to discover available scrapers
2. The agent calls `AsRunActorTool()` with the appropriate Actor ID and input
3. The agent polls `AsGetRunStatusTool()` until the run completes
4. The agent calls `AsGetDatasetItemsTool()` to retrieve the scraped data
