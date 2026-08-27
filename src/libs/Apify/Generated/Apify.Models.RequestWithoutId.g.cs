#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// A request stored in the request queue, including its metadata and processing state, without the assigned ID.
    /// </summary>
    public readonly partial struct RequestWithoutId : global::System.IEquatable<RequestWithoutId>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.RequestBase? RequestBase { get; init; }
#else
        public global::Apify.RequestBase? RequestBase { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestBase))]
#endif
        public bool IsRequestBase => RequestBase != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequestBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.RequestBase? value)
        {
            value = RequestBase;
            return IsRequestBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestBase PickRequestBase() => IsRequestBase
            ? RequestBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequestBase' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RequestWithoutId(global::Apify.RequestBase value) => new RequestWithoutId((global::Apify.RequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.RequestBase?(RequestWithoutId @this) => @this.RequestBase;

        /// <summary>
        ///
        /// </summary>
        public RequestWithoutId(global::Apify.RequestBase? value)
        {
            RequestBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RequestWithoutId FromRequestBase(global::Apify.RequestBase? value) => new RequestWithoutId(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RequestBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RequestBase?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRequestBase;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.RequestBase, TResult>? requestBase = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRequestBase && requestBase != null)
            {
                return requestBase(RequestBase!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.RequestBase>? requestBase = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRequestBase)
            {
                requestBase?.Invoke(RequestBase!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.RequestBase>? requestBase = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRequestBase)
            {
                requestBase?.Invoke(RequestBase!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RequestBase,
                typeof(global::Apify.RequestBase),
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
        public bool Equals(RequestWithoutId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.RequestBase?>.Default.Equals(RequestBase, other.RequestBase)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RequestWithoutId obj1, RequestWithoutId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RequestWithoutId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RequestWithoutId obj1, RequestWithoutId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RequestWithoutId o && Equals(o);
        }
    }
}
