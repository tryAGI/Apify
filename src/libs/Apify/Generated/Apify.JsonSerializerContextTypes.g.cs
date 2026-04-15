
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PaginationResponse? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorStats? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorShort? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfActors? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfActorsVariant2? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorShort>? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfActorsResponse? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ErrorType? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ErrorDetail? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ErrorResponse? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.VersionSourceType? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvVar? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.SourceCodeFileFormat? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.SourceCodeFile? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.SourceCodeFolder? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Version? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.EnvVar>? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CommonActorPricingInfo? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorChargeEvent? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PayPerEventActorPricingInfo? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PayPerEventActorPricingInfoVariant2? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PayPerEventActorPricingInfoVariant2PricingPerEvent? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.ActorChargeEvent>? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PricePerDatasetItemActorPricingInfo? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PricePerDatasetItemActorPricingInfoVariant2? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.FlatPricePerMonthActorPricingInfo? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.FlatPricePerMonthActorPricingInfoVariant2? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.FreeActorPricingInfo? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.FreeActorPricingInfoVariant2? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunPricingInfo? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunPricingInfoDiscriminator? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunPricingInfoDiscriminatorPricingModel? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorPermissionLevel? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DefaultRunOptions? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorStandby? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ExampleRunInput? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CreateActorRequest? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Version>? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaggedBuildInfo? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaggedBuilds? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Actor? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorResponse? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvVarRequest? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CreateOrUpdateVersionRequest? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.EnvVarRequest>? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildTag? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateActorRequest? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.CreateOrUpdateVersionRequest>? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.BuildTag?>? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfVersions? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfVersionsResponse? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.VersionResponse? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfEnvVars? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfEnvVarsResponse? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvVarResponse? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookEventType? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookCondition? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchStatus? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ExampleWebhookDispatch? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookStats? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookShort? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookEventType>? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhooks? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhooksVariant2? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookShort>? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhooksResponse? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorJobStatus? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunOrigin? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildsMeta? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildShort? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfBuilds? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfBuildsVariant2? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.BuildShort>? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfBuildsResponse? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildStats? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildOptions? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildUsage? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorDefinition? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorDefinitionStorages? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<string, long?>? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Build? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildResponse? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnknownBuildTagErrorDetail? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnknownBuildTagErrorDetailVariant2? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnknownBuildTagError? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunMeta? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunShort? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRuns? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRunsVariant2? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RunShort>? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRunsResponse? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStats? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunOptions? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.GeneralAccess? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunUsage? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunUsageUsd? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Metamorph? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Run? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIds? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsDatasets? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsKeyValueStores? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsRequestQueues? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Metamorph>? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunResponse? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunFailedErrorDetail? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunFailedErrorDetailVariant2? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunFailedError? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunTimeoutExceededErrorDetail? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunTimeoutExceededErrorDetailVariant2? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunTimeoutExceededError? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStats? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Dataset? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetResponse? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateDatasetRequest? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutItemsRequest? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ValidationError? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.InvalidItem? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ValidationError>? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.SchemaValidationErrorData? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.InvalidItem>? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetSchemaValidationError? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutItemResponseError? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetFieldStatistics? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStatistics? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.DatasetFieldStatistics>? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStatisticsResponse? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskStats? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskShort? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasks? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasksVariant2? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.TaskShort>? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasksResponse? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskOptions? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskInput? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CreateTaskRequest? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Task? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskResponse? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateTaskRequest? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Webhook? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRunRequest? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ChargeRunRequest? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StorageOwnership? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreStats? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStore? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeyValueStores? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeyValueStoresVariant2? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.KeyValueStore>? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeyValueStoresResponse? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreResponse? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateStoreRequest? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreKey? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeys? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.KeyValueStoreKey>? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeysResponse? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordResponse? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutRecordRequest? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetListItem? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasets? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasetsVariant2? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DatasetListItem>? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasetsResponse? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueShort? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueues? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueuesVariant2? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestQueueShort>? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueuesResponse? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueStats? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueue? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueResponse? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRequestQueueRequest? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HttpMethod? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestUserData? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestBase? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AddedRequest? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraft? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchAddResult? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.AddedRequest>? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestDraft>? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchAddResponse? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraftDeleteById? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraftDeleteByUniqueKey? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraftDelete? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DeletedRequestById? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DeletedRequestByUniqueKey? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DeletedRequest? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchDeleteResult? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DeletedRequest>? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchDeleteResponse? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnlockRequestsResult? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnlockRequestsResponse? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Request? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestVariant2? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequests? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Request>? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestsResponse? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestRegistration? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AddRequestResponse? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestResponse? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRequestResponse? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadRequest? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueHead? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.HeadRequest>? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadResponse? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LockedHeadRequest? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LockedRequestQueueHead? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.LockedHeadRequest>? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadAndLockResponse? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestLockInfo? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ProlongRequestLockResponse? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookCreate? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookResponse? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookUpdate? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatch? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchEventData? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatchCall>? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchCall? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TestWebhookResponse? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhookDispatches? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhookDispatchesVariant2? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatch>? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchList? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchResponse? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleBase? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortRunActor? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortRunActorTask? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShort? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortDiscriminator? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortDiscriminatorType? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleShort? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleShortVariant2? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleActionShort>? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedules? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedulesVariant2? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleShort>? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedulesResponse? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionRunInput? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionRunActor? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionRunActorTask? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateAction? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionDiscriminator? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionDiscriminatorType? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreate? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionRunActor? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionRunActorTask? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleAction? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionDiscriminator? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionDiscriminatorType? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Schedule? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleVariant2? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleAction>? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleResponse? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleInvoked? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleLogResponse? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleInvoked>? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CurrentPricingInfo? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StoreListActor? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfStoreActors? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfStoreActorsVariant2? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.StoreListActor>? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfActorsInStoreResponse? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Profile? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UserPublicInfo? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PublicUserDataResponse? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ProxyGroup? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Proxy? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ProxyGroup>? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Plan? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EffectivePlatformFeature? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EffectivePlatformFeatures? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UserPrivateInfo? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PrivateUserDataResponse? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UsageCycle? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PriceTiers? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UsageItem? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PriceTiers>? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.UsageItem>? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DailyServiceUsages? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.MonthlyUsage? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DailyServiceUsages>? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.MonthlyUsageResponse? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Limits? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Current? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AccountLimits? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LimitsResponse? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateLimitsRequest? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BrowserInfoResponse? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<string, global::System.Collections.Generic.IList<string>>? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EncodeAndSignData? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EncodeAndSignResponse? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyRequest? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyData? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyResponse? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.CreateTaskRequest, object>? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRunRequest, object>? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRequestQueueRequest, object>? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestBase>? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestDraftDelete>? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActsGetSortBy? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActRunsPostForcePermissionLevel? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreRecordPutContentEncoding? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreRecordPostContentEncoding? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestQueueRequestsGetFilterItem>? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueRequestsGetFilterItem? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StoreGetPricingModel? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StoreGetResponseFormat? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AnyOf<global::Apify.PutItemResponseError, global::Apify.ErrorResponse>? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskGetResponse? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskPutResponse? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponse? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskWebhooksGetResponseData>? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponseData? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Webhook>? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponse? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskRunsGetResponseData>? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponseData? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsPostResponse? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsLastGetResponse? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PostChargeRunResponse? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type335 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorShort>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.EnvVar>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.Version>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorRunPricingInfo>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.EnvVarRequest>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.CreateOrUpdateVersionRequest>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookEventType>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookShort>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.BuildShort>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RunShort>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.Metamorph>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ValidationError>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.InvalidItem>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.TaskShort>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.KeyValueStore>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.KeyValueStoreKey>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DatasetListItem>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestQueueShort>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.AddedRequest>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestDraft>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DeletedRequest>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.Request>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.HeadRequest>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.LockedHeadRequest>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookDispatchCall>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookDispatch>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleActionShort>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleShort>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleCreateAction>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleAction>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleInvoked>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.StoreListActor>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ProxyGroup>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.PriceTiers>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DailyServiceUsages>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<string, global::System.Collections.Generic.List<string>>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.List<global::Apify.PutItemsRequest>>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.PutItemsRequest>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestBase>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestDraftDelete>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestQueueRequestsGetFilterItem>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.Webhook>? ListType44 { get; set; }
    }
}