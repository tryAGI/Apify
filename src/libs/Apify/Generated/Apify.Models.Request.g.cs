#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// A request stored in the request queue, including its metadata and processing state.
    /// </summary>
    public readonly partial struct Request : global::System.IEquatable<Request>
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
#if NET6_0_OR_GREATER
        public global::Apify.RequestVariant2? Value2 { get; init; }
#else
        public global::Apify.RequestVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request(global::Apify.RequestBase value) => new Request((global::Apify.RequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.RequestBase?(Request @this) => @this.RequestBase;

        /// <summary>
        /// 
        /// </summary>
        public Request(global::Apify.RequestBase? value)
        {
            RequestBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Request(global::Apify.RequestVariant2 value) => new Request((global::Apify.RequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.RequestVariant2?(Request @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Request(global::Apify.RequestVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Request(
            global::Apify.RequestBase? requestBase,
            global::Apify.RequestVariant2? value2
            )
        {
            RequestBase = requestBase;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            RequestBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RequestBase?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRequestBase && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.RequestBase?, TResult>? requestBase = null,
            global::System.Func<global::Apify.RequestVariant2?, TResult>? value2 = null,
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
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.RequestBase?>? requestBase = null,
            global::System.Action<global::Apify.RequestVariant2?>? value2 = null,
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
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
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
                Value2,
                typeof(global::Apify.RequestVariant2),
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
        public bool Equals(Request other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.RequestBase?>.Default.Equals(RequestBase, other.RequestBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.RequestVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Request obj1, Request obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Request>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Request obj1, Request obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Request o && Equals(o);
        }
    }
}
