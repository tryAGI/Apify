#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ActorNotFoundErrorDetail : global::System.IEquatable<ActorNotFoundErrorDetail>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ErrorDetail? ErrorDetail { get; init; }
#else
        public global::Apify.ErrorDetail? ErrorDetail { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ErrorDetail))]
#endif
        public bool IsErrorDetail => ErrorDetail != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ActorNotFoundErrorDetailVariant2? ActorNotFoundErrorDetailVariant2 { get; init; }
#else
        public global::Apify.ActorNotFoundErrorDetailVariant2? ActorNotFoundErrorDetailVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ActorNotFoundErrorDetailVariant2))]
#endif
        public bool IsActorNotFoundErrorDetailVariant2 => ActorNotFoundErrorDetailVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ActorNotFoundErrorDetail(global::Apify.ErrorDetail value) => new ActorNotFoundErrorDetail((global::Apify.ErrorDetail?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ErrorDetail?(ActorNotFoundErrorDetail @this) => @this.ErrorDetail;

        /// <summary>
        /// 
        /// </summary>
        public ActorNotFoundErrorDetail(global::Apify.ErrorDetail? value)
        {
            ErrorDetail = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ActorNotFoundErrorDetail(global::Apify.ActorNotFoundErrorDetailVariant2 value) => new ActorNotFoundErrorDetail((global::Apify.ActorNotFoundErrorDetailVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ActorNotFoundErrorDetailVariant2?(ActorNotFoundErrorDetail @this) => @this.ActorNotFoundErrorDetailVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ActorNotFoundErrorDetail(global::Apify.ActorNotFoundErrorDetailVariant2? value)
        {
            ActorNotFoundErrorDetailVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ActorNotFoundErrorDetail(
            global::Apify.ErrorDetail? errorDetail,
            global::Apify.ActorNotFoundErrorDetailVariant2? actorNotFoundErrorDetailVariant2
            )
        {
            ErrorDetail = errorDetail;
            ActorNotFoundErrorDetailVariant2 = actorNotFoundErrorDetailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ActorNotFoundErrorDetailVariant2 as object ??
            ErrorDetail as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ErrorDetail?.ToString() ??
            ActorNotFoundErrorDetailVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsErrorDetail && IsActorNotFoundErrorDetailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.ErrorDetail?, TResult>? errorDetail = null,
            global::System.Func<global::Apify.ActorNotFoundErrorDetailVariant2?, TResult>? actorNotFoundErrorDetailVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsErrorDetail && errorDetail != null)
            {
                return errorDetail(ErrorDetail!);
            }
            else if (IsActorNotFoundErrorDetailVariant2 && actorNotFoundErrorDetailVariant2 != null)
            {
                return actorNotFoundErrorDetailVariant2(ActorNotFoundErrorDetailVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.ErrorDetail?>? errorDetail = null,
            global::System.Action<global::Apify.ActorNotFoundErrorDetailVariant2?>? actorNotFoundErrorDetailVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsErrorDetail)
            {
                errorDetail?.Invoke(ErrorDetail!);
            }
            else if (IsActorNotFoundErrorDetailVariant2)
            {
                actorNotFoundErrorDetailVariant2?.Invoke(ActorNotFoundErrorDetailVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ErrorDetail,
                typeof(global::Apify.ErrorDetail),
                ActorNotFoundErrorDetailVariant2,
                typeof(global::Apify.ActorNotFoundErrorDetailVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ActorNotFoundErrorDetail other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ErrorDetail?>.Default.Equals(ErrorDetail, other.ErrorDetail) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ActorNotFoundErrorDetailVariant2?>.Default.Equals(ActorNotFoundErrorDetailVariant2, other.ActorNotFoundErrorDetailVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ActorNotFoundErrorDetail obj1, ActorNotFoundErrorDetail obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ActorNotFoundErrorDetail>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ActorNotFoundErrorDetail obj1, ActorNotFoundErrorDetail obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ActorNotFoundErrorDetail o && Equals(o);
        }
    }
}
