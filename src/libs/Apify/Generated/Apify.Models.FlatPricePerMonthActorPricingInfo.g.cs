#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FlatPricePerMonthActorPricingInfo : global::System.IEquatable<FlatPricePerMonthActorPricingInfo>
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
        public global::Apify.FlatPricePerMonthActorPricingInfoVariant2? FlatPricePerMonthActorPricingInfoVariant2 { get; init; }
#else
        public global::Apify.FlatPricePerMonthActorPricingInfoVariant2? FlatPricePerMonthActorPricingInfoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FlatPricePerMonthActorPricingInfoVariant2))]
#endif
        public bool IsFlatPricePerMonthActorPricingInfoVariant2 => FlatPricePerMonthActorPricingInfoVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FlatPricePerMonthActorPricingInfo(global::Apify.CommonActorPricingInfo value) => new FlatPricePerMonthActorPricingInfo((global::Apify.CommonActorPricingInfo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.CommonActorPricingInfo?(FlatPricePerMonthActorPricingInfo @this) => @this.CommonActorPricingInfo;

        /// <summary>
        /// 
        /// </summary>
        public FlatPricePerMonthActorPricingInfo(global::Apify.CommonActorPricingInfo? value)
        {
            CommonActorPricingInfo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FlatPricePerMonthActorPricingInfo(global::Apify.FlatPricePerMonthActorPricingInfoVariant2 value) => new FlatPricePerMonthActorPricingInfo((global::Apify.FlatPricePerMonthActorPricingInfoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.FlatPricePerMonthActorPricingInfoVariant2?(FlatPricePerMonthActorPricingInfo @this) => @this.FlatPricePerMonthActorPricingInfoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FlatPricePerMonthActorPricingInfo(global::Apify.FlatPricePerMonthActorPricingInfoVariant2? value)
        {
            FlatPricePerMonthActorPricingInfoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FlatPricePerMonthActorPricingInfo(
            global::Apify.CommonActorPricingInfo? commonActorPricingInfo,
            global::Apify.FlatPricePerMonthActorPricingInfoVariant2? flatPricePerMonthActorPricingInfoVariant2
            )
        {
            CommonActorPricingInfo = commonActorPricingInfo;
            FlatPricePerMonthActorPricingInfoVariant2 = flatPricePerMonthActorPricingInfoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FlatPricePerMonthActorPricingInfoVariant2 as object ??
            CommonActorPricingInfo as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CommonActorPricingInfo?.ToString() ??
            FlatPricePerMonthActorPricingInfoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCommonActorPricingInfo && IsFlatPricePerMonthActorPricingInfoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.CommonActorPricingInfo?, TResult>? commonActorPricingInfo = null,
            global::System.Func<global::Apify.FlatPricePerMonthActorPricingInfoVariant2?, TResult>? flatPricePerMonthActorPricingInfoVariant2 = null,
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
            else if (IsFlatPricePerMonthActorPricingInfoVariant2 && flatPricePerMonthActorPricingInfoVariant2 != null)
            {
                return flatPricePerMonthActorPricingInfoVariant2(FlatPricePerMonthActorPricingInfoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.CommonActorPricingInfo?>? commonActorPricingInfo = null,
            global::System.Action<global::Apify.FlatPricePerMonthActorPricingInfoVariant2?>? flatPricePerMonthActorPricingInfoVariant2 = null,
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
            else if (IsFlatPricePerMonthActorPricingInfoVariant2)
            {
                flatPricePerMonthActorPricingInfoVariant2?.Invoke(FlatPricePerMonthActorPricingInfoVariant2!);
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
                FlatPricePerMonthActorPricingInfoVariant2,
                typeof(global::Apify.FlatPricePerMonthActorPricingInfoVariant2),
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
        public bool Equals(FlatPricePerMonthActorPricingInfo other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.CommonActorPricingInfo?>.Default.Equals(CommonActorPricingInfo, other.CommonActorPricingInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.FlatPricePerMonthActorPricingInfoVariant2?>.Default.Equals(FlatPricePerMonthActorPricingInfoVariant2, other.FlatPricePerMonthActorPricingInfoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FlatPricePerMonthActorPricingInfo obj1, FlatPricePerMonthActorPricingInfo obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FlatPricePerMonthActorPricingInfo>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FlatPricePerMonthActorPricingInfo obj1, FlatPricePerMonthActorPricingInfo obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FlatPricePerMonthActorPricingInfo o && Equals(o);
        }
    }
}
