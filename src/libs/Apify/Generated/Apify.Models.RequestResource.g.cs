#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// A request stored in the request queue, including its metadata and processing state.
    /// </summary>
    public readonly partial struct RequestResource : global::System.IEquatable<RequestResource>
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
        public global::Apify.RequestBase PickRequestBase() => RequestBase is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequestBase' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.RequestResourceVariant2? RequestResourceVariant2 { get; init; }
#else
        public global::Apify.RequestResourceVariant2? RequestResourceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestResourceVariant2))]
#endif
        public bool IsRequestResourceVariant2 => RequestResourceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequestResourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.RequestResourceVariant2? value)
        {
            value = RequestResourceVariant2;
            return IsRequestResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Apify.RequestResourceVariant2 PickRequestResourceVariant2() => RequestResourceVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequestResourceVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RequestResource(global::Apify.RequestBase value) => new RequestResource((global::Apify.RequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.RequestBase?(RequestResource @this) => @this.RequestBase;

        /// <summary>
        ///
        /// </summary>
        public RequestResource(global::Apify.RequestBase? value)
        {
            RequestBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RequestResource FromRequestBase(global::Apify.RequestBase? value) => new RequestResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RequestResource(global::Apify.RequestResourceVariant2 value) => new RequestResource((global::Apify.RequestResourceVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.RequestResourceVariant2?(RequestResource @this) => @this.RequestResourceVariant2;

        /// <summary>
        ///
        /// </summary>
        public RequestResource(global::Apify.RequestResourceVariant2? value)
        {
            RequestResourceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RequestResource FromRequestResourceVariant2(global::Apify.RequestResourceVariant2? value) => new RequestResource(value);

        /// <summary>
        ///
        /// </summary>
        public RequestResource(
            global::Apify.RequestBase? requestBase,
            global::Apify.RequestResourceVariant2? requestResourceVariant2
            )
        {
            RequestBase = requestBase;
            RequestResourceVariant2 = requestResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RequestResourceVariant2 as object ??
            RequestBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RequestBase?.ToString() ??
            RequestResourceVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRequestBase && IsRequestResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.RequestBase, TResult>? requestBase = null,
            global::System.Func<global::Apify.RequestResourceVariant2, TResult>? requestResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RequestBase is { } __value0 && requestBase != null)
            {
                return requestBase(__value0);
            }
            else if (RequestResourceVariant2 is { } __value1 && requestResourceVariant2 != null)
            {
                return requestResourceVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.RequestBase>? requestBase = null,

            global::System.Action<global::Apify.RequestResourceVariant2>? requestResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RequestBase is { } __value0)
            {
                requestBase?.Invoke(__value0);
            }
            else if (RequestResourceVariant2 is { } __value1)
            {
                requestResourceVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.RequestBase>? requestBase = null,
            global::System.Action<global::Apify.RequestResourceVariant2>? requestResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RequestBase is { } __value0)
            {
                requestBase?.Invoke(__value0);
            }
            else if (RequestResourceVariant2 is { } __value1)
            {
                requestResourceVariant2?.Invoke(__value1);
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
                RequestResourceVariant2,
                typeof(global::Apify.RequestResourceVariant2),
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
        public bool Equals(RequestResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.RequestBase?>.Default.Equals(RequestBase, other.RequestBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.RequestResourceVariant2?>.Default.Equals(RequestResourceVariant2, other.RequestResourceVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RequestResource obj1, RequestResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RequestResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RequestResource obj1, RequestResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RequestResource o && Equals(o);
        }
    }
}
