
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
        public global::Apify.VersionSourceType? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvVar? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.SourceCodeFileFormat? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.SourceCodeFile? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.SourceCodeFolder? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Version? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.EnvVar>? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CommonActorPricingInfo? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PricingModel? Type25 { get; set; }
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
        public global::Apify.ActorNotFoundError? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorNotFoundErrorError? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorNotFoundErrorErrorType? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorVersionNotFoundError? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorVersionNotFoundErrorError? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorVersionNotFoundErrorErrorType? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfEnvVars? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfEnvVarsResponse? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvVarResponse? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvironmentVariableNotFoundError? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvironmentVariableNotFoundErrorError? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvironmentVariableNotFoundErrorErrorType? Type74 { get; set; }
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
        public global::Apify.WebhookDispatchStatus? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ExampleWebhookDispatch? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookStats? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookShort? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookEventType>? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhooks? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhooksVariant2? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookShort>? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhooksResponse? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorJobStatus? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunOrigin? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildsMeta? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildShort? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfBuilds? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfBuildsVariant2? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.BuildShort>? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfBuildsResponse? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildStats? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildOptions? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildUsage? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorDefinition? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorDefinitionStorages? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<string, long?>? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Build? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildResponse? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnknownBuildTagError? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnknownBuildTagErrorError? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnknownBuildTagErrorErrorType? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorBuildNotFoundError? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorBuildNotFoundErrorError? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorBuildNotFoundErrorErrorType? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunMeta? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunShort? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRuns? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRunsVariant2? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RunShort>? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRunsResponse? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStats? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunOptions? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.GeneralAccess? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunUsage? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunUsageUsd? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Metamorph? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Run? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIds? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsDatasets? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsKeyValueStores? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsRequestQueues? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Metamorph>? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunResponse? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunFailedError? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunFailedErrorError? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunFailedErrorErrorType? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunTimeoutExceededError? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunTimeoutExceededErrorError? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunTimeoutExceededErrorErrorType? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunNotFoundError? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunNotFoundErrorError? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunNotFoundErrorErrorType? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskStats? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskShort? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasks? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasksVariant2? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.TaskShort>? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasksResponse? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OptionalRunOptions? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskInput? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CreateTaskRequest? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Task? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskResponse? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateTaskRequest? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Webhook? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRunRequest? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ChargeRunRequest? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordOrTokenNotFoundError? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordOrTokenNotFoundErrorError? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordOrTokenNotFoundErrorErrorType? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StorageOwnership? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreStats? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStore? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeyValueStores? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeyValueStoresVariant2? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.KeyValueStore>? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeyValueStoresResponse? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreResponse? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreNotFoundError? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreNotFoundErrorError? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreNotFoundErrorErrorType? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateStoreRequest? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreKey? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeys? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.KeyValueStoreKey>? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeysResponse? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordResponse? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordNotFoundError? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordNotFoundErrorError? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordNotFoundErrorErrorType? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutRecordRequest? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetListItem? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasets? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasetsVariant2? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DatasetListItem>? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasetsResponse? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStats? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Dataset? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetResponse? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetNotFoundError? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetNotFoundErrorError? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetNotFoundErrorErrorType? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateDatasetRequest? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutItemsRequest? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ValidationError? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.InvalidItem? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ValidationError>? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.SchemaValidationErrorData? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.InvalidItem>? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetSchemaValidationError? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutItemResponseError? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetFieldStatistics? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStatistics? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.DatasetFieldStatistics>? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStatisticsResponse? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueShort? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueues? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueuesVariant2? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestQueueShort>? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueuesResponse? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueStats? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueue? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueResponse? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueNotFoundError? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueNotFoundErrorError? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueNotFoundErrorErrorType? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRequestQueueRequest? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HttpMethod? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestUserData? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestBase? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AddedRequest? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraft? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchAddResult? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.AddedRequest>? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestDraft>? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchAddResponse? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraftDelete? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DeletedRequest? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchDeleteResult? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DeletedRequest>? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchDeleteResponse? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnlockRequestsResult? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnlockRequestsResponse? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Request? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestVariant2? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequests? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Request>? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestsResponse? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestRegistration? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AddRequestResponse? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestResponse? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestNotFoundError? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestNotFoundErrorError? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestNotFoundErrorErrorType? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRequestResponse? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadRequest? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueHead? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.HeadRequest>? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadResponse? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LockedHeadRequest? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LockedRequestQueueHead? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.LockedHeadRequest>? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadAndLockResponse? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestLockInfo? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ProlongRequestLockResponse? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookCreate? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookResponse? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookUpdate? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatch? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchEventData? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatchCall>? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchCall? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TestWebhookResponse? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhookDispatches? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhookDispatchesVariant2? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatch>? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchList? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchResponse? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleBase? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShort? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortScheduleActionShortRunActor? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortScheduleActionShortRunActorType? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortScheduleActionShortRunActorTask? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortScheduleActionShortRunActorTaskType? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortDiscriminator? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleShort? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleShortVariant2? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleActionShort>? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedules? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedulesVariant2? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleShort>? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedulesResponse? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionRunInput? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateAction? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActor? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActorType? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTask? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTaskType? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionDiscriminator? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreate? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleAction? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionScheduleActionRunActor? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionScheduleActionRunActorType? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionScheduleActionRunActorTask? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionScheduleActionRunActorTaskType? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionDiscriminator? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Schedule? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleVariant2? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleAction>? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleResponse? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleInvoked? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleLogResponse? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleInvoked>? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CurrentPricingInfo? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StoreListActor? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfStoreActors? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfStoreActorsVariant2? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.StoreListActor>? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfActorsInStoreResponse? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Profile? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UserPublicInfo? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PublicUserDataResponse? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ProxyGroup? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Proxy? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ProxyGroup>? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Plan? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EffectivePlatformFeature? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EffectivePlatformFeatures? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UserPrivateInfo? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PrivateUserDataResponse? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UsageCycle? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PriceTiers? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UsageItem? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PriceTiers>? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.UsageItem>? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DailyServiceUsages? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.MonthlyUsage? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DailyServiceUsages>? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.MonthlyUsageResponse? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Limits? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Current? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AccountLimits? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LimitsResponse? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateLimitsRequest? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BrowserInfoResponse? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<string, global::System.Collections.Generic.IList<string>>? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EncodeAndSignResponse? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EncodeAndSignResponseData? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyRequest? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyResponse? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyResponseData? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.CreateTaskRequest, object>? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRunRequest, object>? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRequestQueueRequest, object>? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestBase>? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestDraftDelete>? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActsGetSortBy? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActRunsPostForcePermissionLevel? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreRecordPutContentEncoding? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreRecordPostContentEncoding? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueRequestsBatchDeleteContentType? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueRequestsGetFilter? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StoreGetPricingModel? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorNotFoundError, global::Apify.ActorVersionNotFoundError>? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorNotFoundError, global::Apify.ActorVersionNotFoundError, global::Apify.EnvironmentVariableNotFoundError>? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorNotFoundError, global::Apify.ActorBuildNotFoundError>? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorNotFoundError, global::Apify.ActorRunNotFoundError>? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskGetResponse? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskPutResponse? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponse? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskWebhooksGetResponseData>? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponseData? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Webhook>? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponse? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskRunsGetResponseData>? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponseData? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsPostResponse? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsLastGetResponse? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PostChargeRunResponse? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorBuildNotFoundError, global::Apify.RecordOrTokenNotFoundError>? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.KeyValueStoreNotFoundError, global::Apify.RecordNotFoundError>? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.RequestQueueNotFoundError, global::Apify.RequestNotFoundError>? Type372 { get; set; }

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