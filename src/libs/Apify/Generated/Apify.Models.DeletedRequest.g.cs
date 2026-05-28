#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// Confirmation of a request that was successfully deleted from a request queue.
    /// </summary>
    public readonly partial struct DeletedRequest : global::System.IEquatable<DeletedRequest>
    {
        /// <summary>
        /// Confirmation of a request that was successfully deleted, identified by its ID.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.DeletedRequestById? DeletedRequestById { get; init; }
#else
        public global::Apify.DeletedRequestById? DeletedRequestById { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeletedRequestById))]
#endif
        public bool IsDeletedRequestById => DeletedRequestById != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeletedRequestById(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.DeletedRequestById? value)
        {
            value = DeletedRequestById;
            return IsDeletedRequestById;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DeletedRequestById PickDeletedRequestById() => IsDeletedRequestById
            ? DeletedRequestById!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeletedRequestById' but the value was {ToString()}.");

        /// <summary>
        /// Confirmation of a request that was successfully deleted, identified by its unique key.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.DeletedRequestByUniqueKey? DeletedRequestByUniqueKey { get; init; }
#else
        public global::Apify.DeletedRequestByUniqueKey? DeletedRequestByUniqueKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeletedRequestByUniqueKey))]
#endif
        public bool IsDeletedRequestByUniqueKey => DeletedRequestByUniqueKey != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeletedRequestByUniqueKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.DeletedRequestByUniqueKey? value)
        {
            value = DeletedRequestByUniqueKey;
            return IsDeletedRequestByUniqueKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Apify.DeletedRequestByUniqueKey PickDeletedRequestByUniqueKey() => IsDeletedRequestByUniqueKey
            ? DeletedRequestByUniqueKey!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeletedRequestByUniqueKey' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DeletedRequest(global::Apify.DeletedRequestById value) => new DeletedRequest((global::Apify.DeletedRequestById?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.DeletedRequestById?(DeletedRequest @this) => @this.DeletedRequestById;

        /// <summary>
        /// 
        /// </summary>
        public DeletedRequest(global::Apify.DeletedRequestById? value)
        {
            DeletedRequestById = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DeletedRequest FromDeletedRequestById(global::Apify.DeletedRequestById? value) => new DeletedRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DeletedRequest(global::Apify.DeletedRequestByUniqueKey value) => new DeletedRequest((global::Apify.DeletedRequestByUniqueKey?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.DeletedRequestByUniqueKey?(DeletedRequest @this) => @this.DeletedRequestByUniqueKey;

        /// <summary>
        /// 
        /// </summary>
        public DeletedRequest(global::Apify.DeletedRequestByUniqueKey? value)
        {
            DeletedRequestByUniqueKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DeletedRequest FromDeletedRequestByUniqueKey(global::Apify.DeletedRequestByUniqueKey? value) => new DeletedRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public DeletedRequest(
            global::Apify.DeletedRequestById? deletedRequestById,
            global::Apify.DeletedRequestByUniqueKey? deletedRequestByUniqueKey
            )
        {
            DeletedRequestById = deletedRequestById;
            DeletedRequestByUniqueKey = deletedRequestByUniqueKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DeletedRequestByUniqueKey as object ??
            DeletedRequestById as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DeletedRequestById?.ToString() ??
            DeletedRequestByUniqueKey?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDeletedRequestById || IsDeletedRequestByUniqueKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.DeletedRequestById, TResult>? deletedRequestById = null,
            global::System.Func<global::Apify.DeletedRequestByUniqueKey, TResult>? deletedRequestByUniqueKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeletedRequestById && deletedRequestById != null)
            {
                return deletedRequestById(DeletedRequestById!);
            }
            else if (IsDeletedRequestByUniqueKey && deletedRequestByUniqueKey != null)
            {
                return deletedRequestByUniqueKey(DeletedRequestByUniqueKey!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.DeletedRequestById>? deletedRequestById = null,

            global::System.Action<global::Apify.DeletedRequestByUniqueKey>? deletedRequestByUniqueKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeletedRequestById)
            {
                deletedRequestById?.Invoke(DeletedRequestById!);
            }
            else if (IsDeletedRequestByUniqueKey)
            {
                deletedRequestByUniqueKey?.Invoke(DeletedRequestByUniqueKey!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.DeletedRequestById>? deletedRequestById = null,
            global::System.Action<global::Apify.DeletedRequestByUniqueKey>? deletedRequestByUniqueKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeletedRequestById)
            {
                deletedRequestById?.Invoke(DeletedRequestById!);
            }
            else if (IsDeletedRequestByUniqueKey)
            {
                deletedRequestByUniqueKey?.Invoke(DeletedRequestByUniqueKey!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DeletedRequestById,
                typeof(global::Apify.DeletedRequestById),
                DeletedRequestByUniqueKey,
                typeof(global::Apify.DeletedRequestByUniqueKey),
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
        public bool Equals(DeletedRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.DeletedRequestById?>.Default.Equals(DeletedRequestById, other.DeletedRequestById) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.DeletedRequestByUniqueKey?>.Default.Equals(DeletedRequestByUniqueKey, other.DeletedRequestByUniqueKey) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DeletedRequest obj1, DeletedRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DeletedRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DeletedRequest obj1, DeletedRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeletedRequest o && Equals(o);
        }
    }
}
