#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// A request that should be deleted.
    /// </summary>
    public readonly partial struct RequestDraftDelete : global::System.IEquatable<RequestDraftDelete>
    {
        /// <summary>
        /// A request that should be deleted, identified by its ID.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.RequestDraftDeleteById? RequestDraftDeleteById { get; init; }
#else
        public global::Apify.RequestDraftDeleteById? RequestDraftDeleteById { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestDraftDeleteById))]
#endif
        public bool IsRequestDraftDeleteById => RequestDraftDeleteById != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRequestDraftDeleteById(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.RequestDraftDeleteById? value)
        {
            value = RequestDraftDeleteById;
            return IsRequestDraftDeleteById;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraftDeleteById PickRequestDraftDeleteById() => IsRequestDraftDeleteById
            ? RequestDraftDeleteById!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequestDraftDeleteById' but the value was {ToString()}.");

        /// <summary>
        /// A request that should be deleted, identified by its unique key.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.RequestDraftDeleteByUniqueKey? RequestDraftDeleteByUniqueKey { get; init; }
#else
        public global::Apify.RequestDraftDeleteByUniqueKey? RequestDraftDeleteByUniqueKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestDraftDeleteByUniqueKey))]
#endif
        public bool IsRequestDraftDeleteByUniqueKey => RequestDraftDeleteByUniqueKey != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRequestDraftDeleteByUniqueKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.RequestDraftDeleteByUniqueKey? value)
        {
            value = RequestDraftDeleteByUniqueKey;
            return IsRequestDraftDeleteByUniqueKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Apify.RequestDraftDeleteByUniqueKey PickRequestDraftDeleteByUniqueKey() => IsRequestDraftDeleteByUniqueKey
            ? RequestDraftDeleteByUniqueKey!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequestDraftDeleteByUniqueKey' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RequestDraftDelete(global::Apify.RequestDraftDeleteById value) => new RequestDraftDelete((global::Apify.RequestDraftDeleteById?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.RequestDraftDeleteById?(RequestDraftDelete @this) => @this.RequestDraftDeleteById;

        /// <summary>
        /// 
        /// </summary>
        public RequestDraftDelete(global::Apify.RequestDraftDeleteById? value)
        {
            RequestDraftDeleteById = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RequestDraftDelete FromRequestDraftDeleteById(global::Apify.RequestDraftDeleteById? value) => new RequestDraftDelete(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RequestDraftDelete(global::Apify.RequestDraftDeleteByUniqueKey value) => new RequestDraftDelete((global::Apify.RequestDraftDeleteByUniqueKey?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.RequestDraftDeleteByUniqueKey?(RequestDraftDelete @this) => @this.RequestDraftDeleteByUniqueKey;

        /// <summary>
        /// 
        /// </summary>
        public RequestDraftDelete(global::Apify.RequestDraftDeleteByUniqueKey? value)
        {
            RequestDraftDeleteByUniqueKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RequestDraftDelete FromRequestDraftDeleteByUniqueKey(global::Apify.RequestDraftDeleteByUniqueKey? value) => new RequestDraftDelete(value);

        /// <summary>
        /// 
        /// </summary>
        public RequestDraftDelete(
            global::Apify.RequestDraftDeleteById? requestDraftDeleteById,
            global::Apify.RequestDraftDeleteByUniqueKey? requestDraftDeleteByUniqueKey
            )
        {
            RequestDraftDeleteById = requestDraftDeleteById;
            RequestDraftDeleteByUniqueKey = requestDraftDeleteByUniqueKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RequestDraftDeleteByUniqueKey as object ??
            RequestDraftDeleteById as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RequestDraftDeleteById?.ToString() ??
            RequestDraftDeleteByUniqueKey?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRequestDraftDeleteById || IsRequestDraftDeleteByUniqueKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.RequestDraftDeleteById, TResult>? requestDraftDeleteById = null,
            global::System.Func<global::Apify.RequestDraftDeleteByUniqueKey, TResult>? requestDraftDeleteByUniqueKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRequestDraftDeleteById && requestDraftDeleteById != null)
            {
                return requestDraftDeleteById(RequestDraftDeleteById!);
            }
            else if (IsRequestDraftDeleteByUniqueKey && requestDraftDeleteByUniqueKey != null)
            {
                return requestDraftDeleteByUniqueKey(RequestDraftDeleteByUniqueKey!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.RequestDraftDeleteById>? requestDraftDeleteById = null,

            global::System.Action<global::Apify.RequestDraftDeleteByUniqueKey>? requestDraftDeleteByUniqueKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRequestDraftDeleteById)
            {
                requestDraftDeleteById?.Invoke(RequestDraftDeleteById!);
            }
            else if (IsRequestDraftDeleteByUniqueKey)
            {
                requestDraftDeleteByUniqueKey?.Invoke(RequestDraftDeleteByUniqueKey!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.RequestDraftDeleteById>? requestDraftDeleteById = null,
            global::System.Action<global::Apify.RequestDraftDeleteByUniqueKey>? requestDraftDeleteByUniqueKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRequestDraftDeleteById)
            {
                requestDraftDeleteById?.Invoke(RequestDraftDeleteById!);
            }
            else if (IsRequestDraftDeleteByUniqueKey)
            {
                requestDraftDeleteByUniqueKey?.Invoke(RequestDraftDeleteByUniqueKey!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RequestDraftDeleteById,
                typeof(global::Apify.RequestDraftDeleteById),
                RequestDraftDeleteByUniqueKey,
                typeof(global::Apify.RequestDraftDeleteByUniqueKey),
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
        public bool Equals(RequestDraftDelete other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.RequestDraftDeleteById?>.Default.Equals(RequestDraftDeleteById, other.RequestDraftDeleteById) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.RequestDraftDeleteByUniqueKey?>.Default.Equals(RequestDraftDeleteByUniqueKey, other.RequestDraftDeleteByUniqueKey) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RequestDraftDelete obj1, RequestDraftDelete obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RequestDraftDelete>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RequestDraftDelete obj1, RequestDraftDelete obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RequestDraftDelete o && Equals(o);
        }
    }
}
