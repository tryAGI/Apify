
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
        public global::Apify.ActorNotFoundError? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorNotFoundErrorError? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorNotFoundErrorErrorType? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CreateOrUpdateVersionRequest? Type56 { get; set; }
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
        public global::Apify.ActorVersionNotFoundError? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorVersionNotFoundErrorError? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorVersionNotFoundErrorErrorType? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfEnvVars? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfEnvVarsResponse? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvVarResponse? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvironmentVariableNotFoundError? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvironmentVariableNotFoundErrorError? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EnvironmentVariableNotFoundErrorErrorType? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookEventType? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookCondition? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchStatus? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ExampleWebhookDispatch? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookStats? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookShort? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookEventType>? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhooks? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhooksVariant2? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookShort>? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhooksResponse? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorJobStatus? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunOrigin? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildsMeta? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildShort? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfBuilds? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfBuildsVariant2? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.BuildShort>? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfBuildsResponse? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildStats? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildOptions? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildUsage? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorDefinition? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorDefinitionStorages? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<string, long?>? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Build? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BuildResponse? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnknownBuildTagError? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnknownBuildTagErrorError? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnknownBuildTagErrorErrorType? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorBuildNotFoundError? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorBuildNotFoundErrorError? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorBuildNotFoundErrorErrorType? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunMeta? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunShort? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRuns? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRunsVariant2? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RunShort>? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRunsResponse? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStats? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunOptions? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.GeneralAccess? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunUsage? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunUsageUsd? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Metamorph? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Run? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIds? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsDatasets? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsKeyValueStores? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunStorageIdsRequestQueues? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Metamorph>? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RunResponse? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunFailedError? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunFailedErrorError? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunFailedErrorErrorType? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunTimeoutExceededError? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunTimeoutExceededErrorError? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunTimeoutExceededErrorErrorType? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunNotFoundError? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunNotFoundErrorError? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunNotFoundErrorErrorType? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskStats? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskShort? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasks? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasksVariant2? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.TaskShort>? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfTasksResponse? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OptionalRunOptions? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskInput? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CreateTaskRequest? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Task? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TaskResponse? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateTaskRequest? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Webhook? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRunRequest? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ChargeRunRequest? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordOrTokenNotFoundError? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordOrTokenNotFoundErrorError? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordOrTokenNotFoundErrorErrorType? Type153 { get; set; }
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
        public global::Apify.KeyValueStoreNotFoundError? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreNotFoundErrorError? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreNotFoundErrorErrorType? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateStoreRequest? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreKey? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeys? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.KeyValueStoreKey>? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfKeysResponse? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordResponse? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordNotFoundError? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordNotFoundErrorError? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RecordNotFoundErrorErrorType? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutRecordRequest? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetListItem? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasets? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasetsVariant2? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DatasetListItem>? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfDatasetsResponse? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStats? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Dataset? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetResponse? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetNotFoundError? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetNotFoundErrorError? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetNotFoundErrorErrorType? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateDatasetRequest? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutItemsRequest? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ValidationError? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.InvalidItem? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ValidationError>? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.SchemaValidationErrorData? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.InvalidItem>? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetSchemaValidationError? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PutItemResponseError? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetFieldStatistics? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStatistics? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.DatasetFieldStatistics>? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DatasetStatisticsResponse? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueShort? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueues? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueuesVariant2? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestQueueShort>? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestQueuesResponse? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueStats? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueue? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueResponse? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueNotFoundError? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueNotFoundErrorError? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueNotFoundErrorErrorType? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRequestQueueRequest? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HttpMethod? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestUserData? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestBase? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AddedRequest? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraft? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchAddResult? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.AddedRequest>? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestDraft>? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchAddResponse? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraftDelete? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DeletedRequest? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchDeleteResult? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DeletedRequest>? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BatchDeleteResponse? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnlockRequestsResult? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UnlockRequestsResponse? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Request? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestVariant2? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequests? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Request>? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfRequestsResponse? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestRegistration? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AddRequestResponse? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestResponse? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestNotFoundError? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestNotFoundErrorError? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestNotFoundErrorErrorType? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateRequestResponse? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadRequest? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueHead? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.HeadRequest>? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadResponse? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LockedHeadRequest? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LockedRequestQueueHead? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.LockedHeadRequest>? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.HeadAndLockResponse? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestLockInfo? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ProlongRequestLockResponse? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookCreate? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookResponse? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookUpdate? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatch? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchEventData? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatchCall>? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchCall? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.TestWebhookResponse? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhookDispatches? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfWebhookDispatchesVariant2? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatch>? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchList? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.WebhookDispatchResponse? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleBase? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShort? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortScheduleActionShortRunActor? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortScheduleActionShortRunActorType? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortScheduleActionShortRunActorTask? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortScheduleActionShortRunActorTaskType? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionShortDiscriminator? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleShort? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleShortVariant2? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleActionShort>? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedules? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedulesVariant2? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleShort>? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfSchedulesResponse? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionRunInput? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateAction? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActor? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActorType? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTask? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTaskType? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreateActionDiscriminator? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleCreate? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleCreateAction>? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleAction? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionScheduleActionRunActor? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionScheduleActionRunActorType? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionScheduleActionRunActorTask? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionScheduleActionRunActorTaskType? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleActionDiscriminator? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Schedule? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleVariant2? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleAction>? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleResponse? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleInvoked? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ScheduleLogResponse? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ScheduleInvoked>? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CurrentPricingInfo? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StoreListActor? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfStoreActors? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfStoreActorsVariant2? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.StoreListActor>? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfActorsInStoreResponse? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Profile? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UserPublicInfo? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PublicUserDataResponse? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ProxyGroup? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Proxy? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.ProxyGroup>? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Plan? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EffectivePlatformFeature? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EffectivePlatformFeatures? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UserPrivateInfo? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PrivateUserDataResponse? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UsageCycle? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PriceTiers? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UsageItem? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PriceTiers>? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Apify.UsageItem>? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DailyServiceUsages? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.MonthlyUsage? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.DailyServiceUsages>? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.MonthlyUsageResponse? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Limits? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.Current? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AccountLimits? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.LimitsResponse? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.UpdateLimitsRequest? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.BrowserInfoResponse? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<string, global::System.Collections.Generic.IList<string>>? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EncodeAndSignResponse? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.EncodeAndSignResponseData? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyRequest? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyResponse? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DecodeAndVerifyResponseData? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.CreateTaskRequest, object>? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRunRequest, object>? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>>? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.UpdateRequestQueueRequest, object>? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestBase>? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.RequestDraftDelete>? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActsGetSortBy? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActRunsPostForcePermissionLevel? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreRecordPutContentEncoding? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.KeyValueStoreRecordPostContentEncoding? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueRequestsBatchDeleteContentType? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestQueueRequestsGetFilter? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.StoreGetPricingModel? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorNotFoundError, global::Apify.ActorVersionNotFoundError>? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorNotFoundError, global::Apify.ActorVersionNotFoundError, global::Apify.EnvironmentVariableNotFoundError>? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorNotFoundError, global::Apify.ActorBuildNotFoundError>? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorNotFoundError, global::Apify.ActorRunNotFoundError>? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskGetResponse? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskPutResponse? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponse? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskWebhooksGetResponseData>? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskWebhooksGetResponseData? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Apify.Webhook>? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponse? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.AllOf<global::Apify.PaginationResponse, global::Apify.ActorTaskRunsGetResponseData>? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsGetResponseData? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsPostResponse? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorTaskRunsLastGetResponse? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.ActorBuildNotFoundError, global::Apify.RecordOrTokenNotFoundError>? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.KeyValueStoreNotFoundError, global::Apify.RecordNotFoundError>? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.RequestQueueNotFoundError, global::Apify.RequestNotFoundError>? Type369 { get; set; }

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
        public global::System.Collections.Generic.List<global::Apify.CreateOrUpdateVersionRequest>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookEventType>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookShort>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.BuildShort>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RunShort>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.Metamorph>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.TaskShort>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.KeyValueStore>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.KeyValueStoreKey>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DatasetListItem>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ValidationError>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.InvalidItem>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestQueueShort>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.AddedRequest>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestDraft>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DeletedRequest>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.Request>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.HeadRequest>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.LockedHeadRequest>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookDispatchCall>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.WebhookDispatch>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleActionShort>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleShort>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleCreateAction>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleAction>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ScheduleInvoked>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.StoreListActor>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.ProxyGroup>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.PriceTiers>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.DailyServiceUsages>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<string, global::System.Collections.Generic.List<string>>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.List<global::Apify.PutItemsRequest>>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.PutItemsRequest>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestBase>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.RequestDraftDelete>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.Webhook>? ListType42 { get; set; }
    }
}