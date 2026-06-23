
#nullable enable

namespace Apify
{
    /// <summary>
    /// Machine-processable error type identifier.
    /// </summary>
    public enum ErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        x3dSecureAuthFailed,
        /// <summary>
        /// 
        /// </summary>
        AccessRightAlreadyExists,
        /// <summary>
        /// 
        /// </summary>
        ActionNotFound,
        /// <summary>
        /// 
        /// </summary>
        ActorAlreadyRented,
        /// <summary>
        /// 
        /// </summary>
        ActorCanNotBeRented,
        /// <summary>
        /// 
        /// </summary>
        ActorDisabled,
        /// <summary>
        /// 
        /// </summary>
        ActorIsNotRented,
        /// <summary>
        /// 
        /// </summary>
        ActorMemoryLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        ActorNameExistsNewOwner,
        /// <summary>
        /// 
        /// </summary>
        ActorNameNotUnique,
        /// <summary>
        /// 
        /// </summary>
        ActorNotFound,
        /// <summary>
        /// 
        /// </summary>
        ActorNotGithubActor,
        /// <summary>
        /// 
        /// </summary>
        ActorNotPublic,
        /// <summary>
        /// 
        /// </summary>
        ActorPermissionLevelNotSupportedForAgenticPayments,
        /// <summary>
        /// 
        /// </summary>
        ActorReviewAlreadyExists,
        /// <summary>
        /// 
        /// </summary>
        ActorRunFailed,
        /// <summary>
        /// 
        /// </summary>
        ActorStandbyNotSupportedForAgenticPayments,
        /// <summary>
        /// 
        /// </summary>
        ActorTaskNameNotUnique,
        /// <summary>
        /// 
        /// </summary>
        AgenticPaymentInfoRetrievalError,
        /// <summary>
        /// 
        /// </summary>
        AgenticPaymentInformationMissing,
        /// <summary>
        /// 
        /// </summary>
        AgenticPaymentInsufficientAmount,
        /// <summary>
        /// 
        /// </summary>
        AgenticPaymentProviderInternalError,
        /// <summary>
        /// 
        /// </summary>
        AgenticPaymentProviderUnauthorized,
        /// <summary>
        /// 
        /// </summary>
        AirtableWebhookDeprecated,
        /// <summary>
        /// 
        /// </summary>
        AlreadySubscribedToPaidActor,
        /// <summary>
        /// 
        /// </summary>
        ApifyPlanRequiredToUsePaidActor,
        /// <summary>
        /// 
        /// </summary>
        ApifySignupNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        AuthMethodNotSupported,
        /// <summary>
        /// 
        /// </summary>
        AuthorizationServerNotFound,
        /// <summary>
        /// 
        /// </summary>
        AutoIssueDateInvalid,
        /// <summary>
        /// 
        /// </summary>
        BackgroundCheckRequired,
        /// <summary>
        /// 
        /// </summary>
        BillingSystemError,
        /// <summary>
        /// 
        /// </summary>
        BlackFridayPlanExpired,
        /// <summary>
        /// 
        /// </summary>
        BraintreeError,
        /// <summary>
        /// 
        /// </summary>
        BraintreeNotLinked,
        /// <summary>
        /// 
        /// </summary>
        BraintreeOperationTimedOut,
        /// <summary>
        /// 
        /// </summary>
        BraintreeUnsupportedCurrency,
        /// <summary>
        /// 
        /// </summary>
        BuildNotFound,
        /// <summary>
        /// 
        /// </summary>
        BuildOutdated,
        /// <summary>
        /// 
        /// </summary>
        CannotAddApifyEventsToPpeActor,
        /// <summary>
        /// 
        /// </summary>
        CannotAddMultiplePricingInfos,
        /// <summary>
        /// 
        /// </summary>
        CannotAddPricingInfoThatAltersPast,
        /// <summary>
        /// 
        /// </summary>
        CannotAddSecondFuturePricingInfo,
        /// <summary>
        /// 
        /// </summary>
        CannotBuildActorFromWebhook,
        /// <summary>
        /// 
        /// </summary>
        CannotChangeBillingInterval,
        /// <summary>
        /// 
        /// </summary>
        CannotChangeOwner,
        /// <summary>
        /// 
        /// </summary>
        CannotChargeApifyEvent,
        /// <summary>
        /// 
        /// </summary>
        CannotChargeNonPayPerEventActor,
        /// <summary>
        /// 
        /// </summary>
        CannotCommentAsOtherUser,
        /// <summary>
        /// 
        /// </summary>
        CannotCopyActorTask,
        /// <summary>
        /// 
        /// </summary>
        CannotCreatePayout,
        /// <summary>
        /// 
        /// </summary>
        CannotCreatePublicActor,
        /// <summary>
        /// 
        /// </summary>
        CannotCreateTaxTransaction,
        /// <summary>
        /// 
        /// </summary>
        CannotDeleteCriticalActor,
        /// <summary>
        /// 
        /// </summary>
        CannotDeleteInvoice,
        /// <summary>
        /// 
        /// </summary>
        CannotDeletePaidActor,
        /// <summary>
        /// 
        /// </summary>
        CannotDisableOneTimeEventForApifyStartEvent,
        /// <summary>
        /// 
        /// </summary>
        CannotDisableOrganizationWithEnabledMembers,
        /// <summary>
        /// 
        /// </summary>
        CannotDisableUserWithSubscription,
        /// <summary>
        /// 
        /// </summary>
        CannotLinkOauthToUnverifiedEmail,
        /// <summary>
        /// 
        /// </summary>
        CannotMetamorphToPayPerResultActor,
        /// <summary>
        /// 
        /// </summary>
        CannotModifyActorPricingTooFrequently,
        /// <summary>
        /// 
        /// </summary>
        CannotModifyActorPricingWithImmediateEffect,
        /// <summary>
        /// 
        /// </summary>
        CannotOverridePaidActorTrial,
        /// <summary>
        /// 
        /// </summary>
        CannotPermanentlyDeleteSubscription,
        /// <summary>
        /// 
        /// </summary>
        CannotPublishActor,
        /// <summary>
        /// 
        /// </summary>
        CannotReduceLastFullToken,
        /// <summary>
        /// 
        /// </summary>
        CannotReimburseMoreThanOriginalCharge,
        /// <summary>
        /// 
        /// </summary>
        CannotReimburseNonRentalCharge,
        /// <summary>
        /// 
        /// </summary>
        CannotRemoveOwnActorFromRecentlyUsed,
        /// <summary>
        /// 
        /// </summary>
        CannotRemovePaymentMethod,
        /// <summary>
        /// 
        /// </summary>
        CannotRemovePricingInfo,
        /// <summary>
        /// 
        /// </summary>
        CannotRemoveRunningRun,
        /// <summary>
        /// 
        /// </summary>
        CannotRemoveUserWithPublicActors,
        /// <summary>
        /// 
        /// </summary>
        CannotRemoveUserWithSubscription,
        /// <summary>
        /// 
        /// </summary>
        CannotRemoveUserWithUnpaidInvoice,
        /// <summary>
        /// 
        /// </summary>
        CannotRenameEnvVar,
        /// <summary>
        /// 
        /// </summary>
        CannotRentPaidActor,
        /// <summary>
        /// 
        /// </summary>
        CannotReviewOwnActor,
        /// <summary>
        /// 
        /// </summary>
        CannotSetAccessRightsForOwner,
        /// <summary>
        /// 
        /// </summary>
        CannotSetIsStatusMessageTerminal,
        /// <summary>
        /// 
        /// </summary>
        CannotUnpublishCriticalActor,
        /// <summary>
        /// 
        /// </summary>
        CannotUnpublishPaidActor,
        /// <summary>
        /// 
        /// </summary>
        CannotUnpublishProfile,
        /// <summary>
        /// 
        /// </summary>
        CannotUpdateInvoiceField,
        /// <summary>
        /// 
        /// </summary>
        ConcurrentRunsLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        ConcurrentUpdateDetected,
        /// <summary>
        /// 
        /// </summary>
        ConferenceTokenNotFound,
        /// <summary>
        /// 
        /// </summary>
        ContentEncodingForbiddenForHtml,
        /// <summary>
        /// 
        /// </summary>
        CouponAlreadyRedeemed,
        /// <summary>
        /// 
        /// </summary>
        CouponExpired,
        /// <summary>
        /// 
        /// </summary>
        CouponForNewCustomers,
        /// <summary>
        /// 
        /// </summary>
        CouponForSubscribedUsers,
        /// <summary>
        /// 
        /// </summary>
        CouponLimitsAreInConflictWithCurrentLimits,
        /// <summary>
        /// 
        /// </summary>
        CouponMaxNumberOfRedemptionsReached,
        /// <summary>
        /// 
        /// </summary>
        CouponNotFound,
        /// <summary>
        /// 
        /// </summary>
        CouponNotUnique,
        /// <summary>
        /// 
        /// </summary>
        CouponsDisabled,
        /// <summary>
        /// 
        /// </summary>
        CreateGithubIssueNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        CreatorPlanNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        CronExpressionInvalid,
        /// <summary>
        /// 
        /// </summary>
        DailyAiTokenLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        DailyPublicationLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        DatasetDoesNotHaveFieldsSchema,
        /// <summary>
        /// 
        /// </summary>
        DatasetDoesNotHaveSchema,
        /// <summary>
        /// 
        /// </summary>
        DatasetLocked,
        /// <summary>
        /// 
        /// </summary>
        DatasetSchemaInvalid,
        /// <summary>
        /// 
        /// </summary>
        DcrNotSupported,
        /// <summary>
        /// 
        /// </summary>
        DefaultDatasetNotFound,
        /// <summary>
        /// 
        /// </summary>
        DeletingDefaultBuild,
        /// <summary>
        /// 
        /// </summary>
        DeletingUnfinishedBuild,
        /// <summary>
        /// 
        /// </summary>
        ElevatedPermissionsNeeded,
        /// <summary>
        /// 
        /// </summary>
        EmailAlreadyTaken,
        /// <summary>
        /// 
        /// </summary>
        EmailAlreadyTakenRemovedUser,
        /// <summary>
        /// 
        /// </summary>
        EmailDomainNotAllowedForCoupon,
        /// <summary>
        /// 
        /// </summary>
        EmailInvalid,
        /// <summary>
        /// 
        /// </summary>
        EmailNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        EmailNotValid,
        /// <summary>
        /// 
        /// </summary>
        EmailUpdateTooSoon,
        /// <summary>
        /// 
        /// </summary>
        EnvVarAlreadyExists,
        /// <summary>
        /// 
        /// </summary>
        ExchangeRateFetchFailed,
        /// <summary>
        /// 
        /// </summary>
        ExpiredConferenceToken,
        /// <summary>
        /// 
        /// </summary>
        FailedToChargeUser,
        /// <summary>
        /// 
        /// </summary>
        FinalInvoiceNegative,
        /// <summary>
        /// 
        /// </summary>
        FullPermissionActorNotApproved,
        /// <summary>
        /// 
        /// </summary>
        GithubBranchEmpty,
        /// <summary>
        /// 
        /// </summary>
        GithubIssueAlreadyExists,
        /// <summary>
        /// 
        /// </summary>
        GithubPublicKeyNotFound,
        /// <summary>
        /// 
        /// </summary>
        GithubRepositoryNotFound,
        /// <summary>
        /// 
        /// </summary>
        GithubSignatureDoesNotMatchPayload,
        /// <summary>
        /// 
        /// </summary>
        GithubUserNotAuthorizedForIssues,
        /// <summary>
        /// 
        /// </summary>
        GmailNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        IdDoesNotMatch,
        /// <summary>
        /// 
        /// </summary>
        IncompatibleBillingInterval,
        /// <summary>
        /// 
        /// </summary>
        IncompletePayoutBillingInfo,
        /// <summary>
        /// 
        /// </summary>
        InconsistentCurrencies,
        /// <summary>
        /// 
        /// </summary>
        IncorrectPricingModifierPrefix,
        /// <summary>
        /// 
        /// </summary>
        InputJsonInvalidCharacters,
        /// <summary>
        /// 
        /// </summary>
        InputJsonNotObject,
        /// <summary>
        /// 
        /// </summary>
        InputJsonTooLong,
        /// <summary>
        /// 
        /// </summary>
        InputUpdateCollision,
        /// <summary>
        /// 
        /// </summary>
        InsufficientPermissions,
        /// <summary>
        /// 
        /// </summary>
        InsufficientPermissionsToChangeField,
        /// <summary>
        /// 
        /// </summary>
        InsufficientSecurityMeasures,
        /// <summary>
        /// 
        /// </summary>
        InsufficientTaxCountryEvidence,
        /// <summary>
        /// 
        /// </summary>
        IntegrationAuthError,
        /// <summary>
        /// 
        /// </summary>
        InternalServerError,
        /// <summary>
        /// 
        /// </summary>
        InvalidBillingInfo,
        /// <summary>
        /// 
        /// </summary>
        InvalidBillingPeriodForPayout,
        /// <summary>
        /// 
        /// </summary>
        InvalidBuild,
        /// <summary>
        /// 
        /// </summary>
        InvalidClientKey,
        /// <summary>
        /// 
        /// </summary>
        InvalidCollection,
        /// <summary>
        /// 
        /// </summary>
        InvalidConferenceLoginPassword,
        /// <summary>
        /// 
        /// </summary>
        InvalidContentTypeHeader,
        /// <summary>
        /// 
        /// </summary>
        InvalidCredentials,
        /// <summary>
        /// 
        /// </summary>
        InvalidGitAuthToken,
        /// <summary>
        /// 
        /// </summary>
        InvalidGithubIssueUrl,
        /// <summary>
        /// 
        /// </summary>
        InvalidHeader,
        /// <summary>
        /// 
        /// </summary>
        InvalidId,
        /// <summary>
        /// 
        /// </summary>
        InvalidIdempotencyKey,
        /// <summary>
        /// 
        /// </summary>
        InvalidInput,
        /// <summary>
        /// 
        /// </summary>
        InvalidInputSchema,
        /// <summary>
        /// 
        /// </summary>
        InvalidInvoice,
        /// <summary>
        /// 
        /// </summary>
        InvalidInvoiceType,
        /// <summary>
        /// 
        /// </summary>
        InvalidIssueDate,
        /// <summary>
        /// 
        /// </summary>
        InvalidLabelParams,
        /// <summary>
        /// 
        /// </summary>
        InvalidMainAccountUserId,
        /// <summary>
        /// 
        /// </summary>
        InvalidOauthApp,
        /// <summary>
        /// 
        /// </summary>
        InvalidOauthScope,
        /// <summary>
        /// 
        /// </summary>
        InvalidOneTimeInvoice,
        /// <summary>
        /// 
        /// </summary>
        InvalidParameter,
        /// <summary>
        /// 
        /// </summary>
        InvalidPayoutStatus,
        /// <summary>
        /// 
        /// </summary>
        InvalidPictureUrl,
        /// <summary>
        /// 
        /// </summary>
        InvalidRecordKey,
        /// <summary>
        /// 
        /// </summary>
        InvalidRequest,
        /// <summary>
        /// 
        /// </summary>
        InvalidResourceType,
        /// <summary>
        /// 
        /// </summary>
        InvalidSignature,
        /// <summary>
        /// 
        /// </summary>
        InvalidSubscriptionPlan,
        /// <summary>
        /// 
        /// </summary>
        InvalidTaxNumber,
        /// <summary>
        /// 
        /// </summary>
        InvalidTaxNumberFormat,
        /// <summary>
        /// 
        /// </summary>
        InvalidToken,
        /// <summary>
        /// 
        /// </summary>
        InvalidTokenType,
        /// <summary>
        /// 
        /// </summary>
        InvalidTwoFactorCode,
        /// <summary>
        /// 
        /// </summary>
        InvalidTwoFactorCodeOrRecoveryCode,
        /// <summary>
        /// 
        /// </summary>
        InvalidTwoFactorRecoveryCode,
        /// <summary>
        /// 
        /// </summary>
        InvalidUsername,
        /// <summary>
        /// 
        /// </summary>
        InvalidValue,
        /// <summary>
        /// 
        /// </summary>
        InvitationInvalidResourceType,
        /// <summary>
        /// 
        /// </summary>
        InvitationNoLongerValid,
        /// <summary>
        /// 
        /// </summary>
        InvoiceCanceled,
        /// <summary>
        /// 
        /// </summary>
        InvoiceCannotBeRefundedDueToTooHighAmount,
        /// <summary>
        /// 
        /// </summary>
        InvoiceIncomplete,
        /// <summary>
        /// 
        /// </summary>
        InvoiceIsDraft,
        /// <summary>
        /// 
        /// </summary>
        InvoiceLocked,
        /// <summary>
        /// 
        /// </summary>
        InvoiceMustBeBuffer,
        /// <summary>
        /// 
        /// </summary>
        InvoiceNotCanceled,
        /// <summary>
        /// 
        /// </summary>
        InvoiceNotDraft,
        /// <summary>
        /// 
        /// </summary>
        InvoiceNotFound,
        /// <summary>
        /// 
        /// </summary>
        InvoiceOutdated,
        /// <summary>
        /// 
        /// </summary>
        InvoicePaidAlready,
        /// <summary>
        /// 
        /// </summary>
        IssueAlreadyConnectedToGithub,
        /// <summary>
        /// 
        /// </summary>
        IssueNotFound,
        /// <summary>
        /// 
        /// </summary>
        IssuerNotRegistered,
        /// <summary>
        /// 
        /// </summary>
        IssuesBadRequest,
        /// <summary>
        /// 
        /// </summary>
        JobFinished,
        /// <summary>
        /// 
        /// </summary>
        LabelAlreadyLinked,
        /// <summary>
        /// 
        /// </summary>
        LastApiToken,
        /// <summary>
        /// 
        /// </summary>
        LimitReached,
        /// <summary>
        /// 
        /// </summary>
        MaxItemsMustBeGreaterThanZero,
        /// <summary>
        /// 
        /// </summary>
        MaxMetamorphsExceeded,
        /// <summary>
        /// 
        /// </summary>
        MaxTotalChargeUsdBelowMinimum,
        /// <summary>
        /// 
        /// </summary>
        MaxTotalChargeUsdMustBeGreaterThanZero,
        /// <summary>
        /// 
        /// </summary>
        MethodNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        MigrationDisabled,
        /// <summary>
        /// 
        /// </summary>
        MissingActorRights,
        /// <summary>
        /// 
        /// </summary>
        MissingApiToken,
        /// <summary>
        /// 
        /// </summary>
        MissingBillingInfo,
        /// <summary>
        /// 
        /// </summary>
        MissingLineItems,
        /// <summary>
        /// 
        /// </summary>
        MissingPaymentDate,
        /// <summary>
        /// 
        /// </summary>
        MissingPayoutBillingInfo,
        /// <summary>
        /// 
        /// </summary>
        MissingProxyPassword,
        /// <summary>
        /// 
        /// </summary>
        MissingReportingFields,
        /// <summary>
        /// 
        /// </summary>
        MissingResourceName,
        /// <summary>
        /// 
        /// </summary>
        MissingSettings,
        /// <summary>
        /// 
        /// </summary>
        MissingUsername,
        /// <summary>
        /// 
        /// </summary>
        MonthlyUsageLimitTooLow,
        /// <summary>
        /// 
        /// </summary>
        MoreThanOneUpdateNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        MultipleRecordsFound,
        /// <summary>
        /// 
        /// </summary>
        MustBeAdmin,
        /// <summary>
        /// 
        /// </summary>
        NameNotUnique,
        /// <summary>
        /// 
        /// </summary>
        NextRuntimeComputationFailed,
        /// <summary>
        /// 
        /// </summary>
        NoColumnsInExportedDataset,
        /// <summary>
        /// 
        /// </summary>
        NoPaymentAttemptForRefundFound,
        /// <summary>
        /// 
        /// </summary>
        NoPaymentMethodAvailable,
        /// <summary>
        /// 
        /// </summary>
        NoTeamAccountSeatsAvailable,
        /// <summary>
        /// 
        /// </summary>
        NonTemporaryEmail,
        /// <summary>
        /// 
        /// </summary>
        NotEnoughUsageToRunPaidActor,
        /// <summary>
        /// 
        /// </summary>
        NotImplemented,
        /// <summary>
        /// 
        /// </summary>
        NotSupportedCurrencies,
        /// <summary>
        /// 
        /// </summary>
        OAuthServiceAlreadyConnected,
        /// <summary>
        /// 
        /// </summary>
        OAuthServiceNotConnected,
        /// <summary>
        /// 
        /// </summary>
        OauthResourceAccessFailed,
        /// <summary>
        /// 
        /// </summary>
        OneTimeInvoiceAlreadyMarkedPaid,
        /// <summary>
        /// 
        /// </summary>
        OnlyDraftsCanBeDeleted,
        /// <summary>
        /// 
        /// </summary>
        OperationCanceled,
        /// <summary>
        /// 
        /// </summary>
        OperationNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        OperationTimedOut,
        /// <summary>
        /// 
        /// </summary>
        OrganizationCannotOwnItself,
        /// <summary>
        /// 
        /// </summary>
        OrganizationRoleNotFound,
        /// <summary>
        /// 
        /// </summary>
        OverlappingPayoutBillingPeriods,
        /// <summary>
        /// 
        /// </summary>
        OwnTokenRequired,
        /// <summary>
        /// 
        /// </summary>
        PageNotFound,
        /// <summary>
        /// 
        /// </summary>
        ParamNotOneOf,
        /// <summary>
        /// 
        /// </summary>
        ParameterRequired,
        /// <summary>
        /// 
        /// </summary>
        ParametersMismatched,
        /// <summary>
        /// 
        /// </summary>
        PasswordResetEmailAlreadySent,
        /// <summary>
        /// 
        /// </summary>
        PasswordResetTokenExpired,
        /// <summary>
        /// 
        /// </summary>
        PayAsYouGoWithoutMonthlyInterval,
        /// <summary>
        /// 
        /// </summary>
        PaymentAttemptStatusMessageRequired,
        /// <summary>
        /// 
        /// </summary>
        PayoutAlreadyPaid,
        /// <summary>
        /// 
        /// </summary>
        PayoutCanceled,
        /// <summary>
        /// 
        /// </summary>
        PayoutInvalidState,
        /// <summary>
        /// 
        /// </summary>
        PayoutMustBeApprovedToBeMarkedPaid,
        /// <summary>
        /// 
        /// </summary>
        PayoutNotFound,
        /// <summary>
        /// 
        /// </summary>
        PayoutNumberAlreadyExists,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumberInvalid,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumberLandline,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumberOptedOut,
        /// <summary>
        /// 
        /// </summary>
        PhoneVerificationDisabled,
        /// <summary>
        /// 
        /// </summary>
        PlatformFeatureDisabled,
        /// <summary>
        /// 
        /// </summary>
        PriceOverridesValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        PricingModelNotSupported,
        /// <summary>
        /// 
        /// </summary>
        PromotionalPlanNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        ProxyAuthIpNotUnique,
        /// <summary>
        /// 
        /// </summary>
        PublicActorDisabled,
        /// <summary>
        /// 
        /// </summary>
        QueryTimeout,
        /// <summary>
        /// 
        /// </summary>
        QuotedPriceOutdated,
        /// <summary>
        /// 
        /// </summary>
        RateLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        RecaptchaInvalid,
        /// <summary>
        /// 
        /// </summary>
        RecaptchaRequired,
        /// <summary>
        /// 
        /// </summary>
        RecordNotFound,
        /// <summary>
        /// 
        /// </summary>
        RecordNotPublic,
        /// <summary>
        /// 
        /// </summary>
        RecordOrTokenNotFound,
        /// <summary>
        /// 
        /// </summary>
        RecordTooLarge,
        /// <summary>
        /// 
        /// </summary>
        RedirectUriMismatch,
        /// <summary>
        /// 
        /// </summary>
        ReducedPlanNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        RentalChargeAlreadyReimbursed,
        /// <summary>
        /// 
        /// </summary>
        RentalNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        RequestAbortedPrematurely,
        /// <summary>
        /// 
        /// </summary>
        RequestHandledOrLocked,
        /// <summary>
        /// 
        /// </summary>
        RequestIdInvalid,
        /// <summary>
        /// 
        /// </summary>
        RequestQueueDuplicateRequests,
        /// <summary>
        /// 
        /// </summary>
        RequestTooLarge,
        /// <summary>
        /// 
        /// </summary>
        RequestedDatasetViewDoesNotExist,
        /// <summary>
        /// 
        /// </summary>
        ResumeTokenExpired,
        /// <summary>
        /// 
        /// </summary>
        RunFailed,
        /// <summary>
        /// 
        /// </summary>
        RunInputBodyNotValidJson,
        /// <summary>
        /// 
        /// </summary>
        RunTimeoutExceeded,
        /// <summary>
        /// 
        /// </summary>
        RussiaIsEvil,
        /// <summary>
        /// 
        /// </summary>
        SameUser,
        /// <summary>
        /// 
        /// </summary>
        ScheduleActorNotFound,
        /// <summary>
        /// 
        /// </summary>
        ScheduleActorTaskNotFound,
        /// <summary>
        /// 
        /// </summary>
        ScheduleNameNotUnique,
        /// <summary>
        /// 
        /// </summary>
        SchemaValidation,
        /// <summary>
        /// 
        /// </summary>
        SchemaValidationError,
        /// <summary>
        /// 
        /// </summary>
        SchemaValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        ServiceWorkerRegistrationNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        SignUpMethodNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        SlackIntegrationNotCustom,
        /// <summary>
        /// 
        /// </summary>
        SocketClosed,
        /// <summary>
        /// 
        /// </summary>
        SocketDestroyed,
        /// <summary>
        /// 
        /// </summary>
        StoreSchemaInvalid,
        /// <summary>
        /// 
        /// </summary>
        StoreTermsNotAccepted,
        /// <summary>
        /// 
        /// </summary>
        StripeEnabled,
        /// <summary>
        /// 
        /// </summary>
        StripeGenericDecline,
        /// <summary>
        /// 
        /// </summary>
        StripeNotEnabled,
        /// <summary>
        /// 
        /// </summary>
        StripeNotEnabledForUser,
        /// <summary>
        /// 
        /// </summary>
        TaggedBuildRequired,
        /// <summary>
        /// 
        /// </summary>
        TaxCountryInvalid,
        /// <summary>
        /// 
        /// </summary>
        TaxNumberInvalid,
        /// <summary>
        /// 
        /// </summary>
        TaxNumberValidationFailed,
        /// <summary>
        /// 
        /// </summary>
        TaxamoCallFailed,
        /// <summary>
        /// 
        /// </summary>
        TaxamoRequestFailed,
        /// <summary>
        /// 
        /// </summary>
        TestingError,
        /// <summary>
        /// 
        /// </summary>
        TokenNotProvided,
        /// <summary>
        /// 
        /// </summary>
        TooFewVersions,
        /// <summary>
        /// 
        /// </summary>
        TooManyActorTasks,
        /// <summary>
        /// 
        /// </summary>
        TooManyActors,
        /// <summary>
        /// 
        /// </summary>
        TooManyLabelsOnResource,
        /// <summary>
        /// 
        /// </summary>
        TooManyMcpConnectors,
        /// <summary>
        /// 
        /// </summary>
        TooManyOAuthApps,
        /// <summary>
        /// 
        /// </summary>
        TooManyOrganizations,
        /// <summary>
        /// 
        /// </summary>
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        TooManySchedules,
        /// <summary>
        /// 
        /// </summary>
        TooManyUiAccessKeys,
        /// <summary>
        /// 
        /// </summary>
        TooManyUserLabels,
        /// <summary>
        /// 
        /// </summary>
        TooManyValues,
        /// <summary>
        /// 
        /// </summary>
        TooManyVersions,
        /// <summary>
        /// 
        /// </summary>
        TooManyWebhooks,
        /// <summary>
        /// 
        /// </summary>
        UnexpectedRoute,
        /// <summary>
        /// 
        /// </summary>
        UnknownBuildTag,
        /// <summary>
        /// 
        /// </summary>
        UnknownPaymentProvider,
        /// <summary>
        /// 
        /// </summary>
        UnsubscribeTokenInvalid,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedActorPricingModelForAgenticPayments,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedContentEncoding,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedFileTypeForIssue,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedFileTypeImageExpected,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedFileTypeTextOrJsonExpected,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedPermission,
        /// <summary>
        /// 
        /// </summary>
        UpcomingSubscriptionBillNotUpToDate,
        /// <summary>
        /// 
        /// </summary>
        UserAlreadyExists,
        /// <summary>
        /// 
        /// </summary>
        UserAlreadyVerified,
        /// <summary>
        /// 
        /// </summary>
        UserCreatesOrganizationsTooFast,
        /// <summary>
        /// 
        /// </summary>
        UserDisabled,
        /// <summary>
        /// 
        /// </summary>
        UserEmailIsDisposable,
        /// <summary>
        /// 
        /// </summary>
        UserEmailNotSet,
        /// <summary>
        /// 
        /// </summary>
        UserEmailNotVerified,
        /// <summary>
        /// 
        /// </summary>
        UserHasNoSubscription,
        /// <summary>
        /// 
        /// </summary>
        UserIntegrationNotFound,
        /// <summary>
        /// 
        /// </summary>
        UserIsAlreadyInvited,
        /// <summary>
        /// 
        /// </summary>
        UserIsAlreadyOrganizationMember,
        /// <summary>
        /// 
        /// </summary>
        UserIsNotMemberOfOrganization,
        /// <summary>
        /// 
        /// </summary>
        UserIsNotOrganization,
        /// <summary>
        /// 
        /// </summary>
        UserIsOrganization,
        /// <summary>
        /// 
        /// </summary>
        UserIsOrganizationOwner,
        /// <summary>
        /// 
        /// </summary>
        UserIsRemoved,
        /// <summary>
        /// 
        /// </summary>
        UserNotFound,
        /// <summary>
        /// 
        /// </summary>
        UserNotLoggedIn,
        /// <summary>
        /// 
        /// </summary>
        UserNotVerified,
        /// <summary>
        /// 
        /// </summary>
        UserOrTokenNotFound,
        /// <summary>
        /// 
        /// </summary>
        UserPlanNotAllowedForCoupon,
        /// <summary>
        /// 
        /// </summary>
        UserProblemWithCard,
        /// <summary>
        /// 
        /// </summary>
        UserRecordNotFound,
        /// <summary>
        /// 
        /// </summary>
        UsernameAlreadyTaken,
        /// <summary>
        /// 
        /// </summary>
        UsernameMissing,
        /// <summary>
        /// 
        /// </summary>
        UsernameNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        UsernameRemovalForbidden,
        /// <summary>
        /// 
        /// </summary>
        UsernameRequired,
        /// <summary>
        /// 
        /// </summary>
        VerificationEmailAlreadySent,
        /// <summary>
        /// 
        /// </summary>
        VerificationTokenExpired,
        /// <summary>
        /// 
        /// </summary>
        VersionAlreadyExists,
        /// <summary>
        /// 
        /// </summary>
        VersionsSizeExceeded,
        /// <summary>
        /// 
        /// </summary>
        WeakPassword,
        /// <summary>
        /// 
        /// </summary>
        X402AgenticPaymentAlreadyFinalized,
        /// <summary>
        /// 
        /// </summary>
        X402AgenticPaymentInsufficientAmount,
        /// <summary>
        /// 
        /// </summary>
        X402AgenticPaymentMalformedToken,
        /// <summary>
        /// 
        /// </summary>
        X402AgenticPaymentSettlementFailed,
        /// <summary>
        /// 
        /// </summary>
        X402AgenticPaymentSettlementInProgress,
        /// <summary>
        /// 
        /// </summary>
        X402AgenticPaymentSettlementStuck,
        /// <summary>
        /// 
        /// </summary>
        X402AgenticPaymentUnauthorized,
        /// <summary>
        /// 
        /// </summary>
        X402PaymentRequired,
        /// <summary>
        /// 
        /// </summary>
        ZeroInvoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorType value)
        {
            return value switch
            {
                ErrorType.x3dSecureAuthFailed => "3d-secure-auth-failed",
                ErrorType.AccessRightAlreadyExists => "access-right-already-exists",
                ErrorType.ActionNotFound => "action-not-found",
                ErrorType.ActorAlreadyRented => "actor-already-rented",
                ErrorType.ActorCanNotBeRented => "actor-can-not-be-rented",
                ErrorType.ActorDisabled => "actor-disabled",
                ErrorType.ActorIsNotRented => "actor-is-not-rented",
                ErrorType.ActorMemoryLimitExceeded => "actor-memory-limit-exceeded",
                ErrorType.ActorNameExistsNewOwner => "actor-name-exists-new-owner",
                ErrorType.ActorNameNotUnique => "actor-name-not-unique",
                ErrorType.ActorNotFound => "actor-not-found",
                ErrorType.ActorNotGithubActor => "actor-not-github-actor",
                ErrorType.ActorNotPublic => "actor-not-public",
                ErrorType.ActorPermissionLevelNotSupportedForAgenticPayments => "actor-permission-level-not-supported-for-agentic-payments",
                ErrorType.ActorReviewAlreadyExists => "actor-review-already-exists",
                ErrorType.ActorRunFailed => "actor-run-failed",
                ErrorType.ActorStandbyNotSupportedForAgenticPayments => "actor-standby-not-supported-for-agentic-payments",
                ErrorType.ActorTaskNameNotUnique => "actor-task-name-not-unique",
                ErrorType.AgenticPaymentInfoRetrievalError => "agentic-payment-info-retrieval-error",
                ErrorType.AgenticPaymentInformationMissing => "agentic-payment-information-missing",
                ErrorType.AgenticPaymentInsufficientAmount => "agentic-payment-insufficient-amount",
                ErrorType.AgenticPaymentProviderInternalError => "agentic-payment-provider-internal-error",
                ErrorType.AgenticPaymentProviderUnauthorized => "agentic-payment-provider-unauthorized",
                ErrorType.AirtableWebhookDeprecated => "airtable-webhook-deprecated",
                ErrorType.AlreadySubscribedToPaidActor => "already-subscribed-to-paid-actor",
                ErrorType.ApifyPlanRequiredToUsePaidActor => "apify-plan-required-to-use-paid-actor",
                ErrorType.ApifySignupNotAllowed => "apify-signup-not-allowed",
                ErrorType.AuthMethodNotSupported => "auth-method-not-supported",
                ErrorType.AuthorizationServerNotFound => "authorization-server-not-found",
                ErrorType.AutoIssueDateInvalid => "auto-issue-date-invalid",
                ErrorType.BackgroundCheckRequired => "background-check-required",
                ErrorType.BillingSystemError => "billing-system-error",
                ErrorType.BlackFridayPlanExpired => "black-friday-plan-expired",
                ErrorType.BraintreeError => "braintree-error",
                ErrorType.BraintreeNotLinked => "braintree-not-linked",
                ErrorType.BraintreeOperationTimedOut => "braintree-operation-timed-out",
                ErrorType.BraintreeUnsupportedCurrency => "braintree-unsupported-currency",
                ErrorType.BuildNotFound => "build-not-found",
                ErrorType.BuildOutdated => "build-outdated",
                ErrorType.CannotAddApifyEventsToPpeActor => "cannot-add-apify-events-to-ppe-actor",
                ErrorType.CannotAddMultiplePricingInfos => "cannot-add-multiple-pricing-infos",
                ErrorType.CannotAddPricingInfoThatAltersPast => "cannot-add-pricing-info-that-alters-past",
                ErrorType.CannotAddSecondFuturePricingInfo => "cannot-add-second-future-pricing-info",
                ErrorType.CannotBuildActorFromWebhook => "cannot-build-actor-from-webhook",
                ErrorType.CannotChangeBillingInterval => "cannot-change-billing-interval",
                ErrorType.CannotChangeOwner => "cannot-change-owner",
                ErrorType.CannotChargeApifyEvent => "cannot-charge-apify-event",
                ErrorType.CannotChargeNonPayPerEventActor => "cannot-charge-non-pay-per-event-actor",
                ErrorType.CannotCommentAsOtherUser => "cannot-comment-as-other-user",
                ErrorType.CannotCopyActorTask => "cannot-copy-actor-task",
                ErrorType.CannotCreatePayout => "cannot-create-payout",
                ErrorType.CannotCreatePublicActor => "cannot-create-public-actor",
                ErrorType.CannotCreateTaxTransaction => "cannot-create-tax-transaction",
                ErrorType.CannotDeleteCriticalActor => "cannot-delete-critical-actor",
                ErrorType.CannotDeleteInvoice => "cannot-delete-invoice",
                ErrorType.CannotDeletePaidActor => "cannot-delete-paid-actor",
                ErrorType.CannotDisableOneTimeEventForApifyStartEvent => "cannot-disable-one-time-event-for-apify-start-event",
                ErrorType.CannotDisableOrganizationWithEnabledMembers => "cannot-disable-organization-with-enabled-members",
                ErrorType.CannotDisableUserWithSubscription => "cannot-disable-user-with-subscription",
                ErrorType.CannotLinkOauthToUnverifiedEmail => "cannot-link-oauth-to-unverified-email",
                ErrorType.CannotMetamorphToPayPerResultActor => "cannot-metamorph-to-pay-per-result-actor",
                ErrorType.CannotModifyActorPricingTooFrequently => "cannot-modify-actor-pricing-too-frequently",
                ErrorType.CannotModifyActorPricingWithImmediateEffect => "cannot-modify-actor-pricing-with-immediate-effect",
                ErrorType.CannotOverridePaidActorTrial => "cannot-override-paid-actor-trial",
                ErrorType.CannotPermanentlyDeleteSubscription => "cannot-permanently-delete-subscription",
                ErrorType.CannotPublishActor => "cannot-publish-actor",
                ErrorType.CannotReduceLastFullToken => "cannot-reduce-last-full-token",
                ErrorType.CannotReimburseMoreThanOriginalCharge => "cannot-reimburse-more-than-original-charge",
                ErrorType.CannotReimburseNonRentalCharge => "cannot-reimburse-non-rental-charge",
                ErrorType.CannotRemoveOwnActorFromRecentlyUsed => "cannot-remove-own-actor-from-recently-used",
                ErrorType.CannotRemovePaymentMethod => "cannot-remove-payment-method",
                ErrorType.CannotRemovePricingInfo => "cannot-remove-pricing-info",
                ErrorType.CannotRemoveRunningRun => "cannot-remove-running-run",
                ErrorType.CannotRemoveUserWithPublicActors => "cannot-remove-user-with-public-actors",
                ErrorType.CannotRemoveUserWithSubscription => "cannot-remove-user-with-subscription",
                ErrorType.CannotRemoveUserWithUnpaidInvoice => "cannot-remove-user-with-unpaid-invoice",
                ErrorType.CannotRenameEnvVar => "cannot-rename-env-var",
                ErrorType.CannotRentPaidActor => "cannot-rent-paid-actor",
                ErrorType.CannotReviewOwnActor => "cannot-review-own-actor",
                ErrorType.CannotSetAccessRightsForOwner => "cannot-set-access-rights-for-owner",
                ErrorType.CannotSetIsStatusMessageTerminal => "cannot-set-is-status-message-terminal",
                ErrorType.CannotUnpublishCriticalActor => "cannot-unpublish-critical-actor",
                ErrorType.CannotUnpublishPaidActor => "cannot-unpublish-paid-actor",
                ErrorType.CannotUnpublishProfile => "cannot-unpublish-profile",
                ErrorType.CannotUpdateInvoiceField => "cannot-update-invoice-field",
                ErrorType.ConcurrentRunsLimitExceeded => "concurrent-runs-limit-exceeded",
                ErrorType.ConcurrentUpdateDetected => "concurrent-update-detected",
                ErrorType.ConferenceTokenNotFound => "conference-token-not-found",
                ErrorType.ContentEncodingForbiddenForHtml => "content-encoding-forbidden-for-html",
                ErrorType.CouponAlreadyRedeemed => "coupon-already-redeemed",
                ErrorType.CouponExpired => "coupon-expired",
                ErrorType.CouponForNewCustomers => "coupon-for-new-customers",
                ErrorType.CouponForSubscribedUsers => "coupon-for-subscribed-users",
                ErrorType.CouponLimitsAreInConflictWithCurrentLimits => "coupon-limits-are-in-conflict-with-current-limits",
                ErrorType.CouponMaxNumberOfRedemptionsReached => "coupon-max-number-of-redemptions-reached",
                ErrorType.CouponNotFound => "coupon-not-found",
                ErrorType.CouponNotUnique => "coupon-not-unique",
                ErrorType.CouponsDisabled => "coupons-disabled",
                ErrorType.CreateGithubIssueNotAllowed => "create-github-issue-not-allowed",
                ErrorType.CreatorPlanNotAvailable => "creator-plan-not-available",
                ErrorType.CronExpressionInvalid => "cron-expression-invalid",
                ErrorType.DailyAiTokenLimitExceeded => "daily-ai-token-limit-exceeded",
                ErrorType.DailyPublicationLimitExceeded => "daily-publication-limit-exceeded",
                ErrorType.DatasetDoesNotHaveFieldsSchema => "dataset-does-not-have-fields-schema",
                ErrorType.DatasetDoesNotHaveSchema => "dataset-does-not-have-schema",
                ErrorType.DatasetLocked => "dataset-locked",
                ErrorType.DatasetSchemaInvalid => "dataset-schema-invalid",
                ErrorType.DcrNotSupported => "dcr-not-supported",
                ErrorType.DefaultDatasetNotFound => "default-dataset-not-found",
                ErrorType.DeletingDefaultBuild => "deleting-default-build",
                ErrorType.DeletingUnfinishedBuild => "deleting-unfinished-build",
                ErrorType.ElevatedPermissionsNeeded => "elevated-permissions-needed",
                ErrorType.EmailAlreadyTaken => "email-already-taken",
                ErrorType.EmailAlreadyTakenRemovedUser => "email-already-taken-removed-user",
                ErrorType.EmailDomainNotAllowedForCoupon => "email-domain-not-allowed-for-coupon",
                ErrorType.EmailInvalid => "email-invalid",
                ErrorType.EmailNotAllowed => "email-not-allowed",
                ErrorType.EmailNotValid => "email-not-valid",
                ErrorType.EmailUpdateTooSoon => "email-update-too-soon",
                ErrorType.EnvVarAlreadyExists => "env-var-already-exists",
                ErrorType.ExchangeRateFetchFailed => "exchange-rate-fetch-failed",
                ErrorType.ExpiredConferenceToken => "expired-conference-token",
                ErrorType.FailedToChargeUser => "failed-to-charge-user",
                ErrorType.FinalInvoiceNegative => "final-invoice-negative",
                ErrorType.FullPermissionActorNotApproved => "full-permission-actor-not-approved",
                ErrorType.GithubBranchEmpty => "github-branch-empty",
                ErrorType.GithubIssueAlreadyExists => "github-issue-already-exists",
                ErrorType.GithubPublicKeyNotFound => "github-public-key-not-found",
                ErrorType.GithubRepositoryNotFound => "github-repository-not-found",
                ErrorType.GithubSignatureDoesNotMatchPayload => "github-signature-does-not-match-payload",
                ErrorType.GithubUserNotAuthorizedForIssues => "github-user-not-authorized-for-issues",
                ErrorType.GmailNotAllowed => "gmail-not-allowed",
                ErrorType.IdDoesNotMatch => "id-does-not-match",
                ErrorType.IncompatibleBillingInterval => "incompatible-billing-interval",
                ErrorType.IncompletePayoutBillingInfo => "incomplete-payout-billing-info",
                ErrorType.InconsistentCurrencies => "inconsistent-currencies",
                ErrorType.IncorrectPricingModifierPrefix => "incorrect-pricing-modifier-prefix",
                ErrorType.InputJsonInvalidCharacters => "input-json-invalid-characters",
                ErrorType.InputJsonNotObject => "input-json-not-object",
                ErrorType.InputJsonTooLong => "input-json-too-long",
                ErrorType.InputUpdateCollision => "input-update-collision",
                ErrorType.InsufficientPermissions => "insufficient-permissions",
                ErrorType.InsufficientPermissionsToChangeField => "insufficient-permissions-to-change-field",
                ErrorType.InsufficientSecurityMeasures => "insufficient-security-measures",
                ErrorType.InsufficientTaxCountryEvidence => "insufficient-tax-country-evidence",
                ErrorType.IntegrationAuthError => "integration-auth-error",
                ErrorType.InternalServerError => "internal-server-error",
                ErrorType.InvalidBillingInfo => "invalid-billing-info",
                ErrorType.InvalidBillingPeriodForPayout => "invalid-billing-period-for-payout",
                ErrorType.InvalidBuild => "invalid-build",
                ErrorType.InvalidClientKey => "invalid-client-key",
                ErrorType.InvalidCollection => "invalid-collection",
                ErrorType.InvalidConferenceLoginPassword => "invalid-conference-login-password",
                ErrorType.InvalidContentTypeHeader => "invalid-content-type-header",
                ErrorType.InvalidCredentials => "invalid-credentials",
                ErrorType.InvalidGitAuthToken => "invalid-git-auth-token",
                ErrorType.InvalidGithubIssueUrl => "invalid-github-issue-url",
                ErrorType.InvalidHeader => "invalid-header",
                ErrorType.InvalidId => "invalid-id",
                ErrorType.InvalidIdempotencyKey => "invalid-idempotency-key",
                ErrorType.InvalidInput => "invalid-input",
                ErrorType.InvalidInputSchema => "invalid-input-schema",
                ErrorType.InvalidInvoice => "invalid-invoice",
                ErrorType.InvalidInvoiceType => "invalid-invoice-type",
                ErrorType.InvalidIssueDate => "invalid-issue-date",
                ErrorType.InvalidLabelParams => "invalid-label-params",
                ErrorType.InvalidMainAccountUserId => "invalid-main-account-user-id",
                ErrorType.InvalidOauthApp => "invalid-oauth-app",
                ErrorType.InvalidOauthScope => "invalid-oauth-scope",
                ErrorType.InvalidOneTimeInvoice => "invalid-one-time-invoice",
                ErrorType.InvalidParameter => "invalid-parameter",
                ErrorType.InvalidPayoutStatus => "invalid-payout-status",
                ErrorType.InvalidPictureUrl => "invalid-picture-url",
                ErrorType.InvalidRecordKey => "invalid-record-key",
                ErrorType.InvalidRequest => "invalid-request",
                ErrorType.InvalidResourceType => "invalid-resource-type",
                ErrorType.InvalidSignature => "invalid-signature",
                ErrorType.InvalidSubscriptionPlan => "invalid-subscription-plan",
                ErrorType.InvalidTaxNumber => "invalid-tax-number",
                ErrorType.InvalidTaxNumberFormat => "invalid-tax-number-format",
                ErrorType.InvalidToken => "invalid-token",
                ErrorType.InvalidTokenType => "invalid-token-type",
                ErrorType.InvalidTwoFactorCode => "invalid-two-factor-code",
                ErrorType.InvalidTwoFactorCodeOrRecoveryCode => "invalid-two-factor-code-or-recovery-code",
                ErrorType.InvalidTwoFactorRecoveryCode => "invalid-two-factor-recovery-code",
                ErrorType.InvalidUsername => "invalid-username",
                ErrorType.InvalidValue => "invalid-value",
                ErrorType.InvitationInvalidResourceType => "invitation-invalid-resource-type",
                ErrorType.InvitationNoLongerValid => "invitation-no-longer-valid",
                ErrorType.InvoiceCanceled => "invoice-canceled",
                ErrorType.InvoiceCannotBeRefundedDueToTooHighAmount => "invoice-cannot-be-refunded-due-to-too-high-amount",
                ErrorType.InvoiceIncomplete => "invoice-incomplete",
                ErrorType.InvoiceIsDraft => "invoice-is-draft",
                ErrorType.InvoiceLocked => "invoice-locked",
                ErrorType.InvoiceMustBeBuffer => "invoice-must-be-buffer",
                ErrorType.InvoiceNotCanceled => "invoice-not-canceled",
                ErrorType.InvoiceNotDraft => "invoice-not-draft",
                ErrorType.InvoiceNotFound => "invoice-not-found",
                ErrorType.InvoiceOutdated => "invoice-outdated",
                ErrorType.InvoicePaidAlready => "invoice-paid-already",
                ErrorType.IssueAlreadyConnectedToGithub => "issue-already-connected-to-github",
                ErrorType.IssueNotFound => "issue-not-found",
                ErrorType.IssuerNotRegistered => "issuer-not-registered",
                ErrorType.IssuesBadRequest => "issues-bad-request",
                ErrorType.JobFinished => "job-finished",
                ErrorType.LabelAlreadyLinked => "label-already-linked",
                ErrorType.LastApiToken => "last-api-token",
                ErrorType.LimitReached => "limit-reached",
                ErrorType.MaxItemsMustBeGreaterThanZero => "max-items-must-be-greater-than-zero",
                ErrorType.MaxMetamorphsExceeded => "max-metamorphs-exceeded",
                ErrorType.MaxTotalChargeUsdBelowMinimum => "max-total-charge-usd-below-minimum",
                ErrorType.MaxTotalChargeUsdMustBeGreaterThanZero => "max-total-charge-usd-must-be-greater-than-zero",
                ErrorType.MethodNotAllowed => "method-not-allowed",
                ErrorType.MigrationDisabled => "migration-disabled",
                ErrorType.MissingActorRights => "missing-actor-rights",
                ErrorType.MissingApiToken => "missing-api-token",
                ErrorType.MissingBillingInfo => "missing-billing-info",
                ErrorType.MissingLineItems => "missing-line-items",
                ErrorType.MissingPaymentDate => "missing-payment-date",
                ErrorType.MissingPayoutBillingInfo => "missing-payout-billing-info",
                ErrorType.MissingProxyPassword => "missing-proxy-password",
                ErrorType.MissingReportingFields => "missing-reporting-fields",
                ErrorType.MissingResourceName => "missing-resource-name",
                ErrorType.MissingSettings => "missing-settings",
                ErrorType.MissingUsername => "missing-username",
                ErrorType.MonthlyUsageLimitTooLow => "monthly-usage-limit-too-low",
                ErrorType.MoreThanOneUpdateNotAllowed => "more-than-one-update-not-allowed",
                ErrorType.MultipleRecordsFound => "multiple-records-found",
                ErrorType.MustBeAdmin => "must-be-admin",
                ErrorType.NameNotUnique => "name-not-unique",
                ErrorType.NextRuntimeComputationFailed => "next-runtime-computation-failed",
                ErrorType.NoColumnsInExportedDataset => "no-columns-in-exported-dataset",
                ErrorType.NoPaymentAttemptForRefundFound => "no-payment-attempt-for-refund-found",
                ErrorType.NoPaymentMethodAvailable => "no-payment-method-available",
                ErrorType.NoTeamAccountSeatsAvailable => "no-team-account-seats-available",
                ErrorType.NonTemporaryEmail => "non-temporary-email",
                ErrorType.NotEnoughUsageToRunPaidActor => "not-enough-usage-to-run-paid-actor",
                ErrorType.NotImplemented => "not-implemented",
                ErrorType.NotSupportedCurrencies => "not-supported-currencies",
                ErrorType.OAuthServiceAlreadyConnected => "o-auth-service-already-connected",
                ErrorType.OAuthServiceNotConnected => "o-auth-service-not-connected",
                ErrorType.OauthResourceAccessFailed => "oauth-resource-access-failed",
                ErrorType.OneTimeInvoiceAlreadyMarkedPaid => "one-time-invoice-already-marked-paid",
                ErrorType.OnlyDraftsCanBeDeleted => "only-drafts-can-be-deleted",
                ErrorType.OperationCanceled => "operation-canceled",
                ErrorType.OperationNotAllowed => "operation-not-allowed",
                ErrorType.OperationTimedOut => "operation-timed-out",
                ErrorType.OrganizationCannotOwnItself => "organization-cannot-own-itself",
                ErrorType.OrganizationRoleNotFound => "organization-role-not-found",
                ErrorType.OverlappingPayoutBillingPeriods => "overlapping-payout-billing-periods",
                ErrorType.OwnTokenRequired => "own-token-required",
                ErrorType.PageNotFound => "page-not-found",
                ErrorType.ParamNotOneOf => "param-not-one-of",
                ErrorType.ParameterRequired => "parameter-required",
                ErrorType.ParametersMismatched => "parameters-mismatched",
                ErrorType.PasswordResetEmailAlreadySent => "password-reset-email-already-sent",
                ErrorType.PasswordResetTokenExpired => "password-reset-token-expired",
                ErrorType.PayAsYouGoWithoutMonthlyInterval => "pay-as-you-go-without-monthly-interval",
                ErrorType.PaymentAttemptStatusMessageRequired => "payment-attempt-status-message-required",
                ErrorType.PayoutAlreadyPaid => "payout-already-paid",
                ErrorType.PayoutCanceled => "payout-canceled",
                ErrorType.PayoutInvalidState => "payout-invalid-state",
                ErrorType.PayoutMustBeApprovedToBeMarkedPaid => "payout-must-be-approved-to-be-marked-paid",
                ErrorType.PayoutNotFound => "payout-not-found",
                ErrorType.PayoutNumberAlreadyExists => "payout-number-already-exists",
                ErrorType.PhoneNumberInvalid => "phone-number-invalid",
                ErrorType.PhoneNumberLandline => "phone-number-landline",
                ErrorType.PhoneNumberOptedOut => "phone-number-opted-out",
                ErrorType.PhoneVerificationDisabled => "phone-verification-disabled",
                ErrorType.PlatformFeatureDisabled => "platform-feature-disabled",
                ErrorType.PriceOverridesValidationFailed => "price-overrides-validation-failed",
                ErrorType.PricingModelNotSupported => "pricing-model-not-supported",
                ErrorType.PromotionalPlanNotAvailable => "promotional-plan-not-available",
                ErrorType.ProxyAuthIpNotUnique => "proxy-auth-ip-not-unique",
                ErrorType.PublicActorDisabled => "public-actor-disabled",
                ErrorType.QueryTimeout => "query-timeout",
                ErrorType.QuotedPriceOutdated => "quoted-price-outdated",
                ErrorType.RateLimitExceeded => "rate-limit-exceeded",
                ErrorType.RecaptchaInvalid => "recaptcha-invalid",
                ErrorType.RecaptchaRequired => "recaptcha-required",
                ErrorType.RecordNotFound => "record-not-found",
                ErrorType.RecordNotPublic => "record-not-public",
                ErrorType.RecordOrTokenNotFound => "record-or-token-not-found",
                ErrorType.RecordTooLarge => "record-too-large",
                ErrorType.RedirectUriMismatch => "redirect-uri-mismatch",
                ErrorType.ReducedPlanNotAvailable => "reduced-plan-not-available",
                ErrorType.RentalChargeAlreadyReimbursed => "rental-charge-already-reimbursed",
                ErrorType.RentalNotAllowed => "rental-not-allowed",
                ErrorType.RequestAbortedPrematurely => "request-aborted-prematurely",
                ErrorType.RequestHandledOrLocked => "request-handled-or-locked",
                ErrorType.RequestIdInvalid => "request-id-invalid",
                ErrorType.RequestQueueDuplicateRequests => "request-queue-duplicate-requests",
                ErrorType.RequestTooLarge => "request-too-large",
                ErrorType.RequestedDatasetViewDoesNotExist => "requested-dataset-view-does-not-exist",
                ErrorType.ResumeTokenExpired => "resume-token-expired",
                ErrorType.RunFailed => "run-failed",
                ErrorType.RunInputBodyNotValidJson => "run-input-body-not-valid-json",
                ErrorType.RunTimeoutExceeded => "run-timeout-exceeded",
                ErrorType.RussiaIsEvil => "russia-is-evil",
                ErrorType.SameUser => "same-user",
                ErrorType.ScheduleActorNotFound => "schedule-actor-not-found",
                ErrorType.ScheduleActorTaskNotFound => "schedule-actor-task-not-found",
                ErrorType.ScheduleNameNotUnique => "schedule-name-not-unique",
                ErrorType.SchemaValidation => "schema-validation",
                ErrorType.SchemaValidationError => "schema-validation-error",
                ErrorType.SchemaValidationFailed => "schema-validation-failed",
                ErrorType.ServiceWorkerRegistrationNotAllowed => "service-worker-registration-not-allowed",
                ErrorType.SignUpMethodNotAllowed => "sign-up-method-not-allowed",
                ErrorType.SlackIntegrationNotCustom => "slack-integration-not-custom",
                ErrorType.SocketClosed => "socket-closed",
                ErrorType.SocketDestroyed => "socket-destroyed",
                ErrorType.StoreSchemaInvalid => "store-schema-invalid",
                ErrorType.StoreTermsNotAccepted => "store-terms-not-accepted",
                ErrorType.StripeEnabled => "stripe-enabled",
                ErrorType.StripeGenericDecline => "stripe-generic-decline",
                ErrorType.StripeNotEnabled => "stripe-not-enabled",
                ErrorType.StripeNotEnabledForUser => "stripe-not-enabled-for-user",
                ErrorType.TaggedBuildRequired => "tagged-build-required",
                ErrorType.TaxCountryInvalid => "tax-country-invalid",
                ErrorType.TaxNumberInvalid => "tax-number-invalid",
                ErrorType.TaxNumberValidationFailed => "tax-number-validation-failed",
                ErrorType.TaxamoCallFailed => "taxamo-call-failed",
                ErrorType.TaxamoRequestFailed => "taxamo-request-failed",
                ErrorType.TestingError => "testing-error",
                ErrorType.TokenNotProvided => "token-not-provided",
                ErrorType.TooFewVersions => "too-few-versions",
                ErrorType.TooManyActorTasks => "too-many-actor-tasks",
                ErrorType.TooManyActors => "too-many-actors",
                ErrorType.TooManyLabelsOnResource => "too-many-labels-on-resource",
                ErrorType.TooManyMcpConnectors => "too-many-mcp-connectors",
                ErrorType.TooManyOAuthApps => "too-many-o-auth-apps",
                ErrorType.TooManyOrganizations => "too-many-organizations",
                ErrorType.TooManyRequests => "too-many-requests",
                ErrorType.TooManySchedules => "too-many-schedules",
                ErrorType.TooManyUiAccessKeys => "too-many-ui-access-keys",
                ErrorType.TooManyUserLabels => "too-many-user-labels",
                ErrorType.TooManyValues => "too-many-values",
                ErrorType.TooManyVersions => "too-many-versions",
                ErrorType.TooManyWebhooks => "too-many-webhooks",
                ErrorType.UnexpectedRoute => "unexpected-route",
                ErrorType.UnknownBuildTag => "unknown-build-tag",
                ErrorType.UnknownPaymentProvider => "unknown-payment-provider",
                ErrorType.UnsubscribeTokenInvalid => "unsubscribe-token-invalid",
                ErrorType.UnsupportedActorPricingModelForAgenticPayments => "unsupported-actor-pricing-model-for-agentic-payments",
                ErrorType.UnsupportedContentEncoding => "unsupported-content-encoding",
                ErrorType.UnsupportedFileTypeForIssue => "unsupported-file-type-for-issue",
                ErrorType.UnsupportedFileTypeImageExpected => "unsupported-file-type-image-expected",
                ErrorType.UnsupportedFileTypeTextOrJsonExpected => "unsupported-file-type-text-or-json-expected",
                ErrorType.UnsupportedPermission => "unsupported-permission",
                ErrorType.UpcomingSubscriptionBillNotUpToDate => "upcoming-subscription-bill-not-up-to-date",
                ErrorType.UserAlreadyExists => "user-already-exists",
                ErrorType.UserAlreadyVerified => "user-already-verified",
                ErrorType.UserCreatesOrganizationsTooFast => "user-creates-organizations-too-fast",
                ErrorType.UserDisabled => "user-disabled",
                ErrorType.UserEmailIsDisposable => "user-email-is-disposable",
                ErrorType.UserEmailNotSet => "user-email-not-set",
                ErrorType.UserEmailNotVerified => "user-email-not-verified",
                ErrorType.UserHasNoSubscription => "user-has-no-subscription",
                ErrorType.UserIntegrationNotFound => "user-integration-not-found",
                ErrorType.UserIsAlreadyInvited => "user-is-already-invited",
                ErrorType.UserIsAlreadyOrganizationMember => "user-is-already-organization-member",
                ErrorType.UserIsNotMemberOfOrganization => "user-is-not-member-of-organization",
                ErrorType.UserIsNotOrganization => "user-is-not-organization",
                ErrorType.UserIsOrganization => "user-is-organization",
                ErrorType.UserIsOrganizationOwner => "user-is-organization-owner",
                ErrorType.UserIsRemoved => "user-is-removed",
                ErrorType.UserNotFound => "user-not-found",
                ErrorType.UserNotLoggedIn => "user-not-logged-in",
                ErrorType.UserNotVerified => "user-not-verified",
                ErrorType.UserOrTokenNotFound => "user-or-token-not-found",
                ErrorType.UserPlanNotAllowedForCoupon => "user-plan-not-allowed-for-coupon",
                ErrorType.UserProblemWithCard => "user-problem-with-card",
                ErrorType.UserRecordNotFound => "user-record-not-found",
                ErrorType.UsernameAlreadyTaken => "username-already-taken",
                ErrorType.UsernameMissing => "username-missing",
                ErrorType.UsernameNotAllowed => "username-not-allowed",
                ErrorType.UsernameRemovalForbidden => "username-removal-forbidden",
                ErrorType.UsernameRequired => "username-required",
                ErrorType.VerificationEmailAlreadySent => "verification-email-already-sent",
                ErrorType.VerificationTokenExpired => "verification-token-expired",
                ErrorType.VersionAlreadyExists => "version-already-exists",
                ErrorType.VersionsSizeExceeded => "versions-size-exceeded",
                ErrorType.WeakPassword => "weak-password",
                ErrorType.X402AgenticPaymentAlreadyFinalized => "x402-agentic-payment-already-finalized",
                ErrorType.X402AgenticPaymentInsufficientAmount => "x402-agentic-payment-insufficient-amount",
                ErrorType.X402AgenticPaymentMalformedToken => "x402-agentic-payment-malformed-token",
                ErrorType.X402AgenticPaymentSettlementFailed => "x402-agentic-payment-settlement-failed",
                ErrorType.X402AgenticPaymentSettlementInProgress => "x402-agentic-payment-settlement-in-progress",
                ErrorType.X402AgenticPaymentSettlementStuck => "x402-agentic-payment-settlement-stuck",
                ErrorType.X402AgenticPaymentUnauthorized => "x402-agentic-payment-unauthorized",
                ErrorType.X402PaymentRequired => "x402-payment-required",
                ErrorType.ZeroInvoice => "zero-invoice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorType? ToEnum(string value)
        {
            return value switch
            {
                "3d-secure-auth-failed" => ErrorType.x3dSecureAuthFailed,
                "access-right-already-exists" => ErrorType.AccessRightAlreadyExists,
                "action-not-found" => ErrorType.ActionNotFound,
                "actor-already-rented" => ErrorType.ActorAlreadyRented,
                "actor-can-not-be-rented" => ErrorType.ActorCanNotBeRented,
                "actor-disabled" => ErrorType.ActorDisabled,
                "actor-is-not-rented" => ErrorType.ActorIsNotRented,
                "actor-memory-limit-exceeded" => ErrorType.ActorMemoryLimitExceeded,
                "actor-name-exists-new-owner" => ErrorType.ActorNameExistsNewOwner,
                "actor-name-not-unique" => ErrorType.ActorNameNotUnique,
                "actor-not-found" => ErrorType.ActorNotFound,
                "actor-not-github-actor" => ErrorType.ActorNotGithubActor,
                "actor-not-public" => ErrorType.ActorNotPublic,
                "actor-permission-level-not-supported-for-agentic-payments" => ErrorType.ActorPermissionLevelNotSupportedForAgenticPayments,
                "actor-review-already-exists" => ErrorType.ActorReviewAlreadyExists,
                "actor-run-failed" => ErrorType.ActorRunFailed,
                "actor-standby-not-supported-for-agentic-payments" => ErrorType.ActorStandbyNotSupportedForAgenticPayments,
                "actor-task-name-not-unique" => ErrorType.ActorTaskNameNotUnique,
                "agentic-payment-info-retrieval-error" => ErrorType.AgenticPaymentInfoRetrievalError,
                "agentic-payment-information-missing" => ErrorType.AgenticPaymentInformationMissing,
                "agentic-payment-insufficient-amount" => ErrorType.AgenticPaymentInsufficientAmount,
                "agentic-payment-provider-internal-error" => ErrorType.AgenticPaymentProviderInternalError,
                "agentic-payment-provider-unauthorized" => ErrorType.AgenticPaymentProviderUnauthorized,
                "airtable-webhook-deprecated" => ErrorType.AirtableWebhookDeprecated,
                "already-subscribed-to-paid-actor" => ErrorType.AlreadySubscribedToPaidActor,
                "apify-plan-required-to-use-paid-actor" => ErrorType.ApifyPlanRequiredToUsePaidActor,
                "apify-signup-not-allowed" => ErrorType.ApifySignupNotAllowed,
                "auth-method-not-supported" => ErrorType.AuthMethodNotSupported,
                "authorization-server-not-found" => ErrorType.AuthorizationServerNotFound,
                "auto-issue-date-invalid" => ErrorType.AutoIssueDateInvalid,
                "background-check-required" => ErrorType.BackgroundCheckRequired,
                "billing-system-error" => ErrorType.BillingSystemError,
                "black-friday-plan-expired" => ErrorType.BlackFridayPlanExpired,
                "braintree-error" => ErrorType.BraintreeError,
                "braintree-not-linked" => ErrorType.BraintreeNotLinked,
                "braintree-operation-timed-out" => ErrorType.BraintreeOperationTimedOut,
                "braintree-unsupported-currency" => ErrorType.BraintreeUnsupportedCurrency,
                "build-not-found" => ErrorType.BuildNotFound,
                "build-outdated" => ErrorType.BuildOutdated,
                "cannot-add-apify-events-to-ppe-actor" => ErrorType.CannotAddApifyEventsToPpeActor,
                "cannot-add-multiple-pricing-infos" => ErrorType.CannotAddMultiplePricingInfos,
                "cannot-add-pricing-info-that-alters-past" => ErrorType.CannotAddPricingInfoThatAltersPast,
                "cannot-add-second-future-pricing-info" => ErrorType.CannotAddSecondFuturePricingInfo,
                "cannot-build-actor-from-webhook" => ErrorType.CannotBuildActorFromWebhook,
                "cannot-change-billing-interval" => ErrorType.CannotChangeBillingInterval,
                "cannot-change-owner" => ErrorType.CannotChangeOwner,
                "cannot-charge-apify-event" => ErrorType.CannotChargeApifyEvent,
                "cannot-charge-non-pay-per-event-actor" => ErrorType.CannotChargeNonPayPerEventActor,
                "cannot-comment-as-other-user" => ErrorType.CannotCommentAsOtherUser,
                "cannot-copy-actor-task" => ErrorType.CannotCopyActorTask,
                "cannot-create-payout" => ErrorType.CannotCreatePayout,
                "cannot-create-public-actor" => ErrorType.CannotCreatePublicActor,
                "cannot-create-tax-transaction" => ErrorType.CannotCreateTaxTransaction,
                "cannot-delete-critical-actor" => ErrorType.CannotDeleteCriticalActor,
                "cannot-delete-invoice" => ErrorType.CannotDeleteInvoice,
                "cannot-delete-paid-actor" => ErrorType.CannotDeletePaidActor,
                "cannot-disable-one-time-event-for-apify-start-event" => ErrorType.CannotDisableOneTimeEventForApifyStartEvent,
                "cannot-disable-organization-with-enabled-members" => ErrorType.CannotDisableOrganizationWithEnabledMembers,
                "cannot-disable-user-with-subscription" => ErrorType.CannotDisableUserWithSubscription,
                "cannot-link-oauth-to-unverified-email" => ErrorType.CannotLinkOauthToUnverifiedEmail,
                "cannot-metamorph-to-pay-per-result-actor" => ErrorType.CannotMetamorphToPayPerResultActor,
                "cannot-modify-actor-pricing-too-frequently" => ErrorType.CannotModifyActorPricingTooFrequently,
                "cannot-modify-actor-pricing-with-immediate-effect" => ErrorType.CannotModifyActorPricingWithImmediateEffect,
                "cannot-override-paid-actor-trial" => ErrorType.CannotOverridePaidActorTrial,
                "cannot-permanently-delete-subscription" => ErrorType.CannotPermanentlyDeleteSubscription,
                "cannot-publish-actor" => ErrorType.CannotPublishActor,
                "cannot-reduce-last-full-token" => ErrorType.CannotReduceLastFullToken,
                "cannot-reimburse-more-than-original-charge" => ErrorType.CannotReimburseMoreThanOriginalCharge,
                "cannot-reimburse-non-rental-charge" => ErrorType.CannotReimburseNonRentalCharge,
                "cannot-remove-own-actor-from-recently-used" => ErrorType.CannotRemoveOwnActorFromRecentlyUsed,
                "cannot-remove-payment-method" => ErrorType.CannotRemovePaymentMethod,
                "cannot-remove-pricing-info" => ErrorType.CannotRemovePricingInfo,
                "cannot-remove-running-run" => ErrorType.CannotRemoveRunningRun,
                "cannot-remove-user-with-public-actors" => ErrorType.CannotRemoveUserWithPublicActors,
                "cannot-remove-user-with-subscription" => ErrorType.CannotRemoveUserWithSubscription,
                "cannot-remove-user-with-unpaid-invoice" => ErrorType.CannotRemoveUserWithUnpaidInvoice,
                "cannot-rename-env-var" => ErrorType.CannotRenameEnvVar,
                "cannot-rent-paid-actor" => ErrorType.CannotRentPaidActor,
                "cannot-review-own-actor" => ErrorType.CannotReviewOwnActor,
                "cannot-set-access-rights-for-owner" => ErrorType.CannotSetAccessRightsForOwner,
                "cannot-set-is-status-message-terminal" => ErrorType.CannotSetIsStatusMessageTerminal,
                "cannot-unpublish-critical-actor" => ErrorType.CannotUnpublishCriticalActor,
                "cannot-unpublish-paid-actor" => ErrorType.CannotUnpublishPaidActor,
                "cannot-unpublish-profile" => ErrorType.CannotUnpublishProfile,
                "cannot-update-invoice-field" => ErrorType.CannotUpdateInvoiceField,
                "concurrent-runs-limit-exceeded" => ErrorType.ConcurrentRunsLimitExceeded,
                "concurrent-update-detected" => ErrorType.ConcurrentUpdateDetected,
                "conference-token-not-found" => ErrorType.ConferenceTokenNotFound,
                "content-encoding-forbidden-for-html" => ErrorType.ContentEncodingForbiddenForHtml,
                "coupon-already-redeemed" => ErrorType.CouponAlreadyRedeemed,
                "coupon-expired" => ErrorType.CouponExpired,
                "coupon-for-new-customers" => ErrorType.CouponForNewCustomers,
                "coupon-for-subscribed-users" => ErrorType.CouponForSubscribedUsers,
                "coupon-limits-are-in-conflict-with-current-limits" => ErrorType.CouponLimitsAreInConflictWithCurrentLimits,
                "coupon-max-number-of-redemptions-reached" => ErrorType.CouponMaxNumberOfRedemptionsReached,
                "coupon-not-found" => ErrorType.CouponNotFound,
                "coupon-not-unique" => ErrorType.CouponNotUnique,
                "coupons-disabled" => ErrorType.CouponsDisabled,
                "create-github-issue-not-allowed" => ErrorType.CreateGithubIssueNotAllowed,
                "creator-plan-not-available" => ErrorType.CreatorPlanNotAvailable,
                "cron-expression-invalid" => ErrorType.CronExpressionInvalid,
                "daily-ai-token-limit-exceeded" => ErrorType.DailyAiTokenLimitExceeded,
                "daily-publication-limit-exceeded" => ErrorType.DailyPublicationLimitExceeded,
                "dataset-does-not-have-fields-schema" => ErrorType.DatasetDoesNotHaveFieldsSchema,
                "dataset-does-not-have-schema" => ErrorType.DatasetDoesNotHaveSchema,
                "dataset-locked" => ErrorType.DatasetLocked,
                "dataset-schema-invalid" => ErrorType.DatasetSchemaInvalid,
                "dcr-not-supported" => ErrorType.DcrNotSupported,
                "default-dataset-not-found" => ErrorType.DefaultDatasetNotFound,
                "deleting-default-build" => ErrorType.DeletingDefaultBuild,
                "deleting-unfinished-build" => ErrorType.DeletingUnfinishedBuild,
                "elevated-permissions-needed" => ErrorType.ElevatedPermissionsNeeded,
                "email-already-taken" => ErrorType.EmailAlreadyTaken,
                "email-already-taken-removed-user" => ErrorType.EmailAlreadyTakenRemovedUser,
                "email-domain-not-allowed-for-coupon" => ErrorType.EmailDomainNotAllowedForCoupon,
                "email-invalid" => ErrorType.EmailInvalid,
                "email-not-allowed" => ErrorType.EmailNotAllowed,
                "email-not-valid" => ErrorType.EmailNotValid,
                "email-update-too-soon" => ErrorType.EmailUpdateTooSoon,
                "env-var-already-exists" => ErrorType.EnvVarAlreadyExists,
                "exchange-rate-fetch-failed" => ErrorType.ExchangeRateFetchFailed,
                "expired-conference-token" => ErrorType.ExpiredConferenceToken,
                "failed-to-charge-user" => ErrorType.FailedToChargeUser,
                "final-invoice-negative" => ErrorType.FinalInvoiceNegative,
                "full-permission-actor-not-approved" => ErrorType.FullPermissionActorNotApproved,
                "github-branch-empty" => ErrorType.GithubBranchEmpty,
                "github-issue-already-exists" => ErrorType.GithubIssueAlreadyExists,
                "github-public-key-not-found" => ErrorType.GithubPublicKeyNotFound,
                "github-repository-not-found" => ErrorType.GithubRepositoryNotFound,
                "github-signature-does-not-match-payload" => ErrorType.GithubSignatureDoesNotMatchPayload,
                "github-user-not-authorized-for-issues" => ErrorType.GithubUserNotAuthorizedForIssues,
                "gmail-not-allowed" => ErrorType.GmailNotAllowed,
                "id-does-not-match" => ErrorType.IdDoesNotMatch,
                "incompatible-billing-interval" => ErrorType.IncompatibleBillingInterval,
                "incomplete-payout-billing-info" => ErrorType.IncompletePayoutBillingInfo,
                "inconsistent-currencies" => ErrorType.InconsistentCurrencies,
                "incorrect-pricing-modifier-prefix" => ErrorType.IncorrectPricingModifierPrefix,
                "input-json-invalid-characters" => ErrorType.InputJsonInvalidCharacters,
                "input-json-not-object" => ErrorType.InputJsonNotObject,
                "input-json-too-long" => ErrorType.InputJsonTooLong,
                "input-update-collision" => ErrorType.InputUpdateCollision,
                "insufficient-permissions" => ErrorType.InsufficientPermissions,
                "insufficient-permissions-to-change-field" => ErrorType.InsufficientPermissionsToChangeField,
                "insufficient-security-measures" => ErrorType.InsufficientSecurityMeasures,
                "insufficient-tax-country-evidence" => ErrorType.InsufficientTaxCountryEvidence,
                "integration-auth-error" => ErrorType.IntegrationAuthError,
                "internal-server-error" => ErrorType.InternalServerError,
                "invalid-billing-info" => ErrorType.InvalidBillingInfo,
                "invalid-billing-period-for-payout" => ErrorType.InvalidBillingPeriodForPayout,
                "invalid-build" => ErrorType.InvalidBuild,
                "invalid-client-key" => ErrorType.InvalidClientKey,
                "invalid-collection" => ErrorType.InvalidCollection,
                "invalid-conference-login-password" => ErrorType.InvalidConferenceLoginPassword,
                "invalid-content-type-header" => ErrorType.InvalidContentTypeHeader,
                "invalid-credentials" => ErrorType.InvalidCredentials,
                "invalid-git-auth-token" => ErrorType.InvalidGitAuthToken,
                "invalid-github-issue-url" => ErrorType.InvalidGithubIssueUrl,
                "invalid-header" => ErrorType.InvalidHeader,
                "invalid-id" => ErrorType.InvalidId,
                "invalid-idempotency-key" => ErrorType.InvalidIdempotencyKey,
                "invalid-input" => ErrorType.InvalidInput,
                "invalid-input-schema" => ErrorType.InvalidInputSchema,
                "invalid-invoice" => ErrorType.InvalidInvoice,
                "invalid-invoice-type" => ErrorType.InvalidInvoiceType,
                "invalid-issue-date" => ErrorType.InvalidIssueDate,
                "invalid-label-params" => ErrorType.InvalidLabelParams,
                "invalid-main-account-user-id" => ErrorType.InvalidMainAccountUserId,
                "invalid-oauth-app" => ErrorType.InvalidOauthApp,
                "invalid-oauth-scope" => ErrorType.InvalidOauthScope,
                "invalid-one-time-invoice" => ErrorType.InvalidOneTimeInvoice,
                "invalid-parameter" => ErrorType.InvalidParameter,
                "invalid-payout-status" => ErrorType.InvalidPayoutStatus,
                "invalid-picture-url" => ErrorType.InvalidPictureUrl,
                "invalid-record-key" => ErrorType.InvalidRecordKey,
                "invalid-request" => ErrorType.InvalidRequest,
                "invalid-resource-type" => ErrorType.InvalidResourceType,
                "invalid-signature" => ErrorType.InvalidSignature,
                "invalid-subscription-plan" => ErrorType.InvalidSubscriptionPlan,
                "invalid-tax-number" => ErrorType.InvalidTaxNumber,
                "invalid-tax-number-format" => ErrorType.InvalidTaxNumberFormat,
                "invalid-token" => ErrorType.InvalidToken,
                "invalid-token-type" => ErrorType.InvalidTokenType,
                "invalid-two-factor-code" => ErrorType.InvalidTwoFactorCode,
                "invalid-two-factor-code-or-recovery-code" => ErrorType.InvalidTwoFactorCodeOrRecoveryCode,
                "invalid-two-factor-recovery-code" => ErrorType.InvalidTwoFactorRecoveryCode,
                "invalid-username" => ErrorType.InvalidUsername,
                "invalid-value" => ErrorType.InvalidValue,
                "invitation-invalid-resource-type" => ErrorType.InvitationInvalidResourceType,
                "invitation-no-longer-valid" => ErrorType.InvitationNoLongerValid,
                "invoice-canceled" => ErrorType.InvoiceCanceled,
                "invoice-cannot-be-refunded-due-to-too-high-amount" => ErrorType.InvoiceCannotBeRefundedDueToTooHighAmount,
                "invoice-incomplete" => ErrorType.InvoiceIncomplete,
                "invoice-is-draft" => ErrorType.InvoiceIsDraft,
                "invoice-locked" => ErrorType.InvoiceLocked,
                "invoice-must-be-buffer" => ErrorType.InvoiceMustBeBuffer,
                "invoice-not-canceled" => ErrorType.InvoiceNotCanceled,
                "invoice-not-draft" => ErrorType.InvoiceNotDraft,
                "invoice-not-found" => ErrorType.InvoiceNotFound,
                "invoice-outdated" => ErrorType.InvoiceOutdated,
                "invoice-paid-already" => ErrorType.InvoicePaidAlready,
                "issue-already-connected-to-github" => ErrorType.IssueAlreadyConnectedToGithub,
                "issue-not-found" => ErrorType.IssueNotFound,
                "issuer-not-registered" => ErrorType.IssuerNotRegistered,
                "issues-bad-request" => ErrorType.IssuesBadRequest,
                "job-finished" => ErrorType.JobFinished,
                "label-already-linked" => ErrorType.LabelAlreadyLinked,
                "last-api-token" => ErrorType.LastApiToken,
                "limit-reached" => ErrorType.LimitReached,
                "max-items-must-be-greater-than-zero" => ErrorType.MaxItemsMustBeGreaterThanZero,
                "max-metamorphs-exceeded" => ErrorType.MaxMetamorphsExceeded,
                "max-total-charge-usd-below-minimum" => ErrorType.MaxTotalChargeUsdBelowMinimum,
                "max-total-charge-usd-must-be-greater-than-zero" => ErrorType.MaxTotalChargeUsdMustBeGreaterThanZero,
                "method-not-allowed" => ErrorType.MethodNotAllowed,
                "migration-disabled" => ErrorType.MigrationDisabled,
                "missing-actor-rights" => ErrorType.MissingActorRights,
                "missing-api-token" => ErrorType.MissingApiToken,
                "missing-billing-info" => ErrorType.MissingBillingInfo,
                "missing-line-items" => ErrorType.MissingLineItems,
                "missing-payment-date" => ErrorType.MissingPaymentDate,
                "missing-payout-billing-info" => ErrorType.MissingPayoutBillingInfo,
                "missing-proxy-password" => ErrorType.MissingProxyPassword,
                "missing-reporting-fields" => ErrorType.MissingReportingFields,
                "missing-resource-name" => ErrorType.MissingResourceName,
                "missing-settings" => ErrorType.MissingSettings,
                "missing-username" => ErrorType.MissingUsername,
                "monthly-usage-limit-too-low" => ErrorType.MonthlyUsageLimitTooLow,
                "more-than-one-update-not-allowed" => ErrorType.MoreThanOneUpdateNotAllowed,
                "multiple-records-found" => ErrorType.MultipleRecordsFound,
                "must-be-admin" => ErrorType.MustBeAdmin,
                "name-not-unique" => ErrorType.NameNotUnique,
                "next-runtime-computation-failed" => ErrorType.NextRuntimeComputationFailed,
                "no-columns-in-exported-dataset" => ErrorType.NoColumnsInExportedDataset,
                "no-payment-attempt-for-refund-found" => ErrorType.NoPaymentAttemptForRefundFound,
                "no-payment-method-available" => ErrorType.NoPaymentMethodAvailable,
                "no-team-account-seats-available" => ErrorType.NoTeamAccountSeatsAvailable,
                "non-temporary-email" => ErrorType.NonTemporaryEmail,
                "not-enough-usage-to-run-paid-actor" => ErrorType.NotEnoughUsageToRunPaidActor,
                "not-implemented" => ErrorType.NotImplemented,
                "not-supported-currencies" => ErrorType.NotSupportedCurrencies,
                "o-auth-service-already-connected" => ErrorType.OAuthServiceAlreadyConnected,
                "o-auth-service-not-connected" => ErrorType.OAuthServiceNotConnected,
                "oauth-resource-access-failed" => ErrorType.OauthResourceAccessFailed,
                "one-time-invoice-already-marked-paid" => ErrorType.OneTimeInvoiceAlreadyMarkedPaid,
                "only-drafts-can-be-deleted" => ErrorType.OnlyDraftsCanBeDeleted,
                "operation-canceled" => ErrorType.OperationCanceled,
                "operation-not-allowed" => ErrorType.OperationNotAllowed,
                "operation-timed-out" => ErrorType.OperationTimedOut,
                "organization-cannot-own-itself" => ErrorType.OrganizationCannotOwnItself,
                "organization-role-not-found" => ErrorType.OrganizationRoleNotFound,
                "overlapping-payout-billing-periods" => ErrorType.OverlappingPayoutBillingPeriods,
                "own-token-required" => ErrorType.OwnTokenRequired,
                "page-not-found" => ErrorType.PageNotFound,
                "param-not-one-of" => ErrorType.ParamNotOneOf,
                "parameter-required" => ErrorType.ParameterRequired,
                "parameters-mismatched" => ErrorType.ParametersMismatched,
                "password-reset-email-already-sent" => ErrorType.PasswordResetEmailAlreadySent,
                "password-reset-token-expired" => ErrorType.PasswordResetTokenExpired,
                "pay-as-you-go-without-monthly-interval" => ErrorType.PayAsYouGoWithoutMonthlyInterval,
                "payment-attempt-status-message-required" => ErrorType.PaymentAttemptStatusMessageRequired,
                "payout-already-paid" => ErrorType.PayoutAlreadyPaid,
                "payout-canceled" => ErrorType.PayoutCanceled,
                "payout-invalid-state" => ErrorType.PayoutInvalidState,
                "payout-must-be-approved-to-be-marked-paid" => ErrorType.PayoutMustBeApprovedToBeMarkedPaid,
                "payout-not-found" => ErrorType.PayoutNotFound,
                "payout-number-already-exists" => ErrorType.PayoutNumberAlreadyExists,
                "phone-number-invalid" => ErrorType.PhoneNumberInvalid,
                "phone-number-landline" => ErrorType.PhoneNumberLandline,
                "phone-number-opted-out" => ErrorType.PhoneNumberOptedOut,
                "phone-verification-disabled" => ErrorType.PhoneVerificationDisabled,
                "platform-feature-disabled" => ErrorType.PlatformFeatureDisabled,
                "price-overrides-validation-failed" => ErrorType.PriceOverridesValidationFailed,
                "pricing-model-not-supported" => ErrorType.PricingModelNotSupported,
                "promotional-plan-not-available" => ErrorType.PromotionalPlanNotAvailable,
                "proxy-auth-ip-not-unique" => ErrorType.ProxyAuthIpNotUnique,
                "public-actor-disabled" => ErrorType.PublicActorDisabled,
                "query-timeout" => ErrorType.QueryTimeout,
                "quoted-price-outdated" => ErrorType.QuotedPriceOutdated,
                "rate-limit-exceeded" => ErrorType.RateLimitExceeded,
                "recaptcha-invalid" => ErrorType.RecaptchaInvalid,
                "recaptcha-required" => ErrorType.RecaptchaRequired,
                "record-not-found" => ErrorType.RecordNotFound,
                "record-not-public" => ErrorType.RecordNotPublic,
                "record-or-token-not-found" => ErrorType.RecordOrTokenNotFound,
                "record-too-large" => ErrorType.RecordTooLarge,
                "redirect-uri-mismatch" => ErrorType.RedirectUriMismatch,
                "reduced-plan-not-available" => ErrorType.ReducedPlanNotAvailable,
                "rental-charge-already-reimbursed" => ErrorType.RentalChargeAlreadyReimbursed,
                "rental-not-allowed" => ErrorType.RentalNotAllowed,
                "request-aborted-prematurely" => ErrorType.RequestAbortedPrematurely,
                "request-handled-or-locked" => ErrorType.RequestHandledOrLocked,
                "request-id-invalid" => ErrorType.RequestIdInvalid,
                "request-queue-duplicate-requests" => ErrorType.RequestQueueDuplicateRequests,
                "request-too-large" => ErrorType.RequestTooLarge,
                "requested-dataset-view-does-not-exist" => ErrorType.RequestedDatasetViewDoesNotExist,
                "resume-token-expired" => ErrorType.ResumeTokenExpired,
                "run-failed" => ErrorType.RunFailed,
                "run-input-body-not-valid-json" => ErrorType.RunInputBodyNotValidJson,
                "run-timeout-exceeded" => ErrorType.RunTimeoutExceeded,
                "russia-is-evil" => ErrorType.RussiaIsEvil,
                "same-user" => ErrorType.SameUser,
                "schedule-actor-not-found" => ErrorType.ScheduleActorNotFound,
                "schedule-actor-task-not-found" => ErrorType.ScheduleActorTaskNotFound,
                "schedule-name-not-unique" => ErrorType.ScheduleNameNotUnique,
                "schema-validation" => ErrorType.SchemaValidation,
                "schema-validation-error" => ErrorType.SchemaValidationError,
                "schema-validation-failed" => ErrorType.SchemaValidationFailed,
                "service-worker-registration-not-allowed" => ErrorType.ServiceWorkerRegistrationNotAllowed,
                "sign-up-method-not-allowed" => ErrorType.SignUpMethodNotAllowed,
                "slack-integration-not-custom" => ErrorType.SlackIntegrationNotCustom,
                "socket-closed" => ErrorType.SocketClosed,
                "socket-destroyed" => ErrorType.SocketDestroyed,
                "store-schema-invalid" => ErrorType.StoreSchemaInvalid,
                "store-terms-not-accepted" => ErrorType.StoreTermsNotAccepted,
                "stripe-enabled" => ErrorType.StripeEnabled,
                "stripe-generic-decline" => ErrorType.StripeGenericDecline,
                "stripe-not-enabled" => ErrorType.StripeNotEnabled,
                "stripe-not-enabled-for-user" => ErrorType.StripeNotEnabledForUser,
                "tagged-build-required" => ErrorType.TaggedBuildRequired,
                "tax-country-invalid" => ErrorType.TaxCountryInvalid,
                "tax-number-invalid" => ErrorType.TaxNumberInvalid,
                "tax-number-validation-failed" => ErrorType.TaxNumberValidationFailed,
                "taxamo-call-failed" => ErrorType.TaxamoCallFailed,
                "taxamo-request-failed" => ErrorType.TaxamoRequestFailed,
                "testing-error" => ErrorType.TestingError,
                "token-not-provided" => ErrorType.TokenNotProvided,
                "too-few-versions" => ErrorType.TooFewVersions,
                "too-many-actor-tasks" => ErrorType.TooManyActorTasks,
                "too-many-actors" => ErrorType.TooManyActors,
                "too-many-labels-on-resource" => ErrorType.TooManyLabelsOnResource,
                "too-many-mcp-connectors" => ErrorType.TooManyMcpConnectors,
                "too-many-o-auth-apps" => ErrorType.TooManyOAuthApps,
                "too-many-organizations" => ErrorType.TooManyOrganizations,
                "too-many-requests" => ErrorType.TooManyRequests,
                "too-many-schedules" => ErrorType.TooManySchedules,
                "too-many-ui-access-keys" => ErrorType.TooManyUiAccessKeys,
                "too-many-user-labels" => ErrorType.TooManyUserLabels,
                "too-many-values" => ErrorType.TooManyValues,
                "too-many-versions" => ErrorType.TooManyVersions,
                "too-many-webhooks" => ErrorType.TooManyWebhooks,
                "unexpected-route" => ErrorType.UnexpectedRoute,
                "unknown-build-tag" => ErrorType.UnknownBuildTag,
                "unknown-payment-provider" => ErrorType.UnknownPaymentProvider,
                "unsubscribe-token-invalid" => ErrorType.UnsubscribeTokenInvalid,
                "unsupported-actor-pricing-model-for-agentic-payments" => ErrorType.UnsupportedActorPricingModelForAgenticPayments,
                "unsupported-content-encoding" => ErrorType.UnsupportedContentEncoding,
                "unsupported-file-type-for-issue" => ErrorType.UnsupportedFileTypeForIssue,
                "unsupported-file-type-image-expected" => ErrorType.UnsupportedFileTypeImageExpected,
                "unsupported-file-type-text-or-json-expected" => ErrorType.UnsupportedFileTypeTextOrJsonExpected,
                "unsupported-permission" => ErrorType.UnsupportedPermission,
                "upcoming-subscription-bill-not-up-to-date" => ErrorType.UpcomingSubscriptionBillNotUpToDate,
                "user-already-exists" => ErrorType.UserAlreadyExists,
                "user-already-verified" => ErrorType.UserAlreadyVerified,
                "user-creates-organizations-too-fast" => ErrorType.UserCreatesOrganizationsTooFast,
                "user-disabled" => ErrorType.UserDisabled,
                "user-email-is-disposable" => ErrorType.UserEmailIsDisposable,
                "user-email-not-set" => ErrorType.UserEmailNotSet,
                "user-email-not-verified" => ErrorType.UserEmailNotVerified,
                "user-has-no-subscription" => ErrorType.UserHasNoSubscription,
                "user-integration-not-found" => ErrorType.UserIntegrationNotFound,
                "user-is-already-invited" => ErrorType.UserIsAlreadyInvited,
                "user-is-already-organization-member" => ErrorType.UserIsAlreadyOrganizationMember,
                "user-is-not-member-of-organization" => ErrorType.UserIsNotMemberOfOrganization,
                "user-is-not-organization" => ErrorType.UserIsNotOrganization,
                "user-is-organization" => ErrorType.UserIsOrganization,
                "user-is-organization-owner" => ErrorType.UserIsOrganizationOwner,
                "user-is-removed" => ErrorType.UserIsRemoved,
                "user-not-found" => ErrorType.UserNotFound,
                "user-not-logged-in" => ErrorType.UserNotLoggedIn,
                "user-not-verified" => ErrorType.UserNotVerified,
                "user-or-token-not-found" => ErrorType.UserOrTokenNotFound,
                "user-plan-not-allowed-for-coupon" => ErrorType.UserPlanNotAllowedForCoupon,
                "user-problem-with-card" => ErrorType.UserProblemWithCard,
                "user-record-not-found" => ErrorType.UserRecordNotFound,
                "username-already-taken" => ErrorType.UsernameAlreadyTaken,
                "username-missing" => ErrorType.UsernameMissing,
                "username-not-allowed" => ErrorType.UsernameNotAllowed,
                "username-removal-forbidden" => ErrorType.UsernameRemovalForbidden,
                "username-required" => ErrorType.UsernameRequired,
                "verification-email-already-sent" => ErrorType.VerificationEmailAlreadySent,
                "verification-token-expired" => ErrorType.VerificationTokenExpired,
                "version-already-exists" => ErrorType.VersionAlreadyExists,
                "versions-size-exceeded" => ErrorType.VersionsSizeExceeded,
                "weak-password" => ErrorType.WeakPassword,
                "x402-agentic-payment-already-finalized" => ErrorType.X402AgenticPaymentAlreadyFinalized,
                "x402-agentic-payment-insufficient-amount" => ErrorType.X402AgenticPaymentInsufficientAmount,
                "x402-agentic-payment-malformed-token" => ErrorType.X402AgenticPaymentMalformedToken,
                "x402-agentic-payment-settlement-failed" => ErrorType.X402AgenticPaymentSettlementFailed,
                "x402-agentic-payment-settlement-in-progress" => ErrorType.X402AgenticPaymentSettlementInProgress,
                "x402-agentic-payment-settlement-stuck" => ErrorType.X402AgenticPaymentSettlementStuck,
                "x402-agentic-payment-unauthorized" => ErrorType.X402AgenticPaymentUnauthorized,
                "x402-payment-required" => ErrorType.X402PaymentRequired,
                "zero-invoice" => ErrorType.ZeroInvoice,
                _ => null,
            };
        }
    }
}