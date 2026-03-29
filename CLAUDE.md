# CLAUDE.md -- Apify SDK

## Overview

Auto-generated C# SDK for [Apify](https://apify.com/) -- web scraping and automation platform with 4000+ pre-built Actors (scrapers), datasets, key-value stores, request queues, schedules, and webhooks.
OpenAPI spec from `https://docs.apify.com/api/openapi.json` (OpenAPI 3.1.2).

## Build & Test

```bash
dotnet build Apify.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Standard HTTP Bearer token. Get your API token from [Apify Console Integrations](https://console.apify.com/account#/integrations).

```csharp
var client = new ApifyClient(apiKey); // APIFY_API_KEY env var
```

## Key Files

- `src/libs/Apify/openapi.yaml` -- Source OpenAPI spec (downloaded as JSON, named .yaml by convention)
- `src/libs/Apify/generate.sh` -- Regeneration script
- `src/libs/Apify/Generated/` -- **Never edit** -- auto-generated code (1182 files)
- `src/libs/Apify/Extensions/ApifyClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new ApifyClient(apiKey);

// Actors (web scrapers/automations)
client.Actors.ActsGetAsync()                       // List actors
client.ActorsActorRuns.ActRunsPostAsync(...)        // Run an actor
client.ActorsActorRuns.ActRunSyncGetDatasetItemsPostAsync(...)  // Run actor synchronously

// Actor Runs
client.ActorRuns.ActorRunGetAsync(runId)            // Get run status
client.ActorRuns.ActorRunsGetAsync()                // List runs

// Datasets
client.StorageDatasets.DatasetItemsGetAsync(datasetId)  // Get scraped data
client.StorageDatasets.DatasetsGetAsync()               // List datasets

// Key-Value Stores
client.StorageKeyValueStores.KeyValueStoreRecordGetAsync(...)  // Get record
client.StorageKeyValueStores.KeyValueStoreKeysGetAsync(...)    // List keys

// Request Queues
client.StorageRequestQueues.RequestQueuesPostAsync(...)  // Create queue

// Schedules
client.Schedules.SchedulesPostAsync(...)           // Create schedule

// Webhooks
client.WebhooksWebhooks.WebhooksGetAsync()         // List webhooks

// Store (Apify marketplace)
client.Store.StoreGetAsync()                        // Browse store
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsRunActorTool()` -- Run an Apify Actor with specified input
- `AsGetRunStatusTool()` -- Get run status and details
- `AsListActorsTool()` -- List available Actors
- `AsGetDatasetItemsTool()` -- Retrieve scraped data from a dataset
- `AsListRunsTool()` -- List recent Actor runs

## Namespace Conflict

The Apify SDK generates an `Apify.Task` class that shadows `System.Threading.Tasks.Task`. In test files within the `Apify.IntegrationTests` namespace, use the fully qualified type:

```csharp
public async System.Threading.Tasks.Task MyTestMethod()
```

## Typical Workflow

1. Run an Actor: `POST /v2/acts/{actorId}/runs`
2. Poll for completion: `GET /v2/actor-runs/{runId}` (or use `waitForFinish`)
3. Fetch results: `GET /v2/datasets/{datasetId}/items`
