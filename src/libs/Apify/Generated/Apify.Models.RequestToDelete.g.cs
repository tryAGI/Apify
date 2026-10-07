#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// A request that should be deleted.
    /// </summary>
    public readonly partial struct RequestToDelete : global::System.IEquatable<RequestToDelete>
    {
        /// <summary>
        /// A request that should be deleted, identified by its ID.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.RequestToDeleteById? RequestToDeleteById { get; init; }
#else
        public global::Apify.RequestToDeleteById? RequestToDeleteById { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestToDeleteById))]
#endif
        public bool IsRequestToDeleteById => RequestToDeleteById != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequestToDeleteById(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.RequestToDeleteById? value)
        {
            value = RequestToDeleteById;
            return IsRequestToDeleteById;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestToDeleteById PickRequestToDeleteById() => RequestToDeleteById is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequestToDeleteById' but the value was {ToString()}.");

        /// <summary>
        /// A request that should be deleted, identified by its unique key.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.RequestToDeleteByUniqueKey? RequestToDeleteByUniqueKey { get; init; }
#else
        public global::Apify.RequestToDeleteByUniqueKey? RequestToDeleteByUniqueKey { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestToDeleteByUniqueKey))]
#endif
        public bool IsRequestToDeleteByUniqueKey => RequestToDeleteByUniqueKey != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequestToDeleteByUniqueKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.RequestToDeleteByUniqueKey? value)
        {
            value = RequestToDeleteByUniqueKey;
            return IsRequestToDeleteByUniqueKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestToDeleteByUniqueKey PickRequestToDeleteByUniqueKey() => RequestToDeleteByUniqueKey is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequestToDeleteByUniqueKey' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RequestToDelete(global::Apify.RequestToDeleteById value) => new RequestToDelete((global::Apify.RequestToDeleteById?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.RequestToDeleteById?(RequestToDelete @this) => @this.RequestToDeleteById;

        /// <summary>
        ///
        /// </summary>
        public RequestToDelete(global::Apify.RequestToDeleteById? value)
        {
            RequestToDeleteById = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RequestToDelete FromRequestToDeleteById(global::Apify.RequestToDeleteById? value) => new RequestToDelete(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RequestToDelete(global::Apify.RequestToDeleteByUniqueKey value) => new RequestToDelete((global::Apify.RequestToDeleteByUniqueKey?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.RequestToDeleteByUniqueKey?(RequestToDelete @this) => @this.RequestToDeleteByUniqueKey;

        /// <summary>
        ///
        /// </summary>
        public RequestToDelete(global::Apify.RequestToDeleteByUniqueKey? value)
        {
            RequestToDeleteByUniqueKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RequestToDelete FromRequestToDeleteByUniqueKey(global::Apify.RequestToDeleteByUniqueKey? value) => new RequestToDelete(value);

        /// <summary>
        ///
        /// </summary>
        public RequestToDelete(
            global::Apify.RequestToDeleteById? requestToDeleteById,
            global::Apify.RequestToDeleteByUniqueKey? requestToDeleteByUniqueKey
            )
        {
            RequestToDeleteById = requestToDeleteById;
            RequestToDeleteByUniqueKey = requestToDeleteByUniqueKey;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RequestToDeleteByUniqueKey as object ??
            RequestToDeleteById as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RequestToDeleteById?.ToString() ??
            RequestToDeleteByUniqueKey?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRequestToDeleteById || IsRequestToDeleteByUniqueKey;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.RequestToDeleteById, TResult>? requestToDeleteById = null,
            global::System.Func<global::Apify.RequestToDeleteByUniqueKey, TResult>? requestToDeleteByUniqueKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RequestToDeleteById is { } __value0 && requestToDeleteById != null)
            {
                return requestToDeleteById(__value0);
            }
            else if (RequestToDeleteByUniqueKey is { } __value1 && requestToDeleteByUniqueKey != null)
            {
                return requestToDeleteByUniqueKey(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.RequestToDeleteById>? requestToDeleteById = null,

            global::System.Action<global::Apify.RequestToDeleteByUniqueKey>? requestToDeleteByUniqueKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RequestToDeleteById is { } __value0)
            {
                requestToDeleteById?.Invoke(__value0);
            }
            else if (RequestToDeleteByUniqueKey is { } __value1)
            {
                requestToDeleteByUniqueKey?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.RequestToDeleteById>? requestToDeleteById = null,
            global::System.Action<global::Apify.RequestToDeleteByUniqueKey>? requestToDeleteByUniqueKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RequestToDeleteById is { } __value0)
            {
                requestToDeleteById?.Invoke(__value0);
            }
            else if (RequestToDeleteByUniqueKey is { } __value1)
            {
                requestToDeleteByUniqueKey?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RequestToDeleteById,
                typeof(global::Apify.RequestToDeleteById),
                RequestToDeleteByUniqueKey,
                typeof(global::Apify.RequestToDeleteByUniqueKey),
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
        public bool Equals(RequestToDelete other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.RequestToDeleteById?>.Default.Equals(RequestToDeleteById, other.RequestToDeleteById) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.RequestToDeleteByUniqueKey?>.Default.Equals(RequestToDeleteByUniqueKey, other.RequestToDeleteByUniqueKey)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RequestToDelete obj1, RequestToDelete obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RequestToDelete>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RequestToDelete obj1, RequestToDelete obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RequestToDelete o && Equals(o);
        }
    }
}
