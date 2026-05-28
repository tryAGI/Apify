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
        public bool TryPickCommonActorPricingInfo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.CommonActorPricingInfo? value)
        {
            value = CommonActorPricingInfo;
            return IsCommonActorPricingInfo;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.FreeActorPricingInfoVariant2? FreeActorPricingInfoVariant2 { get; init; }
#else
        public global::Apify.FreeActorPricingInfoVariant2? FreeActorPricingInfoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FreeActorPricingInfoVariant2))]
#endif
        public bool IsFreeActorPricingInfoVariant2 => FreeActorPricingInfoVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFreeActorPricingInfoVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.FreeActorPricingInfoVariant2? value)
        {
            value = FreeActorPricingInfoVariant2;
            return IsFreeActorPricingInfoVariant2;
        }
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
        public static implicit operator global::Apify.FreeActorPricingInfoVariant2?(FreeActorPricingInfo @this) => @this.FreeActorPricingInfoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FreeActorPricingInfo(global::Apify.FreeActorPricingInfoVariant2? value)
        {
            FreeActorPricingInfoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FreeActorPricingInfo(
            global::Apify.CommonActorPricingInfo? commonActorPricingInfo,
            global::Apify.FreeActorPricingInfoVariant2? freeActorPricingInfoVariant2
            )
        {
            CommonActorPricingInfo = commonActorPricingInfo;
            FreeActorPricingInfoVariant2 = freeActorPricingInfoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FreeActorPricingInfoVariant2 as object ??
            CommonActorPricingInfo as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CommonActorPricingInfo?.ToString() ??
            FreeActorPricingInfoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCommonActorPricingInfo && IsFreeActorPricingInfoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.CommonActorPricingInfo, TResult>? commonActorPricingInfo = null,
            global::System.Func<global::Apify.FreeActorPricingInfoVariant2, TResult>? freeActorPricingInfoVariant2 = null,
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
            else if (IsFreeActorPricingInfoVariant2 && freeActorPricingInfoVariant2 != null)
            {
                return freeActorPricingInfoVariant2(FreeActorPricingInfoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.CommonActorPricingInfo>? commonActorPricingInfo = null,

            global::System.Action<global::Apify.FreeActorPricingInfoVariant2>? freeActorPricingInfoVariant2 = null,
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
            else if (IsFreeActorPricingInfoVariant2)
            {
                freeActorPricingInfoVariant2?.Invoke(FreeActorPricingInfoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.CommonActorPricingInfo>? commonActorPricingInfo = null,
            global::System.Action<global::Apify.FreeActorPricingInfoVariant2>? freeActorPricingInfoVariant2 = null,
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
            else if (IsFreeActorPricingInfoVariant2)
            {
                freeActorPricingInfoVariant2?.Invoke(FreeActorPricingInfoVariant2!);
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
                FreeActorPricingInfoVariant2,
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
                global::System.Collections.Generic.EqualityComparer<global::Apify.FreeActorPricingInfoVariant2?>.Default.Equals(FreeActorPricingInfoVariant2, other.FreeActorPricingInfoVariant2) 
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
