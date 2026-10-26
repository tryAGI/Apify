
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
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public double? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorStatsPublicActorRunStats30Days? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorListItem? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfActors? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfActorsVariant2? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorListItem>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfActorsResponse? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ErrorType? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ErrorDetail? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ErrorResponse? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorPermissionLevel? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WritableVersionSourceType? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.EnvVarRequest? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.SourceCodeFileFormat? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.SourceCodeFile? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.SourceCodeFolder? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CreateVersionRequest? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.EnvVarRequest>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DefaultRunOptions? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorStandby? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ExampleRunInput? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CreateActorRequest? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.CreateVersionRequest>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.VersionSourceType? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.EnvVar? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.Version? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.EnvVar>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CommonActorPricingInfo? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TieredPricingPerEventEntry? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.TieredPricingPerEventEntry>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorChargeEvent? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PayPerEventActorPricingInfo? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PayPerEventActorPricingInfoVariant2? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PayPerEventActorPricingInfoVariant2PricingPerEvent? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.ActorChargeEvent>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TieredPricingPerDatasetItemEntry? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.TieredPricingPerDatasetItemEntry>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PricePerDatasetItemActorPricingInfo? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PricePerDatasetItemActorPricingInfoVariant2? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.FlatPricePerMonthActorPricingInfo? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.FlatPricePerMonthActorPricingInfoVariant2? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.FreeActorPricingInfo? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.FreeActorPricingInfoVariant2? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunPricingInfo? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunPricingInfoDiscriminator? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunPricingInfoDiscriminatorPricingModel? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaggedBuildInfo? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaggedBuilds? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorNotice? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorResource? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Version>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorRunPricingInfo>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorResponse? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdatedBuildProperty? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateActorRequest? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.UpdatedBuildProperty?>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfVersions? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfVersionsResponse? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.VersionResponse? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateVersionRequest? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfEnvVars? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfEnvVarsResponse? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.EnvVarResponse? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookEventType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookCondition? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookDispatchStatus? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookLastDispatch? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookStats? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookListItem? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookEventType>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhooks? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhooksVariant2? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookListItem>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhooksResponse? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorJobStatus? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunOrigin? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildMeta? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildListItem? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfBuilds? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfBuildsVariant2? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.BuildListItem>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfBuildsResponse? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildStats? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildOptions? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildUsage? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorDefinition? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorDefinitionStorages? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.OneOf<string, long?>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.Build? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildActVersion? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.SourceCodeFile>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildResponse? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunMeta? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunListItem? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRuns? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRunsVariant2? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RunListItem>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRunsResponse? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookRepresentation? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunStats? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunOptions? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.GeneralAccess? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunUsage? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunUsageUsd? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunMetamorphEvent? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.Run? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunStorageIds? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunStorageIdsDatasets? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunStorageIdsKeyValueStores? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunStorageIdsRequestQueues? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RunMetamorphEvent>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunResponse? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetStats? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetResource? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetResponse? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateDatasetRequest? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PutItemsRequest? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetItemValidationError? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.InvalidDatasetItem? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DatasetItemValidationError>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetSchemaValidationErrorData? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.InvalidDatasetItem>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetSchemaValidationError? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PutItemsErrorResponse? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetFieldStatistics? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetStatistics? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.DatasetFieldStatistics>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetStatisticsResponse? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.KeyValueStoreStats? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.KeyValueStoreResource? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.KeyValueStoreResponse? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateKeyValueStoreRequest? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.KeyValueStoreKey? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfKeys? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.KeyValueStoreKey>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfKeysResponse? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RecordResponse? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PutRecordRequest? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueStats? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueResource? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueResponse? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateRequestQueueRequest? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.HttpMethod? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestUserData? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestBase? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestResource? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestResourceVariant2? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRequests? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestResource>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRequestsResponse? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestWithoutId? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestRegistration? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AddRequestResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AddedRequest? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UnprocessedRequest? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BatchAddResult? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.AddedRequest>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.UnprocessedRequest>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BatchAddResponse? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestToDeleteById? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestToDeleteByUniqueKey? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestToDelete? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DeletedRequestById? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DeletedRequestByUniqueKey? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DeletedRequest? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BatchDeleteResult? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DeletedRequest>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BatchDeleteResponse? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UnlockRequestsResult? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UnlockRequestsResponse? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestResponse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateRequestResponse? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestLockInfo? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ProlongRequestLockResponse? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueHeadItem? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueHead? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestQueueHeadItem>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueHeadResponse? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.LockedRequestQueueHeadItem? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.LockedRequestQueueHead? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.LockedRequestQueueHeadItem>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.LockedRequestQueueHeadResponse? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaskStats? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaskListItem? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfTasks? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfTasksVariant2? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.TaskListItem>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfTasksResponse? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaskOptions? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaskInput? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaskPublicConfig? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CreateTaskRequest? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AnyOf<global::Apify.TaskInput, global::System.Collections.Generic.IList<global::Apify.TaskInput>>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.TaskInput>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.Task? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaskResponse? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateTaskRequest? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookResource? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateRunRequest? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ChargeRunRequest? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.StorageOwnership? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfKeyValueStores? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfKeyValueStoresVariant2? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.KeyValueStoreResource>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfKeyValueStoresResponse? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetListItem? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfDatasets? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfDatasetsVariant2? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DatasetListItem>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfDatasetsResponse? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueListItem? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRequestQueues? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRequestQueuesVariant2? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestQueueListItem>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRequestQueuesResponse? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CreateWebhookRequest? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookResponse? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateWebhookRequest? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookDispatchWebhookSummary? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookDispatch? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookDispatchEventData? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatchCall>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookDispatchCall? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookDispatchResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhookDispatches? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhookDispatchesVariant2? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatch>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhookDispatchesResponse? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleBase? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemActionRunActor? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemActionRunActorTask? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemAction? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemActionDiscriminator? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemActionDiscriminatorType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItem? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemVariant2? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleListItemAction>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfSchedules? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfSchedulesVariant2? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleListItem>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfSchedulesResponse? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleNotifications? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleActionRunInput? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleCreateActionRunActor? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleCreateActionRunActorTask? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleCreateAction? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleCreateActionDiscriminator? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleCreateActionDiscriminatorType? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CreateOrUpdateScheduleRequest? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleActionRunActor? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleActionRunActorTask? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleAction? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleActionDiscriminator? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleActionDiscriminatorType? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.Schedule? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleVariant2? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleAction>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleResponse? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleLogEntry? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleLogResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleLogEntry>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CurrentPricingInfo? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.StoreActor? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfStoreActors? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfStoreActorsVariant2? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.StoreActor>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfStoreActorsResponse? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UserProfile? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UserPublicInfo? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UserPublicInfoResponse? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ProxyGroup? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ProxyResource? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ProxyGroup>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UserPlan? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.EffectivePlatformFeature? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.EffectivePlatformFeatures? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UserPrivateInfo? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UserPrivateInfoResponse? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UsageCycle? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PriceTier? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UsageItem? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PriceTier>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.UsageItem>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DailyServiceUsage? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.MonthlyUsage? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DailyServiceUsage>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.MonthlyUsageResponse? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.Limits? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CurrentUsage? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AccountLimits? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AccountLimitsResponse? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateLimitsRequest? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BrowserInfoResponse? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.OneOf<string, global::System.Collections.Generic.IList<string>>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.EncodeAndSignResult? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.EncodeAndSignResponse? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DecodeAndVerifyRequest? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DecodeAndVerifyResult? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DecodeAndVerifyResponse? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRequestQueueRequest, object>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestWithoutId>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestToDelete>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AllOf<global::Apify.CreateTaskRequest, object>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRunRequest, object>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorsGetSortBy? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorsRunsPostForcePermissionLevel? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunsLastDatasetItemsPostContentEncoding? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunsLastKeyValueStoreRecordPutContentEncoding? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunsLastKeyValueStoreRecordPostContentEncoding? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorRunsLastRequestQueueRequestsGetFilterItem>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunsLastRequestQueueRequestsGetFilterItem? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsLastDatasetItemsPostContentEncoding? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorTaskRunsLastRequestQueueRequestsGetFilterItem>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsLastRequestQueueRequestsGetFilterItem? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunDatasetItemsPostContentEncoding? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunKeyValueStoreRecordPutContentEncoding? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunKeyValueStoreRecordPostContentEncoding? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorRunRequestQueueRequestsGetFilterItem>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunRequestQueueRequestsGetFilterItem? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.KeyValueStoreRecordPutContentEncoding? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.KeyValueStoreRecordPostContentEncoding? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetItemsPostContentEncoding? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestQueueRequestsGetFilterItem>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueRequestsGetFilterItem? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.StoreGetPricingModel? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.StoreGetResponseFormat? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorValidateInputPostResponse? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AnyOf<global::Apify.PutItemsErrorResponse, global::Apify.ErrorResponse>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskGetResponse? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskPutResponse? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponse? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskWebhooksGetResponseData>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponseData? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookResource>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponse? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskRunsGetResponseData>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponseData? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsPostResponse? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsLastGetResponse? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PostChargeRunResponse? Type359 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorListItem>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.EnvVarRequest>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.CreateVersionRequest>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.EnvVar>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.Version>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorRunPricingInfo>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookEventType>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookListItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.BuildListItem>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.SourceCodeFile>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RunListItem>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RunMetamorphEvent>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DatasetItemValidationError>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.InvalidDatasetItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.KeyValueStoreKey>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestResource>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.AddedRequest>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.UnprocessedRequest>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DeletedRequest>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestQueueHeadItem>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.LockedRequestQueueHeadItem>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.TaskListItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AnyOf<global::Apify.TaskInput, global::System.Collections.Generic.List<global::Apify.TaskInput>>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.TaskInput>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.KeyValueStoreResource>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DatasetListItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestQueueListItem>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookDispatchCall>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookDispatch>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleListItemAction>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleListItem>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleCreateAction>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleAction>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleLogEntry>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.StoreActor>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ProxyGroup>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.PriceTier>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DailyServiceUsage>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.OneOf<string, global::System.Collections.Generic.List<string>>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.List<global::Apify.PutItemsRequest>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.PutItemsRequest>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestWithoutId>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestToDelete>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorRunsLastRequestQueueRequestsGetFilterItem>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorTaskRunsLastRequestQueueRequestsGetFilterItem>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorRunRequestQueueRequestsGetFilterItem>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestQueueRequestsGetFilterItem>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookResource>? ListType50 { get; set; }
    }
}