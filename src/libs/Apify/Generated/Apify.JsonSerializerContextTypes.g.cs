
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
        public global::Apify.WebhookRepresentation? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStats? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunOptions? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.GeneralAccess? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunUsage? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunUsageUsd? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Metamorph? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Run? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIds? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsDatasets? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsKeyValueStores? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsRequestQueues? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Metamorph>? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunResponse? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunFailedErrorDetail? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunFailedErrorDetailVariant2? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunFailedError? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunTimeoutExceededErrorDetail? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunTimeoutExceededErrorDetailVariant2? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunTimeoutExceededError? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStats? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Dataset? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetResponse? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateDatasetRequest? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutItemsRequest? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ValidationError? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.InvalidItem? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ValidationError>? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.SchemaValidationErrorData? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.InvalidItem>? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetSchemaValidationError? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutItemResponseError? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetFieldStatistics? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStatistics? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.DatasetFieldStatistics>? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStatisticsResponse? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreStats? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStore? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreResponse? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateStoreRequest? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreKey? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeys? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.KeyValueStoreKey>? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeysResponse? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordResponse? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutRecordRequest? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueStats? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueue? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueResponse? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRequestQueueRequest? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HttpMethod? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestUserData? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestBase? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Request? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestVariant2? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequests? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Request>? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestsResponse? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestRegistration? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AddRequestResponse? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AddedRequest? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraft? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchAddResult? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.AddedRequest>? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestDraft>? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchAddResponse? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraftDeleteById? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraftDeleteByUniqueKey? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraftDelete? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DeletedRequestById? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DeletedRequestByUniqueKey? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DeletedRequest? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchDeleteResult? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DeletedRequest>? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchDeleteResponse? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnlockRequestsResult? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnlockRequestsResponse? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestResponse? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRequestResponse? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestLockInfo? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ProlongRequestLockResponse? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadRequest? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueHead? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.HeadRequest>? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadResponse? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LockedHeadRequest? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LockedRequestQueueHead? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.LockedHeadRequest>? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadAndLockResponse? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskStats? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskShort? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasks? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasksVariant2? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.TaskShort>? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasksResponse? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskOptions? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskInput? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CreateTaskRequest? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Task? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskResponse? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateTaskRequest? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Webhook? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRunRequest? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ChargeRunRequest? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StorageOwnership? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeyValueStores? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeyValueStoresVariant2? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.KeyValueStore>? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeyValueStoresResponse? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetListItem? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasets? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasetsVariant2? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DatasetListItem>? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasetsResponse? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueShort? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueues? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueuesVariant2? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestQueueShort>? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueuesResponse? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookCreate? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookResponse? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookUpdate? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatch? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchEventData? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatchCall>? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchCall? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TestWebhookResponse? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhookDispatches? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhookDispatchesVariant2? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatch>? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhookDispatchesResponse? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchResponse? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleBase? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortRunActor? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortRunActorTask? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShort? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortDiscriminator? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortDiscriminatorType? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleShort? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleShortVariant2? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleActionShort>? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedules? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedulesVariant2? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleShort>? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedulesResponse? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionRunInput? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionRunActor? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionRunActorTask? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateAction? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionDiscriminator? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionDiscriminatorType? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreate? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionRunActor? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionRunActorTask? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleAction? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionDiscriminator? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionDiscriminatorType? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Schedule? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleVariant2? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleAction>? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleResponse? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleInvoked? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleLogResponse? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleInvoked>? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CurrentPricingInfo? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StoreListActor? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfStoreActors? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfStoreActorsVariant2? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.StoreListActor>? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfActorsInStoreResponse? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Profile? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UserPublicInfo? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PublicUserDataResponse? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ProxyGroup? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Proxy? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ProxyGroup>? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Plan? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EffectivePlatformFeature? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EffectivePlatformFeatures? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UserPrivateInfo? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PrivateUserDataResponse? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UsageCycle? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PriceTiers? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UsageItem? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PriceTiers>? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.UsageItem>? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DailyServiceUsages? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.MonthlyUsage? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DailyServiceUsages>? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.MonthlyUsageResponse? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Limits? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Current? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AccountLimits? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LimitsResponse? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateLimitsRequest? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BrowserInfoResponse? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<string, global::System.Collections.Generic.IList<string>>? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EncodeAndSignData? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EncodeAndSignResponse? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyRequest? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyData? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyResponse? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRequestQueueRequest, object>? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestBase>? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestDraftDelete>? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.CreateTaskRequest, object>? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRunRequest, object>? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActsGetSortBy? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActRunsPostForcePermissionLevel? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActRunsLastKeyValueStoreRecordPutContentEncoding? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActRunsLastKeyValueStoreRecordPostContentEncoding? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActRunsLastRequestQueueRequestsGetFilterItem>? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActRunsLastRequestQueueRequestsGetFilterItem? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorTaskRunsLastRequestQueueRequestsGetFilterItem>? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsLastRequestQueueRequestsGetFilterItem? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunKeyValueStoreRecordPutContentEncoding? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunKeyValueStoreRecordPostContentEncoding? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorRunRequestQueueRequestsGetFilterItem>? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunRequestQueueRequestsGetFilterItem? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreRecordPutContentEncoding? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreRecordPostContentEncoding? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestQueueRequestsGetFilterItem>? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueRequestsGetFilterItem? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StoreGetPricingModel? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StoreGetResponseFormat? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActValidateInputPostResponse? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AnyOf<global::Apify.PutItemResponseError, global::Apify.ErrorResponse>? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskGetResponse? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskPutResponse? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponse? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskWebhooksGetResponseData>? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponseData? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Webhook>? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponse? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskRunsGetResponseData>? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponseData? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsPostResponse? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsLastGetResponse? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PostChargeRunResponse? Type349 { get; set; }

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
        public global::System.Collections.Generic.List<global::Apify.KeyValueStoreKey>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.Request>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.AddedRequest>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestDraft>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DeletedRequest>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.HeadRequest>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.LockedHeadRequest>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.TaskShort>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.KeyValueStore>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DatasetListItem>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestQueueShort>? ListType25 { get; set; }
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
        public global::System.Collections.Generic.List<global::Apify.ActRunsLastRequestQueueRequestsGetFilterItem>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorTaskRunsLastRequestQueueRequestsGetFilterItem>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorRunRequestQueueRequestsGetFilterItem>? ListType44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestQueueRequestsGetFilterItem>? ListType45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.Webhook>? ListType47 { get; set; }
    }
}