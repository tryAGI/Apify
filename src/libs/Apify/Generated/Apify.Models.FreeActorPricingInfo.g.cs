#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FreeActorPricingInfo : global::System.IEquatable<FreeActorPricingInfo>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.CommonActorPricingInfo? CommonActorPricingInfo { get; init; }
#else
        public global::Apify.CommonActorPricingInfo? CommonActorPricingInfo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommonActorPricingInfo))]
#endif
        public bool IsCommonActorPricingInfo => CommonActorPricingInfo != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.FreeActorPricingInfoVariant2? Value2 { get; init; }
#else
        public global::Apify.FreeActorPricingInfoVariant2? Value2 { get; }
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
        public static implicit operator FreeActorPricingInfo(global::Apify.CommonActorPricingInfo value) => new FreeActorPricingInfo((global::Apify.CommonActorPricingInfo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.CommonActorPricingInfo?(FreeActorPricingInfo @this) => @this.CommonActorPricingInfo;

        /// <summary>
        /// 
        /// </summary>
        public FreeActorPricingInfo(global::Apify.CommonActorPricingInfo? value)
        {
            CommonActorPricingInfo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FreeActorPricingInfo(global::Apify.FreeActorPricingInfoVariant2 value) => new FreeActorPricingInfo((global::Apify.FreeActorPricingInfoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.FreeActorPricingInfoVariant2?(FreeActorPricingInfo @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public FreeActorPricingInfo(global::Apify.FreeActorPricingInfoVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FreeActorPricingInfo(
            global::Apify.CommonActorPricingInfo? commonActorPricingInfo,
            global::Apify.FreeActorPricingInfoVariant2? value2
            )
        {
            CommonActorPricingInfo = commonActorPricingInfo;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            CommonActorPricingInfo as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CommonActorPricingInfo?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCommonActorPricingInfo && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.CommonActorPricingInfo?, TResult>? commonActorPricingInfo = null,
            global::System.Func<global::Apify.FreeActorPricingInfoVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommonActorPricingInfo && commonActorPricingInfo != null)
            {
                return commonActorPricingInfo(CommonActorPricingInfo!);
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
            global::System.Action<global::Apify.CommonActorPricingInfo?>? commonActorPricingInfo = null,
            global::System.Action<global::Apify.FreeActorPricingInfoVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommonActorPricingInfo)
            {
                commonActorPricingInfo?.Invoke(CommonActorPricingInfo!);
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
                CommonActorPricingInfo,
                typeof(global::Apify.CommonActorPricingInfo),
                Value2,
                typeof(global::Apify.FreeActorPricingInfoVariant2),
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
        public bool Equals(FreeActorPricingInfo other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.CommonActorPricingInfo?>.Default.Equals(CommonActorPricingInfo, other.CommonActorPricingInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.FreeActorPricingInfoVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FreeActorPricingInfo obj1, FreeActorPricingInfo obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FreeActorPricingInfo>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FreeActorPricingInfo obj1, FreeActorPricingInfo obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FreeActorPricingInfo o && Equals(o);
        }
    }
}
