#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PricePerDatasetItemActorPricingInfo : global::System.IEquatable<PricePerDatasetItemActorPricingInfo>
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
        public global::Apify.CommonActorPricingInfo PickCommonActorPricingInfo() => IsCommonActorPricingInfo
            ? CommonActorPricingInfo!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CommonActorPricingInfo' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.PricePerDatasetItemActorPricingInfoVariant2? PricePerDatasetItemActorPricingInfoVariant2 { get; init; }
#else
        public global::Apify.PricePerDatasetItemActorPricingInfoVariant2? PricePerDatasetItemActorPricingInfoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PricePerDatasetItemActorPricingInfoVariant2))]
#endif
        public bool IsPricePerDatasetItemActorPricingInfoVariant2 => PricePerDatasetItemActorPricingInfoVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPricePerDatasetItemActorPricingInfoVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.PricePerDatasetItemActorPricingInfoVariant2? value)
        {
            value = PricePerDatasetItemActorPricingInfoVariant2;
            return IsPricePerDatasetItemActorPricingInfoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PricePerDatasetItemActorPricingInfoVariant2 PickPricePerDatasetItemActorPricingInfoVariant2() => IsPricePerDatasetItemActorPricingInfoVariant2
            ? PricePerDatasetItemActorPricingInfoVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PricePerDatasetItemActorPricingInfoVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PricePerDatasetItemActorPricingInfo(global::Apify.CommonActorPricingInfo value) => new PricePerDatasetItemActorPricingInfo((global::Apify.CommonActorPricingInfo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.CommonActorPricingInfo?(PricePerDatasetItemActorPricingInfo @this) => @this.CommonActorPricingInfo;

        /// <summary>
        /// 
        /// </summary>
        public PricePerDatasetItemActorPricingInfo(global::Apify.CommonActorPricingInfo? value)
        {
            CommonActorPricingInfo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PricePerDatasetItemActorPricingInfo FromCommonActorPricingInfo(global::Apify.CommonActorPricingInfo? value) => new PricePerDatasetItemActorPricingInfo(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PricePerDatasetItemActorPricingInfo(global::Apify.PricePerDatasetItemActorPricingInfoVariant2 value) => new PricePerDatasetItemActorPricingInfo((global::Apify.PricePerDatasetItemActorPricingInfoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.PricePerDatasetItemActorPricingInfoVariant2?(PricePerDatasetItemActorPricingInfo @this) => @this.PricePerDatasetItemActorPricingInfoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PricePerDatasetItemActorPricingInfo(global::Apify.PricePerDatasetItemActorPricingInfoVariant2? value)
        {
            PricePerDatasetItemActorPricingInfoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PricePerDatasetItemActorPricingInfo FromPricePerDatasetItemActorPricingInfoVariant2(global::Apify.PricePerDatasetItemActorPricingInfoVariant2? value) => new PricePerDatasetItemActorPricingInfo(value);

        /// <summary>
        /// 
        /// </summary>
        public PricePerDatasetItemActorPricingInfo(
            global::Apify.CommonActorPricingInfo? commonActorPricingInfo,
            global::Apify.PricePerDatasetItemActorPricingInfoVariant2? pricePerDatasetItemActorPricingInfoVariant2
            )
        {
            CommonActorPricingInfo = commonActorPricingInfo;
            PricePerDatasetItemActorPricingInfoVariant2 = pricePerDatasetItemActorPricingInfoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PricePerDatasetItemActorPricingInfoVariant2 as object ??
            CommonActorPricingInfo as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CommonActorPricingInfo?.ToString() ??
            PricePerDatasetItemActorPricingInfoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCommonActorPricingInfo && IsPricePerDatasetItemActorPricingInfoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.CommonActorPricingInfo, TResult>? commonActorPricingInfo = null,
            global::System.Func<global::Apify.PricePerDatasetItemActorPricingInfoVariant2, TResult>? pricePerDatasetItemActorPricingInfoVariant2 = null,
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
            else if (IsPricePerDatasetItemActorPricingInfoVariant2 && pricePerDatasetItemActorPricingInfoVariant2 != null)
            {
                return pricePerDatasetItemActorPricingInfoVariant2(PricePerDatasetItemActorPricingInfoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.CommonActorPricingInfo>? commonActorPricingInfo = null,

            global::System.Action<global::Apify.PricePerDatasetItemActorPricingInfoVariant2>? pricePerDatasetItemActorPricingInfoVariant2 = null,
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
            else if (IsPricePerDatasetItemActorPricingInfoVariant2)
            {
                pricePerDatasetItemActorPricingInfoVariant2?.Invoke(PricePerDatasetItemActorPricingInfoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.CommonActorPricingInfo>? commonActorPricingInfo = null,
            global::System.Action<global::Apify.PricePerDatasetItemActorPricingInfoVariant2>? pricePerDatasetItemActorPricingInfoVariant2 = null,
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
            else if (IsPricePerDatasetItemActorPricingInfoVariant2)
            {
                pricePerDatasetItemActorPricingInfoVariant2?.Invoke(PricePerDatasetItemActorPricingInfoVariant2!);
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
                PricePerDatasetItemActorPricingInfoVariant2,
                typeof(global::Apify.PricePerDatasetItemActorPricingInfoVariant2),
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
        public bool Equals(PricePerDatasetItemActorPricingInfo other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.CommonActorPricingInfo?>.Default.Equals(CommonActorPricingInfo, other.CommonActorPricingInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.PricePerDatasetItemActorPricingInfoVariant2?>.Default.Equals(PricePerDatasetItemActorPricingInfoVariant2, other.PricePerDatasetItemActorPricingInfoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PricePerDatasetItemActorPricingInfo obj1, PricePerDatasetItemActorPricingInfo obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PricePerDatasetItemActorPricingInfo>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PricePerDatasetItemActorPricingInfo obj1, PricePerDatasetItemActorPricingInfo obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PricePerDatasetItemActorPricingInfo o && Equals(o);
        }
    }
}
