
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Apify.JsonConverters.ErrorTypeJsonConverter),

            typeof(global::Apify.JsonConverters.ErrorTypeNullableJsonConverter),

            typeof(global::Apify.JsonConverters.VersionSourceTypeJsonConverter),

            typeof(global::Apify.JsonConverters.VersionSourceTypeNullableJsonConverter),

            typeof(global::Apify.JsonConverters.SourceCodeFileFormatJsonConverter),

            typeof(global::Apify.JsonConverters.SourceCodeFileFormatNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunPricingInfoDiscriminatorPricingModelJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunPricingInfoDiscriminatorPricingModelNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorPermissionLevelJsonConverter),

            typeof(global::Apify.JsonConverters.ActorPermissionLevelNullableJsonConverter),

            typeof(global::Apify.JsonConverters.WebhookEventTypeJsonConverter),

            typeof(global::Apify.JsonConverters.WebhookEventTypeNullableJsonConverter),

            typeof(global::Apify.JsonConverters.WebhookDispatchStatusJsonConverter),

            typeof(global::Apify.JsonConverters.WebhookDispatchStatusNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorJobStatusJsonConverter),

            typeof(global::Apify.JsonConverters.ActorJobStatusNullableJsonConverter),

            typeof(global::Apify.JsonConverters.RunOriginJsonConverter),

            typeof(global::Apify.JsonConverters.RunOriginNullableJsonConverter),

            typeof(global::Apify.JsonConverters.GeneralAccessJsonConverter),

            typeof(global::Apify.JsonConverters.GeneralAccessNullableJsonConverter),

            typeof(global::Apify.JsonConverters.StorageOwnershipJsonConverter),

            typeof(global::Apify.JsonConverters.StorageOwnershipNullableJsonConverter),

            typeof(global::Apify.JsonConverters.HttpMethodJsonConverter),

            typeof(global::Apify.JsonConverters.HttpMethodNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleActionShortDiscriminatorTypeJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleActionShortDiscriminatorTypeNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleCreateActionDiscriminatorTypeJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleCreateActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleActionDiscriminatorTypeJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActsGetSortByJsonConverter),

            typeof(global::Apify.JsonConverters.ActsGetSortByNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActRunsPostForcePermissionLevelJsonConverter),

            typeof(global::Apify.JsonConverters.ActRunsPostForcePermissionLevelNullableJsonConverter),

            typeof(global::Apify.JsonConverters.KeyValueStoreRecordPutContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.KeyValueStoreRecordPutContentEncodingNullableJsonConverter),

            typeof(global::Apify.JsonConverters.KeyValueStoreRecordPostContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.KeyValueStoreRecordPostContentEncodingNullableJsonConverter),

            typeof(global::Apify.JsonConverters.RequestQueueRequestsGetFilterItemJsonConverter),

            typeof(global::Apify.JsonConverters.RequestQueueRequestsGetFilterItemNullableJsonConverter),

            typeof(global::Apify.JsonConverters.StoreGetPricingModelJsonConverter),

            typeof(global::Apify.JsonConverters.StoreGetPricingModelNullableJsonConverter),

            typeof(global::Apify.JsonConverters.StoreGetResponseFormatJsonConverter),

            typeof(global::Apify.JsonConverters.StoreGetResponseFormatNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfActorsJsonConverter),

            typeof(global::Apify.JsonConverters.PayPerEventActorPricingInfoJsonConverter),

            typeof(global::Apify.JsonConverters.PricePerDatasetItemActorPricingInfoJsonConverter),

            typeof(global::Apify.JsonConverters.FlatPricePerMonthActorPricingInfoJsonConverter),

            typeof(global::Apify.JsonConverters.FreeActorPricingInfoJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunPricingInfoJsonConverter),

            typeof(global::Apify.JsonConverters.EnvVarRequestJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfWebhooksJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfBuildsJsonConverter),

            typeof(global::Apify.JsonConverters.UnknownBuildTagErrorDetailJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfRunsJsonConverter),

            typeof(global::Apify.JsonConverters.RunFailedErrorDetailJsonConverter),

            typeof(global::Apify.JsonConverters.RunTimeoutExceededErrorDetailJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfTasksJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfKeyValueStoresJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfDatasetsJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfRequestQueuesJsonConverter),

            typeof(global::Apify.JsonConverters.RequestDraftDeleteJsonConverter),

            typeof(global::Apify.JsonConverters.DeletedRequestJsonConverter),

            typeof(global::Apify.JsonConverters.RequestJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfWebhookDispatchesJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleActionShortJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleShortJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfSchedulesJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleCreateActionJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleActionJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfStoreActorsJsonConverter),

            typeof(global::Apify.JsonConverters.AnyOfJsonConverter<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>),

            typeof(global::Apify.JsonConverters.OneOfJsonConverter<string, long?>),

            typeof(global::Apify.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.CreateTaskRequest, object>),

            typeof(global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.UpdateRunRequest, object>),

            typeof(global::Apify.JsonConverters.OneOfJsonConverter<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>),

            typeof(global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.UpdateRequestQueueRequest, object>),

            typeof(global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.PaginationResponse, global::Apify.ActorTaskWebhooksGetResponseData>),

            typeof(global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.PaginationResponse, global::Apify.ActorTaskRunsGetResponseData>),

            typeof(global::Apify.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorShort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfActors), TypeInfoPropertyName = "ListOfActors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfActorsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ActorShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfActorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorType), TypeInfoPropertyName = "ErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.VersionSourceType), TypeInfoPropertyName = "VersionSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EnvVar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.SourceCodeFileFormat), TypeInfoPropertyName = "SourceCodeFileFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.SourceCodeFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.SourceCodeFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>), TypeInfoPropertyName = "AnyOfSourceCodeFileSourceCodeFolder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.EnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CommonActorPricingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorChargeEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PayPerEventActorPricingInfo), TypeInfoPropertyName = "PayPerEventActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PayPerEventActorPricingInfoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PayPerEventActorPricingInfoVariant2PricingPerEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Apify.ActorChargeEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PricePerDatasetItemActorPricingInfo), TypeInfoPropertyName = "PricePerDatasetItemActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PricePerDatasetItemActorPricingInfoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FlatPricePerMonthActorPricingInfo), TypeInfoPropertyName = "FlatPricePerMonthActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FlatPricePerMonthActorPricingInfoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FreeActorPricingInfo), TypeInfoPropertyName = "FreeActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FreeActorPricingInfoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunPricingInfo), TypeInfoPropertyName = "ActorRunPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunPricingInfoDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunPricingInfoDiscriminatorPricingModel), TypeInfoPropertyName = "ActorRunPricingInfoDiscriminatorPricingModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorPermissionLevel), TypeInfoPropertyName = "ActorPermissionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DefaultRunOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorStandby))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ExampleRunInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CreateActorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.Version>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaggedBuildInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaggedBuilds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Actor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EnvVarRequest), TypeInfoPropertyName = "EnvVarRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CreateOrUpdateVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.EnvVarRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateActorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.CreateOrUpdateVersionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Apify.BuildTag?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.VersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfEnvVars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfEnvVarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EnvVarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookEventType), TypeInfoPropertyName = "WebhookEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookDispatchStatus), TypeInfoPropertyName = "WebhookDispatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ExampleWebhookDispatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookShort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.WebhookEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfWebhooks), TypeInfoPropertyName = "ListOfWebhooks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfWebhooksVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.WebhookShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfWebhooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorJobStatus), TypeInfoPropertyName = "ActorJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunOrigin), TypeInfoPropertyName = "RunOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildsMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildShort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfBuilds), TypeInfoPropertyName = "ListOfBuilds2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfBuildsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.BuildShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfBuildsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorDefinitionStorages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.OneOf<string, long?>), TypeInfoPropertyName = "OneOfStringInt642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Build))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UnknownBuildTagErrorDetail), TypeInfoPropertyName = "UnknownBuildTagErrorDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UnknownBuildTagErrorDetailVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UnknownBuildTagError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunShort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRuns), TypeInfoPropertyName = "ListOfRuns2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRunsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RunShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GeneralAccess), TypeInfoPropertyName = "GeneralAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunUsageUsd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Metamorph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Run))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStorageIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStorageIdsDatasets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStorageIdsKeyValueStores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStorageIdsRequestQueues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.Metamorph>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunFailedErrorDetail), TypeInfoPropertyName = "RunFailedErrorDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunFailedErrorDetailVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunFailedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunTimeoutExceededErrorDetail), TypeInfoPropertyName = "RunTimeoutExceededErrorDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunTimeoutExceededErrorDetailVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunTimeoutExceededError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaskStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaskShort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfTasks), TypeInfoPropertyName = "ListOfTasks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfTasksVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.TaskShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfTasksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaskOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaskInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CreateTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Task))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Webhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ChargeRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.StorageOwnership), TypeInfoPropertyName = "StorageOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.KeyValueStoreStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.KeyValueStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfKeyValueStores), TypeInfoPropertyName = "ListOfKeyValueStores2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfKeyValueStoresVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.KeyValueStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfKeyValueStoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.KeyValueStoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.KeyValueStoreKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfKeys))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.KeyValueStoreKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RecordResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PutRecordRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfDatasets), TypeInfoPropertyName = "ListOfDatasets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfDatasetsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.DatasetListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfDatasetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PutItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.InvalidItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.SchemaValidationErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.InvalidItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetSchemaValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PutItemResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetFieldStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Apify.DatasetFieldStatistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetStatisticsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueShort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequestQueues), TypeInfoPropertyName = "ListOfRequestQueues2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequestQueuesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestQueueShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequestQueuesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateRequestQueueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.HttpMethod), TypeInfoPropertyName = "HttpMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestUserData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AddedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestDraft))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BatchAddResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.AddedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BatchAddResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestDraftDeleteById))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestDraftDeleteByUniqueKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestDraftDelete), TypeInfoPropertyName = "RequestDraftDelete2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DeletedRequestById))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DeletedRequestByUniqueKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DeletedRequest), TypeInfoPropertyName = "DeletedRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BatchDeleteResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.DeletedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BatchDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UnlockRequestsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UnlockRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Request), TypeInfoPropertyName = "Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequests))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.Request>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestRegistration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AddRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.HeadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueHead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.HeadRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.HeadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.LockedHeadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.LockedRequestQueueHead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.LockedHeadRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.HeadAndLockResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestLockInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ProlongRequestLockResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookDispatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookDispatchEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.WebhookDispatchCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookDispatchCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TestWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfWebhookDispatches), TypeInfoPropertyName = "ListOfWebhookDispatches2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfWebhookDispatchesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.WebhookDispatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookDispatchList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookDispatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionShortRunActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionShortRunActorTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionShort), TypeInfoPropertyName = "ScheduleActionShort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionShortDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionShortDiscriminatorType), TypeInfoPropertyName = "ScheduleActionShortDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleShort), TypeInfoPropertyName = "ScheduleShort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleShortVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleActionShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfSchedules), TypeInfoPropertyName = "ListOfSchedules2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfSchedulesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfSchedulesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionRunInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateActionRunActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateActionRunActorTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateAction), TypeInfoPropertyName = "ScheduleCreateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateActionDiscriminatorType), TypeInfoPropertyName = "ScheduleCreateActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionRunActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionRunActorTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleAction), TypeInfoPropertyName = "ScheduleAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionDiscriminatorType), TypeInfoPropertyName = "ScheduleActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Schedule), TypeInfoPropertyName = "Schedule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleInvoked))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleLogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleInvoked>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CurrentPricingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.StoreListActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfStoreActors), TypeInfoPropertyName = "ListOfStoreActors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfStoreActorsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.StoreListActor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfActorsInStoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Profile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPublicInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PublicUserDataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ProxyGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Proxy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ProxyGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Plan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EffectivePlatformFeature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EffectivePlatformFeatures))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPrivateInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PrivateUserDataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UsageCycle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PriceTiers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.PriceTiers>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Apify.UsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DailyServiceUsages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.MonthlyUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.DailyServiceUsages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.MonthlyUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Limits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Current))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AccountLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.LimitsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateLimitsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BrowserInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EncodeAndSignData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EncodeAndSignResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DecodeAndVerifyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DecodeAndVerifyData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DecodeAndVerifyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AllOf<global::Apify.CreateTaskRequest, object>), TypeInfoPropertyName = "AllOfCreateTaskRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AllOf<global::Apify.UpdateRunRequest, object>), TypeInfoPropertyName = "AllOfUpdateRunRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>), TypeInfoPropertyName = "OneOfPutItemsRequestIListPutItemsRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AllOf<global::Apify.UpdateRequestQueueRequest, object>), TypeInfoPropertyName = "AllOfUpdateRequestQueueRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestDraftDelete>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActsGetSortBy), TypeInfoPropertyName = "ActsGetSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActRunsPostForcePermissionLevel), TypeInfoPropertyName = "ActRunsPostForcePermissionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.KeyValueStoreRecordPutContentEncoding), TypeInfoPropertyName = "KeyValueStoreRecordPutContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.KeyValueStoreRecordPostContentEncoding), TypeInfoPropertyName = "KeyValueStoreRecordPostContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestQueueRequestsGetFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueRequestsGetFilterItem), TypeInfoPropertyName = "RequestQueueRequestsGetFilterItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.StoreGetPricingModel), TypeInfoPropertyName = "StoreGetPricingModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.StoreGetResponseFormat), TypeInfoPropertyName = "StoreGetResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskPutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskWebhooksGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskWebhooksGetResponseData>), TypeInfoPropertyName = "AllOfPaginationResponseActorTaskWebhooksGetResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskWebhooksGetResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskRunsGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskRunsGetResponseData>), TypeInfoPropertyName = "AllOfPaginationResponseActorTaskRunsGetResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskRunsGetResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskRunsPostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskRunsLastGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PostChargeRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ActorShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.EnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.Version>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ActorRunPricingInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.EnvVarRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.CreateOrUpdateVersionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.WebhookEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.WebhookShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.BuildShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RunShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.Metamorph>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.TaskShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.KeyValueStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.KeyValueStoreKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.DatasetListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.InvalidItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestQueueShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.AddedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestDraft>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.DeletedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.Request>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.HeadRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.LockedHeadRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.WebhookDispatchCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.WebhookDispatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleActionShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleShort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleCreateAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleInvoked>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.StoreListActor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ProxyGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.PriceTiers>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.DailyServiceUsages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.List<global::Apify.PutItemsRequest>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.PutItemsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestDraftDelete>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestQueueRequestsGetFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.Webhook>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}