
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
        public global::Apify.ErrorResponse? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ErrorResponseError? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ErrorResponseErrorType? Type14 { get; set; }
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
        public global::Apify.PricingModel? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorChargeEvent? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PayPerEventActorPricingInfo? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PayPerEventActorPricingInfoVariant2? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PayPerEventActorPricingInfoVariant2PricingPerEvent? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.ActorChargeEvent>? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PricePerDatasetItemActorPricingInfo? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PricePerDatasetItemActorPricingInfoVariant2? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.FlatPricePerMonthActorPricingInfo? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.FlatPricePerMonthActorPricingInfoVariant2? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.FreeActorPricingInfo? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.FreeActorPricingInfoVariant2? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunPricingInfo? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunPricingInfoDiscriminator? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunPricingInfoDiscriminatorPricingModel? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorPermissionLevel? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DefaultRunOptions? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorStandby? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ExampleRunInput? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CreateActorRequest? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Version>? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaggedBuildInfo? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaggedBuilds? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Actor? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorResponse? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvVarRequest? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CreateOrUpdateVersionRequest? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.EnvVarRequest>? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildTag? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateActorRequest? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.CreateOrUpdateVersionRequest>? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.BuildTag?>? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfVersions? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfVersionsResponse? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.VersionResponse? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ErrorType? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ErrorDetail? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorNotFoundErrorDetail? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorNotFoundErrorDetailVariant2? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorNotFoundError? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordNotFoundErrorDetail? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordNotFoundErrorDetailVariant2? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorVersionNotFoundError? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfEnvVars? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfEnvVarsResponse? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvVarResponse? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvironmentVariableNotFoundError? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookEventType? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookCondition? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchStatus? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ExampleWebhookDispatch? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookStats? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookShort? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookEventType>? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhooks? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhooksVariant2? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookShort>? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhooksResponse? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorJobStatus? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunOrigin? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildsMeta? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildShort? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfBuilds? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfBuildsVariant2? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.BuildShort>? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfBuildsResponse? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildStats? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildOptions? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildUsage? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorDefinition? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorDefinitionStorages? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<string, long?>? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Build? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildResponse? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnknownBuildTagErrorDetail? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnknownBuildTagErrorDetailVariant2? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnknownBuildTagError? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorBuildNotFoundError? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunMeta? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunShort? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRuns? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRunsVariant2? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RunShort>? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRunsResponse? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStats? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunOptions? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.GeneralAccess? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunUsage? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunUsageUsd? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Metamorph? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Run? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIds? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsDatasets? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsKeyValueStores? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsRequestQueues? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Metamorph>? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunResponse? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunFailedErrorDetail? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunFailedErrorDetailVariant2? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunFailedError? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunTimeoutExceededErrorDetail? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunTimeoutExceededErrorDetailVariant2? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunTimeoutExceededError? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunNotFoundError? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskStats? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskShort? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasks? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasksVariant2? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.TaskShort>? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasksResponse? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskOptions? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskInput? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CreateTaskRequest? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Task? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskResponse? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateTaskRequest? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Webhook? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRunRequest? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ChargeRunRequest? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordOrTokenNotFoundErrorDetail? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordOrTokenNotFoundErrorDetailVariant2? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordOrTokenNotFoundError? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StorageOwnership? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreStats? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStore? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeyValueStores? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeyValueStoresVariant2? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.KeyValueStore>? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeyValueStoresResponse? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreResponse? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreNotFoundError? Type161 { get; set; }
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
        public global::Apify.RecordNotFoundError? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutRecordRequest? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetListItem? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasets? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasetsVariant2? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DatasetListItem>? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasetsResponse? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStats? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Dataset? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetResponse? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetNotFoundError? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateDatasetRequest? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutItemsRequest? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ValidationError? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.InvalidItem? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ValidationError>? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.SchemaValidationErrorData? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.InvalidItem>? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetSchemaValidationError? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutItemResponseError? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetFieldStatistics? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStatistics? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.DatasetFieldStatistics>? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStatisticsResponse? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueShort? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueues? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueuesVariant2? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestQueueShort>? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueuesResponse? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueStats? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueue? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueResponse? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueNotFoundError? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRequestQueueRequest? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HttpMethod? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestUserData? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestBase? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AddedRequest? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraft? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchAddResult? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.AddedRequest>? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestDraft>? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchAddResponse? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraftDeleteById? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraftDeleteByUniqueKey? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraftDelete? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DeletedRequestById? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DeletedRequestByUniqueKey? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DeletedRequest? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchDeleteResult? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DeletedRequest>? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchDeleteResponse? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnlockRequestsResult? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnlockRequestsResponse? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Request? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestVariant2? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequests? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Request>? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestsResponse? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestRegistration? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AddRequestResponse? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestResponse? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestNotFoundError? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRequestResponse? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadRequest? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueHead? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.HeadRequest>? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadResponse? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LockedHeadRequest? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LockedRequestQueueHead? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.LockedHeadRequest>? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadAndLockResponse? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestLockInfo? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ProlongRequestLockResponse? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookCreate? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookResponse? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookUpdate? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatch? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchEventData? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatchCall>? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchCall? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TestWebhookResponse? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhookDispatches? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhookDispatchesVariant2? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatch>? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchList? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchResponse? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleBase? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortRunActor? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortRunActorTask? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShort? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortDiscriminator? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortDiscriminatorType? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleShort? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleShortVariant2? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleActionShort>? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedules? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedulesVariant2? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleShort>? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedulesResponse? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionRunInput? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionRunActor? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionRunActorTask? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateAction? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionDiscriminator? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionDiscriminatorType? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreate? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionRunActor? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionRunActorTask? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleAction? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionDiscriminator? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionDiscriminatorType? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Schedule? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleVariant2? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleAction>? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleResponse? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleInvoked? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleLogResponse? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleInvoked>? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CurrentPricingInfo? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StoreListActor? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfStoreActors? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfStoreActorsVariant2? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.StoreListActor>? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfActorsInStoreResponse? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Profile? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UserPublicInfo? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PublicUserDataResponse? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ProxyGroup? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Proxy? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ProxyGroup>? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Plan? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EffectivePlatformFeature? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EffectivePlatformFeatures? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UserPrivateInfo? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PrivateUserDataResponse? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UsageCycle? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PriceTiers? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UsageItem? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PriceTiers>? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.UsageItem>? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DailyServiceUsages? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.MonthlyUsage? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DailyServiceUsages>? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.MonthlyUsageResponse? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Limits? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Current? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AccountLimits? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LimitsResponse? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateLimitsRequest? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BrowserInfoResponse? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<string, global::System.Collections.Generic.IList<string>>? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EncodeAndSignData? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EncodeAndSignResponse? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyRequest? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyData? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyResponse? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.CreateTaskRequest, object>? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRunRequest, object>? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRequestQueueRequest, object>? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestBase>? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestDraftDelete>? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActsGetSortBy? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActRunsPostForcePermissionLevel? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreRecordPutContentEncoding? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreRecordPostContentEncoding? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueRequestsBatchDeleteContentType? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueRequestsGetFilter? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StoreGetPricingModel? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorNotFoundError, global::Apify.ActorVersionNotFoundError>? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorNotFoundError, global::Apify.ActorVersionNotFoundError, global::Apify.EnvironmentVariableNotFoundError>? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorNotFoundError, global::Apify.ActorBuildNotFoundError>? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorNotFoundError, global::Apify.ActorRunNotFoundError>? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskGetResponse? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskPutResponse? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponse? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskWebhooksGetResponseData>? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponseData? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Webhook>? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponse? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskRunsGetResponseData>? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponseData? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsPostResponse? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsLastGetResponse? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PostChargeRunResponse? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorBuildNotFoundError, global::Apify.RecordOrTokenNotFoundError>? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.KeyValueStoreNotFoundError, global::Apify.RecordNotFoundError>? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.RequestQueueNotFoundError, global::Apify.RequestNotFoundError>? Type360 { get; set; }

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
        public global::System.Collections.Generic.List<global::Apify.TaskShort>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.KeyValueStore>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.KeyValueStoreKey>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DatasetListItem>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ValidationError>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.InvalidItem>? ListType18 { get; set; }
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
        public global::System.Collections.Generic.List<object>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.Webhook>? ListType43 { get; set; }
    }
}