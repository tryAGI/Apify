
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
        public global::Apify.UpdateBuildOnPushRequest? Type71 { get; set; }
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
        public global::Apify.WebhookEventType? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookCondition? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookSlackMessage? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookDatasetTransformation? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookGoogleMail? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookGoogleDrive? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookGithubIssue? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookDispatchStatus? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookLastDispatch? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookStats? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookResource? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookEventType>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhookResources? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhookResourcesVariant2? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookResource>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhookResourcesResponse? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorOAuthConnection? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorOAuthConnectionOAuthProviderType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorOAuthConnectionCredentials? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfActorOAuthConnections? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorOAuthConnection>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfActorOAuthConnectionsResponse? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorJobStatus? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunOrigin? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildMeta? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildListItem? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfBuilds? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfBuildsVariant2? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.BuildListItem>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfBuildsResponse? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildStats? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildOptions? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildUsage? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorDefinitionMeta? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorDefinition? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorDefinitionStorages? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.OneOf<string, long?>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.Build? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildActVersion? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.SourceCodeFile>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BuildResponse? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunMeta? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunStandby? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunListItem? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRuns? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRunsVariant2? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RunListItem>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRunsResponse? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookRepresentation? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunStats? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunEventUsage? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.IntegrationTracking? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunOptions? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.GeneralAccess? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunUsage? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunUsageUsd? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunMetamorphEvent? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.Run? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.RunEventUsage>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunStorageIds? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunStorageIdsDatasets? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunStorageIdsKeyValueStores? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunStorageIdsRequestQueues? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RunMetamorphEvent>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RunResponse? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetStats? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetResource? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetResponse? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateDatasetRequest? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PutItemsRequest? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetItemValidationError? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.InvalidDatasetItem? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DatasetItemValidationError>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetSchemaValidationErrorData? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.InvalidDatasetItem>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetSchemaValidationError? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PutItemsErrorResponse? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetFieldStatistics? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetStatistics? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.DatasetFieldStatistics>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetStatisticsResponse? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.KeyValueStoreStats? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.KeyValueStoreResource? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.KeyValueStoreResponse? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateKeyValueStoreRequest? Type162 { get; set; }
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
        public global::Apify.RequestQueueStats? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueResource? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueResponse? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateRequestQueueRequest? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.HttpMethod? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestUserData? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestBase? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestResource? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestResourceVariant2? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRequests? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestResource>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRequestsResponse? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestWithoutId? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestRegistration? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AddRequestResponse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AddedRequest? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UnprocessedRequest? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BatchAddResult? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.AddedRequest>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.UnprocessedRequest>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BatchAddResponse? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestToDeleteById? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestToDeleteByUniqueKey? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestToDelete? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DeletedRequestById? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DeletedRequestByUniqueKey? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DeletedRequest? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BatchDeleteResult? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DeletedRequest>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BatchDeleteResponse? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UnlockRequestsResult? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UnlockRequestsResponse? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestResponse? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateRequestResponse? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestLockInfo? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ProlongRequestLockResponse? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueHeadItem? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueHead? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestQueueHeadItem>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueHeadResponse? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.LockedRequestQueueHeadItem? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.LockedRequestQueueHead? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.LockedRequestQueueHeadItem>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.LockedRequestQueueHeadResponse? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaskStats? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaskListItem? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfTasks? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfTasksVariant2? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.TaskListItem>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfTasksResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaskOptions? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaskInput? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaskPublicConfig? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.TaskPublicConfigFaqItem>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaskPublicConfigFaqItem? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CreateTaskRequest? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AnyOf<global::Apify.TaskInput, global::System.Collections.Generic.IList<global::Apify.TaskInput>>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.TaskInput>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.Task? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.TaskResponse? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateTaskRequest? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateRunRequest? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ChargeRunRequest? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorOAuthAccount? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfActorOAuthAccounts? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorOAuthAccount>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfActorOAuthAccountsResponse? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorOAuthAccountResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.StorageOwnership? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.KeyValueStoreListStats? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.KeyValueStoreListItem? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfKeyValueStores? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfKeyValueStoresVariant2? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.KeyValueStoreListItem>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfKeyValueStoresResponse? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetListItem? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfDatasets? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfDatasetsVariant2? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DatasetListItem>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfDatasetsResponse? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueListStats? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueListItem? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRequestQueues? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRequestQueuesVariant2? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestQueueListItem>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfRequestQueuesResponse? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookListItem? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhooks? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhooksVariant2? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookListItem>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhooksResponse? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CreateWebhookRequest? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookResponse? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateWebhookRequest? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookDispatchWebhookSummary? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookDispatch? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookDispatchEventData? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatchCall>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookDispatchCall? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.WebhookDispatchResponse? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhookDispatches? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhookDispatchesVariant2? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatch>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhookDispatchesResponse? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleBase? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleNotifications? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemActionRunActor? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemActionRunActorTask? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemAction? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemActionDiscriminator? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemActionDiscriminatorType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItem? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemVariant2? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleListItemAction>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfSchedules? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfSchedulesVariant2? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleListItem>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfSchedulesResponse? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleActionRunInput? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleCreateActionRunActor? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleCreateActionRunActorTask? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleCreateAction? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleCreateActionDiscriminator? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleCreateActionDiscriminatorType? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CreateOrUpdateScheduleRequest? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleUiState? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleUiStateData? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleActionRunActor? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleActionRunActorTask? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleAction? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleActionDiscriminator? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleActionDiscriminatorType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.Schedule? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleVariant2? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleAction>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleLogEntry? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleLogResponse? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleLogEntry>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CurrentPricingInfo? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.CurrentPricingInfoTieredPricing2>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CurrentPricingInfoTieredPricing2? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.StoreActor? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.StoreActorInputSchema? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.StoreActorInputSchemaProperties2>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.StoreActorInputSchemaProperties2? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.OneOf<string, global::System.Collections.Generic.IList<string>>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfStoreActors? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfStoreActorsVariant2? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.StoreActor>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfStoreActorsResponse? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UserProfile? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UserPublicInfo? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UserPublicInfoResponse? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ProxyGroup? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ProxyResource? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ProxyGroup>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UserPlan? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UserPlanMonitoringLevel? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.EffectivePlatformFeature? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.EffectivePlatformFeatures? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UserPrivateInfo? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UserPrivateInfoResponse? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UsageCycle? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PriceTier? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UsageItem? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PriceTier>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.UsageItem>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DailyServiceUsage? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.MonthlyUsage? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DailyServiceUsage>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.MonthlyUsageResponse? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.Limits? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CurrentUsage? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AccountLimits? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AccountLimitsResponse? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.UpdateLimitsRequest? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.GitProviderWorkspace? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.GitProviderIntegration? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.GitProviderIntegrationProvider? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.GitProviderWorkspace>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfGitProviderIntegrationsResponse? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.GitProviderIntegration>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.GitRepoFile? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.GitRepoFileEncoding? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.CreateGitRepoRequest? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.GitRepoFile>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.GitRepo? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.GitRepoResponse? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RegisterDeploymentKeyRequest? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RegisterDeploymentKeyResponse? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RegisterDeploymentKeyResponseData? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.BrowserInfoResponse? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.EncodeAndSignResult? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.EncodeAndSignResponse? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DecodeAndVerifyRequest? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DecodeAndVerifyResult? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DecodeAndVerifyResponse? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRequestQueueRequest, object>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestWithoutId>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestToDelete>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AllOf<global::Apify.CreateTaskRequest, object>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRunRequest, object>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorsGetSortBy? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorsRunsPostForcePermissionLevel? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunSyncPostForcePermissionLevel? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunSyncGetForcePermissionLevel? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunSyncGetDatasetItemsPostForcePermissionLevel? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunSyncGetDatasetItemsGetForcePermissionLevel? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunsLastDatasetItemsPostContentEncoding? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunsLastKeyValueStoreRecordPutContentEncoding? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunsLastKeyValueStoreRecordPostContentEncoding? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorRunsLastRequestQueueRequestsGetFilterItem>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunsLastRequestQueueRequestsGetFilterItem? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsLastDatasetItemsPostContentEncoding? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsLastKeyValueStoreRecordPutContentEncoding? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsLastKeyValueStoreRecordPostContentEncoding? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorTaskRunsLastRequestQueueRequestsGetFilterItem>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsLastRequestQueueRequestsGetFilterItem? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunDatasetItemsPostContentEncoding? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunKeyValueStoreRecordPutContentEncoding? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunKeyValueStoreRecordPostContentEncoding? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ActorRunRequestQueueRequestsGetFilterItem>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorRunRequestQueueRequestsGetFilterItem? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.KeyValueStoreRecordPutContentEncoding? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.KeyValueStoreRecordPostContentEncoding? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.DatasetItemsPostContentEncoding? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestQueueRequestsGetFilterItem>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestQueueRequestsGetFilterItem? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.StoreGetPricingModel? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.StoreGetResponseFormat? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorValidateInputPostResponse? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AnyOf<global::Apify.PutItemsErrorResponse, global::Apify.ErrorResponse>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskGetResponse? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskPutResponse? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponse? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskWebhooksGetResponseData>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponseData? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponse? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskRunsGetResponseData>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponseData? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsPostResponse? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.ActorTaskRunsLastGetResponse? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.PostChargeRunResponse? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AnyOf<global::Apify.UserPublicInfoResponse, global::Apify.UserPrivateInfoResponse>? Type418 { get; set; }

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
        public global::System.Collections.Generic.List<global::Apify.WebhookResource>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorOAuthConnection>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.BuildListItem>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.SourceCodeFile>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RunListItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RunMetamorphEvent>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DatasetItemValidationError>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.InvalidDatasetItem>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.KeyValueStoreKey>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestResource>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.AddedRequest>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.UnprocessedRequest>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DeletedRequest>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestQueueHeadItem>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.LockedRequestQueueHeadItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.TaskListItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.TaskPublicConfigFaqItem>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.AnyOf<global::Apify.TaskInput, global::System.Collections.Generic.List<global::Apify.TaskInput>>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.TaskInput>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorOAuthAccount>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.KeyValueStoreListItem>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DatasetListItem>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestQueueListItem>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookListItem>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookDispatchCall>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookDispatch>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleListItemAction>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleListItem>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleCreateAction>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleAction>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleLogEntry>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.OneOf<string, global::System.Collections.Generic.List<string>>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.StoreActor>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ProxyGroup>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.PriceTier>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DailyServiceUsage>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.GitProviderWorkspace>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.GitProviderIntegration>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.GitRepoFile>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.List<global::Apify.PutItemsRequest>>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.PutItemsRequest>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestWithoutId>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestToDelete>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorRunsLastRequestQueueRequestsGetFilterItem>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorTaskRunsLastRequestQueueRequestsGetFilterItem>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ActorRunRequestQueueRequestsGetFilterItem>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestQueueRequestsGetFilterItem>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType56 { get; set; }
    }
}