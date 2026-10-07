
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    #pragma warning disable CS3016 // Converter type array in this attribute is not CLS-compliant.
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

            typeof(global::Apify.JsonConverters.ActorPermissionLevelJsonConverter),

            typeof(global::Apify.JsonConverters.ActorPermissionLevelNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunPricingInfoDiscriminatorPricingModelJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunPricingInfoDiscriminatorPricingModelNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorNoticeJsonConverter),

            typeof(global::Apify.JsonConverters.ActorNoticeNullableJsonConverter),

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

            typeof(global::Apify.JsonConverters.HttpMethodJsonConverter),

            typeof(global::Apify.JsonConverters.HttpMethodNullableJsonConverter),

            typeof(global::Apify.JsonConverters.StorageOwnershipJsonConverter),

            typeof(global::Apify.JsonConverters.StorageOwnershipNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleListItemActionDiscriminatorTypeJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleListItemActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleCreateActionDiscriminatorTypeJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleCreateActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleActionDiscriminatorTypeJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleActionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorsGetSortByJsonConverter),

            typeof(global::Apify.JsonConverters.ActorsGetSortByNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorsRunsPostForcePermissionLevelJsonConverter),

            typeof(global::Apify.JsonConverters.ActorsRunsPostForcePermissionLevelNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunsLastDatasetItemsPostContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunsLastDatasetItemsPostContentEncodingNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunsLastKeyValueStoreRecordPutContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunsLastKeyValueStoreRecordPutContentEncodingNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunsLastKeyValueStoreRecordPostContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunsLastKeyValueStoreRecordPostContentEncodingNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunsLastRequestQueueRequestsGetFilterItemJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunsLastRequestQueueRequestsGetFilterItemNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorTaskRunsLastDatasetItemsPostContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.ActorTaskRunsLastDatasetItemsPostContentEncodingNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorTaskRunsLastKeyValueStoreRecordPutContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.ActorTaskRunsLastKeyValueStoreRecordPutContentEncodingNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorTaskRunsLastKeyValueStoreRecordPostContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.ActorTaskRunsLastKeyValueStoreRecordPostContentEncodingNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorTaskRunsLastRequestQueueRequestsGetFilterItemJsonConverter),

            typeof(global::Apify.JsonConverters.ActorTaskRunsLastRequestQueueRequestsGetFilterItemNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunDatasetItemsPostContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunDatasetItemsPostContentEncodingNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunKeyValueStoreRecordPutContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunKeyValueStoreRecordPutContentEncodingNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunKeyValueStoreRecordPostContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunKeyValueStoreRecordPostContentEncodingNullableJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunRequestQueueRequestsGetFilterItemJsonConverter),

            typeof(global::Apify.JsonConverters.ActorRunRequestQueueRequestsGetFilterItemNullableJsonConverter),

            typeof(global::Apify.JsonConverters.KeyValueStoreRecordPutContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.KeyValueStoreRecordPutContentEncodingNullableJsonConverter),

            typeof(global::Apify.JsonConverters.KeyValueStoreRecordPostContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.KeyValueStoreRecordPostContentEncodingNullableJsonConverter),

            typeof(global::Apify.JsonConverters.DatasetItemsPostContentEncodingJsonConverter),

            typeof(global::Apify.JsonConverters.DatasetItemsPostContentEncodingNullableJsonConverter),

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

            typeof(global::Apify.JsonConverters.ListOfRunsJsonConverter),

            typeof(global::Apify.JsonConverters.RequestResourceJsonConverter),

            typeof(global::Apify.JsonConverters.RequestWithoutIdJsonConverter),

            typeof(global::Apify.JsonConverters.RequestToDeleteJsonConverter),

            typeof(global::Apify.JsonConverters.DeletedRequestJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfTasksJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfKeyValueStoresJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfDatasetsJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfRequestQueuesJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfWebhookDispatchesJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleListItemActionJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleListItemJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfSchedulesJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleCreateActionJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleActionJsonConverter),

            typeof(global::Apify.JsonConverters.ScheduleJsonConverter),

            typeof(global::Apify.JsonConverters.ListOfStoreActorsJsonConverter),

            typeof(global::Apify.JsonConverters.AnyOfJsonConverter<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>),

            typeof(global::Apify.JsonConverters.OneOfJsonConverter<string, long?>),

            typeof(global::Apify.JsonConverters.AnyOfJsonConverter<global::Apify.TaskInput, global::System.Collections.Generic.IList<global::Apify.TaskInput>>),

            typeof(global::Apify.JsonConverters.AnyOfJsonConverter<global::Apify.TaskInput, global::System.Collections.Generic.IList<global::Apify.TaskInput>>),

            typeof(global::Apify.JsonConverters.AnyOfJsonConverter<global::Apify.TaskInput, global::System.Collections.Generic.IList<global::Apify.TaskInput>>),

            typeof(global::Apify.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Apify.JsonConverters.OneOfJsonConverter<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>),

            typeof(global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.UpdateRequestQueueRequest, object>),

            typeof(global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.CreateTaskRequest, object>),

            typeof(global::Apify.JsonConverters.OneOfJsonConverter<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>),

            typeof(global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.UpdateRequestQueueRequest, object>),

            typeof(global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.UpdateRunRequest, object>),

            typeof(global::Apify.JsonConverters.OneOfJsonConverter<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>),

            typeof(global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.UpdateRequestQueueRequest, object>),

            typeof(global::Apify.JsonConverters.OneOfJsonConverter<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>),

            typeof(global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.UpdateRequestQueueRequest, object>),

            typeof(global::Apify.JsonConverters.AnyOfJsonConverter<global::Apify.PutItemsErrorResponse, global::Apify.ErrorResponse>),

            typeof(global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.PaginationResponse, global::Apify.ActorTaskWebhooksGetResponseData>),

            typeof(global::Apify.JsonConverters.AllOfJsonConverter<global::Apify.PaginationResponse, global::Apify.ActorTaskRunsGetResponseData>),

            typeof(global::Apify.JsonConverters.AnyOfJsonConverter<global::Apify.PutItemsErrorResponse, global::Apify.ErrorResponse>),

            typeof(global::Apify.JsonConverters.AnyOfJsonConverter<global::Apify.PutItemsErrorResponse, global::Apify.ErrorResponse>),

            typeof(global::Apify.JsonConverters.AnyOfJsonConverter<global::Apify.PutItemsErrorResponse, global::Apify.ErrorResponse>),

            typeof(global::Apify.JsonConverters.UnixTimestampJsonConverter),
        })]
    #pragma warning restore CS3016
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorStatsPublicActorRunStats30Days))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfActors), TypeInfoPropertyName = "ListOfActors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfActorsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ActorListItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorPermissionLevel), TypeInfoPropertyName = "ActorPermissionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DefaultRunOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorStandby))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ExampleRunInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CreateActorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.Version>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CommonActorPricingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TieredPricingPerEventEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Apify.TieredPricingPerEventEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorChargeEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PayPerEventActorPricingInfo), TypeInfoPropertyName = "PayPerEventActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PayPerEventActorPricingInfoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PayPerEventActorPricingInfoVariant2PricingPerEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Apify.ActorChargeEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TieredPricingPerDatasetItemEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Apify.TieredPricingPerDatasetItemEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PricePerDatasetItemActorPricingInfo), TypeInfoPropertyName = "PricePerDatasetItemActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PricePerDatasetItemActorPricingInfoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FlatPricePerMonthActorPricingInfo), TypeInfoPropertyName = "FlatPricePerMonthActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FlatPricePerMonthActorPricingInfoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FreeActorPricingInfo), TypeInfoPropertyName = "FreeActorPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.FreeActorPricingInfoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunPricingInfo), TypeInfoPropertyName = "ActorRunPricingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunPricingInfoDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunPricingInfoDiscriminatorPricingModel), TypeInfoPropertyName = "ActorRunPricingInfoDiscriminatorPricingModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaggedBuildInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaggedBuilds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorNotice), TypeInfoPropertyName = "ActorNotice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CreateOrUpdateVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdatedBuildProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateActorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.CreateOrUpdateVersionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Apify.UpdatedBuildProperty?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.VersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfEnvVars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfEnvVarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EnvVarRequest), TypeInfoPropertyName = "EnvVarRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EnvVarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookEventType), TypeInfoPropertyName = "WebhookEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookDispatchStatus), TypeInfoPropertyName = "WebhookDispatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookLastDispatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.WebhookEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfWebhooks), TypeInfoPropertyName = "ListOfWebhooks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfWebhooksVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.WebhookListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfWebhooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorJobStatus), TypeInfoPropertyName = "ActorJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunOrigin), TypeInfoPropertyName = "RunOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfBuilds), TypeInfoPropertyName = "ListOfBuilds2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfBuildsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.BuildListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfBuildsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorDefinitionStorages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.OneOf<string, long?>), TypeInfoPropertyName = "OneOfStringInt642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Build))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildActVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.SourceCodeFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BuildResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRuns), TypeInfoPropertyName = "ListOfRuns2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRunsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RunListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookRepresentation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.GeneralAccess), TypeInfoPropertyName = "GeneralAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunUsageUsd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunMetamorphEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Run))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStorageIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStorageIdsDatasets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStorageIdsKeyValueStores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunStorageIdsRequestQueues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RunMetamorphEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PutItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetItemValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.InvalidDatasetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.DatasetItemValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetSchemaValidationErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.InvalidDatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetSchemaValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PutItemsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetFieldStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Apify.DatasetFieldStatistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetStatisticsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.KeyValueStoreStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.KeyValueStoreResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.KeyValueStoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateKeyValueStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.KeyValueStoreKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfKeys))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.KeyValueStoreKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RecordResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PutRecordRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateRequestQueueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.HttpMethod), TypeInfoPropertyName = "HttpMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestUserData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestResource), TypeInfoPropertyName = "RequestResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequests))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestWithoutId), TypeInfoPropertyName = "RequestWithoutId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestRegistration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AddRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AddedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UnprocessedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BatchAddResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.AddedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.UnprocessedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BatchAddResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestToDeleteById))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestToDeleteByUniqueKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestToDelete), TypeInfoPropertyName = "RequestToDelete2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DeletedRequestById))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DeletedRequestByUniqueKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DeletedRequest), TypeInfoPropertyName = "DeletedRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BatchDeleteResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.DeletedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BatchDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UnlockRequestsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UnlockRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestLockInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ProlongRequestLockResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueHeadItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueHead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestQueueHeadItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueHeadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.LockedRequestQueueHeadItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.LockedRequestQueueHead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.LockedRequestQueueHeadItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.LockedRequestQueueHeadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaskStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaskListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfTasks), TypeInfoPropertyName = "ListOfTasks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfTasksVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.TaskListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfTasksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaskOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaskInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaskPublicConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CreateTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AnyOf<global::Apify.TaskInput, global::System.Collections.Generic.IList<global::Apify.TaskInput>>), TypeInfoPropertyName = "AnyOfTaskInputIListTaskInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.TaskInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Task))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.TaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ChargeRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.StorageOwnership), TypeInfoPropertyName = "StorageOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfKeyValueStores), TypeInfoPropertyName = "ListOfKeyValueStores2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfKeyValueStoresVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.KeyValueStoreResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfKeyValueStoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfDatasets), TypeInfoPropertyName = "ListOfDatasets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfDatasetsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.DatasetListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfDatasetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequestQueues), TypeInfoPropertyName = "ListOfRequestQueues2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequestQueuesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestQueueListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfRequestQueuesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CreateWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookDispatchWebhookSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookDispatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookDispatchEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.WebhookDispatchCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookDispatchCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.WebhookDispatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfWebhookDispatches), TypeInfoPropertyName = "ListOfWebhookDispatches2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfWebhookDispatchesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.WebhookDispatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfWebhookDispatchesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleListItemActionRunActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleListItemActionRunActorTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleListItemAction), TypeInfoPropertyName = "ScheduleListItemAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleListItemActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleListItemActionDiscriminatorType), TypeInfoPropertyName = "ScheduleListItemActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleListItem), TypeInfoPropertyName = "ScheduleListItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleListItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleListItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfSchedules), TypeInfoPropertyName = "ListOfSchedules2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfSchedulesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfSchedulesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionRunInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateActionRunActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateActionRunActorTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateAction), TypeInfoPropertyName = "ScheduleCreateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleCreateActionDiscriminatorType), TypeInfoPropertyName = "ScheduleCreateActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CreateOrUpdateScheduleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionRunActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionRunActorTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleAction), TypeInfoPropertyName = "ScheduleAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleActionDiscriminatorType), TypeInfoPropertyName = "ScheduleActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Schedule), TypeInfoPropertyName = "Schedule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleVariant2Notifications))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ScheduleLogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ScheduleLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CurrentPricingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.StoreActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfStoreActors), TypeInfoPropertyName = "ListOfStoreActors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfStoreActorsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.StoreActor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ListOfStoreActorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPublicInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPublicInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ProxyGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ProxyResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ProxyGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EffectivePlatformFeature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EffectivePlatformFeatures))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPrivateInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UserPrivateInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UsageCycle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PriceTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.PriceTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Apify.UsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DailyServiceUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.MonthlyUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.DailyServiceUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.MonthlyUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.Limits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.CurrentUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AccountLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AccountLimitsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.UpdateLimitsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.BrowserInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EncodeAndSignResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.EncodeAndSignResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DecodeAndVerifyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DecodeAndVerifyResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DecodeAndVerifyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>), TypeInfoPropertyName = "OneOfPutItemsRequestIListPutItemsRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AllOf<global::Apify.UpdateRequestQueueRequest, object>), TypeInfoPropertyName = "AllOfUpdateRequestQueueRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestWithoutId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestToDelete>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AllOf<global::Apify.CreateTaskRequest, object>), TypeInfoPropertyName = "AllOfCreateTaskRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AllOf<global::Apify.UpdateRunRequest, object>), TypeInfoPropertyName = "AllOfUpdateRunRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorsGetSortBy), TypeInfoPropertyName = "ActorsGetSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorsRunsPostForcePermissionLevel), TypeInfoPropertyName = "ActorsRunsPostForcePermissionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunsLastDatasetItemsPostContentEncoding), TypeInfoPropertyName = "ActorRunsLastDatasetItemsPostContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunsLastKeyValueStoreRecordPutContentEncoding), TypeInfoPropertyName = "ActorRunsLastKeyValueStoreRecordPutContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunsLastKeyValueStoreRecordPostContentEncoding), TypeInfoPropertyName = "ActorRunsLastKeyValueStoreRecordPostContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ActorRunsLastRequestQueueRequestsGetFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunsLastRequestQueueRequestsGetFilterItem), TypeInfoPropertyName = "ActorRunsLastRequestQueueRequestsGetFilterItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskRunsLastDatasetItemsPostContentEncoding), TypeInfoPropertyName = "ActorTaskRunsLastDatasetItemsPostContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding), TypeInfoPropertyName = "ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding), TypeInfoPropertyName = "ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ActorTaskRunsLastRequestQueueRequestsGetFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskRunsLastRequestQueueRequestsGetFilterItem), TypeInfoPropertyName = "ActorTaskRunsLastRequestQueueRequestsGetFilterItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunDatasetItemsPostContentEncoding), TypeInfoPropertyName = "ActorRunDatasetItemsPostContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunKeyValueStoreRecordPutContentEncoding), TypeInfoPropertyName = "ActorRunKeyValueStoreRecordPutContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunKeyValueStoreRecordPostContentEncoding), TypeInfoPropertyName = "ActorRunKeyValueStoreRecordPostContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.ActorRunRequestQueueRequestsGetFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorRunRequestQueueRequestsGetFilterItem), TypeInfoPropertyName = "ActorRunRequestQueueRequestsGetFilterItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.KeyValueStoreRecordPutContentEncoding), TypeInfoPropertyName = "KeyValueStoreRecordPutContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.KeyValueStoreRecordPostContentEncoding), TypeInfoPropertyName = "KeyValueStoreRecordPostContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.DatasetItemsPostContentEncoding), TypeInfoPropertyName = "DatasetItemsPostContentEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.RequestQueueRequestsGetFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.RequestQueueRequestsGetFilterItem), TypeInfoPropertyName = "RequestQueueRequestsGetFilterItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.StoreGetPricingModel), TypeInfoPropertyName = "StoreGetPricingModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.StoreGetResponseFormat), TypeInfoPropertyName = "StoreGetResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorValidateInputPostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AnyOf<global::Apify.PutItemsErrorResponse, global::Apify.ErrorResponse>), TypeInfoPropertyName = "AnyOfPutItemsErrorResponseErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskPutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskWebhooksGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskWebhooksGetResponseData>), TypeInfoPropertyName = "AllOfPaginationResponseActorTaskWebhooksGetResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskWebhooksGetResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Apify.WebhookResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskRunsGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskRunsGetResponseData>), TypeInfoPropertyName = "AllOfPaginationResponseActorTaskRunsGetResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskRunsGetResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskRunsPostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.ActorTaskRunsLastGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.PostChargeRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ActorListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.EnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.Version>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ActorRunPricingInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.CreateOrUpdateVersionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.WebhookEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.WebhookListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.BuildListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.SourceCodeFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RunListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RunMetamorphEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.DatasetItemValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.InvalidDatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.KeyValueStoreKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.AddedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.UnprocessedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.DeletedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestQueueHeadItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.LockedRequestQueueHeadItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.TaskListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.AnyOf<global::Apify.TaskInput, global::System.Collections.Generic.List<global::Apify.TaskInput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.TaskInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.KeyValueStoreResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.DatasetListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestQueueListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.WebhookDispatchCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.WebhookDispatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleListItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleCreateAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ScheduleLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.StoreActor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ProxyGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.PriceTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.DailyServiceUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.List<global::Apify.PutItemsRequest>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.PutItemsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestWithoutId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestToDelete>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ActorRunsLastRequestQueueRequestsGetFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ActorTaskRunsLastRequestQueueRequestsGetFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.ActorRunRequestQueueRequestsGetFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.RequestQueueRequestsGetFilterItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Apify.WebhookResource>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}